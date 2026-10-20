using System;
using System.ComponentModel.DataAnnotations;

namespace EFexemplo.Models
{
    public class Cliente
    {
        [Key]
        public Guid ClienteId { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Email { get; set; }
    }
}