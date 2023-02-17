using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(Permissao _permissao)
        {
            if (_permissao.Descricao.Length <= 3 || _permissao.Descricao.Length >= 50)
            {
                throw new Exception("Nome de Usuario deve ter mais de 3 caracteres");
            }
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(_permissao);
        }

        public void Buscar(string _nomePermissao)
        {

        }
        public void Alterar(Permissao permissao)
        {

        }
        public void Excluir(int _id)
        {

        }

    }
}
