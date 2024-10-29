using System;

namespace Formularios.Formularios
{
    partial class Registro
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
            this.LBLNombre = new System.Windows.Forms.Label();
            this.TXTBNombre = new System.Windows.Forms.TextBox();
            this.LBLApellidos = new System.Windows.Forms.Label();
            this.TXTBApellidos = new System.Windows.Forms.TextBox();
            this.LBLTelefono = new System.Windows.Forms.Label();
            this.TXTBTelefono = new System.Windows.Forms.TextBox();
            this.LBLDNI = new System.Windows.Forms.Label();
            this.TXTBDNI = new System.Windows.Forms.TextBox();
            this.LBLDireccion = new System.Windows.Forms.Label();
            this.TXTBDireccion = new System.Windows.Forms.TextBox();
            this.LBLCCC = new System.Windows.Forms.Label();
            this.TXTBCCC = new System.Windows.Forms.TextBox();
            this.LBLEmail = new System.Windows.Forms.Label();
            this.TXTBEmail = new System.Windows.Forms.TextBox();
            this.LBLContrasena = new System.Windows.Forms.Label();
            this.TXTBContrasena = new System.Windows.Forms.TextBox();
            this.BTNRegistrar = new System.Windows.Forms.Button();
            this.BTNBorrarForm = new System.Windows.Forms.Button();
            this.LBLAvisoContrasena = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.BTNVerContraRepe = new System.Windows.Forms.Button();
            this.BTNVerContraNormal = new System.Windows.Forms.Button();
            this.LBLAvisoContraRepetida = new System.Windows.Forms.Label();
            this.TXTBRepetirContra = new System.Windows.Forms.TextBox();
            this.LBLConfirmarContrasena = new System.Windows.Forms.Label();
            this.TXTBRepetirContrasena = new System.Windows.Forms.Panel();
            this.LBLAvisoCorreo = new System.Windows.Forms.Label();
            this.panelIzquierdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLNombre
            // 
            this.LBLNombre.AutoSize = true;
            this.LBLNombre.Location = new System.Drawing.Point(194, 25);
            this.LBLNombre.Name = "LBLNombre";
            this.LBLNombre.Size = new System.Drawing.Size(44, 13);
            this.LBLNombre.TabIndex = 0;
            this.LBLNombre.Text = "Nombre";
            // 
            // TXTBNombre
            // 
            this.TXTBNombre.Location = new System.Drawing.Point(167, 41);
            this.TXTBNombre.MaxLength = 30;
            this.TXTBNombre.Name = "TXTBNombre";
            this.TXTBNombre.Size = new System.Drawing.Size(100, 20);
            this.TXTBNombre.TabIndex = 1;
            // 
            // LBLApellidos
            // 
            this.LBLApellidos.AutoSize = true;
            this.LBLApellidos.Location = new System.Drawing.Point(194, 71);
            this.LBLApellidos.Name = "LBLApellidos";
            this.LBLApellidos.Size = new System.Drawing.Size(49, 13);
            this.LBLApellidos.TabIndex = 2;
            this.LBLApellidos.Text = "Apellidos";
            // 
            // TXTBApellidos
            // 
            this.TXTBApellidos.Location = new System.Drawing.Point(167, 87);
            this.TXTBApellidos.MaxLength = 60;
            this.TXTBApellidos.Name = "TXTBApellidos";
            this.TXTBApellidos.Size = new System.Drawing.Size(100, 20);
            this.TXTBApellidos.TabIndex = 3;
            // 
            // LBLTelefono
            // 
            this.LBLTelefono.AutoSize = true;
            this.LBLTelefono.Location = new System.Drawing.Point(194, 110);
            this.LBLTelefono.Name = "LBLTelefono";
            this.LBLTelefono.Size = new System.Drawing.Size(49, 13);
            this.LBLTelefono.TabIndex = 4;
            this.LBLTelefono.Text = "Teléfono";
            // 
            // TXTBTelefono
            // 
            this.TXTBTelefono.Location = new System.Drawing.Point(167, 126);
            this.TXTBTelefono.MaxLength = 9;
            this.TXTBTelefono.Name = "TXTBTelefono";
            this.TXTBTelefono.Size = new System.Drawing.Size(100, 20);
            this.TXTBTelefono.TabIndex = 6;
            this.TXTBTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.caparSoloNumeros);
            // 
            // LBLDNI
            // 
            this.LBLDNI.AutoSize = true;
            this.LBLDNI.Location = new System.Drawing.Point(200, 149);
            this.LBLDNI.Name = "LBLDNI";
            this.LBLDNI.Size = new System.Drawing.Size(26, 13);
            this.LBLDNI.TabIndex = 7;
            this.LBLDNI.Text = "DNI";
            // 
            // TXTBDNI
            // 
            this.TXTBDNI.Location = new System.Drawing.Point(167, 165);
            this.TXTBDNI.MaxLength = 9;
            this.TXTBDNI.Name = "TXTBDNI";
            this.TXTBDNI.Size = new System.Drawing.Size(100, 20);
            this.TXTBDNI.TabIndex = 8;
            // 
            // LBLDireccion
            // 
            this.LBLDireccion.AutoSize = true;
            this.LBLDireccion.Location = new System.Drawing.Point(191, 188);
            this.LBLDireccion.Name = "LBLDireccion";
            this.LBLDireccion.Size = new System.Drawing.Size(52, 13);
            this.LBLDireccion.TabIndex = 9;
            this.LBLDireccion.Text = "Dirección";
            // 
            // TXTBDireccion
            // 
            this.TXTBDireccion.Location = new System.Drawing.Point(167, 204);
            this.TXTBDireccion.MaxLength = 60;
            this.TXTBDireccion.Name = "TXTBDireccion";
            this.TXTBDireccion.Size = new System.Drawing.Size(100, 20);
            this.TXTBDireccion.TabIndex = 10;
            // 
            // LBLCCC
            // 
            this.LBLCCC.AutoSize = true;
            this.LBLCCC.Location = new System.Drawing.Point(194, 227);
            this.LBLCCC.Name = "LBLCCC";
            this.LBLCCC.Size = new System.Drawing.Size(28, 13);
            this.LBLCCC.TabIndex = 11;
            this.LBLCCC.Text = "CCC";
            // 
            // TXTBCCC
            // 
            this.TXTBCCC.Location = new System.Drawing.Point(167, 243);
            this.TXTBCCC.MaxLength = 60;
            this.TXTBCCC.Name = "TXTBCCC";
            this.TXTBCCC.Size = new System.Drawing.Size(100, 20);
            this.TXTBCCC.TabIndex = 12;
            // 
            // LBLEmail
            // 
            this.LBLEmail.AutoSize = true;
            this.LBLEmail.Location = new System.Drawing.Point(174, 276);
            this.LBLEmail.Name = "LBLEmail";
            this.LBLEmail.Size = new System.Drawing.Size(93, 13);
            this.LBLEmail.TabIndex = 13;
            this.LBLEmail.Text = "Correo electronico";
            // 
            // TXTBEmail
            // 
            this.TXTBEmail.BackColor = System.Drawing.SystemColors.Window;
            this.TXTBEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TXTBEmail.Location = new System.Drawing.Point(167, 292);
            this.TXTBEmail.MaxLength = 60;
            this.TXTBEmail.Name = "TXTBEmail";
            this.TXTBEmail.Size = new System.Drawing.Size(100, 20);
            this.TXTBEmail.TabIndex = 14;
            // 
            // LBLContrasena
            // 
            this.LBLContrasena.AutoSize = true;
            this.LBLContrasena.Location = new System.Drawing.Point(182, 315);
            this.LBLContrasena.Name = "LBLContrasena";
            this.LBLContrasena.Size = new System.Drawing.Size(61, 13);
            this.LBLContrasena.TabIndex = 15;
            this.LBLContrasena.Text = "Contraseña";
            // 
            // TXTBContrasena
            // 
            this.TXTBContrasena.Location = new System.Drawing.Point(167, 331);
            this.TXTBContrasena.MaxLength = 30;
            this.TXTBContrasena.Name = "TXTBContrasena";
            this.TXTBContrasena.PasswordChar = '*';
            this.TXTBContrasena.Size = new System.Drawing.Size(100, 20);
            this.TXTBContrasena.TabIndex = 16;
            this.TXTBContrasena.TextChanged += new System.EventHandler(this.TXTBContrasena_TextChanged);
            // 
            // BTNRegistrar
            // 
            this.BTNRegistrar.Location = new System.Drawing.Point(41, 427);
            this.BTNRegistrar.Name = "BTNRegistrar";
            this.BTNRegistrar.Size = new System.Drawing.Size(84, 23);
            this.BTNRegistrar.TabIndex = 19;
            this.BTNRegistrar.Text = "Registrarse";
            this.BTNRegistrar.UseVisualStyleBackColor = true;
            this.BTNRegistrar.Click += new System.EventHandler(this.BTNRegistrar_Click);
            // 
            // BTNBorrarForm
            // 
            this.BTNBorrarForm.Location = new System.Drawing.Point(311, 426);
            this.BTNBorrarForm.Name = "BTNBorrarForm";
            this.BTNBorrarForm.Size = new System.Drawing.Size(80, 23);
            this.BTNBorrarForm.TabIndex = 20;
            this.BTNBorrarForm.Text = "Limpiar Form";
            this.BTNBorrarForm.UseVisualStyleBackColor = true;
            this.BTNBorrarForm.Click += new System.EventHandler(this.BTNBorrarForm_Click);
            // 
            // LBLAvisoContrasena
            // 
            this.LBLAvisoContrasena.AutoSize = true;
            this.LBLAvisoContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAvisoContrasena.ForeColor = System.Drawing.Color.Red;
            this.LBLAvisoContrasena.Location = new System.Drawing.Point(110, 354);
            this.LBLAvisoContrasena.Name = "LBLAvisoContrasena";
            this.LBLAvisoContrasena.Size = new System.Drawing.Size(0, 13);
            this.LBLAvisoContrasena.TabIndex = 21;
            this.toolTip1.SetToolTip(this.LBLAvisoContrasena, "La contraseña debe tener:\n- Más de 8 caracteres\n- Letras mayúsculas y minúsculas\n" +
        "- Al menos un número\n- Al menos un carácter especial (% & $ / *)");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Como tener una contraseña valida";
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.Controls.Add(this.LBLAvisoCorreo);
            this.panelIzquierdo.Controls.Add(this.BTNVerContraRepe);
            this.panelIzquierdo.Controls.Add(this.BTNVerContraNormal);
            this.panelIzquierdo.Controls.Add(this.LBLAvisoContraRepetida);
            this.panelIzquierdo.Controls.Add(this.LBLAvisoContrasena);
            this.panelIzquierdo.Controls.Add(this.TXTBRepetirContra);
            this.panelIzquierdo.Controls.Add(this.LBLConfirmarContrasena);
            this.panelIzquierdo.Controls.Add(this.LBLNombre);
            this.panelIzquierdo.Controls.Add(this.BTNBorrarForm);
            this.panelIzquierdo.Controls.Add(this.TXTBNombre);
            this.panelIzquierdo.Controls.Add(this.BTNRegistrar);
            this.panelIzquierdo.Controls.Add(this.LBLApellidos);
            this.panelIzquierdo.Controls.Add(this.TXTBContrasena);
            this.panelIzquierdo.Controls.Add(this.TXTBApellidos);
            this.panelIzquierdo.Controls.Add(this.LBLContrasena);
            this.panelIzquierdo.Controls.Add(this.LBLTelefono);
            this.panelIzquierdo.Controls.Add(this.TXTBEmail);
            this.panelIzquierdo.Controls.Add(this.TXTBTelefono);
            this.panelIzquierdo.Controls.Add(this.LBLEmail);
            this.panelIzquierdo.Controls.Add(this.LBLDNI);
            this.panelIzquierdo.Controls.Add(this.TXTBCCC);
            this.panelIzquierdo.Controls.Add(this.TXTBDNI);
            this.panelIzquierdo.Controls.Add(this.LBLCCC);
            this.panelIzquierdo.Controls.Add(this.LBLDireccion);
            this.panelIzquierdo.Controls.Add(this.TXTBDireccion);
            this.panelIzquierdo.Location = new System.Drawing.Point(-2, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(454, 461);
            this.panelIzquierdo.TabIndex = 20;
            this.panelIzquierdo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIzquierdo_Paint);
            // 
            // BTNVerContraRepe
            // 
            this.BTNVerContraRepe.Image = global::Formularios.Properties.Resources.contraVisible;
            this.BTNVerContraRepe.Location = new System.Drawing.Point(273, 385);
            this.BTNVerContraRepe.Name = "BTNVerContraRepe";
            this.BTNVerContraRepe.Size = new System.Drawing.Size(27, 23);
            this.BTNVerContraRepe.TabIndex = 23;
            this.BTNVerContraRepe.UseVisualStyleBackColor = true;
            this.BTNVerContraRepe.Click += new System.EventHandler(this.BTNVerContraRepe_Click);
            // 
            // BTNVerContraNormal
            // 
            this.BTNVerContraNormal.AutoEllipsis = true;
            this.BTNVerContraNormal.Image = global::Formularios.Properties.Resources.contraVisible;
            this.BTNVerContraNormal.Location = new System.Drawing.Point(273, 329);
            this.BTNVerContraNormal.Name = "BTNVerContraNormal";
            this.BTNVerContraNormal.Size = new System.Drawing.Size(27, 23);
            this.BTNVerContraNormal.TabIndex = 22;
            this.BTNVerContraNormal.UseVisualStyleBackColor = true;
            this.BTNVerContraNormal.Click += new System.EventHandler(this.BTNVerContraNormal_Click);
            // 
            // LBLAvisoContraRepetida
            // 
            this.LBLAvisoContraRepetida.AutoSize = true;
            this.LBLAvisoContraRepetida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAvisoContraRepetida.ForeColor = System.Drawing.Color.Red;
            this.LBLAvisoContraRepetida.Location = new System.Drawing.Point(125, 411);
            this.LBLAvisoContraRepetida.Name = "LBLAvisoContraRepetida";
            this.LBLAvisoContraRepetida.Size = new System.Drawing.Size(0, 13);
            this.LBLAvisoContraRepetida.TabIndex = 18;
            // 
            // TXTBRepetirContra
            // 
            this.TXTBRepetirContra.Location = new System.Drawing.Point(167, 388);
            this.TXTBRepetirContra.Name = "TXTBRepetirContra";
            this.TXTBRepetirContra.PasswordChar = '*';
            this.TXTBRepetirContra.Size = new System.Drawing.Size(100, 20);
            this.TXTBRepetirContra.TabIndex = 17;
            // 
            // LBLConfirmarContrasena
            // 
            this.LBLConfirmarContrasena.AutoSize = true;
            this.LBLConfirmarContrasena.Location = new System.Drawing.Point(164, 372);
            this.LBLConfirmarContrasena.Name = "LBLConfirmarContrasena";
            this.LBLConfirmarContrasena.Size = new System.Drawing.Size(105, 13);
            this.LBLConfirmarContrasena.TabIndex = 19;
            this.LBLConfirmarContrasena.Text = "Repite la contraseña";
            // 
            // TXTBRepetirContrasena
            // 
            this.TXTBRepetirContrasena.Location = new System.Drawing.Point(450, 0);
            this.TXTBRepetirContrasena.Name = "TXTBRepetirContrasena";
            this.TXTBRepetirContrasena.Size = new System.Drawing.Size(433, 461);
            this.TXTBRepetirContrasena.TabIndex = 21;
            // 
            // LBLAvisoCorreo
            // 
            this.LBLAvisoCorreo.AutoSize = true;
            this.LBLAvisoCorreo.Location = new System.Drawing.Point(274, 298);
            this.LBLAvisoCorreo.Name = "LBLAvisoCorreo";
            this.LBLAvisoCorreo.Size = new System.Drawing.Size(0, 13);
            this.LBLAvisoCorreo.TabIndex = 24;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.TXTBRepetirContrasena);
            this.Name = "Registro";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.panelIzquierdo.ResumeLayout(false);
            this.panelIzquierdo.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label LBLNombre;
        private System.Windows.Forms.TextBox TXTBNombre;
        private System.Windows.Forms.Label LBLApellidos;
        private System.Windows.Forms.TextBox TXTBApellidos;
        private System.Windows.Forms.Label LBLTelefono;
        private System.Windows.Forms.TextBox TXTBTelefono;
        private System.Windows.Forms.Label LBLDNI;
        private System.Windows.Forms.TextBox TXTBDNI;
        private System.Windows.Forms.Label LBLDireccion;
        private System.Windows.Forms.TextBox TXTBDireccion;
        private System.Windows.Forms.Label LBLCCC;
        private System.Windows.Forms.TextBox TXTBCCC;
        private System.Windows.Forms.Label LBLEmail;
        private System.Windows.Forms.TextBox TXTBEmail;
        private System.Windows.Forms.Label LBLContrasena;
        private System.Windows.Forms.TextBox TXTBContrasena;
        private System.Windows.Forms.Button BTNRegistrar;
        private System.Windows.Forms.Button BTNBorrarForm;
        private System.Windows.Forms.Label LBLAvisoContrasena;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel TXTBRepetirContrasena;
        private System.Windows.Forms.TextBox TXTBRepetirContra;
        private System.Windows.Forms.Label LBLConfirmarContrasena;
        private System.Windows.Forms.Label LBLAvisoContraRepetida;
        private System.Windows.Forms.Button BTNVerContraNormal;
        private System.Windows.Forms.Button BTNVerContraRepe;
        private System.Windows.Forms.Label LBLAvisoCorreo;
    }
}