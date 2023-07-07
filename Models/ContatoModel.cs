using System.ComponentModel.DataAnnotations;

namespace SistemaDeCadastros.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Digite o Nome do Contato")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o Email do Contato")]
        [EmailAddress(ErrorMessage = "O Email não é Valido!")]
        public string Email { get; set;}
        
        [Required(ErrorMessage = "Digite o Celular do Contato")]
        [Phone(ErrorMessage = "O Celular não é Valido!")]
        public string Celular { get; set;}
    }
}
