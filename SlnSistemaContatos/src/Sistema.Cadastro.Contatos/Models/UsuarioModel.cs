using Sistema.Cadastro.Contatos.Enums;
using Sistema.Cadastro.Contatos.Helper;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Cadastro.Contatos.Models
{
    public class UsuarioModel
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
        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool SenhaValida(string senha)
        {
            return Senha == senha.GerarHash();
        }
        public void SetSenhaHash()
        {
            Senha = Senha.GerarHash();
        }
    }
}
