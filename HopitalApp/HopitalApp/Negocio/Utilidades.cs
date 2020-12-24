using HopitalApp.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopitalApp.Negocio
{
    public class Utilidades
    {
        private ClassUtilidades ObClassUtilidades = new ClassUtilidades();
        public DataTable ListarTipodeServicio(ComboBox cbo)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = ObClassUtilidades.ListarTiposDeServicios();
                foreach (DataRow item in dt.Rows)
                {
                    cbo.Items.Add(item[1].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public void ListarDoctor(ComboBox cbo)
        {
            try
            {
                DataTable dt = ObClassUtilidades.ListarDoctor();
                if (dt.Rows.Count > 0)
                {
                    cbo.DataSource = dt;
                    cbo.DisplayMember = "Nombre";
                    cbo.ValueMember = "IdDoctor";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void ListarPacientes(DataGridView dgv, string documento, short modulo)
        {
            try
            {
                dgv.DataSource = null;
                DataTable dt = new DataTable();
                if (modulo == 0)
                {
                    dt = ObClassUtilidades.ListarPacientes(documento);

                }
                else if (modulo == 1)
                {
                    dt = ObClassUtilidades.ListarClientes(documento);
                }

                if (dt.Rows.Count > 0)
                {
                    dgv.DataSource = dt;
                    dgv.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ListarCitas(DataGridView dgv)
        {
            try
            {
                dgv.Rows.Clear();
                DataTable dt = ObClassUtilidades.ListarCitas(1);
                foreach (DataRow item in dt.Rows)
                {
                    dgv.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(),"Cerrar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ListarFormularios(DataGridView dgv, string nit)
        {
            try
            {
                dgv.Rows.Clear();
                DataTable dt = ObClassUtilidades.ListarFormularios(nit);
                foreach (DataRow item in dt.Rows)
                {
                    dgv.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(),item[4].ToString(), "Facturar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
