using Melvin01.DAO;
using System;
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
    public partial class FrmVistaUsuario : Form
    {
        public FrmVistaUsuario()
        {
            InitializeComponent();
        }

        private void FrmVistaUsuario_Load(object sender, EventArgs e)
        {
            CLsListaUsuarios cls = new CLsListaUsuarios();

            foreach (var iteracion in cls.user) {
                dataGridView1.Rows.Add(iteracion.ToString());
            
            }
        }
    }
}
