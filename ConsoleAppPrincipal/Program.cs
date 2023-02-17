using BLL;
using DAL;
using Models;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{



    private static void Main(string[] args)
    {









        /*
        Console.WriteLine("--------------- GESTAO PROJECT------------");
        Console.WriteLine("[1] Usuarios");
        Console.WriteLine("[2] Grupos De Usuarios");
        Console.WriteLine("[3] Permissoes");



        Console.WriteLine("=== Usuarios ===");
        Console.WriteLine("[1] Criar Usuario");
        Console.WriteLine("[2] Buscar Usuario");
        Console.WriteLine("[3] Excluir Usuario");


        Console.WriteLine("=== Permissão ===");
        Console.WriteLine("[1] Criar Permissão");
        Console.WriteLine("[2] Buscar Permissão");
        Console.WriteLine("[3] Excluir Permissão");


        Console.WriteLine("=== Grupo De Usuarios ===");
        Console.WriteLine("[1] Criar GrupoUSER");
        Console.WriteLine("[2] Buscar GrupoUSER");
        Console.WriteLine("[3] Excluir GrupoUSER");
        */

        try
        {
            GrupoUsuario grupousuario = new GrupoUsuario();

            GrupoUsuarioBLL grupousuarioBll = new GrupoUsuarioBLL();

            bool opc;
            do
            {
                Console.Write("Descreva a Permissao: ");
                grupousuario.NomeGrupo = Console.ReadLine();
                //  usuario.Nome = "Daniel Germano";
                grupousuarioBll.Inserir(grupousuario);

                Console.Write("\n\nPermissao Registrada Com Sucesso!!!\n\n\n" + "Deseja Criar Mais Um Grupo de Usuario? \n(S) OU (N) : ");
                opc = Console.ReadLine().ToUpper() == "S";
                Console.Clear();

            } while (opc == true);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }





        /*
        // cadastro de permissao
         try
        {
            Permissao permissao = new Permissao();

            PermissaoBLL permissaoBll = new PermissaoBLL();

            bool opc;
            do
            {
                Console.Write("Descreva a Permissao: ");
                permissao.Descricao = Console.ReadLine();
                //  usuario.Nome = "Daniel Germano";
                permissaoBll.Inserir(permissao);

                Console.Write("\n\nPermissao Registrada Com Sucesso!!!\n\n\n" + "Deseja Criar Mais Uma Permissao? \n(S) OU (N) : ");
                opc = Console.ReadLine().ToUpper() == "S";
                Console.Clear();

            } while (opc == true);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
  
        // */



        /*
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
       // */
        // --------------------
    }
}
