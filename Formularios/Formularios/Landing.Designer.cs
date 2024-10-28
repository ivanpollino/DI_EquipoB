namespace Formularios.Formularios
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
            this.lbInfoUsuario = new System.Windows.Forms.Label();
            this.lbLinkLogin = new System.Windows.Forms.LinkLabel();
            this.btLogin = new System.Windows.Forms.Button();
            this.btRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInfoUsuario
            // 
            this.lbInfoUsuario.AutoSize = true;
            this.lbInfoUsuario.Location = new System.Drawing.Point(0, 0);
            this.lbInfoUsuario.Name = "lbInfoUsuario";
            this.lbInfoUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbInfoUsuario.TabIndex = 0;
            this.lbInfoUsuario.Text = "Usuario";
            // 
            // lbLinkLogin
            // 
            this.lbLinkLogin.AutoSize = true;
            this.lbLinkLogin.Location = new System.Drawing.Point(63, 0);
            this.lbLinkLogin.Name = "lbLinkLogin";
            this.lbLinkLogin.Size = new System.Drawing.Size(87, 13);
            this.lbLinkLogin.TabIndex = 1;
            this.lbLinkLogin.TabStop = true;
            this.lbLinkLogin.Text = "Login de Usuario";
            this.lbLinkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLinkLogin_LinkClicked);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(259, 172);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(121, 23);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login de Usuario";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btRegistro
            // 
            this.btRegistro.Location = new System.Drawing.Point(259, 201);
            this.btRegistro.Name = "btRegistro";
            this.btRegistro.Size = new System.Drawing.Size(121, 23);
            this.btRegistro.TabIndex = 3;
            this.btRegistro.Text = "Registro de Usuario";
            this.btRegistro.UseVisualStyleBackColor = true;
            this.btRegistro.Click += new System.EventHandler(this.btRegistro_Click);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegistro);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbLinkLogin);
            this.Controls.Add(this.lbInfoUsuario);
            this.Name = "Landing";
            this.Text = "Landing";
            this.Load += new System.EventHandler(this.Landing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfoUsuario;
        private System.Windows.Forms.LinkLabel lbLinkLogin;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btRegistro;
    }
}