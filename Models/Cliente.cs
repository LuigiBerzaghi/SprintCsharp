using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sprint1CSharp.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? CPF { get; set; }

        [Required]
        public string? Email { get; set; }

        public string? Endereco { get; set; }

        public List<Veiculo> Veiculos { get; set; } = new();
    }
}
