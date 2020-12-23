using HopitalApp.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopitalApp.Vistas
{
    public partial class FrmLogin : Form
    {
        public delegate void PassData(bool Exito);
        public event PassData Pass;

        public FrmLogin()
        {
            InitializeComponent();
        }
        ClassLoginUser ObClassLoginUser = new ClassLoginUser();
        private void FrmLogin_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = TxtUser.Text;
            string passWordk = TxtPassWork.Text;

            if (!(string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(passWordk)))
            {
                bool exito = ObClassLoginUser.LoginUser(usuario, passWordk);
                if (exito)
                {
                    Pass(exito);
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Usuario y password son obligatorios");
            }
        }
    }
}
