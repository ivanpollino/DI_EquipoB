using System;
using System.Drawing;
using System.Windows.Forms;
using Presentacion.Formularios;

namespace Presentacion.ComponentesPersonalizados
{
    public partial class BotonSwitch : UserControl
    {
        public bool estado = false; // False -> panel izquierda, True -> panel derecha
        private Timer animacionTimer; // Timer para la animación
        private int pasosTotales; // Número total de pasos
        private int pasoActual; // Paso actual de la animación
        private int posicionInicialX = 0; // Posición inicial (izquierda)
        private int posicionFinalX = 140; // Posición final (derecha)
        private int incremento; // Incremento por paso de animación

        public Actividades formPadre { get; set; }

        public BotonSwitch()
        {
            InitializeComponent();

            // Inicializar el Timer
            animacionTimer = new Timer();
            animacionTimer.Interval = 10; // Intervalo de 10ms entre pasos (500 ms para completar toda la animación)
            animacionTimer.Tick += AnimacionTick;

            // Calcular cuántos pasos necesitará la animación para 0.5 segundos
            pasosTotales = 25; // 50 pasos para completar la animación en 0.5 segundos (10ms * 50 = 500 ms)
            incremento = (posicionFinalX - posicionInicialX) / pasosTotales;

            // Asignar el evento Click al control principal y sus subcontroles
            this.Click += BotonSwitch_Click;

            // Asegurar que todos los subcontroles propaguen el clic al control principal
            PropagarClick(this);
        }

        public void BotonSwitch_Click(object sender, EventArgs e)
        {
            if (!animacionTimer.Enabled)
            {
                // Iniciar animación si no está en ejecución
                pasoActual = 0;
                animacionTimer.Start();
            }

            if (formPadre != null)
            {
                formPadre.cargarActividades(); // Llamada al método del formulario padre
            }
        }

        private void AnimacionTick(object sender, EventArgs e)
        {
            if (!estado)
            {
                // Desplazarse hacia la posición final (derecha)
                panelQueSeMueve.Left += incremento;
                pasoActual++;

                if (pasoActual >= pasosTotales)
                {
                    panelQueSeMueve.Left = posicionFinalX; // Asegurarse de que esté en la posición final
                    estado = true;
                    animacionTimer.Stop(); // Detener la animación cuando termine
                }
            }
            else
            {
                // Desplazarse hacia la posición inicial (izquierda)
                panelQueSeMueve.Left -= incremento;
                pasoActual++;

                if (pasoActual >= pasosTotales)
                {
                    panelQueSeMueve.Left = posicionInicialX; // Asegurarse de que esté en la posición inicial
                    estado = false;
                    animacionTimer.Stop(); // Detener la animación cuando termine
                }
            }
        }

        private void PropagarClick(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // Asignar el mismo evento Click a todos los subcontroles
                control.Click += (s, e) => BotonSwitch_Click(this, e);

                // Aplicar recursivamente para controles anidados
                if (control.HasChildren)
                {
                    PropagarClick(control);
                }
            }
        }
    }
}
