namespace Presentacion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button BTNAdminitracion;
            this.flowLayoutGestionActividades = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNGestionActividades = new System.Windows.Forms.Button();
            this.BTNRegistrarActividad = new System.Windows.Forms.Button();
            this.BTNListadoActividades = new System.Windows.Forms.Button();
            this.flowLayoutGestioMonitores = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNGestionarMonitores = new System.Windows.Forms.Button();
            this.BTNRegistrarMonitor = new System.Windows.Forms.Button();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.menuTransicion = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutMenuAdministracion = new System.Windows.Forms.FlowLayoutPanel();
            this.menuTransacionActividades = new System.Windows.Forms.Timer(this.components);
            this.menuTransicionAdministracion = new System.Windows.Forms.Timer(this.components);
            BTNAdminitracion = new System.Windows.Forms.Button();
            this.flowLayoutGestionActividades.SuspendLayout();
            this.flowLayoutGestioMonitores.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutMenuAdministracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNAdminitracion
            // 
            BTNAdminitracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            BTNAdminitracion.FlatAppearance.BorderSize = 0;
            BTNAdminitracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BTNAdminitracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BTNAdminitracion.ForeColor = System.Drawing.Color.Cyan;
            BTNAdminitracion.Image = global::Presentacion.Properties.Resources.Services;
            BTNAdminitracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            BTNAdminitracion.Location = new System.Drawing.Point(3, 3);
            BTNAdminitracion.Name = "BTNAdminitracion";
            BTNAdminitracion.Size = new System.Drawing.Size(276, 50);
            BTNAdminitracion.TabIndex = 0;
            BTNAdminitracion.Text = "ADMINISTRACIÓN";
            BTNAdminitracion.UseVisualStyleBackColor = false;
            BTNAdminitracion.Click += new System.EventHandler(this.BTNAdminitracion_Click);
            // 
            // flowLayoutGestionActividades
            // 
            this.flowLayoutGestionActividades.Controls.Add(this.BTNGestionActividades);
            this.flowLayoutGestionActividades.Controls.Add(this.BTNRegistrarActividad);
            this.flowLayoutGestionActividades.Controls.Add(this.BTNListadoActividades);
            this.flowLayoutGestionActividades.Location = new System.Drawing.Point(3, 122);
            this.flowLayoutGestionActividades.Name = "flowLayoutGestionActividades";
            this.flowLayoutGestionActividades.Size = new System.Drawing.Size(283, 56);
            this.flowLayoutGestionActividades.TabIndex = 4;
            // 
            // BTNGestionActividades
            // 
            this.BTNGestionActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTNGestionActividades.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNGestionActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGestionActividades.ForeColor = System.Drawing.Color.White;
            this.BTNGestionActividades.Image = global::Presentacion.Properties.Resources.Actividades;
            this.BTNGestionActividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGestionActividades.Location = new System.Drawing.Point(3, 3);
            this.BTNGestionActividades.Name = "BTNGestionActividades";
            this.BTNGestionActividades.Size = new System.Drawing.Size(273, 50);
            this.BTNGestionActividades.TabIndex = 0;
            this.BTNGestionActividades.Text = "GESTION ACTIVIDADES";
            this.BTNGestionActividades.UseVisualStyleBackColor = false;
            this.BTNGestionActividades.Click += new System.EventHandler(this.BTNGestionActividades_Click);
            // 
            // BTNRegistrarActividad
            // 
            this.BTNRegistrarActividad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTNRegistrarActividad.ForeColor = System.Drawing.Color.White;
            this.BTNRegistrarActividad.Image = global::Presentacion.Properties.Resources.Añadir;
            this.BTNRegistrarActividad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNRegistrarActividad.Location = new System.Drawing.Point(3, 59);
            this.BTNRegistrarActividad.Name = "BTNRegistrarActividad";
            this.BTNRegistrarActividad.Size = new System.Drawing.Size(276, 50);
            this.BTNRegistrarActividad.TabIndex = 2;
            this.BTNRegistrarActividad.Text = "REGISTRAR ACTIVIDAD";
            this.BTNRegistrarActividad.UseVisualStyleBackColor = false;
            this.BTNRegistrarActividad.Click += new System.EventHandler(this.BTNRegistrarActividad_Click);
            // 
            // BTNListadoActividades
            // 
            this.BTNListadoActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTNListadoActividades.ForeColor = System.Drawing.Color.White;
            this.BTNListadoActividades.Image = global::Presentacion.Properties.Resources.listado;
            this.BTNListadoActividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNListadoActividades.Location = new System.Drawing.Point(3, 115);
            this.BTNListadoActividades.Name = "BTNListadoActividades";
            this.BTNListadoActividades.Size = new System.Drawing.Size(276, 50);
            this.BTNListadoActividades.TabIndex = 2;
            this.BTNListadoActividades.Text = "LISTADO ACTIVIDADES";
            this.BTNListadoActividades.UseVisualStyleBackColor = false;
            this.BTNListadoActividades.Click += new System.EventHandler(this.BTNListadoActividades_Click);
            // 
            // flowLayoutGestioMonitores
            // 
            this.flowLayoutGestioMonitores.Controls.Add(this.BTNGestionarMonitores);
            this.flowLayoutGestioMonitores.Controls.Add(this.BTNRegistrarMonitor);
            this.flowLayoutGestioMonitores.Location = new System.Drawing.Point(3, 59);
            this.flowLayoutGestioMonitores.Name = "flowLayoutGestioMonitores";
            this.flowLayoutGestioMonitores.Size = new System.Drawing.Size(279, 57);
            this.flowLayoutGestioMonitores.TabIndex = 3;
            // 
            // BTNGestionarMonitores
            // 
            this.BTNGestionarMonitores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTNGestionarMonitores.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNGestionarMonitores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGestionarMonitores.ForeColor = System.Drawing.Color.White;
            this.BTNGestionarMonitores.Image = global::Presentacion.Properties.Resources.Monitor;
            this.BTNGestionarMonitores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGestionarMonitores.Location = new System.Drawing.Point(3, 3);
            this.BTNGestionarMonitores.Name = "BTNGestionarMonitores";
            this.BTNGestionarMonitores.Size = new System.Drawing.Size(273, 49);
            this.BTNGestionarMonitores.TabIndex = 0;
            this.BTNGestionarMonitores.Text = "GESTION MONITORES";
            this.BTNGestionarMonitores.UseVisualStyleBackColor = false;
            this.BTNGestionarMonitores.Click += new System.EventHandler(this.BTNGestionarMonitores_Click);
            // 
            // BTNRegistrarMonitor
            // 
            this.BTNRegistrarMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTNRegistrarMonitor.ForeColor = System.Drawing.Color.White;
            this.BTNRegistrarMonitor.Image = global::Presentacion.Properties.Resources.Añadir;
            this.BTNRegistrarMonitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNRegistrarMonitor.Location = new System.Drawing.Point(3, 58);
            this.BTNRegistrarMonitor.Name = "BTNRegistrarMonitor";
            this.BTNRegistrarMonitor.Size = new System.Drawing.Size(276, 49);
            this.BTNRegistrarMonitor.TabIndex = 0;
            this.BTNRegistrarMonitor.Text = "REGISTRAR MONITOR";
            this.BTNRegistrarMonitor.UseVisualStyleBackColor = false;
            this.BTNRegistrarMonitor.Click += new System.EventHandler(this.BTNRegistrarMonitor_Click);
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panelFormularios.Location = new System.Drawing.Point(288, 0);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(897, 610);
            this.panelFormularios.TabIndex = 1;
            // 
            // menuTransicion
            // 
            this.menuTransicion.Interval = 10;
            this.menuTransicion.Tick += new System.EventHandler(this.menuTransicion_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutMenuAdministracion);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(289, 610);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutMenuAdministracion
            // 
            this.flowLayoutMenuAdministracion.Controls.Add(BTNAdminitracion);
            this.flowLayoutMenuAdministracion.Controls.Add(this.flowLayoutGestioMonitores);
            this.flowLayoutMenuAdministracion.Controls.Add(this.flowLayoutGestionActividades);
            this.flowLayoutMenuAdministracion.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutMenuAdministracion.Name = "flowLayoutMenuAdministracion";
            this.flowLayoutMenuAdministracion.Size = new System.Drawing.Size(279, 57);
            this.flowLayoutMenuAdministracion.TabIndex = 5;
            // 
            // menuTransacionActividades
            // 
            this.menuTransacionActividades.Interval = 10;
            this.menuTransacionActividades.Tick += new System.EventHandler(this.menuTransacionActividades_Tick);
            // 
            // menuTransicionAdministracion
            // 
            this.menuTransicionAdministracion.Interval = 6;
            this.menuTransicionAdministracion.Tick += new System.EventHandler(this.menuTransicionAdministracion_Tick);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelFormularios);
            this.Name = "Administracion";
            this.Text = " bb";
            this.flowLayoutGestionActividades.ResumeLayout(false);
            this.flowLayoutGestioMonitores.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutMenuAdministracion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Button BTNGestionarMonitores;
        private System.Windows.Forms.Button BTNGestionActividades;
        private System.Windows.Forms.Button BTNRegistrarMonitor;
        private System.Windows.Forms.Button BTNListadoActividades;
        private System.Windows.Forms.Button BTNRegistrarActividad;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutGestioMonitores;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutGestionActividades;
        private System.Windows.Forms.Timer menuTransicion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer menuTransacionActividades;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMenuAdministracion;
        private System.Windows.Forms.Timer menuTransicionAdministracion;
    }
}