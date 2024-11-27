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

namespace Presentacion.Formularios
{
    public partial class VerInformacionActividad : Form
    {

        public ActividadDTO actividadAux;

        public string nombreMonitor;

        private Landing _formPadre;

        public VerInformacionActividad(Landing formPadre)
        {
            InitializeComponent();
            cargarDatos();
            _formPadre = formPadre;
            comprobarTipoFormulario();
        }

        private void comprobarTipoFormulario()
        {
            if (_formPadre.sePuedeApuntar)
            {
                BTNApuntarseActividad.Visible = true;
            }
            else
            {
                BTNApuntarseActividad.Visible = false;
            }
        }

        private void cargarDatos()
        {
            LBLDondeVaNombreActividad.Text = actividadAux.Nombre;
            LBLDondeVaElNombreMonitor.Text = nombreMonitor;
            LBLDondeVaLaDescripcion.Text = actividadAux.Descripcion;
        }

        private void BTNApuntarseActividad_Click(object sender, EventArgs e)
        {
            UsuarioActividadDTO usuarioActividad = new UsuarioActividadDTO(actividadAux.DNI_Monitor,actividadAux.Id_Actividad);
            bool insercion = new Negocio.Managment.UsuarioActividadManagment().RegistrarUsuarioActividad(usuarioActividad);
            if (insercion)
            {
                MessageBox.Show("¡Te has apuntado a la actividad con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al intentar apuntarte a la actividad. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
