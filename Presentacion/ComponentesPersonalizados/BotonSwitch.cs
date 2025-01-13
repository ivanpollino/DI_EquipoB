using System;
using System.Drawing;
using System.Windows.Forms;
using Presentacion.Formularios;

namespace Presentacion.ComponentesPersonalizados
{
    /// <summary>
    /// Representa un control personalizado que simula un botón de switch con animación.
    /// El botón permite cambiar de estado entre "izquierda" y "derecha" con una animación suave.
    /// </summary>
    public partial class BotonSwitch : UserControl
    {
        public bool estado = false;
        private Timer animacionTimer;
        private int pasosTotales; 
        private int pasoActual;
        private int posicionInicialX = 0; 
        private int posicionFinalX = 140; 
        private int incremento;

        public Actividades formPadre { get; set; }

        public BotonSwitch()
        {
            InitializeComponent();

            // Inicializar el Timer
            animacionTimer = new Timer();
            animacionTimer.Interval = 10;
            animacionTimer.Tick += AnimacionTick;

            pasosTotales = 25; 
            incremento = (posicionFinalX - posicionInicialX) / pasosTotales;

            this.Click += BotonSwitch_Click;

            PropagarClick(this);
        }

        /// <summary>
        /// Evento que se dispara cuando se hace clic en el botón de switch.
        /// Inicia la animación para cambiar el estado del botón y realiza la acción correspondiente
        /// en el formulario padre.
        /// </summary>
        /// <param name="sender">El objeto que dispara el evento.</param>
        /// <param name="e">Los argumentos del evento <c>EventArgs</c>.</param>
        public void BotonSwitch_Click(object sender, EventArgs e)
        {
            if (!animacionTimer.Enabled)
            {
                pasoActual = 0;
                animacionTimer.Start();
            }

            if (formPadre != null)
            {
                formPadre.cargarActividades();
            }
        }

        private void AnimacionTick(object sender, EventArgs e)
        {
            if (!estado)
            {
                panelQueSeMueve.Left += incremento;
                pasoActual++;

                if (pasoActual >= pasosTotales)
                {
                    panelQueSeMueve.Left = posicionFinalX;
                    estado = true;
                    animacionTimer.Stop();
                }
            }
            else
            {
                panelQueSeMueve.Left -= incremento;
                pasoActual++;

                if (pasoActual >= pasosTotales)
                {
                    panelQueSeMueve.Left = posicionInicialX;
                    estado = false;
                    animacionTimer.Stop();
                }
            }
        }

        /// <summary>
        /// Propaga el evento <c>Click</c> a todos los subcontroles dentro de un control dado.
        /// Asegura que cualquier clic en los subcontroles también active el evento del botón.
        /// </summary>
        /// <param name="parent">El control principal que contiene los subcontroles.</param>
        private void PropagarClick(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += (s, e) => BotonSwitch_Click(this, e);

                if (control.HasChildren)
                {
                    PropagarClick(control);
                }
            }
        }
    }
}
