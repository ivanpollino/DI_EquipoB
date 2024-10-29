using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace landing
{
    public partial class Form1 : Form
    {
        private string databaseName = "Usuario del gimasio";//Simulación de base de datos
        private bool logeado = false; //Por predeterminado NO está logeado
        /// <summary>
        /// FALTA COMPROBAR QUE SE MODIFQUE EL LOGEADO A TRUE
        /// </summary>

        public Form1()
        {
            InitializeComponent();
            cargarHeader();
        }
        private void cargarHeader()
        {   // Ocultar todo
            lbInfoUsuario.Visible = false;
            lbLinkLogin.Visible = false;
            if (logeado)
            {
                // Si está logeado mostramos el nombre de la base de datos
                lbInfoUsuario.Visible = true;
                lbInfoUsuario.Text = $"Usuario: {databaseName}";
            }
            else
            {
                // Si no está logeado mostrar enlace de login
                lbLinkLogin.Visible = true;
            }
        }
        private void btRegistro_Click(object sender, EventArgs e)
        {
            //RegistroFormulario registroForm = new RegistroFormulario();
            //registroForm.ShowDialog();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //LoginFormulario loginForm = new LoginFormulario(); // Abrir formulario de login
            //loginForm.ShowDialog();
        }

        private void lbLinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btLogin_Click(sender, e);
        }
    }
}
