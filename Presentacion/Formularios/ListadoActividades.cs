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

namespace Presentacion
{
    /// <summary>
    /// Formulario que muestra el listado de actividades y proporciona opciones para gestionar actividades.
    /// </summary>
    public partial class ListadoActividades : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia del formulario ListadoActividades.
        /// </summary>
        public ListadoActividades()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        /// <summary>
        /// Evento para borrar todas las actividades del listado tras una confirmación del usuario.
        /// </summary>
        private void borrarActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se muestra un mensaje de confirmación al usuario para borrar todas las actividades
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas borrar todas las actividades? Esto no se puede deshacer.",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) // Si el usuario confirma la acción
            {
                // Iterar sobre todos los controles dentro del FlowLayoutPanel 'contenedorActividades'
                foreach (Control control in contenedorActividades.Controls)
                {
                    // Verificar si el control es de tipo 'ActividadPestaña'
                    if (control is ActividadPestaña)
                    {
                        ActividadPestaña actividadControl = (ActividadPestaña)control;

                        // Llamar al método 'eliminarActividad' para eliminar la actividad
                        actividadControl.eliminarActividad();
                    }
                }
                // Limpiar todos los controles del panel
                contenedorActividades.Controls.Clear();
            }
        }

        /// <summary>
        /// Evento para abrir el formulario de registro de actividad cuando se selecciona la opción del menú.
        /// </summary>
        private void abrirFormRegActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obtener el formulario principal (el formulario que contiene este formulario como hijo)
            Form formularioPrincipal = this.ParentForm;

            // Verificar que el formulario principal no sea nulo
            if (formularioPrincipal != null)
            {
                // Buscar el panel donde se embeben otros formularios en el formulario principal
                Panel panelPrincipal = formularioPrincipal.Controls["panelFormularios"] as Panel;

                if (panelPrincipal != null) // Si el panel principal es válido
                {
                    // Limpiar el contenido previo del panel
                    panelPrincipal.Controls.Clear();

                    // Crear una nueva instancia del formulario de registro de actividad
                    RegistrarActividad formRegistroActividad = new RegistrarActividad();
                    formRegistroActividad.TopLevel = false; // Establecer que no es un formulario independiente
                    formRegistroActividad.Dock = DockStyle.Fill; // Ajustar el tamaño al panel

                    // Añadir el formulario de registro de actividad al panel
                    panelPrincipal.Controls.Add(formRegistroActividad);

                    // Mostrar el formulario de registro de actividad
                    formRegistroActividad.Show();
                }
                else
                {
                    // Mostrar un mensaje de error si no se encuentra el panel principal
                    MessageBox.Show("No se encontró el panel principal para cargar el formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar un mensaje de error si no se pudo determinar el formulario principal
                MessageBox.Show("No se pudo determinar el formulario principal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
