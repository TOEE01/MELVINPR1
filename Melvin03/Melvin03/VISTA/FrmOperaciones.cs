﻿using System;
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
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                int suma;
                suma = Convert.ToInt32(txtdato1.Text) + Convert.ToInt32(txtdato2.Text);

                txtResultado.Text = suma.ToString();

              
            }catch (Exception ex)
            {
                MessageBox.Show("Los Datos no son correctos revisa");
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            try
            {
                int resta;
                resta = Convert.ToInt32(txtdato1.Text) - Convert.ToInt32(txtdato2.Text);
                txtResultado.Text = resta.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Los datos no esta bien revisa");
            }
        }
    }

}
