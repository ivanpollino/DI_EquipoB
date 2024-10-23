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
            this.LBLEmail = new System.Windows.Forms.Label();
            this.TXTBEmail = new System.Windows.Forms.TextBox();
            this.LBLPass = new System.Windows.Forms.Label();
            this.TXTBPass = new System.Windows.Forms.TextBox();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLEmail
            // 
            this.LBLEmail.AutoSize = true;
            this.LBLEmail.Location = new System.Drawing.Point(352, 74);
            this.LBLEmail.Name = "LBLEmail";
            this.LBLEmail.Size = new System.Drawing.Size(93, 13);
            this.LBLEmail.TabIndex = 0;
            this.LBLEmail.Text = "Correo electronico";
            // 
            // TXTBEmail
            // 
            this.TXTBEmail.Location = new System.Drawing.Point(348, 100);
            this.TXTBEmail.Name = "TXTBEmail";
            this.TXTBEmail.Size = new System.Drawing.Size(100, 20);
            this.TXTBEmail.TabIndex = 1;
            // 
            // LBLPass
            // 
            this.LBLPass.AutoSize = true;
            this.LBLPass.Location = new System.Drawing.Point(366, 138);
            this.LBLPass.Name = "LBLPass";
            this.LBLPass.Size = new System.Drawing.Size(61, 13);
            this.LBLPass.TabIndex = 2;
            this.LBLPass.Text = "Contraseña";
            // 
            // TXTBPass
            // 
            this.TXTBPass.Location = new System.Drawing.Point(347, 163);
            this.TXTBPass.Name = "TXTBPass";
            this.TXTBPass.PasswordChar = '*';
            this.TXTBPass.Size = new System.Drawing.Size(100, 20);
            this.TXTBPass.TabIndex = 3;
            // 
            // BTNLogin
            // 
            this.BTNLogin.Location = new System.Drawing.Point(358, 208);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(75, 23);
            this.BTNLogin.TabIndex = 4;
            this.BTNLogin.Text = "Login";
            this.BTNLogin.UseVisualStyleBackColor = true;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.TXTBPass);
            this.Controls.Add(this.LBLPass);
            this.Controls.Add(this.TXTBEmail);
            this.Controls.Add(this.LBLEmail);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLEmail;
        private System.Windows.Forms.TextBox TXTBEmail;
        private System.Windows.Forms.Label LBLPass;
        private System.Windows.Forms.TextBox TXTBPass;
        private System.Windows.Forms.Button BTNLogin;
    }
}