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
            estrellas();
        }
        /// <summary>
        /// Verifica si el usuario está apuntado a una actividad y muestra u oculta las estrellas de valoración
        /// en función de si está apuntado o no. Si el usuario está apuntado, muestra las estrellas de valoración 
        /// y las ajusta a la configuración correspondiente. Si no está apuntado, oculta las estrellas.
        /// </summary>
        private void estrellas()
        {
            UsuarioActividadManagment usuarioActividadManagment = new UsuarioActividadManagment();
            List<UsuarioActividadDTO> actividadesApuntadas = usuarioActividadManagment.ObtenerActividadesApuntado(usuario.DNI);

            bool estaApuntado = actividadesApuntadas.Any(a => a.Id_Actividad == actividadDto.Id_Actividad);
            if (estaApuntado)
            {
                CenterElementsConEstrella();
                byte valoracion = usuarioActividadManagment.ObtenerValoracion(actividadDto.Id_Actividad, usuario.DNI);

                estrellasValoracion1.Configurar(actividadDto, usuario);
                estrellasValoracion1.Visible = true;

            }
            else
            {
                CenterElements();
                estrellasValoracion1.Visible = false;// Si el usuario no está apuntado ocultar las estrellas
            }
        }
        /// <summary>
        /// Centra los elementos dentro del contenedor de información en el control, añadiendo el control personalizado de estrellas.
        /// Ajusta las posiciones de las etiquetas para que estén distribuidas de manera equilibrada.
        /// </summary>
        private void CenterElementsConEstrella()
        {
            int panelWidth = panelContenedorInfo.ClientSize.Width;
            int panelHeight = panelContenedorInfo.ClientSize.Height;

            int spacing = 10; 

            int totalHeight = LBLIndicadorNombreActividad.Height + LBLDondeVaNombreActividad.Height +
                              LBLIndicadorNombreMonitor.Height + LBLDonveVaNombreMonitor.Height +
                              estrellasValoracion1.Height + (5 * spacing); 

            int currentY = (panelHeight - totalHeight) / 2;

            LBLIndicadorNombreActividad.Location = new Point((panelWidth - LBLIndicadorNombreActividad.Width) / 2, currentY);
            currentY += LBLIndicadorNombreActividad.Height + spacing;

            LBLDondeVaNombreActividad.Location = new Point((panelWidth - LBLDondeVaNombreActividad.Width) / 2, currentY);
            currentY += LBLDondeVaNombreActividad.Height + spacing;

            LBLIndicadorNombreMonitor.Location = new Point((panelWidth - LBLIndicadorNombreMonitor.Width) / 2, currentY);
            currentY += LBLIndicadorNombreMonitor.Height + spacing;

            LBLDonveVaNombreMonitor.Location = new Point((panelWidth - LBLDonveVaNombreMonitor.Width) / 2, currentY);
            currentY += LBLDonveVaNombreMonitor.Height + spacing;

            int estrellasOffset = -5; 
            estrellasValoracion1.Location = new Point((panelWidth - estrellasValoracion1.Width) / 2, currentY + estrellasOffset);
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

            int spacing = 15;

            int totalHeight = LBLIndicadorNombreActividad.Height + LBLDondeVaNombreActividad.Height +
                              LBLIndicadorNombreMonitor.Height + LBLDonveVaNombreMonitor.Height +
                              (3 * spacing);

            int currentY = (panelHeight - totalHeight) / 2;

            LBLIndicadorNombreActividad.Location = new Point((panelWidth - LBLIndicadorNombreActividad.Width) / 2, currentY);
            LBLDondeVaNombreActividad.Location = new Point((panelWidth - LBLDondeVaNombreActividad.Width) / 2, LBLIndicadorNombreActividad.Bottom + spacing);

            LBLIndicadorNombreMonitor.Location = new Point((panelWidth - LBLIndicadorNombreMonitor.Width) / 2, LBLDondeVaNombreActividad.Bottom + spacing);
            LBLDonveVaNombreMonitor.Location = new Point((panelWidth - LBLDonveVaNombreMonitor.Width) / 2, LBLIndicadorNombreMonitor.Bottom + spacing);
        }

        private void ActividadUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void LBLIndicadorNombreActividad_Click(object sender, EventArgs e)
        {

        }
    }
}
