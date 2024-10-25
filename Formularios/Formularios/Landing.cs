﻿using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Registro registroForm = new Registro();
            registroForm.ShowDialog();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(); // Abrir formulario de login
            loginForm.ShowDialog();
        }

        private void lbLinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btLogin_Click(sender, e);
        }
    }
}