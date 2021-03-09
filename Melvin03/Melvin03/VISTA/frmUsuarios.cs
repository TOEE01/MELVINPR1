
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
            using (programacionEntities db = new programacionEntities())
            {

                var Lista = db.UserList.ToList();
                foreach (var iteracion in Lista)
                {
                    dtVistaUsuario.Rows.Add(iteracion.id,iteracion.NombreUsuario,iteracion.Apellido,iteracion.Edad,iteracion.Pass);
                }
                
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
            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();

                    userList.NombreUsuario = txtNombreUsuario.Text;
                    userList.Apellido = txtApellidoUsuario.Text;
                    userList.Edad = Convert.ToInt32(txtEdad.Text);
                    userList.Pass = txtPass.Text;
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            Carga();
            clear();
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                using (programacionEntities db = new programacionEntities()) {
                    int update = Convert.ToInt32(txtid.Text);
                    UserList user = db.UserList.Where(x => x.id == update).Select(x => x).FirstOrDefault();
                    user.NombreUsuario = txtNombreUsuario.Text;
                    user.Apellido = txtApellidoUsuario.Text;
                    user.Edad = Convert.ToInt32(txtEdad.Text);
                    user.Pass = txtPass.Text;
                    db.SaveChanges();

                }
            }
            catch (Exception Ex){
                MessageBox.Show(Ex.ToString());   
            }
            Carga();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())

                {
                    int Eliminar = Convert.ToInt32(txtid.Text);
                    UserList userListt = db.UserList.Where(x => x.id == Eliminar).Select(x => x).FirstOrDefault();

                    //userListt = db.UserList.Find(Eliminar);
                    db.UserList.Remove(userListt);
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            
            }
            Carga();  

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
