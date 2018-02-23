using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace senai.ifood.domain.entities
{
    public class UsuarioPermissaoDomain : BaseDomain
    {   
        [ForeignKey("UsuarioId")]
        public UsuarioDomain Usuario { get; set; }

        
        public int UsuarioId { get; set; }

        [ForeignKey("PermissaoId")]
        public PermissoesDomain Permissao { get; set; }
        
        public int PermissaoId { get; set; }

        public UsuarioPermissaoDomain()
        {
            
        }
    }
}