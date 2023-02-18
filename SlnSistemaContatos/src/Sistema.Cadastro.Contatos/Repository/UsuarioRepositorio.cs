using Sistema.Cadastro.Contatos.Data;
using Sistema.Cadastro.Contatos.Models;

namespace Sistema.Cadastro.Contatos.Repository
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly ContextDatabase _bancoContext;
        
        public UsuarioRepositorio(ContextDatabase bancoContext)
        {
            this._bancoContext = bancoContext;
        }

        public UsuarioModel BuscarLogin(string login)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper());
        }

        public UsuarioModel BuscarId(int id)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public List<UsuarioModel> ListarContatos()
        {
            return _bancoContext.Usuarios.ToList();
        }
        
        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            usuario.DataCadastro = DateTime.Now;
            usuario.SetSenhaHash();
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDB = BuscarId(usuario.Id);

            if (usuarioDB == null) throw new System.Exception("Houve um erro na atualização do usuário");

            usuarioDB.Nome = usuario.Nome;
            usuarioDB.Login = usuario.Login;
            usuarioDB.Email = usuario.Email;
            usuarioDB.Perfil = usuario.Perfil;
            usuarioDB.DataAtualizacao = DateTime.Now;

            _bancoContext.Usuarios.Update(usuarioDB);
            _bancoContext.SaveChanges();

            return usuarioDB;
        }

        public bool Apagar(int id)
        {
            //Apagar da Database
            UsuarioModel usuarioDB = BuscarId(id);

            if (usuarioDB == null) throw new System.Exception("Houve um erro na exclusão do usuário");

            _bancoContext.Usuarios.Remove(usuarioDB);
            _bancoContext.SaveChanges();
            return true;
        }

    }
}
