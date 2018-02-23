using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace senai.ifood.domain.entities
{
    public class UsuarioDomain : BaseDomain
    {
        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [StringLength(50, MinimumLength=4)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }


        public ICollection<UsuarioPermissaoDomain> UsuariosPermissoes { get; set; }
        
        
        public ICollection<RestauranteDomain> Restaurantes { get; set; }
        

        public UsuarioDomain()
        {
            
        } 

        public UsuarioDomain(string Email, string Password, DateTime DataCriacao)
        {
            this.Email = Email;
            this.Senha = Senha;
            this.DataCriacao = DataCriacao;
        }
    }
}