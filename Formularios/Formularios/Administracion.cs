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

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        bool menuExpandMonitores = false;
        bool menuExpandActividades = false;

        private void menuTransicion_Tick(object sender, EventArgs e)
        {
            if(menuExpandMonitores == false)
            {
                flowLayoutGestioMonitores.Height += 10;
                if(flowLayoutGestioMonitores.Height >= 111)
                {
                    menuTransicion.Stop();
                    menuExpandMonitores = true;
                }
            }
            else
            {
                flowLayoutGestioMonitores.Height -= 10;
                if (flowLayoutGestioMonitores.Height <= 56)
                {
                    menuTransicion.Stop();
                    menuExpandMonitores = false;
                }
            }

        }

        private void BTNGestionarMonitores_Click(object sender, EventArgs e)
        {
            menuTransicion.Start();
        }

        private void BTNGestionActividades_Click(object sender, EventArgs e)
        {
            menuTransacionActividades.Start();
        }

        private void menuTransacionActividades_Tick(object sender, EventArgs e)
        {
            if (menuExpandActividades == false)
            {
                flowLayoutGestioMonitores.Height += 10;
                if (flowLayoutGestioMonitores.Height >= 169)
                {
                    menuTransicion.Stop();
                    menuExpandActividades = true;
                }
            }
            else
            {
                flowLayoutGestioMonitores.Height -= 10;
                if (flowLayoutGestioMonitores.Height <= 56)
                {
                    menuTransicion.Stop();
                    menuExpandActividades = false;
                }
            }
        }
    }
}
