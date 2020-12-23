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
    public partial class FrmBuscarPaciente : Form
    {
        public delegate void PassData(int id, string nombre);
        public event PassData Pass;
        public FrmBuscarPaciente(short modulo)
        {
            InitializeComponent();
            Modulo = modulo;
        }
        Utilidades ObUtilidades = new Utilidades();
        private short Modulo { get; set; }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(TxtDocumento.Text))
                {
                    ObUtilidades.ListarPacientes(DataGridView, TxtDocumento.Text, Modulo);
                }
            }
        }

        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (DataGridView.Rows.Count > 0)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        int id = Convert.ToInt32(DataGridView.Rows[DataGridView.CurrentRow.Index].Cells[0].Value);
                        string nombre = Convert.ToString(DataGridView.Rows[DataGridView.CurrentRow.Index].Cells[1].Value);
                        Pass(id, nombre);
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalle error: " + ex, "Vista Form");
            }

        }
    }
}
