﻿namespace Formularios.Formularios
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
            this.lbInfoUsuario = new System.Windows.Forms.Label();
            this.lbLinkLogin = new System.Windows.Forms.LinkLabel();
            this.btLogin = new System.Windows.Forms.Button();
            this.btRegistro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTexto1 = new System.Windows.Forms.Label();
            this.lbTexto2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInfoUsuario
            // 
            this.lbInfoUsuario.AutoSize = true;
            this.lbInfoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbInfoUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoUsuario.ForeColor = System.Drawing.Color.White;
            this.lbInfoUsuario.Location = new System.Drawing.Point(376, 9);
            this.lbInfoUsuario.Name = "lbInfoUsuario";
            this.lbInfoUsuario.Size = new System.Drawing.Size(81, 30);
            this.lbInfoUsuario.TabIndex = 0;
            this.lbInfoUsuario.Text = "usuario";
            // 
            // lbLinkLogin
            // 
            this.lbLinkLogin.AutoSize = true;
            this.lbLinkLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLinkLogin.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinkLogin.LinkColor = System.Drawing.Color.SlateGray;
            this.lbLinkLogin.Location = new System.Drawing.Point(387, 17);
            this.lbLinkLogin.Name = "lbLinkLogin";
            this.lbLinkLogin.Size = new System.Drawing.Size(50, 20);
            this.lbLinkLogin.TabIndex = 1;
            this.lbLinkLogin.TabStop = true;
            this.lbLinkLogin.Text = "LOGIN";
            this.lbLinkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLinkLogin_LinkClicked);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(358, 329);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(121, 23);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login de Usuario";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btRegistro
            // 
            this.btRegistro.Location = new System.Drawing.Point(358, 358);
            this.btRegistro.Name = "btRegistro";
            this.btRegistro.Size = new System.Drawing.Size(121, 23);
            this.btRegistro.TabIndex = 3;
            this.btRegistro.Text = "Registro de Usuario";
            this.btRegistro.UseVisualStyleBackColor = true;
            this.btRegistro.Click += new System.EventHandler(this.btRegistro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = global::Formularios.Properties.Resources.img_gym;
            this.panel1.Controls.Add(this.lbTexto2);
            this.panel1.Controls.Add(this.lbTexto1);
            this.panel1.Controls.Add(this.lbLinkLogin);
            this.panel1.Controls.Add(this.btRegistro);
            this.panel1.Controls.Add(this.lbInfoUsuario);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 461);
            this.panel1.TabIndex = 4;
            // 
            // lbTexto1
            // 
            this.lbTexto1.AutoSize = true;
            this.lbTexto1.BackColor = System.Drawing.Color.Transparent;
            this.lbTexto1.Font = new System.Drawing.Font("Segoe UI Black", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexto1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbTexto1.Location = new System.Drawing.Point(110, 102);
            this.lbTexto1.Name = "lbTexto1";
            this.lbTexto1.Size = new System.Drawing.Size(641, 86);
            this.lbTexto1.TabIndex = 4;
            this.lbTexto1.Text = "TU MÁXIMO NIVEL";
            this.lbTexto1.Click += new System.EventHandler(this.lbTexto1_Click);
            // 
            // lbTexto2
            // 
            this.lbTexto2.AutoSize = true;
            this.lbTexto2.BackColor = System.Drawing.Color.Transparent;
            this.lbTexto2.Font = new System.Drawing.Font("Segoe UI Black", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbTexto2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbTexto2.Location = new System.Drawing.Point(234, 188);
            this.lbTexto2.Name = "lbTexto2";
            this.lbTexto2.Size = new System.Drawing.Size(393, 86);
            this.lbTexto2.TabIndex = 5;
            this.lbTexto2.Text = "ES POSIBLE";
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Landing";
            this.Text = "Landing";
            this.Load += new System.EventHandler(this.Landing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}