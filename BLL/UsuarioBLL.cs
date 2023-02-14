using DAL;
using Models;
namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
            {
                throw new Exception("Nome de Usuario deve ter mais de 3 caracteres");
            }
            if (_usuario.Senha == "1234")
            {
                throw new Exception("A senha nao pode ser 1234");
            }
            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
            {
                throw new Exception("A senha deve ter entre 7 e 11 caracteres");
            }
            // todo: validar se ja existe um usuario com este nome.
            if (_usuario.NomeUsuario.Contains(" "))
            {
                throw new Exception("Usuario nao pode conter espaco");
            }
            if (_usuario.Senha.Contains("1234567"))
            {
                throw new Exception("Nao e permitido numeros sequenciais");
            }

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
           

        }
        public Usuario Buscar(string _nomeUsuario)
        {
            throw new NotImplementedException();
        }
        public void Alterar(Usuario _usuario)
        {

        }
        public void Excluir(int _id)
        {

        }





    }
}