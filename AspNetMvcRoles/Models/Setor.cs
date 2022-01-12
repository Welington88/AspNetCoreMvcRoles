using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AspNetMvcRoles.Models
{
    [Table("Setores")]
    public class Setor
    {
        public Setor(){
        }
        [Key]
        public int IdSetor { get; set; }

        [Display(Name ="Setor")]
        public String Descricao { get; set; }

        [JsonIgnore]
        public virtual ICollection<Cargo> Cargos { get; set; }

        [JsonIgnore]
        public virtual ICollection<Funcinario> Funcinarios { get; set; }

        [ForeignKey("Sedes")]
        [Display(Name = "Código Sede")]
        public int IdSede { get; set; }
        public virtual Sedes Sedes { get; set; }

    }
    
}