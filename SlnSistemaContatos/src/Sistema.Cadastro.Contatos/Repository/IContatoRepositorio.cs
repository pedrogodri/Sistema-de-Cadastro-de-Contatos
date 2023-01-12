using Sistema.Cadastro.Contatos.Models;

namespace Sistema.Cadastro.Contatos.Repository
{
    public interface IContatoRepositorio
    {
        ContatoModel BuscarId(int id);
        List<ContatoModel> ListarContatos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
}
