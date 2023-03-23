using System;
using BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace WindowsFormsApp1
{
    public partial class FormConsultaGrupoUsuario : Form
    {
        public int Id;
        public FormConsultaGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarPorNome(textBoxBuscar.Text);        
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            if (grupoUsuarioBindingSource.Count > 0)
            {
                Id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).IdGrupoUsuario;
                Close();
            }
            else
                MessageBox.Show("Não existe um grupo de usuário para ser selecionado.");
        }
    }
}
