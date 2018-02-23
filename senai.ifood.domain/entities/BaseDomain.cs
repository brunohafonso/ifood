using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace senai.ifood.domain.entities
{
    public abstract class BaseDomain
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int Id { get; set; }
        
       [Required]
       [DataType(DataType.DateTime)]
       public DateTime DataCriacao { get; set; }
    }
}