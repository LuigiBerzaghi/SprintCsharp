using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint1CSharp.Models
{
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Modelo { get; set; }

        [Required]
        public string? Placa { get; set; }

        [Required]
        public string? Cor { get; set; }

        [Required]
        public string? Ano { get; set; }

        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; }
    }
}
