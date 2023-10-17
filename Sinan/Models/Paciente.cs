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
        [Display(Name = "Data de Nascimento")]
        [Column("birthdate")]
        public DateOnly birthdate { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name ="Escolaridade")]
        [Column ("schooling")]
        public string schooling { get; set;}
        //----------------------------------------------------------------------
        [Display(Name = "Cartão do SUS")]
        [Column("suscard")]
        public string? suscard { get; set; }
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
        [Display(Name = "Altura(cm)")]
        [Column("height")]
        public int? height { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Peso(gramas)")]
        [Column("weight")]
        public int? weight { get; set; }
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
        [Display(Name = "Endereço")]
        [Column("address")]
        public string address { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Número")]
        [Column("number")]
        public string number { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Complemento")]
        [Column("complement")]
        public string? complement { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "Telefone")]
        [Column("phone")]
        public string? phone { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "CEP")]
        [Column("cep")]
        public string? cep { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Zona")]
        [Column("zone")]
        public string zone { get; set; }
        //----------------------------------------------------------------------
        [Required]
        [Display(Name = "Tipo sanguíneo")]
        [Column("bloodtype")]
        public string bloodType { get; set; }
        //----------------------------------------------------------------------
        [Display(Name = "CPF")]
        [Column("cpf")]
        public string? cpf { get; set; }

    }
}
