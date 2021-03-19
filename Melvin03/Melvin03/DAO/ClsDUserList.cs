using Melvin03.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melvin03.DAO
{
    class ClsDUserList
    {
        public List<UserList> cargarDatosUserList() {
            List<UserList> Lista;

            using (programacionEntities db = new programacionEntities())
            {

                Lista = db.UserList.ToList();
                

            }

            return Lista;
        }

        public void SaveUserList(UserList user)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();

                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        public void deletedato(int ID) {
            try
            {
                using (programacionEntities db = new programacionEntities())

                {
                    int Eliminar = Convert.ToInt32(ID);
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
        }

        public void updateUser(UserList user) {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int update = Convert.ToInt32(user.id);
                    UserList userList = db.UserList.Where(x => x.id == update).Select(x => x).FirstOrDefault();
                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
                    db.SaveChanges();

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

    }
}
