using BLL;
using Models;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    


    private static void Main(string[] args)
    {
        
        try
        {
            Usuario usuario = new Usuario();

            UsuarioBLL usuarioBll = new UsuarioBLL();
            
            do
            {

                usuario.Nome = "Daniel Germano";
                usuario.NomeUsuario = "DJ5555";
                usuario.Ativo = true;
                usuario.Email = "ddger2018@gmail.com";
                usuario.CPF = "458.158.442-88";
                usuario.Senha = "10203055555";


                usuarioBll.Inserir(usuario);

            } while (true);


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
