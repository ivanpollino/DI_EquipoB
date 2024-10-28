using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios.Formularios
{
    public partial class Login : Form
    {
        private bool mostrarContrasena = false;
        public UsuarioDTO UsuarioAutenticado { get; set; }
        public Login()
        {
            InitializeComponent();
            PersonalizarBotonLogin();
        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            UsuarioDTO usuario = new UsuarioDTO();
            usuario = new Negocio.Managment.UsuarioManagment().comprobarLogin(TXTBEmail.Text,TXTBPass.Text);

            if (usuario != null)
            {
                MessageBox.Show("Inicio de sesion correcto");
                UsuarioAutenticado = usuario;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Los datos introducidos no son validos");
            }
        }
        private void PersonalizarBotonLogin()
        {
            // Configuraciones del botón
            this.BTNLogin.Enabled = false;
            this.BTNLogin.Text = "Login";
            this.BTNLogin.Size = new Size(120, 35);
            this.BTNLogin.Location = new Point(120, 220);
            this.BTNLogin.BackColor = Color.RoyalBlue;
            this.BTNLogin.ForeColor = Color.White;
            this.BTNLogin.FlatStyle = FlatStyle.Flat;
            this.BTNLogin.FlatAppearance.BorderSize = 0;

            // Redondear bordes del botón
            this.BTNLogin.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, 20, 20, 180, 90);
                path.AddArc(this.BTNLogin.Width - 20, 0, 20, 20, 270, 90);
                path.AddArc(this.BTNLogin.Width - 20, this.BTNLogin.Height - 20, 20, 20, 0, 90);
                path.AddArc(0, this.BTNLogin.Height - 20, 20, 20, 90, 90);
                path.CloseFigure();
                this.BTNLogin.ForeColor = Color.White;
                this.BTNLogin.Region = new Region(path);
            };

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

        private void BTNAlternarContrasena_Click(object sender, EventArgs e)
        {
            if (TXTBPass.PasswordChar == '\0')
            {
                TXTBPass.PasswordChar = '*';
                
            }
            else
            {               
                TXTBPass.PasswordChar = '\0';
            }
        }

        private void BTNLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}
