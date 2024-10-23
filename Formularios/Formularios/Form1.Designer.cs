
namespace landing
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbInfoUsuario = new System.Windows.Forms.Label();
            this.btRegistro = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbLinkLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbInfoUsuario
            // 
            this.lbInfoUsuario.AutoSize = true;
            this.lbInfoUsuario.Location = new System.Drawing.Point(12, 9);
            this.lbInfoUsuario.Name = "lbInfoUsuario";
            this.lbInfoUsuario.Size = new System.Drawing.Size(61, 13);
            this.lbInfoUsuario.TabIndex = 0;
            this.lbInfoUsuario.Text = "InfoUsuario";
            // 
            // btRegistro
            // 
            this.btRegistro.Location = new System.Drawing.Point(15, 298);
            this.btRegistro.Name = "btRegistro";
            this.btRegistro.Size = new System.Drawing.Size(118, 23);
            this.btRegistro.TabIndex = 1;
            this.btRegistro.Text = "Registro de Usuario";
            this.btRegistro.UseVisualStyleBackColor = true;
            this.btRegistro.Click += new System.EventHandler(this.btRegistro_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(139, 298);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(118, 23);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login de Usuario";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbLinkLogin
            // 
            this.lbLinkLogin.AutoSize = true;
            this.lbLinkLogin.Location = new System.Drawing.Point(79, 9);
            this.lbLinkLogin.Name = "lbLinkLogin";
            this.lbLinkLogin.Size = new System.Drawing.Size(87, 13);
            this.lbLinkLogin.TabIndex = 3;
            this.lbLinkLogin.TabStop = true;
            this.lbLinkLogin.Text = "Login de Usuario";
            this.lbLinkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLinkLogin_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLinkLogin);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btRegistro);
            this.Controls.Add(this.lbInfoUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfoUsuario;
        private System.Windows.Forms.Button btRegistro;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.LinkLabel lbLinkLogin;
    }
}

