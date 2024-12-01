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
    /// <summary>
    /// Representa el formulario que muestra las actividades a las que el usuario está apuntado.
    /// Esta clase gestiona la visualización y carga de actividades en función del estado del usuario.
    /// </summary>
    public partial class ActividadesApuntado : Form
    {

        public bool sePuedeApuntar;

        public ActividadesApuntado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Obtiene el formulario padre que contiene el formulario actual.
        /// Busca en la jerarquía de contenedores hasta encontrar un formulario principal.
        /// </summary>
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

        /// <summary>
        /// Carga las actividades desde el formulario padre y las muestra en el formulario actual.
        /// Verifica que el formulario padre sea de tipo <c>Actividades</c>.
        /// </summary>
        /// <param name="formPadre">Formulario padre que se pasa para cargar las actividades.</param>
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

        /// <summary>
        /// Muestra una barra de carga mientras se cargan las actividades.
        /// La barra de carga se muestra en un formulario independiente y se actualiza hasta completarse.
        /// </summary>
        /// <param name="callback">La acción que se ejecutará una vez se complete el proceso de carga.</param>
        private void MostrarBarraDeCarga(Action callback)
        {
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
                Interval = 10
            };

            int progreso = 0;
            timer.Tick += (s, e) =>
            {
                progreso += 1;
                progressBar.Value = progreso;

                if (progreso >= progressBar.Maximum)
                {
                    timer.Stop();
                    barraDeCargaForm.Close();
                    callback.Invoke();
                }
            };

            barraDeCargaForm.Load += (s, e) => timer.Start();
            barraDeCargaForm.ShowDialog(); 
        }

    }
}
