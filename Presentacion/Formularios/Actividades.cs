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

        public Actividades()
        {
            InitializeComponent();

            formTusActividades = new ActividadesApuntado();

            formTusActividades.TopLevel = false;
            formTusActividades.FormBorderStyle = FormBorderStyle.None;
            formTusActividades.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(formTusActividades);


            //panelFormularios.Controls.Add(formTodasActividades); // Muestra todas las actividades por defecto
            //formTodasActividades.Show();
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

        // Con el CheckBox se muestras las ctividades inscritas
        private void chbTusActividades_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTusActividades.Checked)
            {
                cargarActividadesDisponibles(formTusActividades);
            }
            /*else
            {
                panelFormularios.Controls.Clear();
                panelFormularios.Controls.Add(formTodasActividades);
                formTodasActividades.Show();
            }*/
        }

        private void cargarActividadesDisponibles(Form fomrulario)
        {
            String nombreMonitor;
            List<ActividadDTO> listaActividades = new Negocio.Managment.ActividadManagment().ObtenerActividades();

            foreach (var actividad in listaActividades)
            {
                ActividadPestaña aP = new ActividadPestaña();

                aP.actividadDto = actividad;
                aP.LBLDondeVaNombreActividad.Text = actividad.Nombre;
                nombreMonitor = new Negocio.Managment.UsuarioManagment().sacarNombreApellidosDeUsuario(actividad.DNI_Monitor);
                aP.LBLDonveVaNombreMonitor.Text = nombreMonitor;

                //formulario.contenedorActividades.Controls.Add(aP);
            }
        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
