using System.ComponentModel.DataAnnotations;

namespace Sistema.Cadastro.Contatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o email")]
        [EmailAddress(ErrorMessage = "Email cadastrado é inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o celular")]
        [Phone(ErrorMessage = "O celular cadastrado é inválido")]
        public string Celular { get; set; }
    }
}
