using Sistema.Cadastro.Contatos.Models;

namespace Sistema.Cadastro.Contatos.Repository
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> ListarContatos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
