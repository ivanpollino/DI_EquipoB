
namespace Presentacion.Formularios
{
    partial class RegistroActividad
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
            this.cbMonitores = new System.Windows.Forms.ComboBox();
            this.btLimpiarForm = new System.Windows.Forms.Button();
            this.btRegistrarAct = new System.Windows.Forms.Button();
            this.tbxNombreAct = new System.Windows.Forms.TextBox();
            this.tbxDescripcionAct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbNombreActv = new System.Windows.Forms.Label();
            this.LBLTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMonitores
            // 
            this.cbMonitores.FormattingEnabled = true;
            this.cbMonitores.Location = new System.Drawing.Point(72, 267);
            this.cbMonitores.Name = "cbMonitores";
            this.cbMonitores.Size = new System.Drawing.Size(248, 21);
            this.cbMonitores.TabIndex = 47;
            // 
            // btLimpiarForm
            // 
            this.btLimpiarForm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiarForm.Location = new System.Drawing.Point(200, 343);
            this.btLimpiarForm.Name = "btLimpiarForm";
            this.btLimpiarForm.Size = new System.Drawing.Size(122, 35);
            this.btLimpiarForm.TabIndex = 46;
            this.btLimpiarForm.Text = "Limpiar Form";
            this.btLimpiarForm.UseVisualStyleBackColor = true;
            this.btLimpiarForm.Click += new System.EventHandler(this.btLimpiarForm_Click);
            // 
            // btRegistrarAct
            // 
            this.btRegistrarAct.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarAct.Location = new System.Drawing.Point(72, 343);
            this.btRegistrarAct.Name = "btRegistrarAct";
            this.btRegistrarAct.Size = new System.Drawing.Size(122, 35);
            this.btRegistrarAct.TabIndex = 45;
            this.btRegistrarAct.Text = " Registrar Actividad";
            this.btRegistrarAct.UseVisualStyleBackColor = true;
            this.btRegistrarAct.Click += new System.EventHandler(this.btRegistrarAct_Click);
            // 
            // tbxNombreAct
            // 
            this.tbxNombreAct.Location = new System.Drawing.Point(72, 165);
            this.tbxNombreAct.Name = "tbxNombreAct";
            this.tbxNombreAct.Size = new System.Drawing.Size(381, 20);
            this.tbxNombreAct.TabIndex = 44;
            // 
            // tbxDescripcionAct
            // 
            this.tbxDescripcionAct.Location = new System.Drawing.Point(72, 217);
            this.tbxDescripcionAct.Name = "tbxDescripcionAct";
            this.tbxDescripcionAct.Size = new System.Drawing.Size(381, 20);
            this.tbxDescripcionAct.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "lbMonitor";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Monitor asociado";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lbDescripcion.Location = new System.Drawing.Point(68, 195);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(190, 19);
            this.lbDescripcion.TabIndex = 41;
            this.lbDescripcion.Text = "Descripción de la actividad";
            // 
            // lbNombreActv
            // 
            this.lbNombreActv.AutoSize = true;
            this.lbNombreActv.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreActv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbNombreActv.ForeColor = System.Drawing.Color.Black;
            this.lbNombreActv.Location = new System.Drawing.Point(68, 143);
            this.lbNombreActv.Name = "lbNombreActv";
            this.lbNombreActv.Size = new System.Drawing.Size(168, 19);
            this.lbNombreActv.TabIndex = 40;
            this.lbNombreActv.Text = "Nombre de la actividad";
            // 
            // LBLTitulo
            // 
            this.LBLTitulo.AutoSize = true;
            this.LBLTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LBLTitulo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.LBLTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBLTitulo.Location = new System.Drawing.Point(63, 60);
            this.LBLTitulo.Name = "LBLTitulo";
            this.LBLTitulo.Size = new System.Drawing.Size(408, 51);
            this.LBLTitulo.TabIndex = 39;
            this.LBLTitulo.Text = "Registro de Actividad";
            // 
            // RegistroActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbMonitores);
            this.Controls.Add(this.btLimpiarForm);
            this.Controls.Add(this.btRegistrarAct);
            this.Controls.Add(this.tbxNombreAct);
            this.Controls.Add(this.tbxDescripcionAct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbNombreActv);
            this.Controls.Add(this.LBLTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroActividad";
            this.Text = "RegistroActividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMonitores;
        private System.Windows.Forms.Button btLimpiarForm;
        private System.Windows.Forms.Button btRegistrarAct;
        private System.Windows.Forms.TextBox tbxNombreAct;
        private System.Windows.Forms.TextBox tbxDescripcionAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbNombreActv;
        private System.Windows.Forms.Label LBLTitulo;
    }
}