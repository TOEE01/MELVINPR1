
using Melvin03.DAO;
using Melvin03.MODEL;
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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
                    Carga();
                clear();
        }

        void Carga() {
            dtVistaUsuario.Rows.Clear();
            ClsDUserList clsDUserList = new ClsDUserList();
            List<UserList> Lista= clsDUserList.cargarDatosUserList();
            
            foreach (var iteracion in Lista)
            {
                dtVistaUsuario.Rows.Add(iteracion.id, iteracion.NombreUsuario, iteracion.Apellido, iteracion.Edad, iteracion.Pass);
            }


        }


        void clear()
        {
            txtid.Clear();
            txtNombreUsuario.Clear();
            txtApellidoUsuario.Clear();
            txtEdad.Clear();
            txtPass.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals("")) { 
            ClsDUserList clsDUserList = new ClsDUserList();
            //clsDUserList.SaveUserList(txtNombreUsuario.Text,txtApellidoUsuario.Text,Convert.ToInt32(txtEdad.Text),txtPass.Text);
            UserList userList = new UserList();
            userList.NombreUsuario = txtNombreUsuario.Text;
            userList.Apellido = txtApellidoUsuario.Text;
            userList.Edad = Convert.ToInt32(txtEdad.Text);
            userList.Pass = txtPass.Text;
            clsDUserList.SaveUserList(userList);
            }
            else  {
                ClsDUserList clsDUserList = new ClsDUserList();

                UserList userList = new UserList();
                userList.id = Convert.ToInt32(txtid.Text);
                userList.NombreUsuario = txtNombreUsuario.Text;
                userList.Apellido = txtApellidoUsuario.Text;
                userList.Edad = Convert.ToInt32(txtEdad.Text);
                userList.Pass = txtPass.Text;
                clsDUserList.updateUser(userList);
            }
            Carga();
            clear();
        } 

        private void button2_Click(object sender, EventArgs e)
        {
       
            Carga();
            clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDUserList user = new ClsDUserList();
            user.deletedato(Convert.ToInt32(txtid.Text));

            Carga();
            clear();
        }

        private void dtVistaUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtVistaUsuario.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtVistaUsuario.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dtVistaUsuario.CurrentRow.Cells[2].Value.ToString();
            String Edad = dtVistaUsuario.CurrentRow.Cells[3].Value.ToString();
            String pass = dtVistaUsuario.CurrentRow.Cells[4].Value.ToString();

            txtid.Text = Id;
            txtNombreUsuario.Text = Nombre;
            txtApellidoUsuario.Text = Apellido;
            txtEdad.Text = Edad;
            txtPass.Text = pass;


        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
           
        }
    }
}
