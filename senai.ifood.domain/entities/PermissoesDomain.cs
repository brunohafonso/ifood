using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace senai.ifood.domain.entities
{
    public class PermissoesDomain : BaseDomain
    {
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        public ICollection<UsuarioPermissaoDomain> UsuariosPermissoes { get; set; }
        
    }
}