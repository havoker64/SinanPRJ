using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sinan.Data;
using Sinan.Models;
using BCrypt.Net;

namespace Sinan.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDBcontext _context;

        public UsuariosController(AppDBcontext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Listing()
        {
            var usuarios = await _context.Usuarios.ToListAsync();

            return View(usuarios);
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
                string hashedSenha = BCrypt.Net.BCrypt.HashPassword(usuario.password);

                // Substitua a senha do usuário pela senha codificada
                usuario.password = hashedSenha;

                _context.Add(usuario);
                await _context.SaveChangesAsync();

                return RedirectToAction("Listing");
            }

            return View(usuario);
        }

        public async Task<IActionResult> Edit(long IdUsu)
        {
            System.Diagnostics.Debug.WriteLine($"Edit - IdUsu: {IdUsu}");

            var usuario = await _context.Usuarios.FindAsync(IdUsu);
            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Update(usuario);
                await _context.SaveChangesAsync();

                return RedirectToAction("Listing");
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

            return RedirectToAction("Listing");
        }
    }
}
