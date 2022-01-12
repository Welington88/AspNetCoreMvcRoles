using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApsNetCore.Models
{
    [Table("Regras")]
    public class Regras
    {
        [Key]
        public int IdRegra { get; set; }

        [Required]
        public String Name { get; set; }
    }
}
