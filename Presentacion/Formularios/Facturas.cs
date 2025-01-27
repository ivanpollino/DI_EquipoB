using CrystalDecisions.CrystalReports.Engine;
using Negocio.EntitiesDTO;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class Facturas : Form
    {
        private UsuarioDTO usuarioLogueado;

        public Facturas(UsuarioDTO usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            rellenarAños();
            ConfigurarBotones(btnBuscar);
            combAño.SelectedIndexChanged += CombAño_SelectedIndexChanged;

            // Maximizar la ventana al abrir
            this.WindowState = FormWindowState.Maximized;

            // Hacer que CRVFactura se ajuste al centro automáticamente
            this.Resize += Facturas_Resize;

            // Llamar a rellenarMeses con el año actual
            int añoActual = DateTime.Now.Year;
            rellenarMeses(añoActual);
        }

        private void Facturas_Resize(object sender, EventArgs e)
        {
            // Ajustar CRVFactura al centro del formulario y maximizarlo dentro del espacio disponible
            CRVFactura.Width = this.ClientSize.Width - 40; // Ajuste del ancho con márgenes
            CRVFactura.Height = this.ClientSize.Height - 100; // Ajuste de la altura con márgenes
            CRVFactura.Left = (this.ClientSize.Width - CRVFactura.Width) / 2; // Centrar horizontalmente
            CRVFactura.Top = (this.ClientSize.Height - CRVFactura.Height) / 2; // Centrar verticalmente
        }

        private void ConfigurarBotones(Button button)
        {
            button.BackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.Cursor = Cursors.Hand;

            // Crear bordes redondeados
            GraphicsPath path = new GraphicsPath();
            int radius = 35;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }

        private void rellenarAños()
        {
            int añoActual = DateTime.Now.Year;

            combAño.Items.Clear();
            for (int i = añoActual; i >= añoActual - 5; i--) // Desde el actual hasta 5 años atrás
            {
                combAño.Items.Add(i);
            }

            combAño.SelectedItem = añoActual;
        }

        private void rellenarMeses(int añoSeleccionado)
        {
            combMeses.Items.Clear();

            string[] meses = {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            };

            int mesActual = DateTime.Now.Month;
            int añoActual = DateTime.Now.Year;

            if (añoSeleccionado == añoActual)
            {
                for (int i = 0; i < mesActual; i++)
                {
                    combMeses.Items.Add(meses[i]);
                }
            }
            else
            {
                foreach (string mes in meses)
                {
                    combMeses.Items.Add(mes);
                }
            }
        }

        private void CombAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combAño.SelectedItem != null)
            {
                int añoSeleccionado = (int)combAño.SelectedItem;
                rellenarMeses(añoSeleccionado);
            }
        }

        private void CargarReporte()
        {
            try
            {
                if (combMeses.SelectedItem == null || combAño.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un mes y un año.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mesSeleccionado = combMeses.SelectedItem.ToString();
                string añoSeleccionado = combAño.SelectedItem.ToString();

                ReportDocument rpt = new ReportDocument();
                string ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Informes\Factura.rpt");

                if (!System.IO.File.Exists(ruta))
                {
                    MessageBox.Show("No se encontró el archivo del reporte en la ruta:\n" + ruta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                rpt.Load(ruta);

                rpt.SetParameterValue("Mes", mesSeleccionado);
                rpt.SetParameterValue("Año", añoSeleccionado);
                rpt.SetParameterValue("DNI", usuarioLogueado.DNI);
                rpt.SetParameterValue("NombreCliente", usuarioLogueado.Nombre + " " + usuarioLogueado.Apellidos);
                rpt.SetParameterValue("Direccion", usuarioLogueado.Direccion);
                rpt.SetParameterValue("CCC", usuarioLogueado.Cuenta_Corriente);

                CRVFactura.ReportSource = rpt;
                CRVFactura.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }
    }
}