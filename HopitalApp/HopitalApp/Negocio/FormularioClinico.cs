using HopitalApp.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopitalApp.Negocio
{
    public class FormularioClinico
    {
        ClassFormularioClinico ObClassFormularioClinico = new ClassFormularioClinico();
        public int Formulario(int idPaciente, int idCliente, int idUsuario)
        {
            int id = 0;
            try
            {
                id = ObClassFormularioClinico.GuardarFormulario(idPaciente, idCliente, idUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return id;
        }

        public int DetalleFormulario(int idFormulario, int idPaciente, int idTipoServio, int idDoctor, decimal costo, DateTime fecha)
        {
            int id = 0;
            try
            {
                id = ObClassFormularioClinico.GuardarDetalleFormulario(idFormulario,idPaciente, idTipoServio, idDoctor, costo, fecha);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return id;
        }

        public bool CerrarCita(int idCita)
        {
            return ObClassFormularioClinico.CerrarCita(idCita);
        }

        public bool CerrarFactura(int idFormulario)
        {
            return ObClassFormularioClinico.CerrarFactura(idFormulario);
        }
    }
}
