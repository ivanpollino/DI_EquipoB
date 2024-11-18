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
    public partial class ListadoActividades : Form
    {
        public ListadoActividades()
        {
            InitializeComponent();

        }

        private void borrarActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Confirmar la acción con el usuario
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas borrar todas las actividades? Esto no se puede deshacer.",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Iterar sobre todos los controles personalizados dentro del FlowLayoutPanel
                foreach (Control control in contenedorActividades.Controls)
                {
                    // Comprobar si el control implementa el método 'bajaActividad'
                    if (control is ActividadPestaña) // Cambia 'MiControlPersonalizado' por el tipo real de tus controles
                    {
                        ActividadPestaña actividadControl = (ActividadPestaña)control;

                        // Invocar el método interno 'bajaActividad' del control
                        actividadControl.eliminarActividad();
                    }
                }
                contenedorActividades.Controls.Clear();
            }
        }

        private void abrirFormRegActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obtener el formulario principal (el contenedor superior)
            Form formularioPrincipal = this.ParentForm;

            // Verificar que el formulario principal no sea nulo
            if (formularioPrincipal != null)
            {
                // Buscar el panel en el formulario principal donde se embeben los formularios
                Panel panelPrincipal = formularioPrincipal.Controls["panelFormularios"] as Panel;

                if (panelPrincipal != null)
                {
                    // Limpiar el contenido previo del panel
                    panelPrincipal.Controls.Clear();

                    // Crear una instancia del formulario de registro de actividades
                    RegistrarActividad formRegistroActividad = new RegistrarActividad();
                    formRegistroActividad.TopLevel = false; // Indicar que no es un formulario independiente
                    formRegistroActividad.Dock = DockStyle.Fill; // Ajustar el tamaño al panel

                    // Agregar el formulario al panel
                    panelPrincipal.Controls.Add(formRegistroActividad);

                    // Mostrar el formulario
                    formRegistroActividad.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró el panel principal para cargar el formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se pudo determinar el formulario principal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
