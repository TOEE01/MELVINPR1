﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melvin01.VISTA
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void cLICKPARAMASINFORMACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe cerca = new FrmAcercaDe();
            cerca.MdiParent = this;
            cerca.Show();
        }

        private void vistaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVistaUsuario view = new FrmVistaUsuario();
            view.MdiParent = this;
            view.Show();
        }
    }
}
