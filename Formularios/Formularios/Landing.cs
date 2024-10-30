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

namespace Formularios.Formularios
{
    public partial class Landing : Form
    {
        private UsuarioDTO usuario;
        private string databaseName = "Usuario del gimasio";//Simulación de base de datos
        private bool logeado = false; //Por predeterminado NO está logeado
        public Landing()
        {
            InitializeComponent();
            cargarHeader();
            ConfigurarBotones(btLogin);
            ConfigurarBotones(btRegistro);
        }

        private void Landing_Load(object sender, EventArgs e)
        {

        }
        private void cargarHeader()
        {   // Ocultar todo
            lbInfoUsuario.Visible = false;
            lbLinkLogin.Visible = false;
            if (logeado)
            {
                // Si está logeado mostramos el nombre de la base de datos
                lbInfoUsuario.Visible = true;
                lbInfoUsuario.Text = $"Usuario: " + usuario.Nombre;
            }
            else
            {
                // Si no está logeado mostrar enlace de login
                lbLinkLogin.Visible = true;
            }
        }

        private void btRegistro_Click(object sender, EventArgs e)
        {
            Registro registroForm = new Registro();
            registroForm.ShowDialog();
            if (registroForm.registroCorrecto)
            {
                btLogin_Click(sender, e);
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(); 
            loginForm.ShowDialog();
            if (loginForm.UsuarioAutenticado != null)
            {
                usuario = loginForm.UsuarioAutenticado;
                logeado = true;
                cargarHeader();
            }
            else
            {
                logeado = false;
            }
        }

        private void lbLinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btLogin_Click(sender, e);
        }

        private void lbTexto2_Paint(object sender, PaintEventArgs e)
        {
            string texto = "ES POSIBLE";
            Font fuente = lbTexto2.Font;
            Color colorBorde = Color.DarkCyan;  // Color del borde
            int grosorBorde = 3;

            //Contorno del texto
            GraphicsPath rutaTexto = new GraphicsPath();
            rutaTexto.AddString(texto, fuente.FontFamily, (int)fuente.Style, e.Graphics.DpiY * fuente.Size / 72,
                                lbTexto2.ClientRectangle.Location, StringFormat.GenericDefault);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(colorBorde, grosorBorde) { LineJoin = LineJoin.Round })
            {
                e.Graphics.DrawPath(pen, rutaTexto);
            }
        }
        private void ConfigurarBotones(Button button)
        {
                button.Font = btRegistro.Font; 
                button.BackColor = Color.DarkCyan;
                button.ForeColor = Color.Black;
                button.FlatStyle = FlatStyle.Flat;
                button.Cursor = Cursors.Hand; // Cambia el cursor
                button.FlatAppearance.BorderSize = 0; 

                // Crear un GraphicsPath para bordes redondeados
                GraphicsPath path = new GraphicsPath();
                int radius = 35; 
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                // Asignar el área del botón
                button.Region = new Region(path);
            
        }
    }
}
