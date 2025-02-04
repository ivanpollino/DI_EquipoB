﻿using Negocio.EntitiesDTO;
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

namespace Presentacion
{
    public partial class RegistroMonitor : Form
    {
        // Variables booleanas para validar cada campo del formulario
        private bool bNombre, bApellido, bDni, bEmail, bCcc, bContraseña, bRepecontraseña;
        
        /// <summary>
        /// Determina si todos los campos requeridos están correctamente validados.
        /// </summary>
        private bool comprobacionFinal = true;

        /// <summary>
        /// Indica si el registro fue exitoso o no.
        /// </summary>
        public bool registroCorrecto = false;


        public RegistroMonitor()
        {
            InitializeComponent();
            ConfigurarBotones(BTNRegistrar);
            ConfigurarBotones(BTNBorrarForm);
            BTNRegistrar.Enabled = false;

            TXTBContrasena.TextChanged += new EventHandler(comprobarContraseña);
            TXTBEmail.TextChanged += new EventHandler(ValidarEmail);
            TXTBDNI.TextChanged += new EventHandler(ValidarDNI);
            TXTBNombre.TextChanged += new EventHandler(ComprobarNombre);
            TXTBApellidos.TextChanged += new EventHandler(ComprobarApellidos);
            TXTBContrasena.TextChanged += new EventHandler(comprobarContraseñaRepetida);
            TXTBRepetirContra.TextChanged += new EventHandler(comprobarContraseñaRepetida);
        }

        /// <summary>
        /// Limpia todos los campos del formulario de registro.
        /// </summary>
        private void BTNBorrarForm_Click(object sender, EventArgs e)
        {
            TXTBNombre.Text = String.Empty;
            TXTBApellidos.Text = String.Empty;
            TXTBDNI.Text = String.Empty;
            TXTBContrasena.Text = String.Empty;
            TXTBEmail.Text = String.Empty;
            TXTBTelefono.Text = String.Empty;
            TXTBDireccion.Text = String.Empty;
            TXTBRepetirContra.Text = String.Empty;
        }

        /// <summary>
        /// Valida el campo de nombre para verificar que no esté vacío.
        /// </summary>
        private void ComprobarNombre(object sender, EventArgs e)
        {
            String nombre = TXTBNombre.Text;
            bNombre = !string.IsNullOrWhiteSpace(nombre);
            habilitarBotonRegistro();
        }

        /// <summary>
        /// Valida el campo de apellidos para verificar que no esté vacío.
        /// </summary>
        private void ComprobarApellidos(object sender, EventArgs e)
        {
            String apellidos = TXTBApellidos.Text;
            bApellido = !string.IsNullOrWhiteSpace(apellidos);
            habilitarBotonRegistro();
        }

        /// <summary>
        /// Valida el formato del DNI utilizando una expresión regular.
        /// </summary>
        private void ValidarDNI(object sender, EventArgs e)
        {
            var regex = new Regex(@"^\d{8}[A-Z]$");
            if (!regex.IsMatch(TXTBDNI.Text))
            {
                LBLAvisoDNI.Text = "DNI inválido";
                bDni = false;
            }
            else
            {
                LBLAvisoDNI.Text = "";
                bDni = true;
            }
            habilitarBotonRegistro();
        }


        /// <summary>
        /// Valida el formato del correo electrónico.
        /// </summary>
        private void ValidarEmail(object sender, EventArgs e)
        {
            String correo = TXTBEmail.Text;
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (Regex.IsMatch(correo, patronCorreo))
            {
                LBLAvisoCorreo.Text = "";
                bEmail = true;            
            }
            else
            {
                LBLAvisoCorreo.Text = "El correo electrónico no es válido";
                bEmail = false;
            }
            habilitarBotonRegistro();
        }

        /// <summary>
        /// Verifica que la contraseña cumple los requisitos mínimos de seguridad.
        /// </summary>
        private void comprobarContraseña(object sender, EventArgs e)
        {
            string patron = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[%&$/\*]).{8,}$";
            if (!Regex.IsMatch(TXTBContrasena.Text, patron))
            {
                LBLAvisoContrasena.Text = "La contraseña no cumple los requisitos";
                bContraseña = false;
            }
            else
            {
                LBLAvisoContrasena.Text = "";
                bContraseña = true;
            }
            habilitarBotonRegistro();
        }

