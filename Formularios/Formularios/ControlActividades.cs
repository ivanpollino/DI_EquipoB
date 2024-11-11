using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.EntitiesDTO;
using Negocio.Managment;

namespace Formularios.Formularios
{
    public partial class ControlActividades : UserControl
    {
        public ControlActividades()
        {
            InitializeComponent();
        }

        private void imagenBorrarActividad_Click(object sender, EventArgs e)
        {
            String mensaje;
            ActividadDTO actividad = new ActividadDTO();

            actividad.Nombre = LBLDondeVaElNombreActividad.Text;

            mensaje = new ActividadManagment().bajaActividad(actividad);

        }
    }
}
