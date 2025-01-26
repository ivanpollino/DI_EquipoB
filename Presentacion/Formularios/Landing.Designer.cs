using System.Windows.Forms;

namespace Presentacion
{
    partial class Landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNVerActividades = new System.Windows.Forms.Button();
            this.panelParaUsuarios = new System.Windows.Forms.Panel();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.BTNCerrarSesionUsuario = new System.Windows.Forms.Button();
            this.panelAdministrador = new System.Windows.Forms.Panel();
            this.BTNMisFacturas = new System.Windows.Forms.Button();
            this.BTNCerrarSesionAdmin = new System.Windows.Forms.Button();
            this.BTNOpcionesAdministrador = new System.Windows.Forms.Button();
            this.lbTexto2 = new System.Windows.Forms.Label();
            this.lbTexto1 = new System.Windows.Forms.Label();
            this.lbLinkLogin = new System.Windows.Forms.LinkLabel();
            this.btRegistro = new System.Windows.Forms.Button();
            this.lbInfoUsuario = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelParaUsuarios.SuspendLayout();
            this.panelAdministrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BTNVerActividades);
            this.panel1.Controls.Add(this.panelParaUsuarios);
            this.panel1.Controls.Add(this.panelAdministrador);
            this.panel1.Controls.Add(this.lbTexto2);
            this.panel1.Controls.Add(this.lbTexto1);
            this.panel1.Controls.Add(this.lbLinkLogin);
            this.panel1.Controls.Add(this.btRegistro);
            this.panel1.Controls.Add(this.lbInfoUsuario);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 641);
            this.panel1.TabIndex = 4;
            // 
            // BTNVerActividades
            // 
            this.BTNVerActividades.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVerActividades.ForeColor = System.Drawing.Color.Black;
            this.BTNVerActividades.Location = new System.Drawing.Point(346, 359);
            this.BTNVerActividades.Name = "BTNVerActividades";
            this.BTNVerActividades.Size = new System.Drawing.Size(164, 30);
            this.BTNVerActividades.TabIndex = 8;
            this.BTNVerActividades.Text = "ACTIVIDADES";
            this.BTNVerActividades.UseVisualStyleBackColor = true;
            this.BTNVerActividades.Visible = false;
            this.BTNVerActividades.Click += new System.EventHandler(this.BTNVerActividades_Click);
            // 
            // panelParaUsuarios
            // 
            this.panelParaUsuarios.Controls.Add(this.BTNMisFacturas);
            this.panelParaUsuarios.Controls.Add(this.btnEditarPerfil);
            this.panelParaUsuarios.Controls.Add(this.BTNCerrarSesionUsuario);
            this.panelParaUsuarios.Location = new System.Drawing.Point(780, 390);
            this.panelParaUsuarios.Name = "panelParaUsuarios";
            this.panelParaUsuarios.Size = new System.Drawing.Size(208, 194);
            this.panelParaUsuarios.TabIndex = 7;
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnEditarPerfil.FlatAppearance.BorderSize = 0;
            this.btnEditarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPerfil.ForeColor = System.Drawing.Color.Cyan;
            this.btnEditarPerfil.Image = global::Presentacion.Properties.Resources.user_solid_48;
            this.btnEditarPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPerfil.Location = new System.Drawing.Point(0, 0);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(208, 66);
            this.btnEditarPerfil.TabIndex = 9;
            this.btnEditarPerfil.Text = "Editar Perfil";
            this.btnEditarPerfil.UseVisualStyleBackColor = false;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // BTNCerrarSesionUsuario
            // 
            this.BTNCerrarSesionUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTNCerrarSesionUsuario.FlatAppearance.BorderSize = 0;
            this.BTNCerrarSesionUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCerrarSesionUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCerrarSesionUsuario.ForeColor = System.Drawing.Color.Cyan;
            this.BTNCerrarSesionUsuario.Image = global::Presentacion.Properties.Resources.logOut;
            this.BTNCerrarSesionUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCerrarSesionUsuario.Location = new System.Drawing.Point(0, 127);
            this.BTNCerrarSesionUsuario.Name = "BTNCerrarSesionUsuario";
            this.BTNCerrarSesionUsuario.Size = new System.Drawing.Size(208, 66);
            this.BTNCerrarSesionUsuario.TabIndex = 8;
            this.BTNCerrarSesionUsuario.Text = "Cerrar sesión";
            this.BTNCerrarSesionUsuario.UseVisualStyleBackColor = false;
            this.BTNCerrarSesionUsuario.Click += new System.EventHandler(this.BTNCerrarSesionUsuario_Click);
            // 
            // panelAdministrador
            // 
            this.panelAdministrador.BackColor = System.Drawing.Color.Black;
            this.panelAdministrador.Controls.Add(this.BTNCerrarSesionAdmin);
            this.panelAdministrador.Controls.Add(this.BTNOpcionesAdministrador);
            this.panelAdministrador.Location = new System.Drawing.Point(780, 174);
            this.panelAdministrador.Name = "panelAdministrador";
            this.panelAdministrador.Size = new System.Drawing.Size(208, 136);
            this.panelAdministrador.TabIndex = 6;
            // 
            // BTNMisFacturas
            // 
            this.BTNMisFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTNMisFacturas.FlatAppearance.BorderSize = 0;
            this.BTNMisFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMisFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMisFacturas.ForeColor = System.Drawing.Color.Cyan;
            this.BTNMisFacturas.Image = global::Presentacion.Properties.Resources.euro_regular_48;
            this.BTNMisFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMisFacturas.Location = new System.Drawing.Point(0, 62);
            this.BTNMisFacturas.Name = "BTNMisFacturas";
            this.BTNMisFacturas.Size = new System.Drawing.Size(208, 68);
            this.BTNMisFacturas.TabIndex = 2;
            this.BTNMisFacturas.Text = "Mis Facturas";
            this.BTNMisFacturas.UseVisualStyleBackColor = false;
            this.BTNMisFacturas.Click += new System.EventHandler(this.BTNMisFacturas_Click);
            // 
            // BTNCerrarSesionAdmin
            // 
            this.BTNCerrarSesionAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTNCerrarSesionAdmin.FlatAppearance.BorderSize = 0;
            this.BTNCerrarSesionAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCerrarSesionAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCerrarSesionAdmin.ForeColor = System.Drawing.Color.Cyan;
            this.BTNCerrarSesionAdmin.Image = global::Presentacion.Properties.Resources.logOut;
            this.BTNCerrarSesionAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCerrarSesionAdmin.Location = new System.Drawing.Point(0, 66);
            this.BTNCerrarSesionAdmin.Name = "BTNCerrarSesionAdmin";
            this.BTNCerrarSesionAdmin.Size = new System.Drawing.Size(208, 68);
            this.BTNCerrarSesionAdmin.TabIndex = 1;
            this.BTNCerrarSesionAdmin.Text = "Cerrar sesión";
            this.BTNCerrarSesionAdmin.UseVisualStyleBackColor = false;
            this.BTNCerrarSesionAdmin.Click += new System.EventHandler(this.BTNCerrarSesionAdmin_Click);
            // 
            // BTNOpcionesAdministrador
            // 
            this.BTNOpcionesAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BTNOpcionesAdministrador.FlatAppearance.BorderSize = 0;
            this.BTNOpcionesAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNOpcionesAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNOpcionesAdministrador.ForeColor = System.Drawing.Color.Cyan;
            this.BTNOpcionesAdministrador.Image = global::Presentacion.Properties.Resources.Services;
            this.BTNOpcionesAdministrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNOpcionesAdministrador.Location = new System.Drawing.Point(0, 0);
            this.BTNOpcionesAdministrador.Name = "BTNOpcionesAdministrador";
            this.BTNOpcionesAdministrador.Size = new System.Drawing.Size(208, 66);
            this.BTNOpcionesAdministrador.TabIndex = 0;
            this.BTNOpcionesAdministrador.Text = "              Panel de Administración";
            this.BTNOpcionesAdministrador.UseVisualStyleBackColor = false;
            this.BTNOpcionesAdministrador.Click += new System.EventHandler(this.BTNOpcionesAdministrador_Click);
            // 
            // lbTexto2
            // 
            this.lbTexto2.AutoSize = true;
            this.lbTexto2.BackColor = System.Drawing.Color.Transparent;
            this.lbTexto2.Font = new System.Drawing.Font("Segoe UI Black", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbTexto2.ForeColor = System.Drawing.Color.Black;
            this.lbTexto2.Location = new System.Drawing.Point(188, 193);
            this.lbTexto2.Name = "lbTexto2";
            this.lbTexto2.Size = new System.Drawing.Size(529, 106);
            this.lbTexto2.TabIndex = 5;
            this.lbTexto2.Text = "                      ";
            this.lbTexto2.Paint += new System.Windows.Forms.PaintEventHandler(this.lbTexto2_Paint);
            // 
            // lbTexto1
            // 
            this.lbTexto1.AutoSize = true;
            this.lbTexto1.BackColor = System.Drawing.Color.Transparent;
            this.lbTexto1.Font = new System.Drawing.Font("Segoe UI Black", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexto1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbTexto1.Location = new System.Drawing.Point(133, 119);
            this.lbTexto1.Name = "lbTexto1";
            this.lbTexto1.Size = new System.Drawing.Size(641, 86);
            this.lbTexto1.TabIndex = 4;
            this.lbTexto1.Text = "TU MÁXIMO NIVEL";
            // 
            // lbLinkLogin
            // 
            this.lbLinkLogin.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.lbLinkLogin.AutoSize = true;
            this.lbLinkLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLinkLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLinkLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinkLogin.ForeColor = System.Drawing.Color.Cyan;
            this.lbLinkLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbLinkLogin.LinkColor = System.Drawing.Color.DarkGray;
            this.lbLinkLogin.Location = new System.Drawing.Point(344, 37);
            this.lbLinkLogin.Name = "lbLinkLogin";
            this.lbLinkLogin.Size = new System.Drawing.Size(186, 25);
            this.lbLinkLogin.TabIndex = 1;
            this.lbLinkLogin.TabStop = true;
            this.lbLinkLogin.Text = "━━━━   LOGIN   ━━━━";
            this.lbLinkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLinkLogin_LinkClicked);
            // 
            // btRegistro
            // 
            this.btRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btRegistro.ForeColor = System.Drawing.Color.Black;
            this.btRegistro.Location = new System.Drawing.Point(346, 379);
            this.btRegistro.Name = "btRegistro";
            this.btRegistro.Size = new System.Drawing.Size(164, 30);
            this.btRegistro.TabIndex = 3;
            this.btRegistro.Text = "REGISTRO";
            this.btRegistro.UseVisualStyleBackColor = true;
            this.btRegistro.Click += new System.EventHandler(this.btRegistro_Click);
            // 
            // lbInfoUsuario
            // 
            this.lbInfoUsuario.AutoSize = true;
            this.lbInfoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbInfoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbInfoUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.lbInfoUsuario.Location = new System.Drawing.Point(391, 29);
            this.lbInfoUsuario.Name = "lbInfoUsuario";
            this.lbInfoUsuario.Size = new System.Drawing.Size(81, 30);
            this.lbInfoUsuario.TabIndex = 0;
            this.lbInfoUsuario.Text = "usuario";
            this.lbInfoUsuario.Click += new System.EventHandler(this.lbInfoUsuario_Click);
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.Black;
            this.btLogin.Location = new System.Drawing.Point(346, 340);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(164, 30);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "LOGIN";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 641);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Landing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Landing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Landing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelParaUsuarios.ResumeLayout(false);
            this.panelAdministrador.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbInfoUsuario;
        private System.Windows.Forms.LinkLabel lbLinkLogin;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTexto1;
        private System.Windows.Forms.Label lbTexto2;
        private Panel panelAdministrador;
        private Button BTNOpcionesAdministrador;
        private Button BTNCerrarSesionAdmin;
        private Button BTNCerrarSesionUsuario;
        private Panel panelParaUsuarios;
        private Button BTNVerActividades;
        private Button btnEditarPerfil;
        private Button BTNMisFacturas;
    }
}