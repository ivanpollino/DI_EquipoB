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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.LBLAvisoDNI = new System.Windows.Forms.Label();
            this.lblAvisoCuenta = new System.Windows.Forms.Label();
            this.LBLAvisoCorreo = new System.Windows.Forms.Label();
            this.BTNVerContraRepe = new System.Windows.Forms.Button();
            this.BTNVerContraNormal = new System.Windows.Forms.Button();
            this.LBLAvisoContraRepetida = new System.Windows.Forms.Label();
            this.LBLAvisoContrasena = new System.Windows.Forms.Label();
            this.TXTBRepetirContra = new System.Windows.Forms.TextBox();
            this.LBLConfirmarContrasena = new System.Windows.Forms.Label();
            this.LBLNombre = new System.Windows.Forms.Label();
            this.BTNBorrarForm = new System.Windows.Forms.Button();
            this.TXTBNombre = new System.Windows.Forms.TextBox();
            this.BTNRegistrar = new System.Windows.Forms.Button();
            this.LBLApellidos = new System.Windows.Forms.Label();
            this.TXTBContrasena = new System.Windows.Forms.TextBox();
            this.TXTBApellidos = new System.Windows.Forms.TextBox();
            this.LBLContrasena = new System.Windows.Forms.Label();
            this.LBLTelefono = new System.Windows.Forms.Label();
            this.TXTBEmail = new System.Windows.Forms.TextBox();
            this.TXTBTelefono = new System.Windows.Forms.TextBox();
            this.LBLEmail = new System.Windows.Forms.Label();
            this.LBLDNI = new System.Windows.Forms.Label();
            this.TXTBCCC = new System.Windows.Forms.TextBox();
            this.TXTBDNI = new System.Windows.Forms.TextBox();
            this.LBLCCC = new System.Windows.Forms.Label();
            this.LBLDireccion = new System.Windows.Forms.Label();
            this.TXTBDireccion = new System.Windows.Forms.TextBox();
            this.LBLTitulo = new System.Windows.Forms.Label();
            this.panelIzquierdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Como tener una contraseña valida";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipTitle = "Como tener un formato de CCC valido";
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackgroundImage = global::Formularios.Properties.Resources.Registro;
            this.panelIzquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelIzquierdo.Controls.Add(this.LBLTitulo);
            this.panelIzquierdo.Controls.Add(this.LBLAvisoDNI);
            this.panelIzquierdo.Controls.Add(this.lblAvisoCuenta);
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
            this.panelIzquierdo.Size = new System.Drawing.Size(894, 461);
            this.panelIzquierdo.TabIndex = 20;
            this.panelIzquierdo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIzquierdo_Paint);
            // 
            // LBLAvisoDNI
            // 
            this.LBLAvisoDNI.AutoSize = true;
            this.LBLAvisoDNI.BackColor = System.Drawing.Color.Transparent;
            this.LBLAvisoDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAvisoDNI.ForeColor = System.Drawing.Color.Red;
            this.LBLAvisoDNI.Location = new System.Drawing.Point(208, 166);
            this.LBLAvisoDNI.Name = "LBLAvisoDNI";
            this.LBLAvisoDNI.Size = new System.Drawing.Size(0, 13);
            this.LBLAvisoDNI.TabIndex = 26;
            // 
            // lblAvisoCuenta
            // 
            this.lblAvisoCuenta.AutoSize = true;
            this.lblAvisoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblAvisoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoCuenta.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoCuenta.Location = new System.Drawing.Point(208, 217);
            this.lblAvisoCuenta.Name = "lblAvisoCuenta";
            this.lblAvisoCuenta.Size = new System.Drawing.Size(0, 13);
            this.lblAvisoCuenta.TabIndex = 25;
            this.toolTip2.SetToolTip(this.lblAvisoCuenta, "La CCC debe tener:\n- Empezar por ES\n- Y tener 20 digitos numericos\n");
            // 
            // LBLAvisoCorreo
            // 
            this.LBLAvisoCorreo.AutoSize = true;
            this.LBLAvisoCorreo.BackColor = System.Drawing.Color.Transparent;
            this.LBLAvisoCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAvisoCorreo.ForeColor = System.Drawing.Color.Red;
            this.LBLAvisoCorreo.Location = new System.Drawing.Point(76, 266);
            this.LBLAvisoCorreo.Name = "LBLAvisoCorreo";
            this.LBLAvisoCorreo.Size = new System.Drawing.Size(0, 13);
            this.LBLAvisoCorreo.TabIndex = 24;
            // 
            // BTNVerContraRepe
            // 
            this.BTNVerContraRepe.Image = global::Formularios.Properties.Resources.contraVisible;
            this.BTNVerContraRepe.Location = new System.Drawing.Point(285, 343);
            this.BTNVerContraRepe.Name = "BTNVerContraRepe";
            this.BTNVerContraRepe.Size = new System.Drawing.Size(38, 23);
            this.BTNVerContraRepe.TabIndex = 23;
            this.BTNVerContraRepe.UseVisualStyleBackColor = true;
            this.BTNVerContraRepe.Click += new System.EventHandler(this.BTNVerContraRepe_Click);
            // 
            // BTNVerContraNormal
            // 
            this.BTNVerContraNormal.AutoEllipsis = true;
            this.BTNVerContraNormal.Image = global::Formularios.Properties.Resources.contraVisible;
            this.BTNVerContraNormal.Location = new System.Drawing.Point(285, 291);
            this.BTNVerContraNormal.Name = "BTNVerContraNormal";
            this.BTNVerContraNormal.Size = new System.Drawing.Size(38, 23);
            this.BTNVerContraNormal.TabIndex = 22;
            this.BTNVerContraNormal.UseVisualStyleBackColor = true;
            this.BTNVerContraNormal.Click += new System.EventHandler(this.BTNVerContraNormal_Click);
            // 
            // LBLAvisoContraRepetida
            // 
            this.LBLAvisoContraRepetida.AutoSize = true;
            this.LBLAvisoContraRepetida.BackColor = System.Drawing.Color.Transparent;
            this.LBLAvisoContraRepetida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAvisoContraRepetida.ForeColor = System.Drawing.Color.Red;
            this.LBLAvisoContraRepetida.Location = new System.Drawing.Point(76, 368);
            this.LBLAvisoContraRepetida.Name = "LBLAvisoContraRepetida";
            this.LBLAvisoContraRepetida.Size = new System.Drawing.Size(0, 13);
            this.LBLAvisoContraRepetida.TabIndex = 18;
            // 
            // LBLAvisoContrasena
            // 
            this.LBLAvisoContrasena.AutoSize = true;
            this.LBLAvisoContrasena.BackColor = System.Drawing.Color.Transparent;
            this.LBLAvisoContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAvisoContrasena.ForeColor = System.Drawing.Color.Red;
            this.LBLAvisoContrasena.Location = new System.Drawing.Point(75, 314);
            this.LBLAvisoContrasena.Name = "LBLAvisoContrasena";
            this.LBLAvisoContrasena.Size = new System.Drawing.Size(0, 13);
            this.LBLAvisoContrasena.TabIndex = 21;
            this.toolTip1.SetToolTip(this.LBLAvisoContrasena, "La contraseña debe tener:\n- Más de 8 caracteres\n- Letras mayúsculas y minúsculas\n" +
        "- Al menos un número\n- Al menos un carácter especial (% & $ / *)");
            // 
            // TXTBRepetirContra
            // 
            this.TXTBRepetirContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBRepetirContra.Location = new System.Drawing.Point(79, 345);
            this.TXTBRepetirContra.Name = "TXTBRepetirContra";
            this.TXTBRepetirContra.PasswordChar = '*';
            this.TXTBRepetirContra.Size = new System.Drawing.Size(197, 20);
            this.TXTBRepetirContra.TabIndex = 17;
            // 
            // LBLConfirmarContrasena
            // 
            this.LBLConfirmarContrasena.AutoSize = true;
            this.LBLConfirmarContrasena.BackColor = System.Drawing.Color.Transparent;
            this.LBLConfirmarContrasena.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLConfirmarContrasena.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLConfirmarContrasena.Location = new System.Drawing.Point(76, 329);
            this.LBLConfirmarContrasena.Name = "LBLConfirmarContrasena";
            this.LBLConfirmarContrasena.Size = new System.Drawing.Size(133, 17);
            this.LBLConfirmarContrasena.TabIndex = 19;
            this.LBLConfirmarContrasena.Text = "Repite la contraseña";
            // 
            // LBLNombre
            // 
            this.LBLNombre.AutoSize = true;
            this.LBLNombre.BackColor = System.Drawing.Color.Transparent;
            this.LBLNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LBLNombre.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLNombre.Location = new System.Drawing.Point(76, 78);
            this.LBLNombre.Name = "LBLNombre";
            this.LBLNombre.Size = new System.Drawing.Size(65, 19);
            this.LBLNombre.TabIndex = 0;
            this.LBLNombre.Text = "Nombre";
            // 
            // BTNBorrarForm
            // 
            this.BTNBorrarForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBorrarForm.Location = new System.Drawing.Point(78, 393);
            this.BTNBorrarForm.Name = "BTNBorrarForm";
            this.BTNBorrarForm.Size = new System.Drawing.Size(110, 33);
            this.BTNBorrarForm.TabIndex = 20;
            this.BTNBorrarForm.Text = "Limpiar Form";
            this.BTNBorrarForm.UseVisualStyleBackColor = true;
            this.BTNBorrarForm.Click += new System.EventHandler(this.BTNBorrarForm_Click);
            // 
            // TXTBNombre
            // 
            this.TXTBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBNombre.Location = new System.Drawing.Point(79, 97);
            this.TXTBNombre.MaxLength = 30;
            this.TXTBNombre.Name = "TXTBNombre";
            this.TXTBNombre.Size = new System.Drawing.Size(111, 20);
            this.TXTBNombre.TabIndex = 1;
            // 
            // BTNRegistrar
            // 
            this.BTNRegistrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRegistrar.Location = new System.Drawing.Point(208, 393);
            this.BTNRegistrar.Name = "BTNRegistrar";
            this.BTNRegistrar.Size = new System.Drawing.Size(114, 33);
            this.BTNRegistrar.TabIndex = 19;
            this.BTNRegistrar.Text = "Registrarse";
            this.BTNRegistrar.UseVisualStyleBackColor = true;
            this.BTNRegistrar.Click += new System.EventHandler(this.BTNRegistrar_Click);
            // 
            // LBLApellidos
            // 
            this.LBLApellidos.AutoSize = true;
            this.LBLApellidos.BackColor = System.Drawing.Color.Transparent;
            this.LBLApellidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLApellidos.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLApellidos.Location = new System.Drawing.Point(210, 78);
            this.LBLApellidos.Name = "LBLApellidos";
            this.LBLApellidos.Size = new System.Drawing.Size(66, 17);
            this.LBLApellidos.TabIndex = 2;
            this.LBLApellidos.Text = "Apellidos";
            // 
            // TXTBContrasena
            // 
            this.TXTBContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBContrasena.Location = new System.Drawing.Point(79, 293);
            this.TXTBContrasena.MaxLength = 30;
            this.TXTBContrasena.Name = "TXTBContrasena";
            this.TXTBContrasena.PasswordChar = '*';
            this.TXTBContrasena.Size = new System.Drawing.Size(197, 20);
            this.TXTBContrasena.TabIndex = 16;
            // 
            // TXTBApellidos
            // 
            this.TXTBApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBApellidos.Location = new System.Drawing.Point(211, 97);
            this.TXTBApellidos.MaxLength = 60;
            this.TXTBApellidos.Name = "TXTBApellidos";
            this.TXTBApellidos.Size = new System.Drawing.Size(111, 20);
            this.TXTBApellidos.TabIndex = 3;
            // 
            // LBLContrasena
            // 
            this.LBLContrasena.AutoSize = true;
            this.LBLContrasena.BackColor = System.Drawing.Color.Transparent;
            this.LBLContrasena.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLContrasena.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLContrasena.Location = new System.Drawing.Point(76, 277);
            this.LBLContrasena.Name = "LBLContrasena";
            this.LBLContrasena.Size = new System.Drawing.Size(77, 17);
            this.LBLContrasena.TabIndex = 15;
            this.LBLContrasena.Text = "Contraseña";
            // 
            // LBLTelefono
            // 
            this.LBLTelefono.AutoSize = true;
            this.LBLTelefono.BackColor = System.Drawing.Color.Transparent;
            this.LBLTelefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTelefono.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLTelefono.Location = new System.Drawing.Point(75, 130);
            this.LBLTelefono.Name = "LBLTelefono";
            this.LBLTelefono.Size = new System.Drawing.Size(62, 17);
            this.LBLTelefono.TabIndex = 4;
            this.LBLTelefono.Text = "Teléfono";
            // 
            // TXTBEmail
            // 
            this.TXTBEmail.BackColor = System.Drawing.SystemColors.Window;
            this.TXTBEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBEmail.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TXTBEmail.Location = new System.Drawing.Point(79, 245);
            this.TXTBEmail.MaxLength = 60;
            this.TXTBEmail.Name = "TXTBEmail";
            this.TXTBEmail.Size = new System.Drawing.Size(243, 20);
            this.TXTBEmail.TabIndex = 14;
            // 
            // TXTBTelefono
            // 
            this.TXTBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBTelefono.Location = new System.Drawing.Point(79, 146);
            this.TXTBTelefono.MaxLength = 9;
            this.TXTBTelefono.Name = "TXTBTelefono";
            this.TXTBTelefono.Size = new System.Drawing.Size(111, 20);
            this.TXTBTelefono.TabIndex = 6;
            this.TXTBTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.caparSoloNumeros);
            // 
            // LBLEmail
            // 
            this.LBLEmail.AutoSize = true;
            this.LBLEmail.BackColor = System.Drawing.Color.Transparent;
            this.LBLEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEmail.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLEmail.Location = new System.Drawing.Point(78, 229);
            this.LBLEmail.Name = "LBLEmail";
            this.LBLEmail.Size = new System.Drawing.Size(121, 17);
            this.LBLEmail.TabIndex = 13;
            this.LBLEmail.Text = "Correo electronico";
            // 
            // LBLDNI
            // 
            this.LBLDNI.AutoSize = true;
            this.LBLDNI.BackColor = System.Drawing.Color.Transparent;
            this.LBLDNI.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDNI.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLDNI.Location = new System.Drawing.Point(209, 130);
            this.LBLDNI.Name = "LBLDNI";
            this.LBLDNI.Size = new System.Drawing.Size(32, 17);
            this.LBLDNI.TabIndex = 7;
            this.LBLDNI.Text = "DNI";
            // 
            // TXTBCCC
            // 
            this.TXTBCCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBCCC.Location = new System.Drawing.Point(211, 194);
            this.TXTBCCC.MaxLength = 22;
            this.TXTBCCC.Name = "TXTBCCC";
            this.TXTBCCC.Size = new System.Drawing.Size(111, 20);
            this.TXTBCCC.TabIndex = 12;
            // 
            // TXTBDNI
            // 
            this.TXTBDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBDNI.Location = new System.Drawing.Point(211, 146);
            this.TXTBDNI.MaxLength = 9;
            this.TXTBDNI.Name = "TXTBDNI";
            this.TXTBDNI.Size = new System.Drawing.Size(111, 20);
            this.TXTBDNI.TabIndex = 8;
            // 
            // LBLCCC
            // 
            this.LBLCCC.AutoSize = true;
            this.LBLCCC.BackColor = System.Drawing.Color.Transparent;
            this.LBLCCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCCC.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLCCC.Location = new System.Drawing.Point(209, 178);
            this.LBLCCC.Name = "LBLCCC";
            this.LBLCCC.Size = new System.Drawing.Size(32, 17);
            this.LBLCCC.TabIndex = 11;
            this.LBLCCC.Text = "CCC";
            // 
            // LBLDireccion
            // 
            this.LBLDireccion.AutoSize = true;
            this.LBLDireccion.BackColor = System.Drawing.Color.Transparent;
            this.LBLDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDireccion.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLDireccion.Location = new System.Drawing.Point(76, 178);
            this.LBLDireccion.Name = "LBLDireccion";
            this.LBLDireccion.Size = new System.Drawing.Size(66, 17);
            this.LBLDireccion.TabIndex = 9;
            this.LBLDireccion.Text = "Dirección";
            // 
            // TXTBDireccion
            // 
            this.TXTBDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBDireccion.Location = new System.Drawing.Point(79, 194);
            this.TXTBDireccion.MaxLength = 60;
            this.TXTBDireccion.Name = "TXTBDireccion";
            this.TXTBDireccion.Size = new System.Drawing.Size(111, 20);
            this.TXTBDireccion.TabIndex = 10;
            // 
            // LBLTitulo
            // 
            this.LBLTitulo.AutoSize = true;
            this.LBLTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LBLTitulo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.LBLTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLTitulo.Location = new System.Drawing.Point(71, 13);
            this.LBLTitulo.Name = "LBLTitulo";
            this.LBLTitulo.Size = new System.Drawing.Size(172, 51);
            this.LBLTitulo.TabIndex = 27;
            this.LBLTitulo.Text = "Registro";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelIzquierdo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.TextBox TXTBRepetirContra;
        private System.Windows.Forms.Label LBLConfirmarContrasena;
        private System.Windows.Forms.Label LBLAvisoContraRepetida;
        private System.Windows.Forms.Button BTNVerContraNormal;
        private System.Windows.Forms.Button BTNVerContraRepe;
        private System.Windows.Forms.Label LBLAvisoCorreo;
        private System.Windows.Forms.Label LBLAvisoDNI;
        private System.Windows.Forms.Label lblAvisoCuenta;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label LBLTitulo;
    }
}