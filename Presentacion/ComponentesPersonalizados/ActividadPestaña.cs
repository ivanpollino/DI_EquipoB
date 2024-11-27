using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.EntitiesDTO;

namespace Presentacion.ComponentesPersonalizados
{
    /// <summary>
    /// Representa una pestaña de actividad.
    /// Permite la eliminación de una actividad con confirmación del usuario.
    /// </summary>
    public partial class ActividadPestaña : UserControl
    {
        public ActividadDTO actividadDto;
        public ActividadPestaña()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Se ejecuta cuando el usuario hace clic en el botón de eliminar de la pestaña.
        /// Solicita confirmación al usuario para borrar la actividad y la elimina.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Solicitar confirmación al usuario
            var confirmResult = MessageBox.Show(
                "¿Estás seguro de que quieres borrar esta actividad?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario confirma la eliminación
            if (confirmResult == DialogResult.Yes)
            {
                // Llamar al método que elimina la actividad
    
                if (eliminarActividad() == "Actividad borrada con exito")
                {
                    // Mostrar mensaje de confirmación
                    MessageBox.Show("La actividad ha sido eliminada exitosamente.",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    // Eliminar el control personalizado del contenedor
                    this.Parent.Controls.Remove(this);
                }
            }
        }
        /// <summary>
        /// Elimina la actividad asociada.
        /// Llama a la capa de negocio para borrar la actividad.
        /// </summary>
        /// <returns>Un mensaje que indica el resultado de la eliminación.</returns>
        public String eliminarActividad()
        {
            return new Negocio.Managment.ActividadManagment().bajaActividad(actividadDto);
        }
    }
}
