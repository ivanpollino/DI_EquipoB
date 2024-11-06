using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios.Formularios
{
    /// <summary>
    /// Formulario de inicio de sesión para la aplicación. Permite al usuario autenticarse mediante email y contraseña,
    /// así como redirigir al formulario de registro en caso de no estar registrado.
    /// </summary>
    public partial class Login : Form
    {
        private bool mostrarContrasena = false; // Estado de visibilidad de la contraseña
        public UsuarioDTO UsuarioAutenticado { get; set; } // Usuario autenticado

        /// <summary>
        /// Constructor de la clase Login. Inicializa el formulario y personaliza el botón de inicio de sesión.
        /// </summary>
        public Login()
        {
            InitializeComponent();
            ConfigurarBotones(BTNLogin);
        }

        /// <summary>
        /// Evento para manejar el proceso de autenticación del usuario cuando se hace clic en el botón de inicio de sesión.
        /// Verifica las credenciales del usuario y, si son válidas, muestra un mensaje de éxito y cierra el formulario.
        /// </summary>
        private void BTNLogin_Click(object sender, EventArgs e)
        {
            UsuarioDTO usuario = new UsuarioDTO();
            usuario = new Negocio.Managment.UsuarioManagment().comprobarLogin(TXTBEmail.Text, TXTBPass.Text);

            if (usuario != null)
            {
                MessageBox.Show("Inicio de sesión correcto");
                UsuarioAutenticado = usuario;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Los datos introducidos no son válidos");
            }
        }
        /// <summary>
        /// Configura los botones de la interfaz con bordes redondeados y estilo personalizado.
        /// </summary>
        /// <param name="button">Botón a personalizar</param>
        private void ConfigurarBotones(Button button)
        {
            button.Font = BTNLogin.Font;
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

            // Habilitar el botón solo si los campos están llenos
            TXTBEmail.TextChanged += (sender, e) =>
            {
                this.BTNLogin.Enabled = !string.IsNullOrWhiteSpace(TXTBEmail.Text) && !string.IsNullOrWhiteSpace(TXTBPass.Text);
            };
            TXTBPass.TextChanged += (sender, e) =>
            {
                this.BTNLogin.Enabled = !string.IsNullOrWhiteSpace(TXTBEmail.Text) && !string.IsNullOrWhiteSpace(TXTBPass.Text);
            };

            // Evento Click del botón
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
        }
        
        /// <summary>
        /// Alterna la visibilidad de la contraseña en el campo de texto de la contraseña.
        /// Cambia entre mostrar y ocultar el texto de la contraseña.
        /// </summary>
        private void BTNAlternarContrasena_Click(object sender, EventArgs e)
        {
            if (TXTBPass.PasswordChar == '\0')
            {
                TXTBPass.PasswordChar = '*';
                BTNAlternarContrasena.Image = Properties.Resources.contraVisible;
            }
            else
            {
                TXTBPass.PasswordChar = '\0';
                BTNAlternarContrasena.Image = Properties.Resources.contraNoVisible;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Método ejecutado al cargar el formulario (sin implementación adicional).
        }

        private void panelDerecho_Paint(object sender, PaintEventArgs e)
        {
            // Método ejecutado al pintar el panel derecho (sin implementación adicional).
        }

        private void panelIzquierdo_Paint(object sender, PaintEventArgs e)
        {
            // Método ejecutado al pintar el panel izquierdo (sin implementación adicional).
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento ejecutado al hacer clic en el label1 (sin implementación adicional).
        }

        /// <summary>
        /// Abre el formulario de registro cuando el usuario hace clic en el enlace "Registrarse".
        /// Cierra el formulario de inicio de sesión actual después de abrir el formulario de registro.
        /// </summary>
        private void LinkLoginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registro RegistroForm = new Registro();
            RegistroForm.ShowDialog();
            this.Close();
        }
    }
}
