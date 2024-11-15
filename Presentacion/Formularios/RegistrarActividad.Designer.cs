
namespace Presentacion
{
    partial class RegistrarActividad
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMonitores = new System.Windows.Forms.ComboBox();
            this.btLimpiarForm = new System.Windows.Forms.Button();
            this.btRegistrarAct = new System.Windows.Forms.Button();
            this.tbxNombreAct = new System.Windows.Forms.TextBox();
            this.tbxDescripcionAct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbNombreActv = new System.Windows.Forms.Label();
            this.LBLTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.cbMonitores);
            this.panel1.Controls.Add(this.btLimpiarForm);
            this.panel1.Controls.Add(this.btRegistrarAct);
            this.panel1.Controls.Add(this.tbxNombreAct);
            this.panel1.Controls.Add(this.tbxDescripcionAct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbDescripcion);
            this.panel1.Controls.Add(this.lbNombreActv);
            this.panel1.Controls.Add(this.LBLTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // cbMonitores
            // 
            this.cbMonitores.FormattingEnabled = true;
            this.cbMonitores.Location = new System.Drawing.Point(83, 265);
            this.cbMonitores.Name = "cbMonitores";
            this.cbMonitores.Size = new System.Drawing.Size(248, 21);
            this.cbMonitores.TabIndex = 38;
            // 
            // btLimpiarForm
            // 
            this.btLimpiarForm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiarForm.Location = new System.Drawing.Point(211, 341);
            this.btLimpiarForm.Name = "btLimpiarForm";
            this.btLimpiarForm.Size = new System.Drawing.Size(122, 35);
            this.btLimpiarForm.TabIndex = 37;
            this.btLimpiarForm.Text = "Limpiar Form";
            this.btLimpiarForm.UseVisualStyleBackColor = true;
            this.btLimpiarForm.Click += new System.EventHandler(this.btLimpiarForm_Click);
            // 
            // btRegistrarAct
            // 
            this.btRegistrarAct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarAct.Location = new System.Drawing.Point(83, 341);
            this.btRegistrarAct.Name = "btRegistrarAct";
            this.btRegistrarAct.Size = new System.Drawing.Size(122, 35);
            this.btRegistrarAct.TabIndex = 36;
            this.btRegistrarAct.Text = " Registrar Actividad";
            this.btRegistrarAct.UseVisualStyleBackColor = true;
            this.btRegistrarAct.Click += new System.EventHandler(this.btRegistrarAct_Click);
            // 
            // tbxNombreAct
            // 
            this.tbxNombreAct.Location = new System.Drawing.Point(83, 163);
            this.tbxNombreAct.Name = "tbxNombreAct";
            this.tbxNombreAct.Size = new System.Drawing.Size(381, 20);
            this.tbxNombreAct.TabIndex = 34;
            // 
            // tbxDescripcionAct
            // 
            this.tbxDescripcionAct.Location = new System.Drawing.Point(83, 215);
            this.tbxDescripcionAct.Name = "tbxDescripcionAct";
            this.tbxDescripcionAct.Size = new System.Drawing.Size(381, 20);
            this.tbxDescripcionAct.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "lbMonitor";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Monitor asociado";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbDescripcion.ForeColor = System.Drawing.Color.White;
            this.lbDescripcion.Location = new System.Drawing.Point(79, 193);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(190, 19);
            this.lbDescripcion.TabIndex = 30;
            this.lbDescripcion.Text = "Descripción de la actividad";
            // 
            // lbNombreActv
            // 
            this.lbNombreActv.AutoSize = true;
            this.lbNombreActv.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreActv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbNombreActv.ForeColor = System.Drawing.Color.White;
            this.lbNombreActv.Location = new System.Drawing.Point(79, 141);
            this.lbNombreActv.Name = "lbNombreActv";
            this.lbNombreActv.Size = new System.Drawing.Size(168, 19);
            this.lbNombreActv.TabIndex = 29;
            this.lbNombreActv.Text = "Nombre de la actividad";
            // 
            // LBLTitulo
            // 
            this.LBLTitulo.AutoSize = true;
            this.LBLTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LBLTitulo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.LBLTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLTitulo.Location = new System.Drawing.Point(74, 58);
            this.LBLTitulo.Name = "LBLTitulo";
            this.LBLTitulo.Size = new System.Drawing.Size(408, 51);
            this.LBLTitulo.TabIndex = 28;
            this.LBLTitulo.Text = "Registro de Actividad";
            // 
            // RegistrarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarActividad";
            this.Text = "RegistrarActividad";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBLTitulo;
        private System.Windows.Forms.TextBox tbxNombreAct;
        private System.Windows.Forms.TextBox tbxDescripcionAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbNombreActv;
        private System.Windows.Forms.Button btLimpiarForm;
        private System.Windows.Forms.Button btRegistrarAct;
        private System.Windows.Forms.ComboBox cbMonitores;
    }
}