using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ComponentesPersonalizados
{
    public partial class ActividadUsuario : UserControl
    {
        public ActividadDTO actividadDto;
        public ActividadUsuario()
        {
            InitializeComponent();
        }

        private void panelContenedorInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gilipollas");
        }

    }
}
