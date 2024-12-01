using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    partial class VerInformacionActividad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.LBLNombreActvidad = new System.Windows.Forms.Label();
            this.LBLDondeVaNombreActividad = new System.Windows.Forms.Label();
            this.LBLDescripcionActividad = new System.Windows.Forms.Label();
            this.LBLDondeVaLaDescripcion = new System.Windows.Forms.Label();
            this.LBLNombreMonitor = new System.Windows.Forms.Label();
            this.LBLDondeVaElNombreMonitor = new System.Windows.Forms.Label();
            this.BTNApuntarseActividad = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelContenedor.Controls.Add(this.LBLNombreActvidad);
            this.panelContenedor.Controls.Add(this.LBLDondeVaNombreActividad);
            this.panelContenedor.Controls.Add(this.LBLDescripcionActividad);
            this.panelContenedor.Controls.Add(this.LBLDondeVaLaDescripcion);
            this.panelContenedor.Controls.Add(this.LBLNombreMonitor);
            this.panelContenedor.Controls.Add(this.LBLDondeVaElNombreMonitor);
            this.panelContenedor.Controls.Add(this.BTNApuntarseActividad);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(315, 423);
            this.panelContenedor.TabIndex = 0;
            // 
            // LBLNombreActvidad
            // 
            this.LBLNombreActvidad.AutoSize = true;
            this.LBLNombreActvidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNombreActvidad.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLNombreActvidad.Location = new System.Drawing.Point(84, 46);
            this.LBLNombreActvidad.Name = "LBLNombreActvidad";
            this.LBLNombreActvidad.Size = new System.Drawing.Size(147, 20);
            this.LBLNombreActvidad.TabIndex = 0;
            this.LBLNombreActvidad.Text = "Nombre actividad";
            // 
            // LBLDondeVaNombreActividad
            // 
            this.LBLDondeVaNombreActividad.AutoSize = true;
            this.LBLDondeVaNombreActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDondeVaNombreActividad.ForeColor = System.Drawing.Color.White;
            this.LBLDondeVaNombreActividad.Location = new System.Drawing.Point(144, 80);
            this.LBLDondeVaNombreActividad.Name = "LBLDondeVaNombreActividad";
            this.LBLDondeVaNombreActividad.Size = new System.Drawing.Size(52, 18);
            this.LBLDondeVaNombreActividad.TabIndex = 1;
            this.LBLDondeVaNombreActividad.Text = "label1";
            // 
            // LBLDescripcionActividad
            // 
            this.LBLDescripcionActividad.AutoSize = true;
            this.LBLDescripcionActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDescripcionActividad.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLDescripcionActividad.Location = new System.Drawing.Point(110, 117);
            this.LBLDescripcionActividad.Name = "LBLDescripcionActividad";
            this.LBLDescripcionActividad.Size = new System.Drawing.Size(179, 20);
            this.LBLDescripcionActividad.TabIndex = 2;
            this.LBLDescripcionActividad.Text = "Descripción actividad";
            // 
            // LBLDondeVaLaDescripcion
            // 
            this.LBLDondeVaLaDescripcion.AutoSize = true;
            this.LBLDondeVaLaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDondeVaLaDescripcion.ForeColor = System.Drawing.Color.White;
            this.LBLDondeVaLaDescripcion.Location = new System.Drawing.Point(144, 157);
            this.LBLDondeVaLaDescripcion.Name = "LBLDondeVaLaDescripcion";
            this.LBLDondeVaLaDescripcion.Size = new System.Drawing.Size(52, 18);
            this.LBLDondeVaLaDescripcion.TabIndex = 3;
            this.LBLDondeVaLaDescripcion.Text = "label1";
            // 
            // LBLNombreMonitor
            // 
            this.LBLNombreMonitor.AutoSize = true;
            this.LBLNombreMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNombreMonitor.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLNombreMonitor.Location = new System.Drawing.Point(120, 191);
            this.LBLNombreMonitor.Name = "LBLNombreMonitor";
            this.LBLNombreMonitor.Size = new System.Drawing.Size(136, 20);
            this.LBLNombreMonitor.TabIndex = 4;
            this.LBLNombreMonitor.Text = "Nombre monitor";
            // 
            // LBLDondeVaElNombreMonitor
            // 
            this.LBLDondeVaElNombreMonitor.AutoSize = true;
            this.LBLDondeVaElNombreMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDondeVaElNombreMonitor.ForeColor = System.Drawing.Color.White;
            this.LBLDondeVaElNombreMonitor.Location = new System.Drawing.Point(144, 226);
            this.LBLDondeVaElNombreMonitor.Name = "LBLDondeVaElNombreMonitor";
            this.LBLDondeVaElNombreMonitor.Size = new System.Drawing.Size(52, 18);
            this.LBLDondeVaElNombreMonitor.TabIndex = 5;
            this.LBLDondeVaElNombreMonitor.Text = "label1";
            // 
            // BTNApuntarseActividad
            // 
            this.BTNApuntarseActividad.Location = new System.Drawing.Point(88, 267);
            this.BTNApuntarseActividad.Name = "BTNApuntarseActividad";
            this.BTNApuntarseActividad.Size = new System.Drawing.Size(143, 50);
            this.BTNApuntarseActividad.TabIndex = 6;
            this.BTNApuntarseActividad.Text = "Apuntarse";
            this.BTNApuntarseActividad.Click += new System.EventHandler(this.BTNApuntarseActividad_Click);
            // 
            // VerInformacionActividad
            // 
            this.ClientSize = new System.Drawing.Size(315, 423);
            this.Controls.Add(this.panelContenedor);
            this.MaximumSize = new System.Drawing.Size(331, 462);
            this.MinimumSize = new System.Drawing.Size(331, 462);
            this.Name = "VerInformacionActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información Actividad";
            this.Load += new System.EventHandler(this.VerInformacionActividad_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label LBLNombreActvidad;
        private System.Windows.Forms.Label LBLDondeVaNombreActividad;
        private System.Windows.Forms.Label LBLDescripcionActividad;
        private System.Windows.Forms.Label LBLDondeVaLaDescripcion;
        private System.Windows.Forms.Label LBLNombreMonitor;
        private System.Windows.Forms.Label LBLDondeVaElNombreMonitor;
        private System.Windows.Forms.Button BTNApuntarseActividad;
    }
}
