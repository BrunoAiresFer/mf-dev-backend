using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend.Models
{
    [Table("Veiculos")] //criação da tabela de veículos
    public class Veiculo
    {
        [Key]
        public int id { get; set; } //chave primária

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Placa é obrigatório.")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "O campo Ano de frabricação é obrigatório.")]
        public int AnoFabricacao { get; set;}

        [Required(ErrorMessage = "O campo Ano do modelo é obrigatório.")]
        public int AnoModelo { get; set; }


    }
}
