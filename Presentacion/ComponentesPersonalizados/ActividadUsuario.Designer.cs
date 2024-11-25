namespace Presentacion.ComponentesPersonalizados
{
    partial class ActividadUsuario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBLIndicadorNombreActividad = new System.Windows.Forms.Label();
            this.LBLDondeVaNombreActividad = new System.Windows.Forms.Label();
            this.LBLIndicadorNombreMonitor = new System.Windows.Forms.Label();
            this.LBLDonveVaNombreMonitor = new System.Windows.Forms.Label();
            this.panelContenedorInfo = new System.Windows.Forms.Panel();
            this.panelContenedorInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLIndicadorNombreActividad
            // 
            this.LBLIndicadorNombreActividad.AutoSize = true;
            this.LBLIndicadorNombreActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLIndicadorNombreActividad.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLIndicadorNombreActividad.Location = new System.Drawing.Point(16, 17);
            this.LBLIndicadorNombreActividad.Name = "LBLIndicadorNombreActividad";
            this.LBLIndicadorNombreActividad.Size = new System.Drawing.Size(110, 13);
            this.LBLIndicadorNombreActividad.TabIndex = 2;
            this.LBLIndicadorNombreActividad.Text = "Nombre actividad:";
            // 
            // LBLDondeVaNombreActividad
            // 
            this.LBLDondeVaNombreActividad.AutoSize = true;
            this.LBLDondeVaNombreActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDondeVaNombreActividad.ForeColor = System.Drawing.Color.White;
            this.LBLDondeVaNombreActividad.Location = new System.Drawing.Point(45, 40);
            this.LBLDondeVaNombreActividad.Name = "LBLDondeVaNombreActividad";
            this.LBLDondeVaNombreActividad.Size = new System.Drawing.Size(41, 13);
            this.LBLDondeVaNombreActividad.TabIndex = 3;
            this.LBLDondeVaNombreActividad.Text = "label2";
            // 
            // LBLIndicadorNombreMonitor
            // 
            this.LBLIndicadorNombreMonitor.AutoSize = true;
            this.LBLIndicadorNombreMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLIndicadorNombreMonitor.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLIndicadorNombreMonitor.Location = new System.Drawing.Point(16, 71);
            this.LBLIndicadorNombreMonitor.Name = "LBLIndicadorNombreMonitor";
            this.LBLIndicadorNombreMonitor.Size = new System.Drawing.Size(108, 13);
            this.LBLIndicadorNombreMonitor.TabIndex = 4;
            this.LBLIndicadorNombreMonitor.Text = "Monitor asignado:";
            // 
            // LBLDonveVaNombreMonitor
            // 
            this.LBLDonveVaNombreMonitor.AutoSize = true;
            this.LBLDonveVaNombreMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDonveVaNombreMonitor.ForeColor = System.Drawing.Color.White;
            this.LBLDonveVaNombreMonitor.Location = new System.Drawing.Point(45, 94);
            this.LBLDonveVaNombreMonitor.Name = "LBLDonveVaNombreMonitor";
            this.LBLDonveVaNombreMonitor.Size = new System.Drawing.Size(41, 13);
            this.LBLDonveVaNombreMonitor.TabIndex = 5;
            this.LBLDonveVaNombreMonitor.Text = "label4";
            // 
            // panelContenedorInfo
            // 
            this.panelContenedorInfo.Controls.Add(this.LBLIndicadorNombreActividad);
            this.panelContenedorInfo.Controls.Add(this.LBLDondeVaNombreActividad);
            this.panelContenedorInfo.Controls.Add(this.LBLIndicadorNombreMonitor);
            this.panelContenedorInfo.Controls.Add(this.LBLDonveVaNombreMonitor);
            this.panelContenedorInfo.Location = new System.Drawing.Point(3, 6);
            this.panelContenedorInfo.Name = "panelContenedorInfo";
            this.panelContenedorInfo.Size = new System.Drawing.Size(147, 144);
            this.panelContenedorInfo.TabIndex = 6;
            this.panelContenedorInfo.Click += new System.EventHandler(this.panelContenedorInfo_Click);
            // 
            // ActividadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.panelContenedorInfo);
            this.Name = "ActividadUsuario";
            this.panelContenedorInfo.ResumeLayout(false);
            this.panelContenedorInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LBLIndicadorNombreActividad;
        public System.Windows.Forms.Label LBLDondeVaNombreActividad;
        public System.Windows.Forms.Label LBLIndicadorNombreMonitor;
        public System.Windows.Forms.Label LBLDonveVaNombreMonitor;
        private System.Windows.Forms.Panel panelContenedorInfo;
    }
}
