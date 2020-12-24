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
        FormularioClinico ObFormularioClinico = new FormularioClinico();
        private void FormListarFacturas_Load(object sender, EventArgs e)
        {
        }

        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(TxtDocumento.Text))
                {
                    ObUtilidades.ListarFormularios(DataGridView, TxtDocumento.Text);
                }
            }
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
                        bool exito = ObFormularioClinico.CerrarFactura(id);
                        if (exito)
                        {
                            ImprimirFactura frmImprimirFactura = new ImprimirFactura(id);
                            frmImprimirFactura.ShowDialog();
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
