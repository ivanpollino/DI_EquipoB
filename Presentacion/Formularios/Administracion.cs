﻿using System;
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
                if (flowLayoutGestioMonitores.Height <= 56)
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

        private void menuTransicionAdministracion_Tick(object sender, EventArgs e)
        {
            if (menuExpanAdministracion == false)
            {
                flowLayoutMenuAdministracion.Height += 10;
                if (flowLayoutMenuAdministracion.Height >= 350)
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

        private void flowLayoutMenuAdministracion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNListadoActividades_Click(object sender, EventArgs e)
        {
            ListadoActividades formulario = new ListadoActividades();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelFormularios.Controls.Add(formulario);
            panelFormularios.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }
    }
}