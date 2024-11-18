using Negocio.EntitiesDTO;
using Presentacion.ComponentesPersonalizados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    /// <summary>
    /// Formulario principal para la administración de monitores, actividades y otras opciones de gestión.
    /// </summary>
    public partial class Administracion : Form
    {
        // Variables para controlar la expansión de los menús.
        bool menuExpandMonitores = false;
        bool menuExpandActividades = false;
        bool menuExpanAdministracion = false;

        /// <summary>
        /// Controlador de la animación para la expansión y contracción del menú de Monitores.
        /// </summary>
        private void menuTransicion_Tick(object sender, EventArgs e)
        {
            // Lógica para expandir o contraer el menú de Monitores.
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de Gestión de Monitores.
        /// </summary>
        private void BTNGestionarMonitores_Click(object sender, EventArgs e)
        {
            menuTransicion.Start(); // Inicia la animación de expansión del menú de monitores.
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de Gestión de Actividades.
        /// </summary>
        private void BTNGestionActividades_Click(object sender, EventArgs e)
        {
            menuTransacionActividades.Start(); // Inicia la animación de expansión del menú de actividades.
        }

        /// <summary>
        /// Controlador de la animación para la expansión y contracción del menú de Actividades.
        /// </summary>
        private void menuTransacionActividades_Tick(object sender, EventArgs e)
        {
            // Lógica para expandir o contraer el menú de Actividades.
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de Administración.
        /// </summary>
        private void BTNAdminitracion_Click(object sender, EventArgs e)
        {
            menuTransicionAdministracion.Start(); // Inicia la animación de expansión del menú de administración.
        }

        /// <summary>
        /// Controlador de la animación para la expansión y contracción del menú de Administración.
        /// </summary>
        private void menuTransicionAdministracion_Tick(object sender, EventArgs e)
        {
            // Lógica para expandir o contraer el menú de Administración.
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de Listado de Actividades.
        /// </summary>
        private void BTNListadoActividades_Click(object sender, EventArgs e)
        {
            ListadoActividades formulario = new ListadoActividades();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(formulario); // Añade el formulario al panel de formularios.
            panelFormularios.Tag = formulario;
            cargarActividades(formulario); // Carga las actividades en el formulario.
            formulario.BringToFront(); // Trae el formulario al frente.
            formulario.Show(); // Muestra el formulario.
        }

        /// <summary>
        /// Carga la lista de actividades en el formulario de Listado de Actividades.
        /// </summary>
        private void cargarActividades(ListadoActividades formulario)
        {
            // Carga las actividades y las asigna a controles dentro del formulario.
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón para registrar un monitor.
        /// </summary>
        private void BTNRegistrarMonitor_Click(object sender, EventArgs e)
        {
            RegistroMonitor registroMonitor = new RegistroMonitor();

            registroMonitor.TopLevel = false;
            registroMonitor.FormBorderStyle = FormBorderStyle.None;
            registroMonitor.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(registroMonitor);
            panelFormularios.Tag = registroMonitor;
            registroMonitor.BringToFront();
            registroMonitor.Show();
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón para registrar una actividad.
        /// </summary>
        private void BTNRegistrarActividad_Click(object sender, EventArgs e)
        {
            RegistrarActividad registrarActividad = new RegistrarActividad();

            registrarActividad.TopLevel = false;
            registrarActividad.FormBorderStyle = FormBorderStyle.None;
            registrarActividad.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(registrarActividad);
            panelFormularios.Tag = registrarActividad;
            registrarActividad.BringToFront();
            registrarActividad.Show();
        }

    }
}
