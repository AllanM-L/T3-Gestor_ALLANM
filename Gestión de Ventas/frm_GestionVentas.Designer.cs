namespace T3_Gestor_ALLANM.Gestión_de_Ventas
{
        partial class frm_GestionVentas
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
                this.cboTienda = new System.Windows.Forms.ComboBox();
                this.txtNumeroOrden = new System.Windows.Forms.TextBox();
                this.dtpFechaOrden = new System.Windows.Forms.DateTimePicker();
                this.cboTitulo = new System.Windows.Forms.ComboBox();
                this.txtTerminosPago = new System.Windows.Forms.TextBox();
                this.btnGuardar = new System.Windows.Forms.Button();
                this.labelTienda = new System.Windows.Forms.Label();
                this.labelNumeroOrden = new System.Windows.Forms.Label();
                this.labelFechaOrden = new System.Windows.Forms.Label();
                this.labelTitulo = new System.Windows.Forms.Label();
                this.labelTerminosPago = new System.Windows.Forms.Label();

                this.SuspendLayout();

                // 
                // cboTienda
                // 
                this.cboTienda.FormattingEnabled = true;
                this.cboTienda.Location = new System.Drawing.Point(160, 40);
                this.cboTienda.Name = "cboTienda";
                this.cboTienda.Size = new System.Drawing.Size(200, 21);
                this.cboTienda.TabIndex = 0;

                // 
                // txtNumeroOrden
                // 
                this.txtNumeroOrden.Location = new System.Drawing.Point(160, 80);
                this.txtNumeroOrden.Name = "txtNumeroOrden";
                this.txtNumeroOrden.Size = new System.Drawing.Size(200, 20);
                this.txtNumeroOrden.TabIndex = 1;

                // 
                // dtpFechaOrden
                // 
                this.dtpFechaOrden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
                this.dtpFechaOrden.Location = new System.Drawing.Point(160, 120);
                this.dtpFechaOrden.Name = "dtpFechaOrden";
                this.dtpFechaOrden.Size = new System.Drawing.Size(200, 20);
                this.dtpFechaOrden.TabIndex = 2;

                // 
                // cboTitulo
                // 
                this.cboTitulo.FormattingEnabled = true;
                this.cboTitulo.Location = new System.Drawing.Point(160, 160);
                this.cboTitulo.Name = "cboTitulo";
                this.cboTitulo.Size = new System.Drawing.Size(200, 21);
                this.cboTitulo.TabIndex = 3;

                // 
                // txtTerminosPago
                // 
                this.txtTerminosPago.Location = new System.Drawing.Point(160, 200);
                this.txtTerminosPago.Name = "txtTerminosPago";
                this.txtTerminosPago.Size = new System.Drawing.Size(200, 20);
                this.txtTerminosPago.TabIndex = 4;

                // 
                // btnGuardar
                // 
                this.btnGuardar.Location = new System.Drawing.Point(160, 240);
                this.btnGuardar.Name = "btnGuardar";
                this.btnGuardar.Size = new System.Drawing.Size(100, 30);
                this.btnGuardar.TabIndex = 5;
                this.btnGuardar.Text = "Guardar";
                this.btnGuardar.UseVisualStyleBackColor = true;
                this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

                // 
                // labelTienda
                // 
                this.labelTienda.AutoSize = true;
                this.labelTienda.Location = new System.Drawing.Point(40, 40);
                this.labelTienda.Name = "labelTienda";
                this.labelTienda.Size = new System.Drawing.Size(45, 13);
                this.labelTienda.TabIndex = 6;
                this.labelTienda.Text = "Tienda:";

                // 
                // labelNumeroOrden
                // 
                this.labelNumeroOrden.AutoSize = true;
                this.labelNumeroOrden.Location = new System.Drawing.Point(40, 80);
                this.labelNumeroOrden.Name = "labelNumeroOrden";
                this.labelNumeroOrden.Size = new System.Drawing.Size(92, 13);
                this.labelNumeroOrden.TabIndex = 7;
                this.labelNumeroOrden.Text = "Número de Orden:";

                // 
                // labelFechaOrden
                // 
                this.labelFechaOrden.AutoSize = true;
                this.labelFechaOrden.Location = new System.Drawing.Point(40, 120);
                this.labelFechaOrden.Name = "labelFechaOrden";
                this.labelFechaOrden.Size = new System.Drawing.Size(75, 13);
                this.labelFechaOrden.TabIndex = 8;
                this.labelFechaOrden.Text = "Fecha de Orden:";

                // 
                // labelTitulo
                // 
                this.labelTitulo.AutoSize = true;
                this.labelTitulo.Location = new System.Drawing.Point(40, 160);
                this.labelTitulo.Name = "labelTitulo";
                this.labelTitulo.Size = new System.Drawing.Size(40, 13);
                this.labelTitulo.TabIndex = 9;
                this.labelTitulo.Text = "Título:";

                // 
                // labelTerminosPago
                // 
                this.labelTerminosPago.AutoSize = true;
                this.labelTerminosPago.Location = new System.Drawing.Point(40, 200);
                this.labelTerminosPago.Name = "labelTerminosPago";
                this.labelTerminosPago.Size = new System.Drawing.Size(100, 13);
                this.labelTerminosPago.TabIndex = 10;
                this.labelTerminosPago.Text = "Términos de Pago:";

                // 
                // frm_GestionVentas
                // 
                this.ClientSize = new System.Drawing.Size(400, 300);
                this.Controls.Add(this.labelTerminosPago);
                this.Controls.Add(this.labelTitulo);
                this.Controls.Add(this.labelFechaOrden);
                this.Controls.Add(this.labelNumeroOrden);
                this.Controls.Add(this.labelTienda);
                this.Controls.Add(this.btnGuardar);
                this.Controls.Add(this.txtTerminosPago);
                this.Controls.Add(this.cboTitulo);
                this.Controls.Add(this.dtpFechaOrden);
                this.Controls.Add(this.txtNumeroOrden);
                this.Controls.Add(this.cboTienda);
                this.Name = "frm_GestionVentas";
                this.Text = "Gestión de Ventas";
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            // Declaración de los controles
            private System.Windows.Forms.ComboBox cboTienda;
            private System.Windows.Forms.TextBox txtNumeroOrden;
            private System.Windows.Forms.DateTimePicker dtpFechaOrden;
            private System.Windows.Forms.ComboBox cboTitulo;
            private System.Windows.Forms.TextBox txtTerminosPago;
            private System.Windows.Forms.Button btnGuardar;
            private System.Windows.Forms.Label labelTienda;
            private System.Windows.Forms.Label labelNumeroOrden;
            private System.Windows.Forms.Label labelFechaOrden;
            private System.Windows.Forms.Label labelTitulo;
            private System.Windows.Forms.Label labelTerminosPago;
        }
    

}