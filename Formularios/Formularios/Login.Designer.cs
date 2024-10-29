using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Formularios.Formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.BTNAlternarContrasena = new System.Windows.Forms.Button();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.TXTBPass = new System.Windows.Forms.TextBox();
            this.LBLPass = new System.Windows.Forms.Label();
            this.TXTBEmail = new System.Windows.Forms.TextBox();
            this.LBLEmail = new System.Windows.Forms.Label();
            this.LBLTitulo = new System.Windows.Forms.Label();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.panelDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.White;
            this.panelDerecho.Controls.Add(this.BTNAlternarContrasena);
            this.panelDerecho.Controls.Add(this.BTNLogin);
            this.panelDerecho.Controls.Add(this.TXTBPass);
            this.panelDerecho.Controls.Add(this.LBLPass);
            this.panelDerecho.Controls.Add(this.TXTBEmail);
            this.panelDerecho.Controls.Add(this.LBLEmail);
            this.panelDerecho.Controls.Add(this.LBLTitulo);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDerecho.Location = new System.Drawing.Point(434, 0);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(450, 461);
            this.panelDerecho.TabIndex = 0;
            // 
            // BTNAlternarContrasena
            // 
            this.BTNAlternarContrasena.Image = global::Formularios.Properties.Resources.contraVisible;
            this.BTNAlternarContrasena.Location = new System.Drawing.Point(381, 275);
            this.BTNAlternarContrasena.Name = "BTNAlternarContrasena";
            this.BTNAlternarContrasena.Size = new System.Drawing.Size(45, 34);
            this.BTNAlternarContrasena.TabIndex = 5;
            this.BTNAlternarContrasena.UseVisualStyleBackColor = true;
            this.BTNAlternarContrasena.Click += new System.EventHandler(this.BTNAlternarContrasena_Click);
            // 
            // BTNLogin
            // 
            this.BTNLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BTNLogin.Location = new System.Drawing.Point(300, 353);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(75, 23);
            this.BTNLogin.TabIndex = 0;
            // 
            // TXTBPass
            // 
            this.TXTBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBPass.Location = new System.Drawing.Point(54, 277);
            this.TXTBPass.Name = "TXTBPass";
            this.TXTBPass.PasswordChar = '*';
            this.TXTBPass.Size = new System.Drawing.Size(321, 32);
            this.TXTBPass.TabIndex = 4;
            // 
            // LBLPass
            // 
            this.LBLPass.AutoSize = true;
            this.LBLPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPass.Location = new System.Drawing.Point(49, 234);
            this.LBLPass.Name = "LBLPass";
            this.LBLPass.Size = new System.Drawing.Size(124, 26);
            this.LBLPass.TabIndex = 3;
            this.LBLPass.Text = "Contraseña";
            // 
            // TXTBEmail
            // 
            this.TXTBEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBEmail.Location = new System.Drawing.Point(54, 179);
            this.TXTBEmail.Name = "TXTBEmail";
            this.TXTBEmail.Size = new System.Drawing.Size(321, 32);
            this.TXTBEmail.TabIndex = 2;
            // 
            // LBLEmail
            // 
            this.LBLEmail.AutoSize = true;
            this.LBLEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEmail.Location = new System.Drawing.Point(49, 140);
            this.LBLEmail.Name = "LBLEmail";
            this.LBLEmail.Size = new System.Drawing.Size(192, 26);
            this.LBLEmail.TabIndex = 1;
            this.LBLEmail.Text = "Correo Electronico";
            // 
            // LBLTitulo
            // 
            this.LBLTitulo.AutoSize = true;
            this.LBLTitulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.LBLTitulo.Location = new System.Drawing.Point(45, 55);
            this.LBLTitulo.Name = "LBLTitulo";
            this.LBLTitulo.Size = new System.Drawing.Size(127, 54);
            this.LBLTitulo.TabIndex = 0;
            this.LBLTitulo.Text = "Login";
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIzquierdo.BackgroundImage")));
            this.panelIzquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(435, 461);
            this.panelIzquierdo.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.panelIzquierdo);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelDerecho.ResumeLayout(false);
            this.panelDerecho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelIzquierdo;
        private Panel panelDerecho;
        private Label LBLTitulo;
        private Button BTNLogin;
        private TextBox TXTBPass;
        private Label LBLPass;
        private TextBox TXTBEmail;
        private Label LBLEmail;
        private Button BTNAlternarContrasena;
    }
}