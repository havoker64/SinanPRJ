using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sinan.Models
{
    [Table("paciente")]
    public class Paciente
    {
        [Display(Name="Código")]
        [Column("Idpacient")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Idpacient { get; set; }
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
        public string suscard { get; set; }
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
        [Display(Name = "Sexo")]
        [Column("gender")]
        public string gender { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Altura(cm)")]
        [Column("height")]
        public int height { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Peso(gramas)")]
        [Column("weight")]
        public int weight { get; set; }
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
        [Required]
        [Display(Name = "Bairro")]
        [Column("pneighborhood")]
        public string pneighborhood { get; set; }
        //----------------------------------------------------------------------
        [Required]
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
        public string cep { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Zona")]
        [Column("zone")]
        public string zone { get; set; }

    }
}
