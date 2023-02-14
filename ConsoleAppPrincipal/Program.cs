using BLL;
using Models;

public class Program
{



    public static void Main(string[] args)
    {
        try
        {
            Usuario usuario = new Usuario();
            usuario.Nome = "Daniel Germano";
            usuario.NomeUsuario = "DJ";
            usuario.Ativo = true;
            usuario.Email = "ddger2018@gmail.com";
            usuario.CPF = "458.158.442-88";
            usuario.Senha = "102030";

            UsuarioBLL usuarioBll = new UsuarioBLL();
            usuarioBll.Inserir(usuario);
        }
        catch (Exception ex)
        {
           Console.WriteLine(ex.Message);
        }
    }
}
