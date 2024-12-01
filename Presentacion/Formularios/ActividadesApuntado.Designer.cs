namespace Presentacion.Formularios
{
    partial class ActividadesApuntado
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
            this.contenedorActividades = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // contenedorActividades
            // 
            this.contenedorActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.contenedorActividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorActividades.Location = new System.Drawing.Point(0, 0);
            this.contenedorActividades.Name = "contenedorActividades";
            this.contenedorActividades.Size = new System.Drawing.Size(1183, 442);
            this.contenedorActividades.TabIndex = 0;
            // 
            // ActividadesApuntado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 442);
            this.Controls.Add(this.contenedorActividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActividadesApuntado";
            this.Text = "ActividadesDisponibles";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel contenedorActividades;
    }
}