using System.Windows.Forms;

namespace Presentacion
{
    partial class ListadoActividades
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
            this.contenedorActividades = new System.Windows.Forms.FlowLayoutPanel();
            this.MSListadoActividades = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFormRegActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSListadoActividades.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedorActividades
            // 
            this.contenedorActividades.AutoScroll = true;
            this.contenedorActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.contenedorActividades.ContextMenuStrip = this.MSListadoActividades;
            this.contenedorActividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorActividades.Location = new System.Drawing.Point(0, 0);
            this.contenedorActividades.Name = "contenedorActividades";
            this.contenedorActividades.Size = new System.Drawing.Size(897, 610);
            this.contenedorActividades.TabIndex = 0;
            // 
            // MSListadoActividades
            // 
            this.MSListadoActividades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarActividadesToolStripMenuItem,
            this.abrirFormRegActividadToolStripMenuItem});
            this.MSListadoActividades.Name = "MSListadoActividades";
            this.MSListadoActividades.Size = new System.Drawing.Size(323, 70);
            // 
            // borrarActividadesToolStripMenuItem
            // 
            this.borrarActividadesToolStripMenuItem.Name = "borrarActividadesToolStripMenuItem";
            this.borrarActividadesToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.borrarActividadesToolStripMenuItem.Text = "Borrar todas las actividades";
            this.borrarActividadesToolStripMenuItem.Click += new System.EventHandler(this.borrarActividadesToolStripMenuItem_Click);
            // 
            // abrirFormRegActividadToolStripMenuItem
            // 
            this.abrirFormRegActividadToolStripMenuItem.Name = "abrirFormRegActividadToolStripMenuItem";
            this.abrirFormRegActividadToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.abrirFormRegActividadToolStripMenuItem.Text = "Abrir el formulario de creación de una activdad";
            this.abrirFormRegActividadToolStripMenuItem.Click += new System.EventHandler(this.abrirFormRegActividadToolStripMenuItem_Click);
            // 
            // ListadoActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 610);
            this.Controls.Add(this.contenedorActividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoActividades";
            this.Text = "ListadoActividades";
            this.MSListadoActividades.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel contenedorActividades;
        private ContextMenuStrip MSListadoActividades;
        private ToolStripMenuItem borrarActividadesToolStripMenuItem;
        private ToolStripMenuItem abrirFormRegActividadToolStripMenuItem;
    }
}