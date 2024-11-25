using Negocio.EntitiesDTO;
using Presentacion.ComponentesPersonalizados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class ActividadesDisponibles : Form
    {
        public ActividadesDisponibles()
        {
            InitializeComponent();
            cargarActividades();
        }

        private void cargarActividades()
        {
            String nombreMonitor;
            List<ActividadDTO> listaActividades = new Negocio.Managment.ActividadManagment().ObtenerActividades();

            foreach (var actividad in listaActividades)
            {
                ActividadPestaña aP = new ActividadPestaña();

                aP.actividadDto = actividad;
                aP.LBLDondeVaNombreActividad.Text = actividad.Nombre;
                nombreMonitor = new Negocio.Managment.UsuarioManagment().sacarNombreApellidosDeUsuario(actividad.DNI_Monitor);
                aP.LBLDonveVaNombreMonitor.Text = nombreMonitor;

                //formulario.contenedorActividades.Controls.Add(aP);
            }
        }
    }
}
