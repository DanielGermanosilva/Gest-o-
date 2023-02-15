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

           string opc;
            do
            {
               
                Console.WriteLine("Digite Seu Nome: ");
                usuario.Nome = Console.ReadLine();
                //  usuario.Nome = "Daniel Germano";

                Console.WriteLine("Crie um Nome de Usuario: ");
                usuario.NomeUsuario = Console.ReadLine();
                // usuario.NomeUsuario = "DJ5555";

                Console.WriteLine("Digite Seu Email: ");
                usuario.Email = Console.ReadLine();
                //  usuario.Email = "ddger2018@gmail.com";

                Console.WriteLine("Digite Seu CPF: ");
                usuario.CPF = Console.ReadLine();
                //  usuario.CPF = "458.158.442-88";

                Console.WriteLine("Crie Uma Senha: ");
                usuario.Senha = Console.ReadLine();
                //   usuario.Senha = "10203055555";
                Console.WriteLine("Usuario Está Ativo? (S) OU (N) : ");
                usuario.Ativo = Console.ReadLine().ToUpper() == "S";

                usuarioBll.Inserir(usuario);
                Console.WriteLine("\n\nUsuario Registrado Com Sucesso!!!\n\n\n" + "Deseja Criar Mais Um Usuario? ");
                opc = Console.ReadLine();
                Console.Clear();

            } while (opc == "sim");


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
