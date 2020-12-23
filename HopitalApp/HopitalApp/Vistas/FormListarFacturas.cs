using HopitalApp.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopitalApp.Vistas
{
    public partial class FormListarFacturas : Form
    {
        public FormListarFacturas()
        {
            InitializeComponent();
        }

        Utilidades ObUtilidades = new Utilidades();

        private void FormListarFacturas_Load(object sender, EventArgs e)
        {
            ObUtilidades.ListarFormularios(DataGridView);
        }

        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals("Facturar"))
                    {
                        int id = Convert.ToInt32(DataGridView.Rows[DataGridView.CurrentRow.Index].Cells["ColumnId"].Value);
                        //bool exito = OBFormularioClinico.CerrarCita(id);
                        //if (exito)
                        //{
                        //    DataGridView.Rows.RemoveAt(e.RowIndex);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle error: " + ex.Message, "Vista Form");
            }

        }
    }
}
