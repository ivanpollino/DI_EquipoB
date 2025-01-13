namespace Presentacion.Formularios
{
    partial class Top5
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
            this.btDescargarGraPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDescargarGraPDF
            // 
            this.btDescargarGraPDF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDescargarGraPDF.ForeColor = System.Drawing.Color.Black;
            this.btDescargarGraPDF.Location = new System.Drawing.Point(654, 493);
            this.btDescargarGraPDF.Name = "btDescargarGraPDF";
            this.btDescargarGraPDF.Size = new System.Drawing.Size(153, 30);
            this.btDescargarGraPDF.TabIndex = 9;
            this.btDescargarGraPDF.Text = "DESCARGAR PDF";
            this.btDescargarGraPDF.UseVisualStyleBackColor = true;
            this.btDescargarGraPDF.Click += new System.EventHandler(this.btDescargarGraPDF_Click);
            // 
            // Top5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(897, 610);
            this.Controls.Add(this.btDescargarGraPDF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Top5";
            this.Text = "Top5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDescargarGraPDF;
    }
}