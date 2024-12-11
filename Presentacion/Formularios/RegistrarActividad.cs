using Negocio.EntitiesDTO;
using Negocio.Managment;
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

namespace Presentacion
{
    public partial class RegistrarActividad : Form
    {
        public RegistrarActividad()
        {
            InitializeComponent();
            ConfigurarBotones(btRegistrarAct);
            ConfigurarBotones(btLimpiarForm);
            btRegistrarAct.Enabled = false;
            tbxNombreAct.TextChanged += new EventHandler(CamposModificados); //Obligatorio
            tbxDescripcionAct.TextChanged += new EventHandler(CamposModificados); //Obligatorio
            LlenarComboBoxMonitores();
        }
        /// <summary>
        /// Obtiene la lista de monitores desde la base de datos y la asigna al ComboBox `cbMonitores`.
        /// Este método obtiene los monitores utilizando el método <see cref="ObtenerMonitoresDesdeDB"/> y los carga en el ComboBox.
        /// </summary>
        private void LlenarComboBoxMonitores()
        {
            try
            {
                var monitores = new MonitorManagment().ObtenerUsuariosMonitores();
                cbMonitores.DisplayMember = "NombreCompleto";
                cbMonitores.ValueMember = "DNI";  // Usar el DNI como valor
                cbMonitores.DataSource = monitores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los monitores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Habilita el botón de "Registrar Actividad" solo cuando ambos campos (nombre y descripción) están completos.
        /// </summary>
        /// <param name="sender">El objeto que ha generado el evento (campo de texto)</param>
        /// <param name="e">Argumentos del evento</param>
        private void CamposModificados(object sender, EventArgs e)
        {
            btRegistrarAct.Enabled = !string.IsNullOrWhiteSpace(tbxNombreAct.Text) && !string.IsNullOrWhiteSpace(tbxDescripcionAct.Text);
        }

        /// <summary>
        /// Registra la actividad en el sistema, muestra un mensaje de éxito y limpia los campos del formulario.
        /// </summary>
        /// <param name="sender">El objeto que ha generado el evento (botón de registrar actividad)</param>
        /// <param name="e">Argumentos del evento</param>
        private void btRegistrarAct_Click(object sender, EventArgs e)
        {
            string nombreActividad = tbxNombreAct.Text;
            string descripcionActividad = tbxDescripcionAct.Text;
            string dniMonitor = cbMonitores.SelectedValue?.ToString();

            if (string.IsNullOrWhiteSpace(nombreActividad) || string.IsNullOrWhiteSpace(descripcionActividad) || cbMonitores.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ActividadDTO nuevaActividad = new ActividadDTO
            {
                Nombre = nombreActividad,
                Descripcion = descripcionActividad,
                DNI_Monitor = dniMonitor,
                MediaValoracion = 1
                
            };

            ActividadManagment actividadManagment = new ActividadManagment();
            try
            {
                String mensaje = actividadManagment.RegistrarActividad(nuevaActividad);
                if(mensaje== "Error: El ID de la actividad ya está registrado.")
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(mensaje, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la actividad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Limpia todos los campos del formulario (nombre, descripción y monitor).
        /// También deshabilita el botón de "Registrar Actividad" hasta que se completen los campos obligatorios.
        /// </summary>
        private void LimpiarFormulario()
        {
            tbxNombreAct.Clear();
            tbxDescripcionAct.Clear();
            cbMonitores.SelectedIndex = -1;
            btRegistrarAct.Enabled = false;
        }

        /// <summary>
        /// Evento que se ejecuta cuando el usuario hace clic en el botón de "Limpiar Formulario".
        /// Limpia todos los campos y desactiva el botón de registrar actividad.
        /// </summary>
        /// <param name="sender">El objeto que ha generado el evento (botón de limpiar formulario)</param>
        /// <param name="e">Argumentos del evento</param>
        private void btLimpiarForm_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        /// <summary>
        /// Configura los botones de la interfaz con bordes redondeados y estilo personalizado.
        /// </summary>
        /// <param name="button">Botón a personalizar</param>
        private void ConfigurarBotones(Button button)
        {
            button.Font = btRegistrarAct.Font;
            button.BackColor = Color.DarkCyan;
            button.ForeColor = Color.Black;
            button.FlatStyle = FlatStyle.Flat;
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderSize = 0;
            GraphicsPath path = new GraphicsPath();
            int radius = 35;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
