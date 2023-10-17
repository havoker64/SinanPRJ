using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sinan.Data;
using Sinan.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Sinan.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDBcontext _context;

        public UsuariosController(AppDBcontext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var admCookieValue = HttpContext.Request.Cookies["AdmCookie"];

            // Verificar se o usuário é um administrador com base no valor do cookie
            bool isAdm = !string.IsNullOrEmpty(admCookieValue) && bool.Parse(admCookieValue);

            if (isAdm)
            {
                // O usuário é um administrador, pode acessar a view protegida
                var usuarios = await _context.Usuarios.ToListAsync();

                return View(usuarios);
            }
            else
            {
                // Redirecionar ou mostrar uma mensagem de acesso negado
                return RedirectToAction("Denied");
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                // Codifique a senha usando bcrypt
                string hashedSenha = BCrypt.Net.BCrypt.HashPassword(usuario.Password);

                // Substitua a senha do usuário pela senha codificada
                usuario.Password = hashedSenha;

                _context.Add(usuario);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        public async Task<IActionResult> Edit(long? IdUsu)
        {
            var usuario = await _context.Usuarios.FindAsync(IdUsu);
            if (usuario == null)
                return NotFound();

            usuario.Password = null;


            return View(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Usuario usuario)
        {
            string hashedSenha = BCrypt.Net.BCrypt.HashPassword(usuario.Password);

            usuario.Password = hashedSenha;

            if (ModelState.IsValid)
            {
                _context.Update(usuario);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        public async Task<IActionResult> Delete(long IdUsu)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(m => m.IdUsu == IdUsu);
            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(long IdUsu)
        {
            var usuario = await _context.Usuarios.FindAsync(IdUsu);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Usuario model)
        {
            if (ModelState.IsValid)
            {
                // Verifica se o modelo de dados de login (Usuario model) é válido.

                var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Username == model.Username);

                // Tenta encontrar um usuário no banco de dados com o nome de usuário (Username) fornecido.

                if (usuario != null && VerificarSenha(usuario, model.Password))
                {
                    // Se um usuário com o nome de usuário existir e a senha estiver correta:

                    // Gere um ID de sessão exclusivo.
                    string sessionId = Guid.NewGuid().ToString();

                    // Armazene o ID da sessão no cookie.
                    var sessionCookieOptions = new CookieOptions
                    {
                        Expires = DateTime.Now.AddDays(1) // Define a expiração do cookie para 1 dia.
                    };

                    Response.Cookies.Append("SessionId", sessionId, sessionCookieOptions);

                    Response.Cookies.Append("AdmCookie", usuario.Adm.ToString(), sessionCookieOptions);

                    // Armazene o ID da sessão no modelo de usuário.
                    int? sessionIdInt = null; // Inicialize com null ou um valor padrão adequado
                    if (int.TryParse(sessionId, out int parsedSessionId))
                    {
                        sessionIdInt = parsedSessionId;
                    }

                    // Atribua sessionIdInt a usuario.sessionId
                    usuario.sessionId = sessionIdInt;

                    // Atualize o modelo de usuário no banco de dados.
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Se não houver correspondência de usuário ou a senha estiver incorreta:

                    ModelState.AddModelError(string.Empty, "Tentativa de login inválida.");
                    // Adiciona um erro ao ModelState, que pode ser usado para exibir uma mensagem de erro na view.

                    // Retorna a view de login para que o usuário possa tentar novamente.
                }
            }

            return View();
        }


        private bool VerificarSenha(Usuario usuario, string password)
        {
            // Recupere o hash da senha armazenada no banco de dados
            string senhaArmazenadaNoBanco = usuario.Password;

            // Use BCrypt para verificar a senha
            bool senhaCorreta = BCrypt.Net.BCrypt.Verify(password, senhaArmazenadaNoBanco);

            return senhaCorreta;
        }

        public async Task<IActionResult> Logout()
        {
            // Limpe o ID de sessão no banco de dados
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Username == User.Identity.Name);

            if (usuario != null)
            {
                usuario.sessionId = null; // Limpa o ID de sessão
                _context.Update(usuario);
                await _context.SaveChangesAsync();
            }

            // Efetue o logout do usuário
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login");
        }

        public IActionResult Denied()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
