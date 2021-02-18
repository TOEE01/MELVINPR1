using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melvin01.DAO;
using Melvin01.DOMINIO;
using Melvin01.VISTA;

namespace Melvin01.NEGOCIO
{
    class ClsLogin
    {

        CLsListaUsuarios cls = new CLsListaUsuarios();
        
        Login log = new Login();

        public int acceso(Login log)
        {
            int estado = 0;
            for (int i = 0; i< cls.user.Length;i++){
            if (log.Usuario.Equals(cls.user[i]) && log.Password.Equals(cls.pass[i])) {
                 estado = 1;

                frmMenu frm = new frmMenu();
                frm.Show();
                
               
            }
            }
            return estado;
        }
    }
}
