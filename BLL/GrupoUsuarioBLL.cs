using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario _grupousuario)
        {
            if (_grupousuario.NomeGrupo.Length <= 3 || _grupousuario.NomeGrupo.Length >= 50)
            {
                throw new Exception("Nome do Grupo deve ter mais de 3 caracteres");
            }
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            grupousuarioDAL.Inserir(_grupousuario);
        }


        public void Buscar(string _nomegrupo)
        {

        }
        public void Alterar(GrupoUsuario grupousuario)
        {

        }
        public void Excluir(int _id)
        {

        }

    }
}
