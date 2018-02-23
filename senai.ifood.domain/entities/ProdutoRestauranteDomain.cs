using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace senai.ifood.domain.entities
{
    public class ProdutoRestauranteDomain : BaseDomain
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(300)]
        public string Descricao { get; set; }

        [Required]
        public bool Ativo { get; set; }
        
        [Required]
        public Decimal valor { get; set; }
        
        [Required]
        public RestauranteDomain Restaurante { get; set; }
        
        [Required]
        public int RestauranteId { get; set; }
    }
}