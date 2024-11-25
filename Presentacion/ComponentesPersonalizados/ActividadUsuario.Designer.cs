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
            this.SuspendLayout();
            // 
            // LBLIndicadorNombreActividad
            // 
            this.LBLIndicadorNombreActividad.AutoSize = true;
            this.LBLIndicadorNombreActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLIndicadorNombreActividad.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLIndicadorNombreActividad.Location = new System.Drawing.Point(3, 10);
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
            this.LBLDondeVaNombreActividad.Location = new System.Drawing.Point(3, 32);
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
            this.LBLIndicadorNombreMonitor.Location = new System.Drawing.Point(5, 54);
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
            this.LBLDonveVaNombreMonitor.Location = new System.Drawing.Point(5, 76);
            this.LBLDonveVaNombreMonitor.Name = "LBLDonveVaNombreMonitor";
            this.LBLDonveVaNombreMonitor.Size = new System.Drawing.Size(41, 13);
            this.LBLDonveVaNombreMonitor.TabIndex = 5;
            this.LBLDonveVaNombreMonitor.Text = "label4";
            // 
            // ActividadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.LBLDonveVaNombreMonitor);
            this.Controls.Add(this.LBLIndicadorNombreMonitor);
            this.Controls.Add(this.LBLDondeVaNombreActividad);
            this.Controls.Add(this.LBLIndicadorNombreActividad);
            this.Name = "ActividadUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LBLIndicadorNombreActividad;
        public System.Windows.Forms.Label LBLDondeVaNombreActividad;
        public System.Windows.Forms.Label LBLIndicadorNombreMonitor;
        public System.Windows.Forms.Label LBLDonveVaNombreMonitor;
    }
}
