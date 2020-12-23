using HopitalApp.Controlador;
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
    public partial class FrmFormularioClinico : Form
    {
        public FrmFormularioClinico()
        {
            InitializeComponent();
        }

        private Utilidades ObUtilidades = new Utilidades();
        private FormularioClinico ObFormularioClinico = new FormularioClinico();
        private DataTable dtTipoServicio = new DataTable();
        private int IdDocumento = 0;
        private int IdPaciente = 0;
        private int IdCliente = 0;

        private void FrmFormularioClinico_Load(object sender, EventArgs e)
        {
            CargarFormulario();
        }

        private void CargarFormulario()
        {
            dtTipoServicio = ObUtilidades.ListarTipodeServicio(CboServicio);
            ObUtilidades.ListarDoctor(CboDoctor);
        }

        private void CboServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboServicio.SelectedIndex >= 0)
            {
                int index = CboServicio.SelectedIndex;
                LbCosto.Text = dtTipoServicio.Rows[index][2].ToString();
            }
        }

        private void CboServicio_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboServicio.SelectedIndex >= 0)
            {
                int index = CboServicio.SelectedIndex;
                LbCosto.Text = dtTipoServicio.Rows[index][2].ToString();
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                FrmBuscarPaciente frmBuscarPaciente = new FrmBuscarPaciente(0);
                frmBuscarPaciente.Pass += new FrmBuscarPaciente.PassData(Buscar);
                frmBuscarPaciente.ShowDialog();
            }
        }

        private void Buscar(int idUsuario, string nombre)
        {
            IdPaciente = idUsuario;
            TxtPaciente.Text = nombre;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FrmBuscarPaciente frmBuscarPaciente = new FrmBuscarPaciente(1);
                frmBuscarPaciente.Pass += new FrmBuscarPaciente.PassData(BuscarCliente);
                frmBuscarPaciente.ShowDialog();
            }
        }

        private void BuscarCliente(int idUsuario, string nombre)
        {
            IdCliente = idUsuario;
            TxtCliente.Text = nombre;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (CboServicio.SelectedIndex >= 0 && CboDoctor.SelectedValue != null)
            {
                if (IdDocumento == 0)
                {
                    IdDocumento = ObFormularioClinico.Formulario(IdPaciente, IdCliente, 1);
                    TxtId.Text = Convert.ToString(IdDocumento);
                    TxtCliente.Enabled = false;
                    TxtPaciente.Enabled = false;
                }

                if (IdDocumento > 0)
                {
                    int index = CboServicio.SelectedIndex;
                    string Servicio = dtTipoServicio.Rows[index][1].ToString();
                    int idTipoServicio = Convert.ToInt32(dtTipoServicio.Rows[index][0].ToString());
                    decimal costo = Convert.ToDecimal(dtTipoServicio.Rows[index][2].ToString());
                    int idDoctor = Convert.ToInt32(CboDoctor.SelectedValue);
                    DateTime fecha = Convert.ToDateTime(DateTimePicker.Text);
                    int idDetalle = ObFormularioClinico.DetalleFormulario(IdDocumento, IdPaciente,idTipoServicio, idDoctor,costo, fecha);
                    DataGridView.Rows.Add(new object[] { idDetalle, Servicio, CboDoctor.Text, fecha, costo });
                }
            }
        }
    }
}
