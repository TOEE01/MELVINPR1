using Melvin01.DOMINIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Melvin01.NEGOCIO;
using Melvin01.VISTA;

namespace Melvin01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Usuario = txtUser.Text;
            log.Password = txtPass.Text;

            ClsLogin clss = new ClsLogin();
            int variabledeevalucion = clss.acceso(log);

            if (variabledeevalucion == 1)
            {
                MessageBox.Show("welcome");
                this.Hide();

            }
            else
            {
                MessageBox.Show("false");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
