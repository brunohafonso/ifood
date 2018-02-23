using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace senai.ifood.domain.entities
{
    public class ClienteDomain : BaseDomain
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataNascimento { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Sexo { get; set; }
        
        [ForeignKey("UsuarioId")]
        public UsuarioDomain Usuario { get; set; }
        public int UsuarioId { get; set; } 
        
    }
}