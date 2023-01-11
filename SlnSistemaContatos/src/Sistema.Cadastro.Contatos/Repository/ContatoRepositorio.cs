using Sistema.Cadastro.Contatos.Data;
using Sistema.Cadastro.Contatos.Models;

namespace Sistema.Cadastro.Contatos.Repository
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly ContextDatabase _bancoContext;
        public ContatoRepositorio(ContextDatabase bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<ContatoModel> ListarContatos()
        {
            return _bancoContext.Contatos.ToList();
        }
        
        public ContatoModel Adicionar(ContatoModel contato)
        {
            //Gravar na Database 
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }
    }
}
