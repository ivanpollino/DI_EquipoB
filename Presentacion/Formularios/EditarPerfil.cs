using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Presentacion.Formularios
{
    public partial class EditarPerfil : Form
    {
        private UsuarioDTO usuarioLogeado;
        private bool bEmail, bNombre, bCcc, bApellido, bDireccion;
        private bool comprobacionFinal = true;
        public EditarPerfil(UsuarioDTO usuario)
        {
            InitializeComponent();
            this.usuarioLogeado = usuario;
            cargarDatos();
            BTNModificar.Enabled = false;
            ConfigurarBotones(BTNModificar);
            ConfigurarBotones(BTNRestablecer);

            // Eventos de validación de campos
            TXTBEmail.TextChanged += new EventHandler(ValidarEmail);
            TXTBNombre.TextChanged += new EventHandler(ComprobarNombre);
            TXTBCCC.TextChanged += new EventHandler(ValidarCuentaCorriente);
            TXTBDireccion.TextChanged += new EventHandler(ComprobarDireccion);
            TXTBApellidos.TextChanged += new EventHandler(ComprobarApellidos);
        }

        private void ComprobarDireccion(object sender, EventArgs e)
        {
            String direccion = TXTBDireccion.Text;
            bDireccion = !string.IsNullOrWhiteSpace(direccion) && TXTBDireccion.Text != usuarioLogeado.Direccion;
            habilitarBotonRegistro();
        }

        private void ConfigurarBotones(Button button)
        {
            button.Font = BTNModificar.Font;
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

        private void ComprobarApellidos(object sender, EventArgs e)
        {
            String apellidos = TXTBApellidos.Text;
            bApellido = !string.IsNullOrWhiteSpace(apellidos) && TXTBApellidos.Text != usuarioLogeado.Apellidos;
            habilitarBotonRegistro();
        }

        private void ValidarCuentaCorriente(object sender, EventArgs e)
        {
            var regex = new Regex(@"^ES\d{20}$");
            if (!regex.IsMatch(TXTBCCC.Text))
            {
                lblAvisoCuenta.Text = "Cuenta corriente inválida";
                bCcc = false;
            }
            else
            {
                if (TXTBCCC.Text != usuarioLogeado.Cuenta_Corriente)
                {
                    lblAvisoCuenta.Text = "";
                    bCcc = true;
                }
            }
            habilitarBotonRegistro();
        }

        private void ComprobarNombre(object sender, EventArgs e)
        {
            String nombre = TXTBNombre.Text;

            bNombre = !string.IsNullOrWhiteSpace(nombre) && TXTBNombre.Text != usuarioLogeado.Nombre;
            habilitarBotonRegistro();
        }

        private void ValidarEmail(object sender, EventArgs e)
        {
            String correo = TXTBEmail.Text;
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (Regex.IsMatch(correo, patronCorreo))
            {
                if (TXTBEmail.Text != usuarioLogeado.Email)
                {
                    LBLAvisoCorreo.Text = "";
                    bEmail = true;
                }
            }
            else
            {
                LBLAvisoCorreo.Text = "El correo electrónico no es válido";
                bEmail = false;
            }
            habilitarBotonRegistro();
        }

        private void habilitarBotonRegistro()
        {
            BTNModificar.Enabled = bApellido || bNombre || bEmail || bCcc || bDireccion;
            comprobacionFinal = BTNModificar.Enabled;
        }

        private void BTNRestablecer_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            UsuarioDTO usuarioTemporal = new UsuarioDTO();
            String DNI;
            String mensaje;

            // Configurar los datos del usuario temporal
            usuarioTemporal.DNI = usuarioLogeado.DNI;
            usuarioTemporal.Nombre = TXTBNombre.Text;
            usuarioTemporal.Apellidos = TXTBApellidos.Text;
            usuarioTemporal.Telefono = int.Parse(TXTBTelefono.Text);
            usuarioTemporal.Email = TXTBEmail.Text;
            usuarioTemporal.Cuenta_Corriente = TXTBCCC.Text;
            usuarioTemporal.Direccion = TXTBDireccion.Text;

            DNI = usuarioTemporal.DNI;

            
            mensaje = new Negocio.Managment.UsuarioManagment().modificarUsuario(DNI, usuarioTemporal);
            MessageBox.Show(mensaje);

            
            if (mensaje == "Usuario modificado con éxito") 
            {
                usuarioLogeado.Nombre = usuarioTemporal.Nombre;
                usuarioLogeado.Apellidos = usuarioTemporal.Apellidos;
                usuarioLogeado.Telefono = usuarioTemporal.Telefono;
                usuarioLogeado.Email = usuarioTemporal.Email;
                usuarioLogeado.Cuenta_Corriente = usuarioTemporal.Cuenta_Corriente;
                usuarioLogeado.Direccion = usuarioTemporal.Direccion;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        

        private void cargarDatos()
        {
            TXTBNombre.Text = usuarioLogeado.Nombre;
            TXTBApellidos.Text = usuarioLogeado.Apellidos;
            TXTBTelefono.Text = usuarioLogeado.Telefono.ToString();
            TXTBEmail.Text = usuarioLogeado.Email;
            TXTBDireccion.Text = usuarioLogeado.Direccion;
            TXTBCCC.Text = usuarioLogeado.Cuenta_Corriente.ToString();
        }

        private void CentrarPanel()
        {
            
            int x = (this.ClientSize.Width - panelFormulario.Width) / 2;
            int y = (this.ClientSize.Height - panelFormulario.Height) / 2;

            panelFormulario.Location = new Point(x, y);
        }

        private void EditarPerfil_Load(object sender, EventArgs e)
        {
            CentrarPanel();
        }
    }
}
