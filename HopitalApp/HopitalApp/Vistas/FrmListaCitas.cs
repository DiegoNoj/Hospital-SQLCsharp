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
    public partial class FrmListaCitas : Form
    {
        public FrmListaCitas()
        {
            InitializeComponent();
        }
        Utilidades ObUtilidades = new Utilidades();
        FormularioClinico OBFormularioClinico = new FormularioClinico();
        private void FrmListaCitas_Load(object sender, EventArgs e)
        {
            ObUtilidades.ListarCitas(DataGridView);
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals("Cerrar"))
                    {
                        int id  = Convert.ToInt32(DataGridView.Rows[DataGridView.CurrentRow.Index].Cells["ColumnIDCita"].Value);
                        bool exito = OBFormularioClinico.CerrarCita(id);
                        if (exito)
                        {
                            DataGridView.Rows.RemoveAt(e.RowIndex);
                        }
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
