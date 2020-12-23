using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopitalApp.Controlador
{
    public class ClassFormularioClinico
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);
        public int GuardarFormulario(int idPaciente, int idCliente, int idUsuario)
        {
            int id = 0;
            using (SqlCommand cmd = new SqlCommand("sp_formularioclinico", connection))
            {
                cmd.Parameters.Add("@IdPaciente", SqlDbType.Int).Value = idPaciente;
                cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = idCliente;
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = idUsuario;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Modulo", SqlDbType.Char).Value = 'I';
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                cmd.ExecuteNonQuery();
                id = Convert.ToInt32(cmd.Parameters["@Id"].Value.ToString());
                connection.Close();
            }
            return id;
        }

        public int GuardarDetalleFormulario(int idFormulario, int idPaciente, int idTipoServicio, int idDoctor, decimal costo, DateTime fecha)
        {
            int id = 0;
            using (SqlCommand cmd = new SqlCommand("sp_detalleformularioclinico", connection))
            {
                cmd.Parameters.Add("@IdFormulario", SqlDbType.Int).Value = idFormulario;
                cmd.Parameters.Add("@IdPaciente", SqlDbType.Int).Value = idPaciente;
                cmd.Parameters.Add("@IdTipoServicio", SqlDbType.Int).Value = idTipoServicio;
                cmd.Parameters.Add("@IdDoctor", SqlDbType.Int).Value = idDoctor;
                cmd.Parameters.Add("@Costo", SqlDbType.Decimal).Value = costo;
                cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = fecha;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Modulo", SqlDbType.Char).Value = 'I';
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                cmd.ExecuteNonQuery();
                id = Convert.ToInt32(cmd.Parameters["@Id"].Value.ToString());
                connection.Close();
            }
            return id;
        }

        public bool CerrarCita(int idServicio)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_citas", connection))
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = idServicio;
                    cmd.Parameters.Add("@Modulo", SqlDbType.Char).Value = 'U';
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool CerrarFactura(int idFormulario)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_factura", connection))
                {
                    cmd.Parameters.Add("@IdFormulario", SqlDbType.Int).Value = idFormulario;
                    cmd.Parameters.Add("@Modulo", SqlDbType.Char).Value = 'I';
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public DataTable ListarFactura(int idDocumento)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter("sp_factura", connection))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@IdFormulario", SqlDbType.Int).Value = idDocumento;
                adapter.SelectCommand.Parameters.Add("@Modulo", SqlDbType.VarChar).Value = "SI";
                adapter.Fill(dt);
            }
            return dt;
        }


        public DataTable ListarDetalleFactura(int idDocumento)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter("sp_factura", connection))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.Add("@IdFormulario", SqlDbType.Int).Value = idDocumento;
                adapter.SelectCommand.Parameters.Add("@Modulo", SqlDbType.VarChar).Value = "SD";
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
