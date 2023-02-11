using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public void inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into Usuario (nome, NomeUsuario, cpf, Email, Senha, Ativo) " +
                                   "values (@nome, @nomeusuario, @cpf, @email, @senha, @ativo)";
            }
            catch (Exception)
            {

            }
            finally
            {
                cn.Close();
            }
        }
        public Usuario Buscar(string _nomeusuario)
        {

        }
        public void Alterar(Usuario _usuario)
        {

        }
        public void Excluir(int _id)


    }
}