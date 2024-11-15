namespace Presentacion
{
    partial class RegistroMonitor
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
            this.LBLTitulo = new System.Windows.Forms.Label();
            this.TXTBRepetirContra = new System.Windows.Forms.TextBox();
            this.LBLConfirmarContrasena = new System.Windows.Forms.Label();
            this.LBLNombre = new System.Windows.Forms.Label();
            this.TXTBNombre = new System.Windows.Forms.TextBox();
            this.LBLApellidos = new System.Windows.Forms.Label();
            this.TXTBContrasena = new System.Windows.Forms.TextBox();
            this.TXTBApellidos = new System.Windows.Forms.TextBox();
            this.LBLContrasena = new System.Windows.Forms.Label();
            this.LBLTelefono = new System.Windows.Forms.Label();
            this.TXTBEmail = new System.Windows.Forms.TextBox();
            this.TXTBTelefono = new System.Windows.Forms.TextBox();
            this.LBLEmail = new System.Windows.Forms.Label();
            this.LBLDNI = new System.Windows.Forms.Label();
            this.TXTBDNI = new System.Windows.Forms.TextBox();
            this.LBLDireccion = new System.Windows.Forms.Label();
            this.TXTBDireccion = new System.Windows.Forms.TextBox();
            this.BTNBorrarForm = new System.Windows.Forms.Button();
            this.BTNRegistrar = new System.Windows.Forms.Button();
            this.LBLAvisoCorreo = new System.Windows.Forms.Label();
            this.LBLAvisoContrasena = new System.Windows.Forms.Label();
            this.LBLAvisoContraRepetida = new System.Windows.Forms.Label();
            this.LBLAvisoDNI = new System.Windows.Forms.Label();
            this.BTNVerContraRepe = new System.Windows.Forms.Button();
            this.BTNVerContraNormal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLTitulo
            // 
            this.LBLTitulo.AutoSize = true;
            this.LBLTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LBLTitulo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.LBLTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLTitulo.Location = new System.Drawing.Point(3, 0);
            this.LBLTitulo.Name = "LBLTitulo";
            this.LBLTitulo.Size = new System.Drawing.Size(328, 51);
            this.LBLTitulo.TabIndex = 48;
            this.LBLTitulo.Text = "Registro Monitor";
            this.LBLTitulo.Click += new System.EventHandler(this.LBLTitulo_Click);
            // 
            // TXTBRepetirContra
            // 
            this.TXTBRepetirContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBRepetirContra.Location = new System.Drawing.Point(12, 307);
            this.TXTBRepetirContra.Name = "TXTBRepetirContra";
            this.TXTBRepetirContra.PasswordChar = '*';
            this.TXTBRepetirContra.Size = new System.Drawing.Size(197, 20);
            this.TXTBRepetirContra.TabIndex = 44;
            // 
            // LBLConfirmarContrasena
            // 
            this.LBLConfirmarContrasena.AutoSize = true;
            this.LBLConfirmarContrasena.BackColor = System.Drawing.Color.Transparent;
            this.LBLConfirmarContrasena.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLConfirmarContrasena.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLConfirmarContrasena.Location = new System.Drawing.Point(11, 287);
            this.LBLConfirmarContrasena.Name = "LBLConfirmarContrasena";
            this.LBLConfirmarContrasena.Size = new System.Drawing.Size(133, 17);
            this.LBLConfirmarContrasena.TabIndex = 45;
            this.LBLConfirmarContrasena.Text = "Repite la contraseña";
            // 
            // LBLNombre
            // 
            this.LBLNombre.AutoSize = true;
            this.LBLNombre.BackColor = System.Drawing.Color.Transparent;
            this.LBLNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LBLNombre.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLNombre.Location = new System.Drawing.Point(8, 51);
            this.LBLNombre.Name = "LBLNombre";
            this.LBLNombre.Size = new System.Drawing.Size(65, 19);
            this.LBLNombre.TabIndex = 28;
            this.LBLNombre.Text = "Nombre";
            this.LBLNombre.Click += new System.EventHandler(this.LBLNombre_Click);
            // 
            // TXTBNombre
            // 
            this.TXTBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBNombre.Location = new System.Drawing.Point(12, 70);
            this.TXTBNombre.MaxLength = 30;
            this.TXTBNombre.Name = "TXTBNombre";
            this.TXTBNombre.Size = new System.Drawing.Size(111, 20);
            this.TXTBNombre.TabIndex = 29;
            this.TXTBNombre.TextChanged += new System.EventHandler(this.TXTBNombre_TextChanged);
            // 
            // LBLApellidos
            // 
            this.LBLApellidos.AutoSize = true;
            this.LBLApellidos.BackColor = System.Drawing.Color.Transparent;
            this.LBLApellidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLApellidos.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLApellidos.Location = new System.Drawing.Point(158, 51);
            this.LBLApellidos.Name = "LBLApellidos";
            this.LBLApellidos.Size = new System.Drawing.Size(66, 17);
            this.LBLApellidos.TabIndex = 30;
            this.LBLApellidos.Text = "Apellidos";
            this.LBLApellidos.Click += new System.EventHandler(this.LBLApellidos_Click);
            // 
            // TXTBContrasena
            // 
            this.TXTBContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBContrasena.Location = new System.Drawing.Point(12, 239);
            this.TXTBContrasena.MaxLength = 30;
            this.TXTBContrasena.Name = "TXTBContrasena";
            this.TXTBContrasena.PasswordChar = '*';
            this.TXTBContrasena.Size = new System.Drawing.Size(197, 20);
            this.TXTBContrasena.TabIndex = 43;
            // 
            // TXTBApellidos
            // 
            this.TXTBApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBApellidos.Location = new System.Drawing.Point(158, 70);
            this.TXTBApellidos.MaxLength = 60;
            this.TXTBApellidos.Name = "TXTBApellidos";
            this.TXTBApellidos.Size = new System.Drawing.Size(111, 20);
            this.TXTBApellidos.TabIndex = 31;
            this.TXTBApellidos.TextChanged += new System.EventHandler(this.TXTBApellidos_TextChanged);
            // 
            // LBLContrasena
            // 
            this.LBLContrasena.AutoSize = true;
            this.LBLContrasena.BackColor = System.Drawing.Color.Transparent;
            this.LBLContrasena.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLContrasena.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLContrasena.Location = new System.Drawing.Point(11, 221);
            this.LBLContrasena.Name = "LBLContrasena";
            this.LBLContrasena.Size = new System.Drawing.Size(77, 17);
            this.LBLContrasena.TabIndex = 42;
            this.LBLContrasena.Text = "Contraseña";
            // 
            // LBLTelefono
            // 
            this.LBLTelefono.AutoSize = true;
            this.LBLTelefono.BackColor = System.Drawing.Color.Transparent;
            this.LBLTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTelefono.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLTelefono.Location = new System.Drawing.Point(9, 100);
            this.LBLTelefono.Name = "LBLTelefono";
            this.LBLTelefono.Size = new System.Drawing.Size(62, 17);
            this.LBLTelefono.TabIndex = 32;
            this.LBLTelefono.Text = "Teléfono";
            this.LBLTelefono.Click += new System.EventHandler(this.LBLTelefono_Click);
            // 
            // TXTBEmail
            // 
            this.TXTBEmail.BackColor = System.Drawing.SystemColors.Window;
            this.TXTBEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TXTBEmail.Location = new System.Drawing.Point(157, 181);
            this.TXTBEmail.MaxLength = 60;
            this.TXTBEmail.Name = "TXTBEmail";
            this.TXTBEmail.Size = new System.Drawing.Size(112, 20);
            this.TXTBEmail.TabIndex = 41;
            // 
            // TXTBTelefono
            // 
            this.TXTBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBTelefono.Location = new System.Drawing.Point(12, 120);
            this.TXTBTelefono.MaxLength = 9;
            this.TXTBTelefono.Name = "TXTBTelefono";
            this.TXTBTelefono.Size = new System.Drawing.Size(111, 20);
            this.TXTBTelefono.TabIndex = 33;
            this.TXTBTelefono.TextChanged += new System.EventHandler(this.TXTBTelefono_TextChanged);
            // 
            // LBLEmail
            // 
            this.LBLEmail.AutoSize = true;
            this.LBLEmail.BackColor = System.Drawing.Color.Transparent;
            this.LBLEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEmail.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLEmail.Location = new System.Drawing.Point(155, 161);
            this.LBLEmail.Name = "LBLEmail";
            this.LBLEmail.Size = new System.Drawing.Size(121, 17);
            this.LBLEmail.TabIndex = 40;
            this.LBLEmail.Text = "Correo electronico";
            // 
            // LBLDNI
            // 
            this.LBLDNI.AutoSize = true;
            this.LBLDNI.BackColor = System.Drawing.Color.Transparent;
            this.LBLDNI.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDNI.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLDNI.Location = new System.Drawing.Point(158, 100);
            this.LBLDNI.Name = "LBLDNI";
            this.LBLDNI.Size = new System.Drawing.Size(32, 17);
            this.LBLDNI.TabIndex = 34;
            this.LBLDNI.Text = "DNI";
            this.LBLDNI.Click += new System.EventHandler(this.LBLDNI_Click);
            // 
            // TXTBDNI
            // 
            this.TXTBDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBDNI.Location = new System.Drawing.Point(158, 120);
            this.TXTBDNI.MaxLength = 9;
            this.TXTBDNI.Name = "TXTBDNI";
            this.TXTBDNI.Size = new System.Drawing.Size(111, 20);
            this.TXTBDNI.TabIndex = 35;
            this.TXTBDNI.TextChanged += new System.EventHandler(this.TXTBDNI_TextChanged);
            // 
            // LBLDireccion
            // 
            this.LBLDireccion.AutoSize = true;
            this.LBLDireccion.BackColor = System.Drawing.Color.Transparent;
            this.LBLDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDireccion.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLDireccion.Location = new System.Drawing.Point(11, 161);
            this.LBLDireccion.Name = "LBLDireccion";
            this.LBLDireccion.Size = new System.Drawing.Size(66, 17);
            this.LBLDireccion.TabIndex = 36;
            this.LBLDireccion.Text = "Dirección";
            // 
            // TXTBDireccion
            // 
            this.TXTBDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBDireccion.Location = new System.Drawing.Point(12, 181);
            this.TXTBDireccion.MaxLength = 60;
            this.TXTBDireccion.Name = "TXTBDireccion";
            this.TXTBDireccion.Size = new System.Drawing.Size(111, 20);
            this.TXTBDireccion.TabIndex = 37;
            // 
            // BTNBorrarForm
            // 
            this.BTNBorrarForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBorrarForm.Location = new System.Drawing.Point(14, 380);
            this.BTNBorrarForm.Name = "BTNBorrarForm";
            this.BTNBorrarForm.Size = new System.Drawing.Size(110, 33);
            this.BTNBorrarForm.TabIndex = 49;
            this.BTNBorrarForm.Text = "Limpiar Form";
            this.BTNBorrarForm.UseVisualStyleBackColor = true;
            this.BTNBorrarForm.Click += new System.EventHandler(this.BTNBorrarForm_Click_1);
            // 
            // BTNRegistrar
            // 
            this.BTNRegistrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRegistrar.Location = new System.Drawing.Point(155, 380);
            this.BTNRegistrar.Name = "BTNRegistrar";
            this.BTNRegistrar.Size = new System.Drawing.Size(114, 33);
            this.BTNRegistrar.TabIndex = 50;
            this.BTNRegistrar.Text = "Registrarse";
            this.BTNRegistrar.UseVisualStyleBackColor = true;
            this.BTNRegistrar.Click += new System.EventHandler(this.BTNRegistrar_Click);
            // 
            // LBLAvisoCorreo
            // 
            this.LBLAvisoCorreo.AutoSize = true;
            this.LBLAvisoCorreo.BackColor = System.Drawing.Color.Transparent;
            this.LBLAvisoCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAvisoCorreo.ForeColor = System.Drawing.Color.Red;
            this.LBLAvisoCorreo.Location = new System.Drawing.Point(155, 204);
            this.LBLAvisoCorreo.Name = "LBLAvisoCorreo";
            this.LBLAvisoCorreo.Size = new System.Drawing.Size(62, 13);
            this.LBLAvisoCorreo.TabIndex = 51;
            this.LBLAvisoCorreo.Text = "muestrate";
            this.LBLAvisoCorreo.Click += new System.EventHandler(this.LBLAvisoDNI_Click);
            // 
            // LBLAvisoContrasena
            // 
            this.LBLAvisoContrasena.AutoSize = true;
            this.LBLAvisoContrasena.BackColor = System.Drawing.Color.Transparent;
            this.LBLAvisoContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAvisoContrasena.ForeColor = System.Drawing.Color.Red;
            this.LBLAvisoContrasena.Location = new System.Drawing.Point(15, 264);
            this.LBLAvisoContrasena.Name = "LBLAvisoContrasena";
            this.LBLAvisoContrasena.Size = new System.Drawing.Size(62, 13);
            this.LBLAvisoContrasena.TabIndex = 52;
            this.LBLAvisoContrasena.Text = "muestrate";
            // 
            // LBLAvisoContraRepetida
            // 
            this.LBLAvisoContraRepetida.AutoSize = true;
            this.LBLAvisoContraRepetida.BackColor = System.Drawing.Color.Transparent;
            this.LBLAvisoContraRepetida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAvisoContraRepetida.ForeColor = System.Drawing.Color.Red;
            this.LBLAvisoContraRepetida.Location = new System.Drawing.Point(11, 332);
            this.LBLAvisoContraRepetida.Name = "LBLAvisoContraRepetida";
            this.LBLAvisoContraRepetida.Size = new System.Drawing.Size(62, 13);
            this.LBLAvisoContraRepetida.TabIndex = 53;
            this.LBLAvisoContraRepetida.Text = "muestrate";
            // 
            // LBLAvisoDNI
            // 
            this.LBLAvisoDNI.AutoSize = true;
            this.LBLAvisoDNI.BackColor = System.Drawing.Color.Transparent;
            this.LBLAvisoDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAvisoDNI.ForeColor = System.Drawing.Color.Red;
            this.LBLAvisoDNI.Location = new System.Drawing.Point(158, 143);
            this.LBLAvisoDNI.Name = "LBLAvisoDNI";
            this.LBLAvisoDNI.Size = new System.Drawing.Size(62, 13);
            this.LBLAvisoDNI.TabIndex = 54;
            this.LBLAvisoDNI.Text = "muestrate";
            this.LBLAvisoDNI.Click += new System.EventHandler(this.LBLAvisoDNI_Click_1);
            // 
            // BTNVerContraRepe
            // 
            this.BTNVerContraRepe.Image = global::Presentacion.Properties.Resources.contraVisible;
            this.BTNVerContraRepe.Location = new System.Drawing.Point(217, 307);
            this.BTNVerContraRepe.Name = "BTNVerContraRepe";
            this.BTNVerContraRepe.Size = new System.Drawing.Size(38, 23);
            this.BTNVerContraRepe.TabIndex = 47;
            this.BTNVerContraRepe.UseVisualStyleBackColor = true;
            this.BTNVerContraRepe.Click += new System.EventHandler(this.BTNVerContraRepe_Click);
            // 
            // BTNVerContraNormal
            // 
            this.BTNVerContraNormal.AutoEllipsis = true;
            this.BTNVerContraNormal.Image = global::Presentacion.Properties.Resources.contraVisible;
            this.BTNVerContraNormal.Location = new System.Drawing.Point(217, 236);
            this.BTNVerContraNormal.Name = "BTNVerContraNormal";
            this.BTNVerContraNormal.Size = new System.Drawing.Size(38, 23);
            this.BTNVerContraNormal.TabIndex = 46;
            this.BTNVerContraNormal.UseVisualStyleBackColor = true;
            this.BTNVerContraNormal.Click += new System.EventHandler(this.BTNVerContraNormal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBLTitulo);
            this.panel1.Controls.Add(this.BTNRegistrar);
            this.panel1.Controls.Add(this.LBLAvisoContraRepetida);
            this.panel1.Controls.Add(this.BTNBorrarForm);
            this.panel1.Controls.Add(this.LBLAvisoDNI);
            this.panel1.Controls.Add(this.BTNVerContraRepe);
            this.panel1.Controls.Add(this.LBLAvisoContrasena);
            this.panel1.Controls.Add(this.LBLNombre);
            this.panel1.Controls.Add(this.LBLAvisoCorreo);
            this.panel1.Controls.Add(this.TXTBRepetirContra);
            this.panel1.Controls.Add(this.TXTBNombre);
            this.panel1.Controls.Add(this.LBLConfirmarContrasena);
            this.panel1.Controls.Add(this.LBLTelefono);
            this.panel1.Controls.Add(this.BTNVerContraNormal);
            this.panel1.Controls.Add(this.LBLApellidos);
            this.panel1.Controls.Add(this.TXTBApellidos);
            this.panel1.Controls.Add(this.LBLDNI);
            this.panel1.Controls.Add(this.TXTBContrasena);
            this.panel1.Controls.Add(this.TXTBDNI);
            this.panel1.Controls.Add(this.TXTBTelefono);
            this.panel1.Controls.Add(this.LBLDireccion);
            this.panel1.Controls.Add(this.LBLContrasena);
            this.panel1.Controls.Add(this.TXTBDireccion);
            this.panel1.Controls.Add(this.TXTBEmail);
            this.panel1.Controls.Add(this.LBLEmail);
            this.panel1.Location = new System.Drawing.Point(239, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 437);
            this.panel1.TabIndex = 55;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RegistroMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 610);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroMonitor";
            this.Text = "RegistroMonitor";
            this.Load += new System.EventHandler(this.RegistroMonitor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBLTitulo;
        private System.Windows.Forms.Button BTNVerContraRepe;
        private System.Windows.Forms.Button BTNVerContraNormal;
        private System.Windows.Forms.TextBox TXTBRepetirContra;
        private System.Windows.Forms.Label LBLConfirmarContrasena;
        private System.Windows.Forms.Label LBLNombre;
        private System.Windows.Forms.TextBox TXTBNombre;
        private System.Windows.Forms.Label LBLApellidos;
        private System.Windows.Forms.TextBox TXTBContrasena;
        private System.Windows.Forms.TextBox TXTBApellidos;
        private System.Windows.Forms.Label LBLContrasena;
        private System.Windows.Forms.Label LBLTelefono;
        private System.Windows.Forms.TextBox TXTBEmail;
        private System.Windows.Forms.TextBox TXTBTelefono;
        private System.Windows.Forms.Label LBLEmail;
        private System.Windows.Forms.Label LBLDNI;
        private System.Windows.Forms.TextBox TXTBDNI;
        private System.Windows.Forms.Label LBLDireccion;
        private System.Windows.Forms.TextBox TXTBDireccion;
        private System.Windows.Forms.Button BTNBorrarForm;
        private System.Windows.Forms.Button BTNRegistrar;
        private System.Windows.Forms.Label LBLAvisoCorreo;
        private System.Windows.Forms.Label LBLAvisoContrasena;
        private System.Windows.Forms.Label LBLAvisoContraRepetida;
        private System.Windows.Forms.Label LBLAvisoDNI;
        private System.Windows.Forms.Panel panel1;
    }
}