using HopitalApp.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopitalApp.Negocio
{
    public class ImprimirFacturas
    {
        public List<DetalleFacturaEntity> DetalleFactura { get; set; }

        public void ReporteDetalleFactura(int idFactura)
        {
            ClassFormularioClinico dataPrint = new ClassFormularioClinico();
            DataTable dtDetalle = dataPrint.ListarDetalleFactura(idFactura);
            DetalleFactura = new List<DetalleFacturaEntity>();

            foreach (DataRow Rows in dtDetalle.Rows)
            {
                DetalleFacturaEntity rows = new DetalleFacturaEntity()
                {
                    Servicio = Rows[0].ToString(),
                    Doctor = Rows[2].ToString(),
                    Fecha = Rows[1].ToString(),
                    Costo = Rows[3].ToString(),
                };

                DetalleFactura.Add(rows);
            }
        }

        public FacturaEntity ReporteFactura(int idFactura)
        {
            ClassFormularioClinico dataPrint = new ClassFormularioClinico();
            DataTable dtIndex = dataPrint.ListarFactura(idFactura);
            FacturaEntity Factura = new FacturaEntity();

            foreach (DataRow Rows in dtIndex.Rows)
            {
                Factura = new FacturaEntity()
                {
                    Serie = Rows[0].ToString(),
                    Numero = Rows[1].ToString(),
                    Fecha = Rows[2].ToString(),
                    Costo = Rows[3].ToString(),
                    Nit = Rows[4].ToString(),
                    Nombre = Rows[5].ToString(),
                };
            }
            return Factura;
        }

    }
}
