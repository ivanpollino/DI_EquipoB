using Negocio.EntitiesDTO;
using Negocio.Managment;
using Presentacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ComponentesPersonalizados
{
    /// <summary>
    /// Representa un control de usuario personalizado que muestra la información de una actividad
    /// y permite ver más detalles de la actividad al hacer clic en el panel de información.
    /// </summary>
    public partial class ActividadUsuario : UserControl
    {
        public ActividadDTO actividadDto;
        public UsuarioDTO usuario;
        public ActividadUsuario(ActividadDTO actividad, UsuarioDTO usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            actividadDto = actividad;
            if (actividadDto == null)
            {
                MessageBox.Show("Esta vacio");
            }
            //estrellasValoracion1.Visible = false;
            estrellasValoracion1.Configurar(actividadDto, usuario);
            estrellasValoracion1.Visible = true;

        }
        /// <summary>
        /// Evento que se dispara cuando se hace clic en el panel de información de la actividad.
        /// Abre un formulario para mostrar la información detallada de la actividad.
        /// </summary>
        /// <param name="sender">El objeto que dispara el evento.</param>
        /// <param name="e">Los argumentos del evento <c>EventArgs</c>.</param>
        private void panelContenedorInfo_Click(object sender, EventArgs e)
        {
            ActividadesApuntado formularioPadre = (ActividadesApuntado)FindForm();

            VerInformacionActividad verInformacion = new VerInformacionActividad(formularioPadre, actividadDto, LBLDonveVaNombreMonitor.Text, usuario);

            verInformacion.ShowDialog();

        }

        /// <summary>
        /// Centra los elementos dentro del contenedor de información en el control.
        /// Ajusta las posiciones de las etiquetas para que estén distribuidas de manera equilibrada.
        /// </summary>
        private void CenterElements()
        {
            int panelWidth = panelContenedorInfo.ClientSize.Width;
            int panelHeight = panelContenedorInfo.ClientSize.Height;

            int spacing = 10;

            int totalHeight = LBLIndicadorNombreActividad.Height + LBLDondeVaNombreActividad.Height +
                              LBLIndicadorNombreMonitor.Height + LBLDonveVaNombreMonitor.Height +
                              (3 * spacing);

            int currentY = (panelHeight - totalHeight) / 2;

            LBLIndicadorNombreActividad.Location = new Point((panelWidth - LBLIndicadorNombreActividad.Width) / 2, currentY);
            LBLDondeVaNombreActividad.Location = new Point((panelWidth - LBLDondeVaNombreActividad.Width) / 2, LBLIndicadorNombreActividad.Bottom + spacing);

            LBLIndicadorNombreMonitor.Location = new Point((panelWidth - LBLIndicadorNombreMonitor.Width) / 2, LBLDondeVaNombreActividad.Bottom + spacing);
            LBLDonveVaNombreMonitor.Location = new Point((panelWidth - LBLDonveVaNombreMonitor.Width) / 2, LBLIndicadorNombreMonitor.Bottom + spacing);
            estrellasValoracion1.Location = new Point((panelWidth - estrellasValoracion1.Width) / 2, LBLDonveVaNombreMonitor.Bottom + spacing);
        }

        private void ActividadUsuario_Load(object sender, EventArgs e)
        {
            CenterElements();
        }

        private void LBLIndicadorNombreActividad_Click(object sender, EventArgs e)
        {

        }
    }
}
