using BLL;
using Models;

public class Program
{



    private static void Main(string[] args)
    {

        UsuarioBLL usuarioBll = new UsuarioBLL();
        Usuario usuario = new Usuario();


        usuario.Nome = "Daniel Germano";
        usuario.NomeUsuario = "DJ";
        usuario.Ativo = true;
        usuario.Email = "ddger2018@gmail.com";
        usuario.CPF = "458.158.442-88";
        usuario.Senha = "102030";
        usuarioBll.Inserir(usuario);
    }


}
