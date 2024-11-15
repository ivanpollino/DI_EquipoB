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

namespace Presentacion.ComponentesPersonalizados
{
    public partial class ActividadPestaña : UserControl
    {
        public ActividadPestaña()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ActividadDTO actividadDTO = new ActividadDTO();
            actividadDTO.Nombre = LBLDondeVaNombreActividad.Text;
            new Negocio.Managment.ActividadManagment().bajaActividad(actividadDTO);
        }
    }
}
