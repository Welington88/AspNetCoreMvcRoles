using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcRoles.Models
{
    [Table("Regras")]
    public class Regras
    {
        [Key]
        public int IdRegra { get; set; }

        [Required(ErrorMessage = " O Campo {0} é Obrigatório!")]
        public String Name { get; set; }
    }
}
