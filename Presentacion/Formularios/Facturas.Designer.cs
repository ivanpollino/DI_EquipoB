namespace Presentacion.Formularios
{
    partial class Facturas
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
            this.combAño = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.combMeses = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CRVFactura = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // combAño
            // 
            this.combAño.FormattingEnabled = true;
            this.combAño.Location = new System.Drawing.Point(75, 26);
            this.combAño.Name = "combAño";
            this.combAño.Size = new System.Drawing.Size(121, 21);
            this.combAño.TabIndex = 0;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.BackColor = System.Drawing.Color.Transparent;
            this.lblAño.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblAño.Location = new System.Drawing.Point(36, 30);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(33, 17);
            this.lblAño.TabIndex = 30;
            this.lblAño.Text = "Año";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.BackColor = System.Drawing.Color.Transparent;
            this.lblMes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblMes.Location = new System.Drawing.Point(220, 30);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(33, 17);
            this.lblMes.TabIndex = 31;
            this.lblMes.Text = "Mes";
            // 
            // combMeses
            // 
            this.combMeses.FormattingEnabled = true;
            this.combMeses.Location = new System.Drawing.Point(259, 26);
            this.combMeses.Name = "combMeses";
            this.combMeses.Size = new System.Drawing.Size(121, 21);
            this.combMeses.TabIndex = 32;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::Presentacion.Properties.Resources.search_regular_24;
            this.btnBuscar.Location = new System.Drawing.Point(386, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 29);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CRVFactura
            // 
            this.CRVFactura.ActiveViewIndex = 0;
            this.CRVFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVFactura.Location = new System.Drawing.Point(39, 74);
            this.CRVFactura.Name = "CRVFactura";
            this.CRVFactura.ReportSource = "C:\\Users\\User\\Desktop\\ProyectoDI\\DI_EquipoB\\Presentacion\\Informes\\Factura.rpt";
            this.CRVFactura.Size = new System.Drawing.Size(736, 364);
            this.CRVFactura.TabIndex = 34;
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRVFactura);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.combMeses);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.combAño);
            this.Name = "Facturas";
            this.Text = "Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combAño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox combMeses;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVFactura;
    }
}