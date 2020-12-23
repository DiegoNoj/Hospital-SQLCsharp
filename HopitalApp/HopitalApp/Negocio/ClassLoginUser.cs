using HopitalApp.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalApp.Negocio
{
    public class ClassLoginUser
    {
        private ClassLogin login = new ClassLogin();
        public bool LoginUser(string usuario, string passWork)
        {
           return  login.Login(usuario, passWork);
        }
    }
}
