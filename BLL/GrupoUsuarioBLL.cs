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
                throw new Exception("Nome de Usuario deve ter mais de 3 caracteres");
            }
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            GrupoUsuarioDAL.Inserir(_grupousuario);
        }


    }
}
