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
    public partial class Actividades : Form
    {
        //private FormularioTodasActividades formTodasActividades;//Cambiar por nombre del formulario
        private ActividadesApuntado formTusActividades;//Cambiar por nombre del formulario
        private UsuarioDTO usuario;

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
            string texto = "ACTIVIDADES";
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

        private void cargarActividadesApuntado(ActividadesApuntado fomrulario)
        {
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

        public void cargarActividadesDisponibles(ActividadesApuntado fomrulario)
        {
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