        private void BTNVerContraNormal_Click(object sender, EventArgs e)
        {
            if (TXTBContrasena.PasswordChar == '\0')
            {
                TXTBContrasena.PasswordChar = '*';
                BTNVerContraNormal.Image = Properties.Resources.contraVisible;
            }
            else
            {
                TXTBContrasena.PasswordChar = '\0';
                BTNVerContraNormal.Image = Properties.Resources.contraNoVisible;
            }
        }

        private void BTNVerContraRepe_Click(object sender, EventArgs e)
        {
            if (TXTBRepetirContra.PasswordChar == '\0')
            {
                TXTBRepetirContra.PasswordChar = '*';
                BTNVerContraRepe.Image = Properties.Resources.contraVisible;
            }
            else
            {
                TXTBRepetirContra.PasswordChar = '\0';
                BTNVerContraRepe.Image = Properties.Resources.contraNoVisible;
            }
        }

        private void BTNBorrarForm_Click_1(object sender, EventArgs e)
        {
            TXTBNombre.Text = String.Empty;
            TXTBApellidos.Text = String.Empty;
            TXTBDNI.Text = String.Empty;
            TXTBContrasena.Text = String.Empty;
            TXTBEmail.Text = String.Empty;
            TXTBTelefono.Text = String.Empty;
            TXTBDireccion.Text = String.Empty;
            TXTBRepetirContra.Text = String.Empty;
        }

        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            if (comprobacionFinal)
            {
                UsuarioDTO usuarioDTO = new UsuarioDTO
                {
                    Nombre = TXTBNombre.Text,
                    Apellidos = TXTBApellidos.Text,
                    Telefono = string.IsNullOrWhiteSpace(TXTBTelefono.Text) ? (int?)null : int.Parse(TXTBTelefono.Text),
                    DNI = TXTBDNI.Text,
                    Direccion = TXTBDireccion.Text,
                    Cuenta_Corriente = null,
                    Email = TXTBEmail.Text,
                    Passwd = TXTBContrasena.Text
                };

                MonitorDTO monitorDTO = new MonitorDTO();
                monitorDTO.DNI = usuarioDTO.DNI;

                string mensaje = new Negocio.Managment.MonitorManagment().altaMonitor(usuarioDTO);
                MessageBox.Show(mensaje);

                if (mensaje != "Ya hay un monitor registrado con ese email" && mensaje != "Ya hay un monitor registrado con ese DNI")
                {
                    registroCorrecto = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Falta algun campo obligatorio");
            }
        }

        private void miControl1_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Verifica si la contraseña y su repetición coinciden.
        /// </summary>
        private void comprobarContraseñaRepetida(object sender, EventArgs e)
        {
            String contraseña = TXTBContrasena.Text;
            String contraseñaRepe = TXTBRepetirContra.Text;
            if (contraseña == contraseñaRepe)
            {
                LBLAvisoContraRepetida.Text = "";
                bRepecontraseña = true;
            }
            else
            {
                LBLAvisoContraRepetida.Text = "Las contraseñas no coinciden";
                bRepecontraseña = false;
            }
            habilitarBotonRegistro();
        }

        /// <summary>
        /// Configura los botones de la interfaz con bordes redondeados y estilo personalizado.
        /// </summary>
        /// <param name="button">Botón a personalizar</param>
        private void ConfigurarBotones(Button button)
        {
            button.Font = BTNBorrarForm.Font;
            button.BackColor = Color.DarkCyan;
            button.ForeColor = Color.Black;
            button.FlatStyle = FlatStyle.Flat;
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderSize = 0;

            // Crear un GraphicsPath para bordes redondeados
            GraphicsPath path = new GraphicsPath();
            int radius = 30;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }

        /// <summary>
        /// Activa el botón de registro si todos los campos requeridos son válidos.
        /// </summary>
        private void habilitarBotonRegistro()
        {
            BTNRegistrar.Enabled = bContraseña && bApellido && bNombre && bEmail && bDni && bRepecontraseña;
            comprobacionFinal = BTNRegistrar.Enabled;
        }

        private void LBLTitulo_Click(object sender, EventArgs e)
        {

        }

        private void RegistroMonitor_Load(object sender, EventArgs e)
        {

        }

        private void LBLAvisoDNI_Click(object sender, EventArgs e)
        {

        }
    }
}
