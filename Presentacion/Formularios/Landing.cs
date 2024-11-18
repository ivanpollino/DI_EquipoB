using Negocio.EntitiesDTO;
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

namespace Presentacion
{
    /// <summary>
    /// Formulario principal de la aplicación, que actúa como pantalla de bienvenida.
    /// Permite al usuario registrarse, iniciar sesión y visualizar su información de usuario si ha iniciado sesión.
    /// </summary>
    public partial class Landing : Form
    {
        private UsuarioDTO usuario; // Almacena los datos del usuario autenticado
        private string databaseName = "Usuario del gimnasio"; // Nombre de la base de datos asociada
        private bool logeado = false; // Estado de autenticación del usuario
        private bool administrador = false;

        /// <summary>
        /// Inicializa una nueva instancia del formulario Landing, configura los eventos
        /// necesarios y personaliza los botones de la interfaz.
        /// </summary>
        public Landing()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Landing_Resize); // Se asocia el evento de cambio de tamaño
            cargarHeader(); // Método para cargar la cabecera según el estado del usuario
            ConfigurarBotones(btLogin); // Personaliza el botón de Login
            ConfigurarBotones(btRegistro); // Personaliza el botón de Registro
        }

        /// <summary>
        /// Método ejecutado al cargar el formulario (sin implementación adicional).
        /// </summary>
        private void Landing_Load(object sender, EventArgs e)
        {
            // No se requiere implementación adicional aquí.
        }

        /// <summary>
        /// Muestra u oculta los elementos de la cabecera en función del estado de autenticación del usuario.
        /// </summary>
        private void cargarHeader()
        {
            panelAdministrador.Visible = false; // Oculta el panel de administrador si no está logeado
            panelParaUsuarios.Visible = false; // Oculta el panel para usuarios no logeados
            lbInfoUsuario.Visible = false; // Oculta la información del usuario si no está logeado
            lbLinkLogin.Visible = false; // Oculta el enlace de login si el usuario está logeado
            if (logeado)
            {
                lbInfoUsuario.Visible = true; // Muestra la información del usuario si está logeado
                lbInfoUsuario.Text = $"Usuario: " + usuario.Nombre + " " + usuario.Apellidos;
            }
            else
            {
                lbLinkLogin.Visible = true; // Muestra el enlace para iniciar sesión si no está logeado
            }
        }

        /// <summary>
        /// Abre el formulario de registro de usuario. Si el registro es exitoso,
        /// redirige automáticamente al inicio de sesión.
        /// </summary>
        private void btRegistro_Click(object sender, EventArgs e)
        {
            Registro registroForm = new Registro(); // Crea una nueva instancia del formulario de registro
            registroForm.ShowDialog(); // Muestra el formulario de registro de manera modal
            if (registroForm.registroCorrecto) // Si el registro es exitoso
            {
                btLogin_Click(sender, e); // Llama al método de login
            }
        }

        /// <summary>
        /// Abre el formulario de inicio de sesión y, si el usuario se autentica,
        /// carga su información en la cabecera y actualiza el estado de autenticación.
        /// </summary>
        private void btLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(); // Crea una nueva instancia del formulario de login
            loginForm.ShowDialog(); // Muestra el formulario de login de manera modal
            if (loginForm.UsuarioAutenticado != null) // Si el usuario se autentica correctamente
            {
                usuario = loginForm.UsuarioAutenticado; // Asigna el usuario autenticado
                logeado = true; // Cambia el estado de autenticación
                cargarHeader(); // Actualiza la cabecera con la información del usuario
                Landing_Resize(sender, e); // Redimensiona la interfaz si es necesario
                habilitarBotones(); // Habilita los botones correspondientes
                comprobarAdministrador(); // Verifica si el usuario es administrador
            }
            else
            {
                logeado = false; // Si el usuario no se autentica, mantiene el estado de no autenticado
            }
        }

        /// <summary>
        /// Habilita y oculta los botones de inicio de sesión y registro si el usuario está logeado.
        /// </summary>
        private void habilitarBotones()
        {
            if (usuario != null)
            {
                btLogin.Visible = false; // Oculta el botón de login
                btRegistro.Visible = false; // Oculta el botón de registro
            }
        }

        /// <summary>
        /// Verifica si el usuario es administrador mediante la gestión de usuarios.
        /// </summary>
        private void comprobarAdministrador()
        {
            UsuarioDTO usuarioAuxiliar = new UsuarioDTO();
            usuarioAuxiliar = new Negocio.Managment.UsuarioManagment().comprobarAdministrador(usuario.DNI); // Consulta si el usuario es administrador
            if (usuarioAuxiliar.DNI == null)
            {
                administrador = false; // Si no es administrador, cambia el estado a false
            }
            else
            {
                administrador = true; // Si es administrador, cambia el estado a true
            }
        }

        /// <summary>
        /// Activa el evento de inicio de sesión al hacer clic en el enlace de inicio de sesión en la cabecera.
        /// </summary>
        private void lbLinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btLogin_Click(sender, e); // Llama al evento de login
        }

        /// <summary>
        /// Muestra u oculta el panel correspondiente según el rol de usuario.
        /// </summary>
        private void lbInfoUsuario_Click(object sender, EventArgs e)
        {
            if (administrador)
            {
                panelAdministrador.Visible = !panelAdministrador.Visible; // Alterna la visibilidad del panel de administrador
            }
            else
            {
                panelParaUsuarios.Visible = !panelParaUsuarios.Visible; // Alterna la visibilidad del panel de usuario
            }
        }

        /// <summary>
        /// Dibuja un contorno en el texto del label `lbTexto2` para estilizarlo con un borde personalizado.
        /// </summary>
        private void lbTexto2_Paint(object sender, PaintEventArgs e)
        {
            string texto = "ES POSIBLE"; // Texto a mostrar
            Font fuente = lbTexto2.Font;
            Color colorBorde = Color.DarkCyan; // Color del borde
            int grosorBorde = 3; // Grosor del borde

            GraphicsPath rutaTexto = new GraphicsPath();
            rutaTexto.AddString(texto, fuente.FontFamily, (int)fuente.Style, e.Graphics.DpiY * fuente.Size / 72,
                                lbTexto2.ClientRectangle.Location, StringFormat.GenericDefault);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Suaviza el borde
            using (Pen pen = new Pen(colorBorde, grosorBorde) { LineJoin = LineJoin.Round })
            {
                e.Graphics.DrawPath(pen, rutaTexto); // Dibuja el borde alrededor del texto
            }
        }

        /// <summary>
        /// Configura los botones de la interfaz con bordes redondeados y estilo personalizado.
        /// </summary>
        /// <param name="button">Botón a personalizar</param>
        private void ConfigurarBotones(Button button)
        {
            button.Font = btRegistro.Font;
            button.BackColor = Color.DarkCyan;
            button.ForeColor = Color.Black;
            button.FlatStyle = FlatStyle.Flat;
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderSize = 0;

            // Crear un GraphicsPath para bordes redondeados
            GraphicsPath path = new GraphicsPath();
            int radius = 35; // Radio de los bordes redondeados
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path); // Asigna la región de la forma del botón
        }

        /// <summary>
        /// Reorganiza los elementos del formulario de acuerdo con el tamaño de la ventana actual.
        /// </summary>
        private void Landing_Resize(object sender, EventArgs e)
        {
            CenterElements(); // Reorganiza los elementos en la ventana
        }

        /// <summary>
        /// Centra los elementos de la interfaz dentro del panel principal.
        /// </summary>
        private void CenterElements()
        {
            int panelWidth = panel1.ClientSize.Width;
            int panelHeight = panel1.ClientSize.Height;

            int labelUsuarioBottom = lbInfoUsuario.Bottom;
            panelAdministrador.Location = new Point((panelWidth - panelAdministrador.Width) / 2, labelUsuarioBottom + 10);
            panelParaUsuarios.Location = new Point((panelWidth - panelParaUsuarios.Width) / 2, labelUsuarioBottom + 10);

            lbInfoUsuario.Left = (panelWidth - lbInfoUsuario.Width) / 2;
            lbLinkLogin.Left = (panelWidth - lbLinkLogin.Width) / 2;
        }
    }
}
