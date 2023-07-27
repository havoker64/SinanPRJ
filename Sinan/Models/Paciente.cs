using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinan.Models
{
    [Table("paciente")]
    public class Paciente
    {
        [Display(Name="Código")]
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Nome")]
        [Column("name")]
        public string name { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name="Data de nascimento")]
        [Column("birthdate")]
        public  DateTime birthdate { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name ="Escolaridade")]
        [Column ("schooling")]
        public string schooling { get; set;}
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Cartão do SUS")]
        [Column("suscard")]
        public long suscard { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name ="Nome da mãe")]
        [Column("momname")]
        public string momname { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name ="Ancestralidade")]
        [Column("ancestry")]
        public string ancestry { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name ="UF")]
        [Column("uf")]
        public string uf { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Município")]
        [Column("municipality")]
        public string municipality { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Endereço(Rua e número da residência).")]
        [Column("address")]
        public string address { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Telefone")]
        [Column("phone")]
        public long phone { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "CEP")]
        [Column("cep")]
        public long cep { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Zona")]
        [Column("zone")]
        public string zone { get; set; }
    }
}
