
using System.Collections.Generic;

namespace Models
{
    public class Permissao
    {
        public int IdPermissao { get; set; }
        public string Descricao { get; set; }
        public List<GrupoUsuario> GrupoUsuarios { get; set; }

    }
}
