using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        public UsuarioDTO usuario;

        private ActividadesApuntado _formPadre;

        public VerInformacionActividad(ActividadesApuntado formPadre,ActividadDTO actividadAux, String nombreMonitor, UsuarioDTO usuario)
        {
            InitializeComponent();
            ConfigurarBotones(BTNApuntarseActividad);
            ConfigurarBotones(BTNDarseDeBajaActividad);
            this.usuario = usuario;
            this.actividadAux = actividadAux;
            this.nombreMonitor = nombreMonitor;
            cargarDatos();
            _formPadre = formPadre;
            comprobarTipoFormulario();
        }

        private void comprobarTipoFormulario()
        {
            if (_formPadre.sePuedeApuntar)
            {
                BTNApuntarseActividad.Visible = true;
                BTNDarseDeBajaActividad.Visible = false;
            }
            else
            {
                BTNApuntarseActividad.Visible = false;
                BTNDarseDeBajaActividad.Visible = true;
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
            UsuarioActividadDTO usuarioActividad = new UsuarioActividadDTO(usuario.DNI,actividadAux.Id_Actividad);
            bool insercion = new Negocio.Managment.UsuarioActividadManagment().RegistrarUsuarioActividad(usuarioActividad);
            if (insercion)
            {
                MessageBox.Show("¡Te has apuntado a la actividad con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _formPadre.ObtenerFormularioPadre();
                this.Close();

            }
            else
            {
                MessageBox.Show("Ocurrió un error al intentar apuntarte a la actividad. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarBotones(Button button)
        {
            button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            button.BackColor = Color.DarkCyan;
            button.ForeColor = Color.Black;
            button.FlatStyle = FlatStyle.Flat;
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderSize = 0;

            // Crear un GraphicsPath para bordes redondeados
            GraphicsPath path = new GraphicsPath();
            int radius = 35;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }

        private void VerInformacionActividad_Load(object sender, System.EventArgs e)
        {
            CenterElements();
        }

        private void CenterElements()
        {
            int panelWidth = panelContenedor.ClientSize.Width;
            int panelHeight = panelContenedor.ClientSize.Height;

            // Espaciado ajustado para mayor separación entre elementos
            int spacing = 30;  // Espaciado vertical entre cada elemento
            int buttonSpacing = 40; // Espaciado extra antes del botón

            // Calculamos el espacio inicial centrado en el panel
            int totalHeight = (6 * LBLNombreActvidad.Height) + (5 * spacing) + BTNApuntarseActividad.Height + buttonSpacing;
            int currentY = (panelHeight - totalHeight) / 2;

            // Posicionamos los elementos centrados horizontalmente
            LBLNombreActvidad.Location = new Point((panelWidth - LBLNombreActvidad.Width) / 2, currentY);
            LBLDondeVaNombreActividad.Location = new Point((panelWidth - LBLDondeVaNombreActividad.Width) / 2, LBLNombreActvidad.Bottom + spacing);

            LBLDescripcionActividad.Location = new Point((panelWidth - LBLDescripcionActividad.Width) / 2, LBLDondeVaNombreActividad.Bottom + spacing);
            LBLDondeVaLaDescripcion.Location = new Point((panelWidth - LBLDondeVaLaDescripcion.Width) / 2, LBLDescripcionActividad.Bottom + spacing);

            LBLNombreMonitor.Location = new Point((panelWidth - LBLNombreMonitor.Width) / 2, LBLDondeVaLaDescripcion.Bottom + spacing);
            LBLDondeVaElNombreMonitor.Location = new Point((panelWidth - LBLDondeVaElNombreMonitor.Width) / 2, LBLNombreMonitor.Bottom + spacing);

            // Posicionamos el botón con más separación
            BTNApuntarseActividad.Location = new Point((panelWidth - BTNApuntarseActividad.Width) / 2, LBLDondeVaElNombreMonitor.Bottom + buttonSpacing);
        }

        private void BTNDarseDeBajaActividad_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres desapuntarte de esta actividad?",
                                         "Confirmar Desapuntarse",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                
                UsuarioActividadDTO usuarioActividad = new UsuarioActividadDTO(usuario.DNI, actividadAux.Id_Actividad);
                bool insercion = new Negocio.Managment.UsuarioActividadManagment().EliminarActividadUsuario(usuarioActividad);

                if (insercion)
                {
                    MessageBox.Show("¡Te has desapuntado de la actividad con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _formPadre.ObtenerFormularioPadre();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al intentar desapuntarte de la actividad. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
