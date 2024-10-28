using Negocio.EntitiesDTO;
using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Formularios.Formularios
{
    public partial class Registro : Form
    {
        public bool registroCorrecto = false;
        private bool contraValida;
        public Registro()
        {
            InitializeComponent();
            BTNRegistrar.Enabled = false;

            TXTBContrasena.TextChanged += new EventHandler(ComprobarTextBox);
            TXTBEmail.TextChanged += new EventHandler(ComprobarTextBox);
            TXTBDNI.TextChanged += new EventHandler(ComprobarTextBox);
            TXTBNombre.TextChanged += new EventHandler(ComprobarTextBox);
            TXTBCCC.TextChanged += new EventHandler(ComprobarTextBox);
            TXTBApellidos.TextChanged += new EventHandler(ComprobarTextBox);
            TXTBRepetirContra.TextChanged += new EventHandler(ComprobarTextBox);
        }


        private void BTNBorrarForm_Click(object sender, EventArgs e)
        {
            TXTBNombre.Text = String.Empty;
            TXTBApellidos.Text = String.Empty;
            TXTBDNI.Text = String.Empty;
            TXTBCCC.Text = String.Empty;
            TXTBContrasena.Text = String.Empty;
            TXTBEmail.Text = String.Empty;
            TXTBTelefono.Text = String.Empty;
            TXTBDireccion.Text = String.Empty;
            TXTBRepetirContra.Text = String.Empty;
        }

        private void ComprobarTextBox(object sender, EventArgs e)
        {
            String contraseña = TXTBContrasena.Text;
            String nombre = TXTBNombre.Text;
            String correo = TXTBEmail.Text;
            String dni = TXTBDNI.Text;
            String apellidos = TXTBApellidos.Text;
            String ccc = TXTBCCC.Text;
            String repeContra = TXTBRepetirContra.Text;



            if (!string.IsNullOrWhiteSpace(contraseña) && !string.IsNullOrWhiteSpace(nombre) && 
                !string.IsNullOrWhiteSpace(correo) && !string.IsNullOrWhiteSpace(dni) && 
                !string.IsNullOrWhiteSpace(apellidos) && !string.IsNullOrWhiteSpace(ccc) &&
                !string.IsNullOrWhiteSpace(repeContra) && comprobarContraseñaRepetida())
            {
                BTNRegistrar.Enabled = true;
            }
            else
            {
                BTNRegistrar.Enabled = false;
            }
        }

        private void comprobarContraseña()
        {
            string patron = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[%&$/\*]).{8,}$";

            if (!(Regex.IsMatch(TXTBContrasena.Text, patron)))
            {
                contraValida = false;
                LBLAvisoContrasena.Text = "La contraseña no cumple los requisitos";
            }
            else
            {
                contraValida = true;
                LBLAvisoContrasena.Text = "";
            }
        }

        private void TXTBContrasena_TextChanged(object sender, EventArgs e)
        {
            comprobarContraseña();
        }

        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            String mensaje;
            if (contraValida)
            {
                UsuarioDTO usuarioDTO = new UsuarioDTO();
                usuarioDTO.Nombre = TXTBNombre.Text;
                usuarioDTO.Apellidos = TXTBApellidos.Text;
                if (!(string.IsNullOrWhiteSpace(TXTBTelefono.Text)))
                {
                    usuarioDTO.Telefono = int.Parse(TXTBTelefono.Text);
                }
                else
                {
                    usuarioDTO.Telefono = null;
                }
                usuarioDTO.DNI = TXTBDNI.Text;
                usuarioDTO.Direccion = TXTBDireccion.Text;
                usuarioDTO.Cuenta_Corriente = TXTBCCC.Text;
                usuarioDTO.Email = TXTBEmail.Text;
                usuarioDTO.Passwd = TXTBContrasena.Text;

                mensaje = new Negocio.Managment.UsuarioManagment().altaUsuario(usuarioDTO);

                MessageBox.Show(mensaje);

                if (mensaje!= "Ya hay un usuario registrado con ese email" && mensaje!= "Ya hay un usuario registrado con ese DNI")
                {
                    registroCorrecto = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("La contraseña no es valida");
            }
        }
        private void caparSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool comprobarContraseñaRepetida()
        {
            String contraseña = TXTBContrasena.Text;
            String contraseñaRepe = TXTBRepetirContra.Text;
            if (contraseña == contraseñaRepe)
            {
                LBLAvisoContraRepetida.Text = "";
                return true;
            }
            else
            {
                LBLAvisoContraRepetida.Text = "Las contraseñas no coinciden";
                return false;
            }
        }
    }
}
