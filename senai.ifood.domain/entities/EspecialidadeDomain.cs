using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace senai.ifood.domain.entities
{
    public class EspecialidadeDomain : BaseDomain
    {
        public string Nome { get; set; }
        
        public string MyProperty { get; set; }
        
    }
}