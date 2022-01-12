using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApsNetCore.Models
{
    [Table("Sedes_Empresa")]
    public class Sedes
    {
        public Sedes()
        {
        }

        [Key]
        public int Num_Sede { get; set; }

        [Display(Name = "Descrição Sede")]
        [Column("Descr_Sede", TypeName = "varchar(50)")]
        [Required]
        public String Descricao { get; set; }

        [Display(Name = "É Alugada?")]
        [Required]
        public bool Aluguel { get; set; }

        [Display(Name = "Data da Abertura")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy h:m}", ApplyFormatInEditMode = true)]
        public DateTime DataAbertura { get; set; }

        [Display(Name = "Descrição Sede")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public Decimal ValorDaSede { get; set; }

    }
}
