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
    public partial class EstrellasValoracion : UserControl
    {
        private int p;

        public EstrellasValoracion()
        {
            InitializeComponent();
            EstablecerEstrellasVacias();
        }
        private void CambiarEstrellas(int puntuacionSeleccionada)
        {
            estrellaLlena1.Visible = puntuacionSeleccionada >= 1;
            estrellaLlena2.Visible = puntuacionSeleccionada >= 2;
            estrellaLlena3.Visible = puntuacionSeleccionada >= 3;
            estrellaLlena4.Visible = puntuacionSeleccionada >= 4;
            estrellaLlena5.Visible = puntuacionSeleccionada >= 5;

            estrellaEmpty1.Visible = puntuacionSeleccionada < 1;
            estrellaEmpty2.Visible = puntuacionSeleccionada < 2;
            estrellaEmpty3.Visible = puntuacionSeleccionada < 3;
            estrellaEmpty4.Visible = puntuacionSeleccionada < 4;
            estrellaEmpty5.Visible = puntuacionSeleccionada < 5;
        }
        private void EstablecerEstrellasVacias()
        {
            estrellaEmpty1.Visible = true;
            estrellaEmpty2.Visible = true;
            estrellaEmpty3.Visible = true;
            estrellaEmpty4.Visible = true;
            estrellaEmpty5.Visible = true;

            estrellaLlena1.Visible = false;
            estrellaLlena2.Visible = false;
            estrellaLlena3.Visible = false;
            estrellaLlena4.Visible = false;
            estrellaLlena5.Visible = false;
        }
    
    private void estrellaEmpty1_Click(object sender, EventArgs e)
        {
            p = 1;
            CambiarEstrellas(p);
            MostrarMensajeCorrecto();
            //ActualizarValoracion(p);
        }

        private void estrellaEmpty2_Click(object sender, EventArgs e)
        {
            p = 2;
            CambiarEstrellas(p);
            MostrarMensajeCorrecto();
            //ActualizarValoracion(p);
        }

        private void estrellaEmpty3_Click(object sender, EventArgs e)
        {
            p = 3;
            CambiarEstrellas(p);
            MostrarMensajeCorrecto();
            //ActualizarValoracion(p);
        }

        private void estrellaEmpty4_Click(object sender, EventArgs e)
        {
            p = 4;
            CambiarEstrellas(p);
            MostrarMensajeCorrecto();
            //ActualizarValoracion(p);
        }

        private void estrellaEmpty5_Click(object sender, EventArgs e)
        {
            p = 5;
            CambiarEstrellas(p);
            MostrarMensajeCorrecto();
            //ActualizarValoracion(p);
        }

        private void estrellaLlena1_Click(object sender, EventArgs e)
        {
            p = 1;
            CambiarEstrellas(p);
            MostrarMensajeCorrecto();
            //ActualizarValoracion(p);
        }

        private void estrellaLlena2_Click(object sender, EventArgs e)
        {
            p = 2;
            CambiarEstrellas(p);
            MostrarMensajeCorrecto();
            //ActualizarValoracion(p);
        }

        private void estrellaLlena3_Click(object sender, EventArgs e)
        {
            p = 3;
            CambiarEstrellas(p);
            MostrarMensajeCorrecto();
            //ActualizarValoracion(p);
        }

        private void estrellaLlena4_Click(object sender, EventArgs e)
        {
            p = 4;
            CambiarEstrellas(p);
            MostrarMensajeCorrecto();
            //ActualizarValoracion(p);
        }

        private void estrellaLlena5_Click(object sender, EventArgs e)
        {
            p = 5;
            CambiarEstrellas(p);
            MostrarMensajeCorrecto();
            //ActualizarValoracion(p);
        }

        private void estrellaEmpty1_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(1);
        }

        private void estrellaEmpty2_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(2);
        }

        private void estrellaEmpty3_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(3);
        }

        private void estrellaEmpty4_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(4);
        }

        private void estrellaEmpty5_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(5);
        }

        private void estrellaLlena1_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(1);
        }

        private void estrellaLlena2_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(2);
        }

        private void estrellaLlena3_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(3);
        }

        private void estrellaLlena4_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(4);
        }

        private void estrellaLlena5_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(5);
        }
        private void MostrarMensajeCorrecto()
        {
            MessageBox.Show($"Se ha valorado correctamente la actividad con una puntuación de {p} estrellas.");
        }
        private void MostrarMensajeIncorrecto()
        {
            MessageBox.Show($"No se ha valorado correctamente la actividad. Vuelva a intentarlo");
        }

        private void panelEstrellas_MouseLeave(object sender, EventArgs e)
        {
            if (p == 0)
            {
                EstablecerEstrellasVacias();
            }
            else {
                CambiarEstrellas(p);
            }
        }
    }
}
