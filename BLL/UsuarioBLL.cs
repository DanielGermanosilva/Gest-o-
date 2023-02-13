using Models;
namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            if (_usuario,NomeUsuario.Lenght <= 3){
                throw new Exception("Nome de Usuario deve ter mais de 3 caracteres");

                // todo: validar se a senha nao é 1234
                if (_usuario.Senha == "1234")
                {
                    throw new Exception("A senha nao pode ser 1234");
                }
                // todo: validar se ja existe um usuario com este nome.

            }
        }

        public Usuario Buscar(string _nomeUsuario)
        {
            throw new NotImplementedException();
        }
        public void Alterar(Usuario _usuario)
        {

        }
        public void Excluir(int)
        {

        }





    }
}