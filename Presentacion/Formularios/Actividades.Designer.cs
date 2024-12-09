
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
            this.lblMisActividades = new System.Windows.Forms.Label();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.lbActividadesDisponibles = new System.Windows.Forms.Label();
            this.botonSwitch1 = new Presentacion.ComponentesPersonalizados.BotonSwitch();
            this.SuspendLayout();
            // 
            // lblMisActividades
            // 
            this.lblMisActividades.AutoSize = true;
            this.lblMisActividades.Font = new System.Drawing.Font("Segoe UI Black", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMisActividades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblMisActividades.Location = new System.Drawing.Point(339, 22);
            this.lblMisActividades.Name = "lblMisActividades";
            this.lblMisActividades.Size = new System.Drawing.Size(519, 72);
            this.lblMisActividades.TabIndex = 0;
            this.lblMisActividades.Text = "MIS ACTIVIDADES";
            this.lblMisActividades.Paint += new System.Windows.Forms.PaintEventHandler(this.lblMisActividades_Paint);
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panelFormularios.Location = new System.Drawing.Point(0, 175);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1183, 442);
            this.panelFormularios.TabIndex = 2;
            // 
            // lbActividadesDisponibles
            // 
            this.lbActividadesDisponibles.AutoSize = true;
            this.lbActividadesDisponibles.Font = new System.Drawing.Font("Segoe UI Black", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbActividadesDisponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lbActividadesDisponibles.Location = new System.Drawing.Point(205, 22);
            this.lbActividadesDisponibles.Name = "lbActividadesDisponibles";
            this.lbActividadesDisponibles.Size = new System.Drawing.Size(777, 72);
            this.lbActividadesDisponibles.TabIndex = 5;
            this.lbActividadesDisponibles.Text = "ACTIVIDADES DISPONIBLES";
            this.lbActividadesDisponibles.Paint += new System.Windows.Forms.PaintEventHandler(this.lbActividadesDisponibles_Paint);
            // 
            // botonSwitch1
            // 
            this.botonSwitch1.formPadre = null;
            this.botonSwitch1.Location = new System.Drawing.Point(437, 97);
            this.botonSwitch1.Name = "botonSwitch1";
            this.botonSwitch1.Size = new System.Drawing.Size(280, 72);
            this.botonSwitch1.TabIndex = 4;
            // 
            // Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.lbActividadesDisponibles);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.botonSwitch1);
            this.Controls.Add(this.lblMisActividades);
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "Actividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMisActividades;
        private System.Windows.Forms.Panel panelFormularios;
        private ComponentesPersonalizados.BotonSwitch botonSwitch1;
        private System.Windows.Forms.Label lbActividadesDisponibles;
    }
}