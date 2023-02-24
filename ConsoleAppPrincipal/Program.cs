using BLL;
using DAL;
using Models;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    private static void Main(string[] args)
    {
        int opcmain;
        do
        {
            Console.Title = "Menu";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------- GESTAO PROJECT ------------");
            Console.WriteLine("[1] Usuarios");
            Console.WriteLine("[2] Grupos Users");
            Console.WriteLine("[3] Permissoes");
            Console.WriteLine("[0] Sair");
            Console.Write("Escolha: ");
            opcmain = Convert.ToInt32(Console.ReadLine());
            switch (opcmain)
            {
                case 1:
                    USUARIOS();
                    break;
                case 2:
                    GRUPOUSUARIOS();
                    break;
                case 3:
                    PERMISSAO();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    Console.ReadLine();
                    break;
            }
        } while (opcmain != 0);
    }




    //menu usuario
    private static void PERMISSAO()
    {
        int opcmain;
        Console.Clear();
        Console.WriteLine("=== Permissão ===");
        Console.WriteLine("[1] Criar Permissão");
        Console.WriteLine("[2] Buscar Permissão");
        Console.WriteLine("[3] Excluir Permissão");
        Console.WriteLine("[0] Retornar MAIN");
        opcmain = Convert.ToInt32(Console.ReadLine());
        switch (opcmain)
        {
            case 1:
                CriarPermissao();
                break;
            case 2:
                BuscarPermissao();
                break;
            case 3:
                DeletarPermissao();
                break;
            case 4:
                BuscarTodasPermissao();
                break;
            default:
                Console.WriteLine("Opção Invalida.");
                Console.ReadLine();
                break;
        }
        return;
    }

    private static void BuscarTodasPermissao()
    {
        throw new NotImplementedException();
    }

    private static void DeletarPermissao()
    {
        throw new NotImplementedException();
    }

    private static void BuscarPermissao()
    {
        throw new NotImplementedException();
    }

    private static void GRUPOUSUARIOS()
    {
        int opcgrupuser;
        Console.Clear();
        Console.WriteLine("=== Grupo De Usuarios ===");
        Console.WriteLine("[1] Criar GrupoUSER");
        Console.WriteLine("[2] Buscar GrupoUSER");
        Console.WriteLine("[3] Excluir GrupoUSER");
        Console.WriteLine("[4] Exibir GruposUSER");
        Console.WriteLine("[0] Retornar MAIN");
        Console.Write("Escolha: ");
        opcgrupuser = Convert.ToInt32(Console.ReadLine());
        switch (opcgrupuser)
        {
            case 1:
                CriarGrupoUsuario();
                break;
            case 2:
                BuscarGrupo();
                break;
            case 3:
                DeletarGrupo();
                break;
            case 4:
                BuscarTodosGrupos();
                break;
            default:
                Console.WriteLine("Opção Invalida");
                Console.ReadLine();
                break;
        }
        return;
    }

    private static void BuscarTodosGrupos()
    {
        throw new NotImplementedException();
    }

    private static void BuscarGrupo()
    {
        throw new NotImplementedException();
    }

    private static void DeletarGrupo()
    {
        throw new NotImplementedException();
    }

    private static void USUARIOS()
    {
        int opcuser;

        Console.Clear();
        Console.WriteLine("=== Usuarios ===");
        Console.WriteLine("[1] Criar Usuario");
        Console.WriteLine("[2] Buscar Usuario");
        Console.WriteLine("[3] Excluir Usuario");
        Console.WriteLine("[4] Exibir Usuarios");
        Console.WriteLine("[0] Retornar MAIN");
        Console.Write("Escolha: ");
        opcuser = Convert.ToInt32(Console.ReadLine());
        switch (opcuser)
        {
            case 1:
                CriarUsuario();
                break;

            case 2:
                BuscarPorNomeUsuario();
                break;

            case 3:
                DeletarUsuario();
                break;
            case 4:
                BuscarTodosUsuarios();
                break;
            case 0:
                return;
            default:
                Console.WriteLine("Opção Invalida");
                Console.ReadLine();
                break;
        }
        return;
    }





    private static void BuscarPorNomeUsuario()
    {
        return;
    }
    private static void BuscarTodosUsuarios()
    {
        try
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            List<Usuario> usuarios = usuarioBLL.BuscarTodos();

            foreach (Usuario item in usuarios)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("NomeUsuario: " + item.NomeUsuario);
                Console.WriteLine("Nome: " + item.Nome);
                Console.WriteLine("Email: " + item.Email);
                Console.WriteLine("Ativo: " + item.Ativo);
                Console.WriteLine("CPF: " + item.CPF);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadLine();
        return;
    }
    private static void DeletarUsuario()
    {
        int id;
        Console.Clear();
        Console.WriteLine("Digite o ID do Usuario que Deseja Excluir");
        Console.Write("ID: ");
        SqlConnection cn = new SqlConnection();
        try
        {
            cn.ConnectionString = Conexao.StringDeConexao;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "delete from Usuario where id = @id ";
            id = Convert.ToInt32(Console.ReadLine());
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            cn.Open();
            cmd.ExecuteScalar();
            Console.Clear();
            Console.WriteLine("Usuario " + id + " Deletado");
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            throw new Exception("Ocorreu um erro ao tentar deletar o usuario no banco: " + ex.Message);
        }
        finally
        {
            cn.Close();
        }
        return;
    }
    private static void CriarGrupoUsuario()
    {
        try
        {
            GrupoUsuario grupousuario = new GrupoUsuario();

            GrupoUsuarioBLL grupousuarioBll = new GrupoUsuarioBLL();

            bool opc;
            do
            {
                Console.Write("Nome do Grupo: ");
                grupousuario.NomeGrupo = Console.ReadLine();
                //  usuario.Nome = "Daniel Germano";
                grupousuarioBll.Inserir(grupousuario);

                Console.Write("\n\nGrupo Registrado Com Sucesso!!!\n\n\n" + "Deseja Criar Mais Um Grupo de Usuario? \n(S) OU (N) : ");
                opc = Console.ReadLine().ToUpper() == "S";
                Console.Clear();

            } while (opc == true);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return;
    }
    private static void CriarPermissao()
    {
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
        return;
    }
    private static void CriarUsuario()
    {
        Console.Clear();
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


        return;
    }






















}
