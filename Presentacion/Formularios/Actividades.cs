using Negocio.EntitiesDTO;
using Presentacion.ComponentesPersonalizados;
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


namespace Presentacion.Formularios
{
    /// <summary>
    /// Representa el formulario principal que gestiona y muestra las actividades
    /// en las que un usuario puede participar. Permite visualizar tanto las actividades
    /// disponibles como aquellas en las que el usuario está apuntado.
    /// </summary>
    public partial class Actividades : Form
    {
        private ActividadesApuntado formTusActividades;
        private UsuarioDTO usuario;

        /// <summary>
        /// Constructor de la clase <c>Actividades</c>.
        /// Inicializa el formulario y carga las actividades disponibles.
        /// </summary>
        /// <param name="usuario">El objeto <c>UsuarioDTO</c> que representa al usuario actual.</param>
        public Actividades(UsuarioDTO usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            botonSwitch1.formPadre = this;
            formTusActividades = new ActividadesApuntado();

            formTusActividades.TopLevel = false;
            formTusActividades.FormBorderStyle = FormBorderStyle.None;
            formTusActividades.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(formTusActividades);
            panelFormularios.Tag = formTusActividades;
            cargarActividadesDisponibles(formTusActividades);
            formTusActividades.Visible = true;
            formTusActividades.BringToFront();
            formTusActividades.Show();


        }
        private void lbActividades_Paint(object sender, PaintEventArgs e)
        {

            // Asegúrate de que el texto no esté vacío
            string texto = lbActividades.Text;
            if (string.IsNullOrEmpty(texto)) return;

            Font fuente = lbActividades.Font;
            Color colorBorde = Color.DarkCyan;
            int grosorBorde = 3;

            GraphicsPath rutaTexto = new GraphicsPath();
            rutaTexto.AddString(texto, fuente.FontFamily, (int)fuente.Style, e.Graphics.DpiY * fuente.Size / 72,
                                lbActividades.ClientRectangle.Location, StringFormat.GenericDefault);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(colorBorde, grosorBorde) { LineJoin = LineJoin.Round })
            {
                e.Graphics.DrawPath(pen, rutaTexto);
            }
        }

        private void CenterLabel(Label label)
        {
            // Obtenemos el tamaño del contenedor donde está el Label
            int containerWidth = label.Parent.ClientSize.Width;
            int containerHeight = label.Parent.ClientSize.Height;

            // Calculamos la nueva posición centrada
            int x = (containerWidth - label.Width) / 2;
            int y = (containerHeight - label.Height) / 2;

            // Asignamos la nueva posición
            label.Location = new Point(x, y);
        }

        /// <summary>
        /// Carga las actividades en las que el usuario está apuntado y las muestra en el formulario.
        /// </summary>
        /// <param name="formulario">El formulario <c>ActividadesApuntado</c> en el que se cargarán las actividades.</param>
        public void cargarActividadesApuntado(ActividadesApuntado fomrulario)
        {
            lbActividades.Text = "MIS ACTIVIDADES";
            lbActividades.Invalidate();
            CenterLabel(lbActividades);
            formTusActividades.contenedorActividades.Controls.Clear();
            String nombreMonitor;
            List<ActividadDTO> listaTodasActividades = new Negocio.Managment.ActividadManagment().ObtenerActividades();
            List<UsuarioActividadDTO> actividadesApuntado = new Negocio.Managment.UsuarioActividadManagment().ObtenerActividadesApuntado(usuario.DNI);

            foreach (var actividad in listaTodasActividades)
            {
                foreach (var usuarioActividad in actividadesApuntado)
                {
                    if (actividad.Id_Actividad == usuarioActividad.Id_Actividad)
                    {
                        ActividadUsuario au = new ActividadUsuario(actividad,usuario);
                        au.LBLDondeVaNombreActividad.Text = actividad.Nombre;
                        nombreMonitor = new Negocio.Managment.UsuarioManagment().sacarNombreApellidosDeUsuario(actividad.DNI_Monitor);
                        au.LBLDonveVaNombreMonitor.Text = nombreMonitor;
                        formTusActividades.contenedorActividades.Controls.Add(au);
                    }
                } 
            }
            formTusActividades.sePuedeApuntar = false;
        }

        /// <summary>
        /// Carga las actividades disponibles a las que el usuario puede apuntarse
        /// y las muestra en el formulario.
        /// </summary>
        /// <param name="formulario">El formulario <c>ActividadesApuntado</c> en el que se cargarán las actividades disponibles.</param>
        public void cargarActividadesDisponibles(ActividadesApuntado fomrulario)
        {
            lbActividades.Text = "ACTIVIDADES DISPONIBLES";
            lbActividades.Invalidate();
            CenterLabel(lbActividades);
            formTusActividades.contenedorActividades.Controls.Clear();
            String nombreMonitor;
            List<ActividadDTO> listaTodasActividades = new Negocio.Managment.ActividadManagment().ObtenerActividades();
            List<UsuarioActividadDTO> actividadesApuntado = new Negocio.Managment.UsuarioActividadManagment().ObtenerActividadesApuntado(usuario.DNI);
            List<ActividadDTO> actividadesDisponibles = new List<ActividadDTO>();

            if (actividadesApuntado.Count == 0)
            {
                actividadesDisponibles.AddRange(listaTodasActividades);
            }
            else
            {
                foreach (var actividad in listaTodasActividades)
                {
                    bool estaApuntado = false;

                    foreach (var usuarioActividad in actividadesApuntado)
                    {
                        if (actividad.Id_Actividad == usuarioActividad.Id_Actividad)
                        {
                            estaApuntado = true;
                            break; 
                        }
                    }

                    if (!estaApuntado)
                    {
                        actividadesDisponibles.Add(actividad);
                    }
                }
            }

            foreach (var actividad in actividadesDisponibles)
            { 
                ActividadUsuario au = new ActividadUsuario(actividad,usuario);
                au.LBLDondeVaNombreActividad.Text = actividad.Nombre;
                nombreMonitor = new Negocio.Managment.UsuarioManagment().sacarNombreApellidosDeUsuario(actividad.DNI_Monitor);
                au.LBLDonveVaNombreMonitor.Text = nombreMonitor;
                formTusActividades.contenedorActividades.Controls.Add(au);
            }
            formTusActividades.sePuedeApuntar = true;
        }

        /// <summary>
        /// Carga y muestra las actividades basadas en el estado del botón de alternancia (Switch).
        /// Si el botón está activado, muestra las actividades disponibles; de lo contrario,
        /// muestra las actividades en las que el usuario está apuntado.
        /// </summary>
        public void cargarActividades()
        {
            formTusActividades.contenedorActividades.Controls.Clear();

            if (botonSwitch1.estado)
            {
                cargarActividadesDisponibles(formTusActividades);
            }
            else
            {
                cargarActividadesApuntado(formTusActividades);
            }
        }
    }
}
