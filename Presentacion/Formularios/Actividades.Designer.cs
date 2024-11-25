
namespace Presentacion.Formularios
{
    partial class Actividades
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
            this.lbActividades = new System.Windows.Forms.Label();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.chbTusActividades = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbActividades
            // 
            this.lbActividades.AutoSize = true;
            this.lbActividades.Font = new System.Drawing.Font("Segoe UI Black", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbActividades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lbActividades.Location = new System.Drawing.Point(376, 18);
            this.lbActividades.Name = "lbActividades";
            this.lbActividades.Size = new System.Drawing.Size(401, 72);
            this.lbActividades.TabIndex = 0;
            this.lbActividades.Text = "ACTIVIDADES";
            this.lbActividades.Paint += new System.Windows.Forms.PaintEventHandler(this.lbActividades_Paint);
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panelFormularios.Location = new System.Drawing.Point(0, 175);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1183, 442);
            this.panelFormularios.TabIndex = 2;
            // 
            // chbTusActividades
            // 
            this.chbTusActividades.AutoSize = true;
            this.chbTusActividades.Location = new System.Drawing.Point(660, 103);
            this.chbTusActividades.Name = "chbTusActividades";
            this.chbTusActividades.Size = new System.Drawing.Size(117, 17);
            this.chbTusActividades.TabIndex = 3;
            this.chbTusActividades.Text = "Ver tus Actividades";
            this.chbTusActividades.UseVisualStyleBackColor = true;
            this.chbTusActividades.CheckedChanged += new System.EventHandler(this.chbTusActividades_CheckedChanged);
            // 
            // Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.chbTusActividades);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.lbActividades);
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "Actividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbActividades;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.CheckBox chbTusActividades;
    }
}