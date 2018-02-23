using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace senai.ifood.domain.entities
{
    public class RestauranteDomain : BaseDomain
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Responsavel { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Site { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Telefone { get; set; }
        
        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }
        
        public EspecialidadeDomain Especialidade { get; set; }
        
        [ForeignKey("EspecialidadeId")]
        public int EspecialidadeId { get; set; }

        [ForeignKey("UsuarioId")]
        public UsuarioDomain Usuario { get; set; }
        
        public int UsuarioId { get; set; }
        
        public ICollection<ProdutoRestauranteDomain> Produtos { get; set; }
        
        public int ProdutoId { get; set; }
        
    }
}