﻿using Negocio.EntitiesDTO;
using Presentacion.Formularios;
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
            this.Resize += new System.EventHandler(this.Landing_Resize);
            cargarHeader();
            ConfigurarBotones(btLogin);
            ConfigurarBotones(btRegistro);
            ConfigurarBotones(BTNVerActividades);
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            // Método ejecutado al cargar el formulario (sin implementación adicional).
        }

        /// <summary>
        /// Muestra u oculta los elementos de la cabecera en función del estado de autenticación del usuario.
        /// </summary>
        private void cargarHeader()
        {   
            panelAdministrador.Visible = false;
            panelParaUsuarios.Visible = false;
            lbInfoUsuario.Visible = false;
            lbLinkLogin.Visible = false;
            if (logeado)
            {
                // Si el usuario está logeado, muestra la información del usuario.
                lbInfoUsuario.Visible = true;
                lbInfoUsuario.Text = $"Usuario: " + usuario.Nombre + " " + usuario.Apellidos;
            }
            else
            {
                // Si el usuario no está logeado, muestra el enlace para iniciar sesión.
                lbLinkLogin.Visible = true;
            }
        }

        /// <summary>
        /// Abre el formulario de registro de usuario. Si el registro es exitoso,
        /// redirige automáticamente al inicio de sesión.
        /// </summary>
        private void btRegistro_Click(object sender, EventArgs e)
        {
            Registro registroForm = new Registro();
            registroForm.ShowDialog();
            if (registroForm.registroCorrecto)
            {
                btLogin_Click(sender, e);
            }
        }

        /// <summary>
        /// Abre el formulario de inicio de sesión y, si el usuario se autentica,
        /// carga su información en la cabecera y actualiza el estado de autenticación.
        /// </summary>
        private void btLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();
            if (loginForm.UsuarioAutenticado != null)
            {
                usuario = loginForm.UsuarioAutenticado;
                logeado = true;
                cargarHeader();
                Landing_Resize(sender, e);
                habilitarBotones();
                comprobarAdministrador();
                comprobarUsuario();
            }
            else
            {
                logeado = false;
            }
        }

        private void comprobarUsuario()
        {
            UsuarioDTO usuarioNormalAuxiliar = new UsuarioDTO();
            usuarioNormalAuxiliar = new Negocio.Managment.UsuarioManagment().comporobarUsuarioNormal(usuario.DNI);
            if (usuarioNormalAuxiliar.DNI == null)
            {
                BTNVerActividades.Visible = false;
            }
            else
            {
                BTNVerActividades.Visible= true;
            }

        }

        private void habilitarBotones()
        {
            if (usuario != null)
            {

                btLogin.Visible = false;
                btRegistro.Visible = false;
               
            }
        }

        private void comprobarAdministrador()
        {
            UsuarioDTO usuarioAuxiliar = new UsuarioDTO();
            usuarioAuxiliar = new Negocio.Managment.UsuarioManagment().comprobarAdministrador(usuario.DNI);
            if (usuarioAuxiliar.DNI == null)
            {
                administrador = false;
            }
            else
            {
                administrador = true;
            }
        }

        /// <summary>
        /// Activa el evento de inicio de sesión al hacer clic en el enlace de inicio de sesión en la cabecera.
        /// </summary>
        private void lbLinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btLogin_Click(sender, e);
        }

        private void lbInfoUsuario_Click(object sender, EventArgs e)
        {
            if (administrador)
            {
                panelAdministrador.Visible = !panelAdministrador.Visible;
            }
            else
            {
                panelParaUsuarios.Visible = !panelParaUsuarios.Visible;
            }
        }


        /// <summary>
        /// Dibuja un contorno en el texto del label `lbTexto2` para estilizarlo con un borde personalizado.
        /// </summary>
        private void lbTexto2_Paint(object sender, PaintEventArgs e)
        {
            string texto = "ES POSIBLE";
            Font fuente = lbTexto2.Font;
            Color colorBorde = Color.DarkCyan;
            int grosorBorde = 3;

            GraphicsPath rutaTexto = new GraphicsPath();
            rutaTexto.AddString(texto, fuente.FontFamily, (int)fuente.Style, e.Graphics.DpiY * fuente.Size / 72,
                                lbTexto2.ClientRectangle.Location, StringFormat.GenericDefault);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(colorBorde, grosorBorde) { LineJoin = LineJoin.Round })
            {
                e.Graphics.DrawPath(pen, rutaTexto);
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
            int radius = 35;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }

        /// <summary>
        /// Reorganiza los elementos del formulario de acuerdo con el tamaño de la ventana actual.
        /// </summary>
        private void Landing_Resize(object sender, EventArgs e)
        {
            CenterElements();
        }

        /// <summary>
        /// Centra los elementos de la interfaz dentro del panel principal.
        /// </summary>
        private void CenterElements()
        {
            int panelWidth = panel1.ClientSize.Width;
            int panelHeight = panel1.ClientSize.Height;

            int labelUsuarioBottom = lbInfoUsuario.Bottom;
            panelAdministrador.Location = new Point((panelWidth - panelAdministrador.Width) / 2 ,labelUsuarioBottom +10);
            panelParaUsuarios.Location = new Point((panelWidth - panelParaUsuarios.Width) / 2, labelUsuarioBottom + 10);

            lbInfoUsuario.Left = (panel1.ClientSize.Width - lbInfoUsuario.Width) / 2;
            lbLinkLogin.Left = (panel1.ClientSize.Width - lbLinkLogin.Width) / 2;
            lbTexto1.Location = new Point((panelWidth - lbTexto1.Width) / 2, (panelHeight - lbTexto1.Height) / 2 - 100);
            lbTexto2.Location = new Point((panelWidth - lbTexto2.Width) / 2, lbTexto1.Location.Y + lbTexto1.Height + 10);
            btLogin.Location = new Point((panelWidth - btLogin.Width) / 2, lbTexto2.Location.Y + lbTexto2.Height + 30);
            BTNVerActividades.Location = new Point((panelWidth - btLogin.Width) / 2, lbTexto2.Location.Y + lbTexto2.Height + 50);
            btRegistro.Location = new Point((panelWidth - btRegistro.Width) / 2, btLogin.Location.Y + btLogin.Height + 10);
        }

        private void BTNOpcionesAdministrador_Click(object sender, EventArgs e)
        {
            Administracion administracion = new Administracion();
            administracion.ShowDialog();
        }

        private void BTNCerrarSesionAdmin_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void cerrarSesion()
        {
            usuario = null;
            logeado = false;
            cargarHeader();
            btLogin.Visible = true;
            btRegistro.Visible = true;
            BTNVerActividades.Visible = false;
        }

        private void BTNCerrarSesionUsuario_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void BTNVerActividades_Click(object sender, EventArgs e)
        {
            Actividades actividadesForm = new Actividades(usuario);
            actividadesForm.ShowDialog();
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            EditarPerfil editarPerfil = new EditarPerfil(usuario);
            editarPerfil.ShowDialog();
            cargarHeader();
        }

        private void BTNMisFacturas_Click(object sender, EventArgs e)
        {
            Facturas facturas = new Facturas(usuario);
            facturas.ShowDialog();
        }
    }
}