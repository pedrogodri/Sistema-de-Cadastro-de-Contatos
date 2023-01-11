using Sistema.Cadastro.Contatos.Models;

namespace Sistema.Cadastro.Contatos.Repository
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
