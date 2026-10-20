using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFexemplo.Models
{
    public class Categoria
    {
        [Key]
        public Guid CategoriaId { get; set; }

        [Required]
        public string Nome { get; set; }

        public ICollection<Produto> Produtos { get; set; }
            = new List<Produto>();
    }
}