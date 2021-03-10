using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melvin03.DAO;
using Melvin03.DOMINIO;
using Melvin03.VISTA;


namespace Melvin03.NEGOCIO
{
    class ClsLogin
    {
        ClsListaUsuarios cls = new ClsListaUsuarios();

        Login log = new Login();

        public int acceso(Login log)
        {
            int estado = 0;
            for (int i = 0; i < cls.user.Length; i++)
            {
                if (log.Usuario.Equals(cls.user[i]) && log.Password.Equals(cls.pass[i]))
                {
                    estado = 1;

                    //frmMenu frm = new frmMenu();
                    //frm.Show();


                }
            }
            return estado;
        }
    }
}
