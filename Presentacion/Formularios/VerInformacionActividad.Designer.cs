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
            this.LBLNombreActvidad = new System.Windows.Forms.Label();
            this.LBLDescripcionActividad = new System.Windows.Forms.Label();
            this.LBLNombreMonitor = new System.Windows.Forms.Label();
            this.BTNApuntarseActividad = new System.Windows.Forms.Button();
            this.LBLDondeVaNombreActividad = new System.Windows.Forms.Label();
            this.LBLDondeVaElNombreMonitor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLNombreActvidad
            // 
            this.LBLNombreActvidad.AutoSize = true;
            this.LBLNombreActvidad.Location = new System.Drawing.Point(96, 45);
            this.LBLNombreActvidad.Name = "LBLNombreActvidad";
            this.LBLNombreActvidad.Size = new System.Drawing.Size(90, 13);
            this.LBLNombreActvidad.TabIndex = 0;
            this.LBLNombreActvidad.Text = "Nombre actividad";
            // 
            // LBLDescripcionActividad
            // 
            this.LBLDescripcionActividad.AutoSize = true;
            this.LBLDescripcionActividad.Location = new System.Drawing.Point(86, 109);
            this.LBLDescripcionActividad.Name = "LBLDescripcionActividad";
            this.LBLDescripcionActividad.Size = new System.Drawing.Size(109, 13);
            this.LBLDescripcionActividad.TabIndex = 1;
            this.LBLDescripcionActividad.Text = "Descripción actividad";
            // 
            // LBLNombreMonitor
            // 
            this.LBLNombreMonitor.AutoSize = true;
            this.LBLNombreMonitor.Location = new System.Drawing.Point(99, 191);
            this.LBLNombreMonitor.Name = "LBLNombreMonitor";
            this.LBLNombreMonitor.Size = new System.Drawing.Size(81, 13);
            this.LBLNombreMonitor.TabIndex = 2;
            this.LBLNombreMonitor.Text = "Nombre monitor";
            // 
            // BTNApuntarseActividad
            // 
            this.BTNApuntarseActividad.Location = new System.Drawing.Point(102, 275);
            this.BTNApuntarseActividad.Name = "BTNApuntarseActividad";
            this.BTNApuntarseActividad.Size = new System.Drawing.Size(75, 23);
            this.BTNApuntarseActividad.TabIndex = 3;
            this.BTNApuntarseActividad.Text = "Apuntarse";
            this.BTNApuntarseActividad.UseVisualStyleBackColor = true;
            // 
            // LBLDondeVaNombreActividad
            // 
            this.LBLDondeVaNombreActividad.AutoSize = true;
            this.LBLDondeVaNombreActividad.Location = new System.Drawing.Point(123, 68);
            this.LBLDondeVaNombreActividad.Name = "LBLDondeVaNombreActividad";
            this.LBLDondeVaNombreActividad.Size = new System.Drawing.Size(35, 13);
            this.LBLDondeVaNombreActividad.TabIndex = 4;
            this.LBLDondeVaNombreActividad.Text = "label1";
            // 
            // LBLDondeVaElNombreMonitor
            // 
            this.LBLDondeVaElNombreMonitor.AutoSize = true;
            this.LBLDondeVaElNombreMonitor.Location = new System.Drawing.Point(123, 214);
            this.LBLDondeVaElNombreMonitor.Name = "LBLDondeVaElNombreMonitor";
            this.LBLDondeVaElNombreMonitor.Size = new System.Drawing.Size(35, 13);
            this.LBLDondeVaElNombreMonitor.TabIndex = 5;
            this.LBLDondeVaElNombreMonitor.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // VerInformacionActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLDondeVaElNombreMonitor);
            this.Controls.Add(this.LBLDondeVaNombreActividad);
            this.Controls.Add(this.BTNApuntarseActividad);
            this.Controls.Add(this.LBLNombreMonitor);
            this.Controls.Add(this.LBLDescripcionActividad);
            this.Controls.Add(this.LBLNombreActvidad);
            this.Name = "VerInformacionActividad";
            this.Text = "VerInformacionActividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNombreActvidad;
        private System.Windows.Forms.Label LBLDescripcionActividad;
        private System.Windows.Forms.Label LBLNombreMonitor;
        private System.Windows.Forms.Button BTNApuntarseActividad;
        private System.Windows.Forms.Label LBLDondeVaNombreActividad;
        private System.Windows.Forms.Label LBLDondeVaElNombreMonitor;
        private System.Windows.Forms.Label label1;
    }
}