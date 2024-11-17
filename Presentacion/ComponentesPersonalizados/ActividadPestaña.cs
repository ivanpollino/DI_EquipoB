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
    public partial class ActividadPestaña : UserControl
    {
        public ActividadDTO actividadDto;
        public ActividadPestaña()
        {
            InitializeComponent();
        }

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
                var resultado = new Negocio.Managment.ActividadManagment().bajaActividad(actividadDto);

                if (resultado == "Actividad borrada con exito")
                {
                    // Mostrar mensaje de confirmación
                    MessageBox.Show("La actividad ha sido eliminada exitosamente.",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    // Eliminar el control personalizado del contenedor
                    this.Parent.Controls.Remove(this);
                }
                else
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("No se pudo eliminar la actividad: " + resultado,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
