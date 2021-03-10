using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melvin03.VISTA
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cLILKAQUIPARAINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe cerca = new FrmAcercaDe();
            cerca.MdiParent = this;
            cerca.Show();
        }

        private void vISTAUSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVistaUsuario view = new FrmVistaUsuario();
            view.MdiParent = this;
            view.Show();
        }
        public String UsuarioEstado;
        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = UsuarioEstado;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones fop = new FrmOperaciones();
            fop.MdiParent = this;
            fop.btnResta.Enabled = false;
            fop.Show();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones fop = new FrmOperaciones();
            fop.MdiParent = this;
            fop.btnSuma.Enabled = false;
            fop.Show();
        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios fus = new frmUsuarios();
            fus.MdiParent = this;
            fus.Show();
        }
    }
}
