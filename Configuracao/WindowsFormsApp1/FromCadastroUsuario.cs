using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FromCadastroUsuario : Form
    {
        private bool alterar;
        public FromCadastroUsuario(bool _alterar = false, int _id=0)
        {
            InitializeComponent();
            alterar = _alterar;

            if (alterar)
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorId(_id);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            try
            {
            
                usuarioBindingSource.EndEdit();

                if (!alterar)
                    usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current, confirmacaoTextBox.Text);
                else
                    usuarioBLL.Alterar((Usuario)usuarioBindingSource.Current, confirmacaoTextBox.Text);

                MessageBox.Show("Registro salvo com sucesso");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FromCadastroUsuario_Load(object sender, EventArgs e)
        {
            if (!alterar)
            {
                usuarioBindingSource.AddNew();
            }
        }
    }
}
