using Sistema.Cadastro.Contatos.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Cadastro.Contatos.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o email")]
        [EmailAddress(ErrorMessage = "Email cadastrado é inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Selecione o perfil")]
        public PerfilEnum? Perfil { get; set; }
    }
}
