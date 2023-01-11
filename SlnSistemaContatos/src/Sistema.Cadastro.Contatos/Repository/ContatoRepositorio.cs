using Sistema.Cadastro.Contatos.Data;
using Sistema.Cadastro.Contatos.Models;

namespace Sistema.Cadastro.Contatos.Repository
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly ContextDatabase _bancoContext;
        
        public ContatoRepositorio(ContextDatabase bancoContext)
        {
            this._bancoContext = bancoContext;
        }

        public ContatoModel BuscarId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> ListarContatos()
        {
            return _bancoContext.Contatos.ToList();
        }
        
        public ContatoModel Adicionar(ContatoModel contato)
        {
            // Gravar na Database 
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            // Alterar na Database
            ContatoModel contatoDB = BuscarId(contato.Id);

            if (contatoDB == null) throw new System.Exception("Houve um erro na atualização do contato");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;

            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;
        }
    }
}
