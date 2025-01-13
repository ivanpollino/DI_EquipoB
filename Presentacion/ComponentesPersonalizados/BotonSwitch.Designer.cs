using System.Drawing;

namespace Presentacion.ComponentesPersonalizados
{
    partial class BotonSwitch
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelQueSeMueve = new System.Windows.Forms.Panel();
            this.PanelActividadesDisponibles = new System.Windows.Forms.Panel();
            this.LBLVerMisActividades = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelActividadesDisponibles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQueSeMueve
            // 
            this.panelQueSeMueve.BackColor = System.Drawing.Color.DarkCyan;
            this.panelQueSeMueve.Location = new System.Drawing.Point(0, 0);
            this.panelQueSeMueve.Name = "panelQueSeMueve";
            this.panelQueSeMueve.Size = new System.Drawing.Size(140, 72);
            this.panelQueSeMueve.TabIndex = 1;
            // 
            // PanelActividadesDisponibles
            // 
            this.PanelActividadesDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.PanelActividadesDisponibles.Controls.Add(this.panelQueSeMueve);
            this.PanelActividadesDisponibles.Controls.Add(this.LBLVerMisActividades);
            this.PanelActividadesDisponibles.Controls.Add(this.label1);
            this.PanelActividadesDisponibles.Location = new System.Drawing.Point(0, 0);
            this.PanelActividadesDisponibles.Name = "PanelActividadesDisponibles";
            this.PanelActividadesDisponibles.Size = new System.Drawing.Size(280, 72);
            this.PanelActividadesDisponibles.TabIndex = 0;
            // 
            // LBLVerMisActividades
            // 
            this.LBLVerMisActividades.AutoSize = true;
            this.LBLVerMisActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLVerMisActividades.ForeColor = System.Drawing.Color.White;
            this.LBLVerMisActividades.Location = new System.Drawing.Point(153, 28);
            this.LBLVerMisActividades.Name = "LBLVerMisActividades";
            this.LBLVerMisActividades.Size = new System.Drawing.Size(117, 13);
            this.LBLVerMisActividades.TabIndex = 0;
            this.LBLVerMisActividades.Text = "Ver mis actividades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.MaximumSize = new System.Drawing.Size(120, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ver actividades\n   disponibles";
            // 
            // BotonSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelActividadesDisponibles);
            this.Name = "BotonSwitch";
            this.Size = new System.Drawing.Size(280, 72);
            this.PanelActividadesDisponibles.ResumeLayout(false);
            this.PanelActividadesDisponibles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelActividadesDisponibles;
        private System.Windows.Forms.Label LBLVerMisActividades;
        private System.Windows.Forms.Panel panelQueSeMueve;
        private System.Windows.Forms.Label label1;
    }
}
