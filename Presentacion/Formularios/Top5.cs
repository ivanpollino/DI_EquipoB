using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class Top5 : Form
    {
        public Top5()
        {
            InitializeComponent();
            ConfigurarBoton(btDescargarGraPDF);
        }

        private void btDescargarGraPDF_Click(object sender, EventArgs e)
        {
            //Codigo para descarg el informe del top 5 por mes
        }
        private void ConfigurarBoton(Button button)
        {
            button.Font = btDescargarGraPDF.Font;
            button.BackColor = Color.DarkCyan;
            button.ForeColor = Color.Black;
            button.FlatStyle = FlatStyle.Flat;
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderSize = 0;

            // Crear un GraphicsPath para bordes redondeados
            GraphicsPath path = new GraphicsPath();
            int radius = 35;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            button.Region = new Region(path);
        }
    }
}
