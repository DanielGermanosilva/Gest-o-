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
            if (_grupousuario.NomeGrupo.Length <= 3 || _grupousuario.NomeGrupo.Length >= 150)
                throw new Exception("O nome do grupo deverá conter de 3 a 150 caracteres.");

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Inserir(_grupousuario);
        }
        public List<GrupoUsuario> BuscarPorId(int _idGrupoUsuario)
        {
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            return grupoUsuarioDAL.BuscarPorIdUsuario(_idGrupoUsuario);
        }

        public List<GrupoUsuario> BuscarTodosGrupos(string _grupoUsuario)
        {
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            return grupoUsuarioDAL.BuscarTodosGrupos(_grupoUsuario);
        }

        public List<GrupoUsuario> BuscarGrupoPorNome(string _nomeGrupo)
        {
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            return grupoUsuarioDAL.BuscarGrupoPorNome(_nomeGrupo);
        }

        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            if (_grupoUsuario.NomeGrupo.Length <= 3 || _grupoUsuario.NomeGrupo.Length >= 150)
                throw new Exception("O nome do grupo deverá conter de 3 a 150 caracteres.");

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Alterar(_grupoUsuario);
        }

        public void Excluir(GrupoUsuario _grupoUsuario)
        {
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Excluir(_grupoUsuario);
        }

        public List<GrupoUsuario> BuscarPorNome(string text)
        {
            throw new NotImplementedException();
        }
    }
}
