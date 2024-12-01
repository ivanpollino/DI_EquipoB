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
    public partial class ActividadesApuntado : Form
    {

        public bool sePuedeApuntar;

        public ActividadesApuntado()
        {
            InitializeComponent();
        }

        public void ObtenerFormularioPadre()
        {
            Control contenedor = this.Parent;
            while (contenedor != null && !(contenedor is Form))
            {
                contenedor = contenedor.Parent;
            }

            if (contenedor is Form formPadre)
            {
                cargarActividades(formPadre);
            }
            else
            {
                MessageBox.Show("No se encontró un formulario padre válido.");
            }
        }

        public void cargarActividades(Form formPadre)
        {
            if (formPadre is Actividades formularioActividades)
            {
                MostrarBarraDeCarga(() => formularioActividades.cargarActividadesDisponibles(this));
            }
            else
            {
                MessageBox.Show("El formulario padre no es del tipo esperado.");
            }
        }

        private void MostrarBarraDeCarga(Action callback)
        {
            // Crear un nuevo formulario para la barra de carga
            Form barraDeCargaForm = new Form
            {
                Size = new Size(300, 100),
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.White
            };

            ProgressBar progressBar = new ProgressBar
            {
                Style = ProgressBarStyle.Continuous,
                Dock = DockStyle.Fill,
                Maximum = 100
            };

            barraDeCargaForm.Controls.Add(progressBar);

            Timer timer = new Timer
            {
                Interval = 50 // Cada 50ms incrementa el progreso
            };

            int progreso = 0;
            timer.Tick += (s, e) =>
            {
                progreso += 1; // Incrementa el progreso
                progressBar.Value = progreso;

                if (progreso >= progressBar.Maximum) // Cuando llega al máximo
                {
                    timer.Stop();
                    barraDeCargaForm.Close(); // Cierra la barra de carga
                    callback.Invoke(); // Ejecuta el método después de la carga
                }
            };

            barraDeCargaForm.Load += (s, e) => timer.Start(); // Inicia el temporizador al cargar el formulario
            barraDeCargaForm.ShowDialog(); // Muestra la barra de carga
        }

    }
}
