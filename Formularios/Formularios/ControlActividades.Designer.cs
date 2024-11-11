namespace Formularios.Formularios
{
    partial class ControlActividades
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
            this.LBLNombreActividad = new System.Windows.Forms.Label();
            this.w = new System.Windows.Forms.Label();
            this.imagenBorrarActividad = new System.Windows.Forms.PictureBox();
            this.LBLDondeVaElNombreActividad = new System.Windows.Forms.Label();
            this.LBLDondeVaElNombreMonitor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBorrarActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLNombreActividad
            // 
            this.LBLNombreActividad.AutoSize = true;
            this.LBLNombreActividad.Location = new System.Drawing.Point(17, 10);
            this.LBLNombreActividad.Name = "LBLNombreActividad";
            this.LBLNombreActividad.Size = new System.Drawing.Size(93, 13);
            this.LBLNombreActividad.TabIndex = 1;
            this.LBLNombreActividad.Text = "Nombre actividad:";
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Location = new System.Drawing.Point(18, 62);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(92, 13);
            this.w.TabIndex = 2;
            this.w.Text = "Monitor Asignado:";
            // 
            // imagenBorrarActividad
            // 
            this.imagenBorrarActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagenBorrarActividad.Image = global::Formularios.Properties.Resources.eliminar;
            this.imagenBorrarActividad.Location = new System.Drawing.Point(118, 122);
            this.imagenBorrarActividad.Name = "imagenBorrarActividad";
            this.imagenBorrarActividad.Size = new System.Drawing.Size(62, 69);
            this.imagenBorrarActividad.TabIndex = 3;
            this.imagenBorrarActividad.TabStop = false;
            this.imagenBorrarActividad.Click += new System.EventHandler(this.imagenBorrarActividad_Click);
            // 
            // LBLDondeVaElNombreActividad
            // 
            this.LBLDondeVaElNombreActividad.AutoSize = true;
            this.LBLDondeVaElNombreActividad.Location = new System.Drawing.Point(18, 34);
            this.LBLDondeVaElNombreActividad.Name = "LBLDondeVaElNombreActividad";
            this.LBLDondeVaElNombreActividad.Size = new System.Drawing.Size(35, 13);
            this.LBLDondeVaElNombreActividad.TabIndex = 4;
            this.LBLDondeVaElNombreActividad.Text = "label1";
            // 
            // LBLDondeVaElNombreMonitor
            // 
            this.LBLDondeVaElNombreMonitor.AutoSize = true;
            this.LBLDondeVaElNombreMonitor.Location = new System.Drawing.Point(18, 87);
            this.LBLDondeVaElNombreMonitor.Name = "LBLDondeVaElNombreMonitor";
            this.LBLDondeVaElNombreMonitor.Size = new System.Drawing.Size(35, 13);
            this.LBLDondeVaElNombreMonitor.TabIndex = 5;
            this.LBLDondeVaElNombreMonitor.Text = "label2";
            // 
            // ControlActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LBLDondeVaElNombreMonitor);
            this.Controls.Add(this.LBLDondeVaElNombreActividad);
            this.Controls.Add(this.imagenBorrarActividad);
            this.Controls.Add(this.w);
            this.Controls.Add(this.LBLNombreActividad);
            this.Name = "ControlActividades";
            this.Size = new System.Drawing.Size(183, 194);
            ((System.ComponentModel.ISupportInitialize)(this.imagenBorrarActividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBLNombreActividad;
        private System.Windows.Forms.Label w;
        private System.Windows.Forms.PictureBox imagenBorrarActividad;
        private System.Windows.Forms.Label LBLDondeVaElNombreActividad;
        private System.Windows.Forms.Label LBLDondeVaElNombreMonitor;
    }
}
