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
                Conexao conexao = new Conexao();
                cn.ConnectionString = conexao.StringDeConexao;
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