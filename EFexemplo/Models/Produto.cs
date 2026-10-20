using System;
using System.ComponentModel.DataAnnotations;

namespace EFexemplo.Models
{
    public class Produto
    {
        [Key]
        public Guid ProdutoId { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public Guid CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}