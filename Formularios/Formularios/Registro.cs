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
        private bool bNombre,bApellido,bDni,bEmail,bCcc,bContraseña,bRepecontraseña;
        private bool comprobacionFinal = true;
        public Registro()
        {
            InitializeComponent();
            BTNRegistrar.Enabled = false;

            TXTBContrasena.TextChanged += new EventHandler(comprobarContraseña);
            TXTBEmail.TextChanged += new EventHandler(ValidarEmail);
            TXTBDNI.TextChanged += new EventHandler(ValidarDNI);
            TXTBNombre.TextChanged += new EventHandler(ComprobarNombre);
            TXTBCCC.TextChanged += new EventHandler(ValidarCuentaCorriente);
            TXTBApellidos.TextChanged += new EventHandler(ComprobarApellidos);
            TXTBContrasena.TextChanged += new EventHandler(comprobarContraseñaRepetida);
            TXTBRepetirContra.TextChanged += new EventHandler(comprobarContraseñaRepetida);


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

        private void ComprobarNombre(object sender, EventArgs e)
        {
            String nombre = TXTBNombre.Text;
            if (!string.IsNullOrWhiteSpace(nombre)) {
                bNombre = true;
            }
            else
            {
                bNombre=false;  
            }
            habilitarBotonRegistro();
        }
        private void ComprobarApellidos(object sender, EventArgs e)
        {
            String apellidos = TXTBApellidos.Text;
            if (!string.IsNullOrWhiteSpace(apellidos))
            {
                bApellido = true;
            }
            else
            {
                bApellido=false;
            }
            habilitarBotonRegistro();
        }

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
                lblAvisoCuenta.Text = "";
                bCcc = true;
            }
            habilitarBotonRegistro();
        }

        private void ValidarEmail(object sender, EventArgs e)
        {
            String correo = TXTBEmail.Text;
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if(Regex.IsMatch(correo, patronCorreo))
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

        private void comprobarContraseña(object sender, EventArgs e)
        {
            string patron = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[%&$/\*]).{8,}$";

            if (!(Regex.IsMatch(TXTBContrasena.Text, patron)))
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
                bRepecontraseña
                    = false;
            }
            habilitarBotonRegistro();
        }


        private void habilitarBotonRegistro()
        {
            if(bContraseña && bApellido && bNombre && bEmail && bDni && bCcc && bRepecontraseña)
            {
                BTNRegistrar.Enabled = true;
                comprobacionFinal = true;
            }
            else
            {
                BTNRegistrar.Enabled = false;
                comprobacionFinal = false;
            }

        }

        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            String mensaje;
            if (comprobacionFinal)
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
                MessageBox.Show("Falta algun campo obligatorio");
            }
        }
        private void caparSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
    }
}
