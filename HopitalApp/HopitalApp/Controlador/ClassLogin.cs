using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalApp.Controlador
{
    public class ClassLogin
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);

        public bool Login(string usuario, string passWork)
        {
            using (SqlCommand cmd = new SqlCommand("sp_usuario", connection))
            {        
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_usuario";
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuario;
                cmd.Parameters.Add("@PassWork", SqlDbType.VarChar).Value = passWork;
                cmd.Parameters.Add("@Modulo", SqlDbType.Char).Value = 'S';
                connection.Open();
                string estado = Convert.ToString(cmd.ExecuteScalar());
                connection.Close();

                if (estado == "1")
                {
                    return true;
                }
                return false;
            }
        } 
    }
}
