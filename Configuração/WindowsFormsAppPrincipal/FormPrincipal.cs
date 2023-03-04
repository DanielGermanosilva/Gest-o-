using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class BTteste : Form
    {
        public BTteste()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }
    }
}
