using Negocio.EntitiesDTO;
using Negocio.Managment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.ComponentesPersonalizados
{
    public partial class EstrellasValoracion : UserControl
    {
        private byte p; // Puntuación seleccionada
        private ActividadDTO actividad;
        private UsuarioDTO usuario;

        public EstrellasValoracion()
        {
            InitializeComponent();
            EstablecerEstrellasVacias();
        }

        /// <summary>
        /// Inicializa el componente con los datos de la actividad y el usuario.
        /// </summary>
        /// <param name="actividad">DTO de la actividad.</param>
        /// <param name="usuario">DTO del usuario.</param>
        public void Configurar(ActividadDTO actividad, UsuarioDTO usuario)
        {
            this.actividad = actividad ?? throw new ArgumentNullException(nameof(actividad));
            this.usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));

            CargarValoracion();
        }

        /// <summary>
        /// Carga la valoración del usuario para la actividad desde la base de datos.
        /// </summary>
        private void CargarValoracion()
        {
            if (actividad == null || usuario == null)
                MessageBox.Show("El componente no está configurado correctamente.");

            UsuarioActividadManagment managment = new UsuarioActividadManagment();
            byte valoracionGuardada = managment.ObtenerValoracion(actividad.Id_Actividad, usuario.DNI);

            if (valoracionGuardada > 0)
            {
                P = valoracionGuardada; 
            }
        }

        /// <summary>
        /// Actualiza la valoración en la base de datos y refleja el cambio visual.
        /// </summary>
        /// <param name="nuevaValoracion">Nueva puntuación seleccionada.</param>
        private void ActualizarValoracion(byte nuevaValoracion)
        {
            UsuarioActividadManagment managment = new UsuarioActividadManagment();
            bool actualizado = managment.ActualizarValoracion(actividad.Id_Actividad, usuario.DNI, nuevaValoracion);
        }
        /// <summary>
        /// Actualiza la valoración en la base de datos y refleja el cambio visual, 
        /// pero solo si no se ha dado una valoración previamente.
        /// </summary>
        /// <param name="nuevaValoracion">Nueva puntuación seleccionada.</param>
        private void GuardarValoracion(byte nuevaValoracion)
        {
            UsuarioActividadManagment managment = new UsuarioActividadManagment();
            byte valoracionExistente = managment.ObtenerValoracion(actividad.Id_Actividad, usuario.DNI);

            if (valoracionExistente == 0)
            {
                bool actualizado = managment.ActualizarValoracion(actividad.Id_Actividad, usuario.DNI, nuevaValoracion);

                if (actualizado)
                {
                    MessageBox.Show($"Valoración guardada: {nuevaValoracion} estrellas.");
                    managment.ActualizarMediaValoracion(actividad.Id_Actividad);
                    var controlPadre = BuscarControlPadre<ActividadUsuario>();
                    if (controlPadre != null)
                    {
                        controlPadre.actividadDto = new ActividadManagment().ObtenerActividadPorId(actividad.Id_Actividad);
                    }
                    

                }
                else
                {
                    MessageBox.Show("No se pudo guardar la valoración. Inténtelo de nuevo.");
                }
            }
            else
            {
                MessageBox.Show("Ya has valorado esta actividad anteriormente.");
                CargarValoracion();
            }
        }

        private T BuscarControlPadre<T>() where T : Control
        {
            Control parent = this.Parent;

            while (parent != null)
            {
                if (parent is T)
                    return (T)parent;

                parent = parent.Parent; // Subir un nivel en la jerarquía
            }

            return null; // No se encontró el control
        }

        /// <summary>
        /// Cambia la puntuación seleccionada y actualiza en la base de datos.
        /// </summary>
        public byte P
        {
            get { return p; }
            private set
            {
                p = value; 
                CambiarEstrellas(p); 
                ActualizarValoracion(p); 
            }
        }
        /// <summary>
        /// Cambia la visualización de las estrellas según la puntuación seleccionada.
        /// </summary>
        /// <param name="puntuacionSeleccionada">La valoración seleccionada (1-5).</param>
        private void CambiarEstrellas(byte puntuacionSeleccionada)
        {
            estrellaLlena1.Visible = puntuacionSeleccionada >= 1;
            estrellaLlena2.Visible = puntuacionSeleccionada >= 2;
            estrellaLlena3.Visible = puntuacionSeleccionada >= 3;
            estrellaLlena4.Visible = puntuacionSeleccionada >= 4;
            estrellaLlena5.Visible = puntuacionSeleccionada >= 5;

            estrellaEmpty1.Visible = puntuacionSeleccionada < 1;
            estrellaEmpty2.Visible = puntuacionSeleccionada < 2;
            estrellaEmpty3.Visible = puntuacionSeleccionada < 3;
            estrellaEmpty4.Visible = puntuacionSeleccionada < 4;
            estrellaEmpty5.Visible = puntuacionSeleccionada < 5;
        }
        private void EstablecerEstrellasVacias()
        {
            estrellaEmpty1.Visible = true;
            estrellaEmpty2.Visible = true;
            estrellaEmpty3.Visible = true;
            estrellaEmpty4.Visible = true;
            estrellaEmpty5.Visible = true;

            estrellaLlena1.Visible = false;
            estrellaLlena2.Visible = false;
            estrellaLlena3.Visible = false;
            estrellaLlena4.Visible = false;
            estrellaLlena5.Visible = false;
        }
    
        private void estrellaEmpty1_Click(object sender, EventArgs e)
        {
            p = 1;
            CambiarEstrellas(p);
            GuardarValoracion(p);
        }

        private void estrellaEmpty2_Click(object sender, EventArgs e)
        {
            p = 2;
            CambiarEstrellas(p);
            GuardarValoracion(p);
        }

        private void estrellaEmpty3_Click(object sender, EventArgs e)
        {
            p = 3;
            CambiarEstrellas(p);
            GuardarValoracion(p);

        }

        private void estrellaEmpty4_Click(object sender, EventArgs e)
        {
            p = 4;
            CambiarEstrellas(p);
            GuardarValoracion(p);
        }

        private void estrellaEmpty5_Click(object sender, EventArgs e)
        {
            p = 5;
            CambiarEstrellas(p);
            GuardarValoracion(p);
        }

        private void estrellaLlena1_Click(object sender, EventArgs e)
        {
            p = 1;
            CambiarEstrellas(p);
            GuardarValoracion(p);

        }

        private void estrellaLlena2_Click(object sender, EventArgs e)
        {
            p = 2;
            CambiarEstrellas(p);
            GuardarValoracion(p);

        }

        private void estrellaLlena3_Click(object sender, EventArgs e)
        {
            p = 3;
            CambiarEstrellas(p);
            GuardarValoracion(p);

        }

        private void estrellaLlena4_Click(object sender, EventArgs e)
        {
            p = 4;
            CambiarEstrellas(p);
            GuardarValoracion(p);

        }

        private void estrellaLlena5_Click(object sender, EventArgs e)
        {
            p = 5;
            CambiarEstrellas(p);
            GuardarValoracion(p);
        }

        private void estrellaEmpty1_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(1);
        }

        private void estrellaEmpty2_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(2);
        }

        private void estrellaEmpty3_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(3);
        }

        private void estrellaEmpty4_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(4);
        }

        private void estrellaEmpty5_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(5);
        }

        private void estrellaLlena1_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(1);
        }

        private void estrellaLlena2_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(2);
        }

        private void estrellaLlena3_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(3);
        }

        private void estrellaLlena4_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(4);
        }

        private void estrellaLlena5_MouseHover(object sender, EventArgs e)
        {
            CambiarEstrellas(5);
        }

        private void panelEstrellas_MouseLeave(object sender, EventArgs e)
        {
            if (p == 0)
            {
                EstablecerEstrellasVacias();
            }
            else {
                CambiarEstrellas(p);
            }
        }
    }
}
