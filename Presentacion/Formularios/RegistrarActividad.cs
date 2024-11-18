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
    /// <summary>
    /// Formulario para registrar una nueva actividad en el sistema.
    /// </summary>
    public partial class RegistrarActividad : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia del formulario RegistrarActividad.
        /// Configura los botones y la funcionalidad para registrar la actividad.
        /// </summary>
        public RegistrarActividad()
        {
            InitializeComponent();
            ConfigurarBotones(btRegistrarAct);
            ConfigurarBotones(btLimpiarForm);
            btRegistrarAct.Enabled = false; // El botón de registrar está deshabilitado inicialmente
            tbxNombreAct.TextChanged += new EventHandler(CamposModificados); // Evento para habilitar el botón si ambos campos están completos
            tbxDescripcionAct.TextChanged += new EventHandler(CamposModificados); // Evento para habilitar el botón si ambos campos están completos
            LlenarComboBoxMonitores(); // Llenar el ComboBox con la lista de monitores
        }

        /// <summary>
        /// Obtiene la lista de monitores desde la base de datos y la asigna al ComboBox `cbMonitores`.
        /// </summary>
        private void LlenarComboBoxMonitores()
        {
            try
            {
                // Obtiene los monitores desde la base de datos usando el método ObtenerUsuariosMonitores
                var monitores = new MonitorManagment().ObtenerUsuariosMonitores();
                cbMonitores.DisplayMember = "NombreCompleto"; // Muestra el nombre completo en el ComboBox
                cbMonitores.ValueMember = "DNI"; // El valor asociado es el DNI del monitor
                cbMonitores.DataSource = monitores;
            }
            catch (Exception ex)
            {
                // Si ocurre un error, se muestra un mensaje con el detalle del error
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
            // Habilita el botón solo si ambos campos (nombre y descripción) están completos
            btRegistrarAct.Enabled = !string.IsNullOrWhiteSpace(tbxNombreAct.Text) && !string.IsNullOrWhiteSpace(tbxDescripcionAct.Text);
        }

        /// <summary>
        /// Registra la actividad en el sistema, muestra un mensaje de éxito y limpia los campos del formulario.
        /// </summary>
        /// <param name="sender">El objeto que ha generado el evento (botón de registrar actividad)</param>
        /// <param name="e">Argumentos del evento</param>
        private void btRegistrarAct_Click(object sender, EventArgs e)
        {
            // Se obtienen los valores de los campos del formulario
            string nombreActividad = tbxNombreAct.Text;
            string descripcionActividad = tbxDescripcionAct.Text;
            string dniMonitor = cbMonitores.SelectedValue?.ToString();

            // Se verifica que todos los campos obligatorios estén completos
            if (string.IsNullOrWhiteSpace(nombreActividad) || string.IsNullOrWhiteSpace(descripcionActividad) || cbMonitores.SelectedItem == null)
            {
                // Si algún campo está vacío, se muestra un mensaje de error
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Se crea una nueva instancia de la actividad con los datos proporcionados
            ActividadDTO nuevaActividad = new ActividadDTO
            {
                Nombre = nombreActividad,
                Descripcion = descripcionActividad,
                DNI_Monitor = dniMonitor
            };

            // Se instancia el manejo de la actividad para registrar la nueva actividad
            ActividadManagment actividadManagment = new ActividadManagment();
            try
            {
                // Se intenta registrar la actividad en el sistema
                actividadManagment.RegistrarActividad(nuevaActividad);
                // Si el registro es exitoso, se muestra un mensaje de éxito
                MessageBox.Show($"La actividad '{nombreActividad}' ha sido registrada con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario(); // Se limpia el formulario después de registrar
            }
            catch (Exception ex)
            {
                // Si ocurre un error durante el registro, se muestra un mensaje con el detalle del error
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
            cbMonitores.SelectedIndex = -1; // Restablece la selección del ComboBox
            btRegistrarAct.Enabled = false; // Deshabilita el botón de registrar actividad
        }

        /// <summary>
        /// Evento que se ejecuta cuando el usuario hace clic en el botón de "Limpiar Formulario".
        /// Limpia todos los campos y desactiva el botón de registrar actividad.
        /// </summary>
        /// <param name="sender">El objeto que ha generado el evento (botón de limpiar formulario)</param>
        /// <param name="e">Argumentos del evento</param>
        private void btLimpiarForm_Click(object sender, EventArgs e)
        {
            LimpiarFormulario(); // Llama a la función para limpiar el formulario
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

            // Configura los bordes redondeados del botón
            GraphicsPath path = new GraphicsPath();
            int radius = 35;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Aplica la región redondeada al botón
            button.Region = new Region(path);
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Este método parece estar vacío o sin implementación
        }
    }
}
