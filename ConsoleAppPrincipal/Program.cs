using BLL;
using Models;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{



    private static void Main(string[] args)
    {
        Console.WriteLine("--------------- GESTAO PROJECT------------"):
        Console.WriteLine("[1] Usuarios");
        Console.WriteLine("[2] Grupos De Usuarios");
        Console.WriteLine("[3] Permiçoes");










        // Cadastro de Usuario
        try
        {
            Usuario usuario = new Usuario();

            UsuarioBLL usuarioBll = new UsuarioBLL();

            bool opc;
            do
            {

                Console.Write("Digite Seu Nome: ");
                usuario.Nome = Console.ReadLine();
                //  usuario.Nome = "Daniel Germano";

                Console.Write("Crie um Nome de Usuario: ");
                usuario.NomeUsuario = Console.ReadLine().ToLower();
                // usuario.NomeUsuario = "DJ5555";

                Console.Write("Digite Seu Email: ");
                usuario.Email = Console.ReadLine().ToLower();
                //  usuario.Email = "ddger2018@gmail.com";

                Console.Write("Digite Seu CPF: ");
                usuario.CPF = Console.ReadLine();
                //  usuario.CPF = "458.158.442-88";

                Console.Write("Crie Uma Senha: ");
                usuario.Senha = Console.ReadLine();
                //   usuario.Senha = "10203055555";
                Console.Write("Usuario Está Ativo? \n(S) OU (N) : ");
                usuario.Ativo = Console.ReadLine().ToUpper() == "S";

                usuarioBll.Inserir(usuario);
                Console.Write("\n\nUsuario Registrado Com Sucesso!!!\n\n\n" + "Deseja Criar Mais Um Usuario? \n(S) OU (N) : ");
                opc = Console.ReadLine().ToUpper() == "S";
                Console.Clear();

            } while (opc == true);


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        // --------------------
    }
}
