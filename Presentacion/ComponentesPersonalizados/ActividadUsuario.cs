using Negocio.EntitiesDTO;
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
        }

        private void panelContenedorInfo_Click(object sender, EventArgs e)
        {
            ActividadesApuntado formularioPadre = (ActividadesApuntado)FindForm();


            VerInformacionActividad verInformacion = new VerInformacionActividad(formularioPadre, actividadDto, LBLDonveVaNombreMonitor.Text,usuario);

            verInformacion.ShowDialog();

        }


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
            CenterElements();
        }
    }
}
