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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userControl11 = new Presentacion.ComponentesPersonalizados.UserControl1();
            this.userControl12 = new Presentacion.ComponentesPersonalizados.UserControl1();
            this.userControl13 = new Presentacion.ComponentesPersonalizados.UserControl1();
            this.userControl14 = new Presentacion.ComponentesPersonalizados.UserControl1();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.userControl11);
            this.flowLayoutPanel1.Controls.Add(this.userControl12);
            this.flowLayoutPanel1.Controls.Add(this.userControl13);
            this.flowLayoutPanel1.Controls.Add(this.userControl14);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, -2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(881, 575);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(3, 3);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(150, 150);
            this.userControl11.TabIndex = 0;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(159, 3);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(150, 150);
            this.userControl12.TabIndex = 1;
            // 
            // userControl13
            // 
            this.userControl13.Location = new System.Drawing.Point(315, 3);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(150, 150);
            this.userControl13.TabIndex = 2;
            // 
            // userControl14
            // 
            this.userControl14.Location = new System.Drawing.Point(471, 3);
            this.userControl14.Name = "userControl14";
            this.userControl14.Size = new System.Drawing.Size(150, 150);
            this.userControl14.TabIndex = 3;
            // 
            // ListadoActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 571);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoActividades";
            this.Text = "ListadoActividades";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentesPersonalizados.UserControl1 userControl11;
        private ComponentesPersonalizados.UserControl1 userControl12;
        private ComponentesPersonalizados.UserControl1 userControl13;
        private ComponentesPersonalizados.UserControl1 userControl14;
    }
}