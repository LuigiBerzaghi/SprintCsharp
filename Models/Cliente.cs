using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Sprint1CSharp.Models
{
    public class Cliente
    {
        [Key]
        [BindRequired]              
        [Range(1, int.MaxValue)]
        public int Id { get; set; } 

        [Required] public string? Nome { get; set; }
        [Required] public string? CPF  { get; set; }
        [Required, EmailAddress] public string? Email { get; set; }

        public string? Endereco { get; set; }
        public List<Veiculo> Veiculos { get; set; } = new();
    }
}
