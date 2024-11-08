using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios.Formularios
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void BTNAdminitracion_Click(object sender, EventArgs e)
        {
            panelMonitores.Visible = !panelMonitores.Visible;
            panelActividades.Visible = !panelActividades.Visible;
        }

        private void BTNGestionActividades_Click(object sender, EventArgs e)
        {

        }
    }
}
