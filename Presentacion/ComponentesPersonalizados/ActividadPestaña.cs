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
    /// Componente personalizado que representa una actividad en la interfaz gráfica.
    /// Permite eliminar la actividad con confirmación.
    /// </summary>
    public partial class ActividadPestaña : UserControl
    {
        
        public ActividadDTO actividadDto;

       
        public ActividadPestaña()
        {
            InitializeComponent(); 
        }

        /// <summary>
        /// Evento que se dispara cuando se hace clic en el PictureBox (representando la actividad).
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            var confirmResult = MessageBox.Show(
                "¿Estás seguro de que quieres borrar esta actividad?", 
                "Confirmación", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question); 

            
            if (confirmResult == DialogResult.Yes)
            {
               
                if (eliminarActividad() == "Actividad borrada con exito")
                {
                    
                    MessageBox.Show("La actividad ha sido eliminada exitosamente.",
                                    "Éxito", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information); 
                    
                    this.Parent.Controls.Remove(this);
                }
            }
        }

        /// <summary>
        /// Método que llama a la lógica de negocio para eliminar la actividad.
        /// </summary>
        /// <returns>Mensaje que indica el estado de la operación.</returns>
        public String eliminarActividad()
        {
            
            return new Negocio.Managment.ActividadManagment().bajaActividad(actividadDto);
        }
    }
}
