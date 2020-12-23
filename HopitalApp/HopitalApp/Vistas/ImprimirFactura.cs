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
    public partial class ImprimirFactura : Form
    {
        public ImprimirFactura(int idFactura)
        {
            InitializeComponent();
            IdFactura = idFactura;
        }
        private ImprimirFacturas OBImprimirFacturas = new ImprimirFacturas();
        int IdFactura = 0;
        private void ImprimirFactura_Load(object sender, EventArgs e)
        {
            OBImprimirFacturas.ReporteDetalleFactura(IdFactura);
            FacturaEntityBindingSource.DataSource = OBImprimirFacturas.ReporteFactura(IdFactura);
            ImprimirFacturaBindingSource.DataSource = OBImprimirFacturas.DetalleFactura;
            this.ReportViewer.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
