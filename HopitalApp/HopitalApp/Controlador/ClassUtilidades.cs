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
    public class ClassUtilidades
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);

        public DataTable ListarTiposDeServicios()
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter("sp_tiposervicio", connection))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@Modulo", SqlDbType.Char).Value = 'S';
                adapter.Fill(dt);
            }
            return dt;
        }


        public DataTable ListarDoctor()
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter("sp_doctores", connection))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@Modulo", SqlDbType.Char).Value = 'S';
                adapter.Fill(dt);
            }
            return dt;
        }


        public DataTable ListarPacientes(string documento)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter("sp_paciente", connection))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@Documento", SqlDbType.VarChar).Value = documento;
                adapter.SelectCommand.Parameters.Add("@Modulo", SqlDbType.Char).Value = 'S';
                adapter.Fill(dt);
            }
            return dt;
        }


        public DataTable ListarClientes(string documento)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter("sp_cliente", connection))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@Documento", SqlDbType.VarChar).Value = documento;
                adapter.SelectCommand.Parameters.Add("@Modulo", SqlDbType.Char).Value = 'S';
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable ListarCitas(int idDoctor)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter("sp_citas", connection))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@IdDoctor", SqlDbType.Int).Value = idDoctor;
                adapter.SelectCommand.Parameters.Add("@Modulo", SqlDbType.Char).Value = 'S';
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable ListarFormularios(string nit)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter("sp_formularioclinico", connection))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@Documento", SqlDbType.VarChar).Value = nit;
                adapter.SelectCommand.Parameters.Add("@Modulo", SqlDbType.Char).Value = 'S';
                adapter.Fill(dt);
            }
            return dt;
        }

    }
}
