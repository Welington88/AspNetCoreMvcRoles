using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcRoles.Models
{
    [Table("Cadastro")]
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required(ErrorMessage = " O Campo {0} é Obrigatório!")]
        public String Usuario { get; set; }

        [Required(ErrorMessage = " O Campo {0} é Obrigatório!")]
        [StringLength(50, ErrorMessage = " O Campo {0} pode ter no máximo {1} e minimo {2} caracteres ", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public String Senha { get; set; }

        [Required(ErrorMessage = " O Campo {0} é Obrigatório!")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = " O Campo {0} é Obrigatório!")]
        public String Nivel { get; set; }
    }
}
