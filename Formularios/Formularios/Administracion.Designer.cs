namespace Formularios.Formularios
{
    partial class Administracion
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
            System.Windows.Forms.Button BTNAdminitracion;
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNGestionarMonitores = new System.Windows.Forms.Button();
            this.BTNGestionActividades = new System.Windows.Forms.Button();
            BTNAdminitracion = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(BTNAdminitracion);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(281, 610);
            this.panelMenu.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panelFormularios.Location = new System.Drawing.Point(280, 0);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(905, 610);
            this.panelFormularios.TabIndex = 1;
            // 
            // BTNAdminitracion
            // 
            BTNAdminitracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            BTNAdminitracion.FlatAppearance.BorderSize = 0;
            BTNAdminitracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTNAdminitracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BTNAdminitracion.ForeColor = System.Drawing.Color.Cyan;
            BTNAdminitracion.Location = new System.Drawing.Point(0, 53);
            BTNAdminitracion.Name = "BTNAdminitracion";
            BTNAdminitracion.Size = new System.Drawing.Size(281, 50);
            BTNAdminitracion.TabIndex = 0;
            BTNAdminitracion.Text = "ADMINISTRACIÓN";
            BTNAdminitracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            BTNAdminitracion.UseVisualStyleBackColor = false;
            BTNAdminitracion.Click += new System.EventHandler(this.BTNAdminitracion_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTNGestionarMonitores);
            this.panel1.Controls.Add(this.BTNGestionActividades);
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 98);
            this.panel1.TabIndex = 0;
            // 
            // BTNGestionarMonitores
            // 
            this.BTNGestionarMonitores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTNGestionarMonitores.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNGestionarMonitores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGestionarMonitores.ForeColor = System.Drawing.Color.White;
            this.BTNGestionarMonitores.Location = new System.Drawing.Point(0, 0);
            this.BTNGestionarMonitores.Name = "BTNGestionarMonitores";
            this.BTNGestionarMonitores.Size = new System.Drawing.Size(279, 50);
            this.BTNGestionarMonitores.TabIndex = 0;
            this.BTNGestionarMonitores.Text = "GESTION MONITORES";
            this.BTNGestionarMonitores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGestionarMonitores.UseVisualStyleBackColor = false;
            // 
            // BTNGestionActividades
            // 
            this.BTNGestionActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTNGestionActividades.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNGestionActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGestionActividades.ForeColor = System.Drawing.Color.White;
            this.BTNGestionActividades.Location = new System.Drawing.Point(0, 48);
            this.BTNGestionActividades.Name = "BTNGestionActividades";
            this.BTNGestionActividades.Size = new System.Drawing.Size(279, 50);
            this.BTNGestionActividades.TabIndex = 0;
            this.BTNGestionActividades.Text = "GESTION ACTIVIDADES";
            this.BTNGestionActividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGestionActividades.UseVisualStyleBackColor = false;
            this.BTNGestionActividades.Click += new System.EventHandler(this.BTNGestionActividades_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panelMenu);
            this.Name = "Administracion";
            this.Text = "Administracion";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNGestionarMonitores;
        private System.Windows.Forms.Button BTNGestionActividades;
    }
}