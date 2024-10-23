using Negocio.EntitiesDTO;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            UsuarioDTO usuario = new UsuarioDTO();
            usuario = new Negocio.Managment.UsuarioManagment().comprobarLogin(TXTBEmail.Text,TXTBPass.Text);

            if (usuario != null)
            {
                MessageBox.Show("Inicio de sesion correcto");
            }
            else
            {
                MessageBox.Show("Los datos introducidos no son validos");
            }
        }
    }
}
