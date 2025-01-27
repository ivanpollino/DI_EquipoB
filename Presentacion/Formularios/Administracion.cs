using CrystalDecisions.CrystalReports.Engine;
using Negocio.EntitiesDTO;
using Presentacion.ComponentesPersonalizados;
using Presentacion.Formularios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        bool menuExpandMonitores = false;
        bool menuExpandActividades = false;
        bool menuExpanAdministracion = false;
        bool menuExpanEstadisticas = false;

        private void menuTransicion_Tick(object sender, EventArgs e)
        {
            if(menuExpandMonitores == false)
            {
                flowLayoutGestioMonitores.Height += 10;
                if(flowLayoutGestioMonitores.Height >= 111)
                {
                    menuTransicion.Stop();
                    menuExpandMonitores = true;
                }
            }
            else
            {
                flowLayoutGestioMonitores.Height -= 10;
                if (flowLayoutGestioMonitores.Height <= 60)
                {
                    menuTransicion.Stop();
                    menuExpandMonitores = false;
                }
            }

        }

        private void BTNGestionarMonitores_Click(object sender, EventArgs e)
        {
            menuTransicion.Start();
        }

        private void BTNGestionActividades_Click(object sender, EventArgs e)
        {
            menuTransacionActividades.Start();
        }

        private void BTNEstadisticas_Click(object sender, EventArgs e)
        {
            menuTransicionEstadisticas.Start();
        }


        private void menuTransacionActividades_Tick(object sender, EventArgs e)
        {
            if (menuExpandActividades == false)
            {
                flowLayoutGestionActividades.Height += 10;
                if (flowLayoutGestionActividades.Height >= 169)
                {
                    menuTransacionActividades.Stop();
                    menuExpandActividades = true;
                }
            }
            else
            {
                flowLayoutGestionActividades.Height -= 10;
                if (flowLayoutGestionActividades.Height <= 58)
                {
                    menuTransacionActividades.Stop();
                    menuExpandActividades = false;
                }
            }
        }

        private void BTNAdminitracion_Click(object sender, EventArgs e)
        {
            menuTransicionAdministracion.Start();
        }

        private void menuTransicionEstadisticas_Tick(object sender, EventArgs e)
        {
            if (menuExpanEstadisticas == false)
            {
                flowLayoutEstadisticas.Height += 10;
                if (flowLayoutEstadisticas.Height >= 169)
                {
                    menuTransicionEstadisticas.Stop();
                    menuExpanEstadisticas = true;
                }
            }
            else
            {
                flowLayoutEstadisticas.Height -= 10;
                if (flowLayoutEstadisticas.Height <= 59)
                {
                    menuTransicionEstadisticas.Stop();
                    menuExpanEstadisticas = false;
                }
            }
        }

        private void menuTransicionAdministracion_Tick(object sender, EventArgs e)
        {
            if (menuExpanAdministracion == false)
            {
                flowLayoutMenuAdministracion.Height += 10;
                if (flowLayoutMenuAdministracion.Height >= 600)
                {
                    menuTransicionAdministracion.Stop();
                    menuExpanAdministracion = true;
                }
            }
            else
            {
                flowLayoutMenuAdministracion.Height -= 10;
                if (flowLayoutMenuAdministracion.Height <= 59)
                {
                    menuTransicionAdministracion.Stop();
                    menuExpanAdministracion = false;
                }
            }
        }


        private void BTNListadoActividades_Click(object sender, EventArgs e)
        {
            ListadoActividades formulario = new ListadoActividades();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(formulario);
            panelFormularios.Tag = formulario;
            cargarActividades(formulario);
            formulario.BringToFront();
            formulario.Show();
        }

        private void cargarActividades(ListadoActividades formulario)
        {
            String nombreMonitor;
            List<ActividadDTO> listaActividades = new Negocio.Managment.ActividadManagment().ObtenerActividades();

            foreach (var actividad in listaActividades)
            {
                ActividadPestaña aP = new ActividadPestaña();

                aP.actividadDto = actividad;
                aP.LBLDondeVaNombreActividad.Text = actividad.Nombre;
                nombreMonitor = new Negocio.Managment.UsuarioManagment().sacarNombreApellidosDeUsuario(actividad.DNI_Monitor);
                aP.LBLDonveVaNombreMonitor.Text = nombreMonitor;

                formulario.contenedorActividades.Controls.Add(aP);
            }
        }

        private void BTNRegistrarMonitor_Click(object sender, EventArgs e)
        {
            RegistroMonitor registroMonitor = new RegistroMonitor();
            registroMonitor.TopLevel = false;
            registroMonitor.FormBorderStyle = FormBorderStyle.None;
            registroMonitor.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(registroMonitor);
            panelFormularios.Tag =registroMonitor;
            registroMonitor.BringToFront();
            registroMonitor.Show();
        }

        private void BTNRegistrarActividad_Click(object sender, EventArgs e)
        {
            RegistrarActividad registrarActividad = new RegistrarActividad();
            registrarActividad.TopLevel = false;
            registrarActividad.FormBorderStyle = FormBorderStyle.None;
            registrarActividad.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(registrarActividad);
            panelFormularios.Tag = registrarActividad;
            registrarActividad.BringToFront();
            registrarActividad.Show();
        }

        private void btnTodasLasActividades_Click(object sender, EventArgs e)
        {
           InformeVerTodasLasActividades informeVerTodasLasActividades = new InformeVerTodasLasActividades();
            informeVerTodasLasActividades.TopLevel = false;
            informeVerTodasLasActividades.FormBorderStyle = FormBorderStyle.None;
            informeVerTodasLasActividades.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(informeVerTodasLasActividades);
            panelFormularios.Tag = informeVerTodasLasActividades;
            informeVerTodasLasActividades.BringToFront();
            informeVerTodasLasActividades.Show();
        }

        private void BTNVerTop5_Click_1(object sender, EventArgs e)
        {
            Top5Actividades top5Actividades = new Top5Actividades();
            top5Actividades.TopLevel = false;
            top5Actividades.FormBorderStyle = FormBorderStyle.None;
            top5Actividades.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(top5Actividades);
            panelFormularios.Tag = top5Actividades;
            top5Actividades.BringToFront();
            top5Actividades.Show();
        }
    }
}
