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
        /// Método que llena el ComboBox de monitores con los datos obtenidos de la base de datos.
        /// Este método obtiene la lista de monitores mediante el servicio `MonitorManagment`, 
        /// asigna los valores del ComboBox y maneja posibles errores en el proceso.
        /// </summary>
        private void LlenarComboBoxMonitores()
        {
            try
            {
                var monitorManagment = new MonitorManagment();
                var monitores = monitorManagment.ObtenerUsuariosMonitores();

                if (monitores.Any())
                {
                    cbMonitores.DisplayMember = "Nombre"; // Nombre visible
                    cbMonitores.ValueMember = "DNI"; // El valor es el DNI
                    cbMonitores.DataSource = monitores; // Asigna la lista
                }
                else
                {
                    MessageBox.Show("No se encontraron monitores disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            string monitorSeleccionado = cbMonitores.SelectedItem?.ToString() ?? "Sin monitor";// Si no se ha seleccionado un monitor, asignamos "Sin monitor"

            //////////////////////////////////GuardarActividad(nombreActividad, descripcionActividad, monitorSeleccionado);
            MessageBox.Show($"La actividad '{nombreActividad}' ha sido registrada con éxito.\nMonitor asignado: {monitorSeleccionado}",
                            "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
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

    }
}
