using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Presentacion
{
    partial class Login
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
            System.Windows.Forms.Panel panelDerecho;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LinkLoginLabel = new System.Windows.Forms.LinkLabel();
            this.BTNAlternarContrasena = new System.Windows.Forms.Button();
            this.TXTBPass = new System.Windows.Forms.TextBox();
            this.LBLPass = new System.Windows.Forms.Label();
            this.TXTBEmail = new System.Windows.Forms.TextBox();
            this.LBLEmail = new System.Windows.Forms.Label();
            this.LBLTitulo = new System.Windows.Forms.Label();
            this.BTNLogin = new System.Windows.Forms.Button();
            panelDerecho = new System.Windows.Forms.Panel();
            panelDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDerecho
            // 
            panelDerecho.BackColor = System.Drawing.Color.Transparent;
            panelDerecho.BackgroundImage = global::Presentacion.Properties.Resources.imagenFondoLogin;
            panelDerecho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panelDerecho.Controls.Add(this.BTNLogin);
            panelDerecho.Controls.Add(this.LinkLoginLabel);
            panelDerecho.Controls.Add(this.BTNAlternarContrasena);
            panelDerecho.Controls.Add(this.TXTBPass);
            panelDerecho.Controls.Add(this.LBLPass);
            panelDerecho.Controls.Add(this.TXTBEmail);
            panelDerecho.Controls.Add(this.LBLEmail);
            panelDerecho.Controls.Add(this.LBLTitulo);
            panelDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            panelDerecho.ForeColor = System.Drawing.Color.Coral;
            panelDerecho.Location = new System.Drawing.Point(0, 0);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new System.Drawing.Size(884, 461);
            panelDerecho.TabIndex = 0;
            panelDerecho.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDerecho_Paint);
            // 
            // LinkLoginLabel
            // 
            this.LinkLoginLabel.AutoSize = true;
            this.LinkLoginLabel.DisabledLinkColor = System.Drawing.Color.DarkSlateGray;
            this.LinkLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLoginLabel.ForeColor = System.Drawing.Color.Cyan;
            this.LinkLoginLabel.LinkColor = System.Drawing.Color.DarkCyan;
            this.LinkLoginLabel.Location = new System.Drawing.Point(591, 389);
            this.LinkLoginLabel.Name = "LinkLoginLabel";
            this.LinkLoginLabel.Size = new System.Drawing.Size(225, 20);
            this.LinkLoginLabel.TabIndex = 7;
            this.LinkLoginLabel.TabStop = true;
            this.LinkLoginLabel.Text = "¿No tienes cuenta? Regístrate";
            this.LinkLoginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLoginLabel_LinkClicked);
            // 
            // BTNAlternarContrasena
            // 
            this.BTNAlternarContrasena.Image = global::Presentacion.Properties.Resources.contraVisible;
            this.BTNAlternarContrasena.Location = new System.Drawing.Point(827, 275);
            this.BTNAlternarContrasena.Name = "BTNAlternarContrasena";
            this.BTNAlternarContrasena.Size = new System.Drawing.Size(45, 34);
            this.BTNAlternarContrasena.TabIndex = 5;
            this.BTNAlternarContrasena.UseVisualStyleBackColor = true;
            this.BTNAlternarContrasena.Click += new System.EventHandler(this.BTNAlternarContrasena_Click);
            // 
            // TXTBPass
            // 
            this.TXTBPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBPass.ForeColor = System.Drawing.Color.White;
            this.TXTBPass.Location = new System.Drawing.Point(495, 274);
            this.TXTBPass.Name = "TXTBPass";
            this.TXTBPass.PasswordChar = '*';
            this.TXTBPass.Size = new System.Drawing.Size(321, 32);
            this.TXTBPass.TabIndex = 4;
            // 
            // LBLPass
            // 
            this.LBLPass.AutoSize = true;
            this.LBLPass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPass.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLPass.Location = new System.Drawing.Point(490, 226);
            this.LBLPass.Name = "LBLPass";
            this.LBLPass.Size = new System.Drawing.Size(123, 30);
            this.LBLPass.TabIndex = 3;
            this.LBLPass.Text = "Contraseña";
            // 
            // TXTBEmail
            // 
            this.TXTBEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXTBEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBEmail.ForeColor = System.Drawing.Color.White;
            this.TXTBEmail.Location = new System.Drawing.Point(495, 182);
            this.TXTBEmail.Name = "TXTBEmail";
            this.TXTBEmail.Size = new System.Drawing.Size(321, 32);
            this.TXTBEmail.TabIndex = 2;
            // 
            // LBLEmail
            // 
            this.LBLEmail.AutoSize = true;
            this.LBLEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEmail.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLEmail.Location = new System.Drawing.Point(490, 137);
            this.LBLEmail.Name = "LBLEmail";
            this.LBLEmail.Size = new System.Drawing.Size(194, 30);
            this.LBLEmail.TabIndex = 1;
            this.LBLEmail.Text = "Correo Electronico";
            // 
            // LBLTitulo
            // 
            this.LBLTitulo.AutoSize = true;
            this.LBLTitulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.LBLTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLTitulo.Location = new System.Drawing.Point(486, 63);
            this.LBLTitulo.Name = "LBLTitulo";
            this.LBLTitulo.Size = new System.Drawing.Size(127, 54);
            this.LBLTitulo.TabIndex = 0;
            this.LBLTitulo.Text = "Login";
            // 
            // BTNLogin
            // 
            this.BTNLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLogin.ForeColor = System.Drawing.Color.Black;
            this.BTNLogin.Location = new System.Drawing.Point(713, 330);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(103, 30);
            this.BTNLogin.TabIndex = 8;
            this.BTNLogin.Text = "LOGIN";
            this.BTNLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(panelDerecho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            panelDerecho.ResumeLayout(false);
            panelDerecho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label LBLTitulo;
        private TextBox TXTBPass;
        private Label LBLPass;
        private TextBox TXTBEmail;
        private Label LBLEmail;
        private Button BTNAlternarContrasena;
        private LinkLabel LinkLoginLabel;
        private Button BTNLogin;
    }
}