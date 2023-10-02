using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinan.Models
{
    [Table("usuario")] 
    public class Usuario
    {
        [Display(Name = "Código")][Column("IdUsu")][Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdUsu { get; set; }

        [Required][Display(Name = "Usuário")][Column("username")]
        public string Username { get; set; }

        [Required][Display(Name = "Senha")][Column("password")]
        public string password { get; set; }

        //[Display(Name = "Permissões de ADM")][Column("Adm")]
        //public bool Adm { get; set; }
    }
}
