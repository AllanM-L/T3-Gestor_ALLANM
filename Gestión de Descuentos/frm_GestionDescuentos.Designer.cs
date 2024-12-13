namespace T3_Gestor_ALLANM.Gestión_de_Descuentos
{
        partial class frm_GestionDescuentos
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
                this.numericUpDownDescuento = new System.Windows.Forms.NumericUpDown();
                this.numericUpDownCantidadBaja = new System.Windows.Forms.NumericUpDown();
                this.numericUpDownCantidadAlta = new System.Windows.Forms.NumericUpDown();
                this.btnGuardar = new System.Windows.Forms.Button();
                this.labelTienda = new System.Windows.Forms.Label();
                this.labelDescuento = new System.Windows.Forms.Label();
                this.labelCantidadBaja = new System.Windows.Forms.Label();
                this.labelCantidadAlta = new System.Windows.Forms.Label();

                ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescuento)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadBaja)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadAlta)).BeginInit();
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
                // numericUpDownDescuento
                // 
                this.numericUpDownDescuento.DecimalPlaces = 2;
                this.numericUpDownDescuento.Location = new System.Drawing.Point(160, 80);
                this.numericUpDownDescuento.Name = "numericUpDownDescuento";
                this.numericUpDownDescuento.Size = new System.Drawing.Size(200, 20);
                this.numericUpDownDescuento.TabIndex = 1;

                // 
                // numericUpDownCantidadBaja
                // 
                this.numericUpDownCantidadBaja.Location = new System.Drawing.Point(160, 120);
                this.numericUpDownCantidadBaja.Name = "numericUpDownCantidadBaja";
                this.numericUpDownCantidadBaja.Size = new System.Drawing.Size(200, 20);
                this.numericUpDownCantidadBaja.TabIndex = 2;

                // 
                // numericUpDownCantidadAlta
                // 
                this.numericUpDownCantidadAlta.Location = new System.Drawing.Point(160, 160);
                this.numericUpDownCantidadAlta.Name = "numericUpDownCantidadAlta";
                this.numericUpDownCantidadAlta.Size = new System.Drawing.Size(200, 20);
                this.numericUpDownCantidadAlta.TabIndex = 3;

                // 
                // btnGuardar
                // 
                this.btnGuardar.Location = new System.Drawing.Point(160, 200);
                this.btnGuardar.Name = "btnGuardar";
                this.btnGuardar.Size = new System.Drawing.Size(100, 30);
                this.btnGuardar.TabIndex = 4;
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
                this.labelTienda.TabIndex = 5;
                this.labelTienda.Text = "Tienda:";

                // 
                // labelDescuento
                // 
                this.labelDescuento.AutoSize = true;
                this.labelDescuento.Location = new System.Drawing.Point(40, 80);
                this.labelDescuento.Name = "labelDescuento";
                this.labelDescuento.Size = new System.Drawing.Size(64, 13);
                this.labelDescuento.TabIndex = 6;
                this.labelDescuento.Text = "Descuento:";

                // 
                // labelCantidadBaja
                // 
                this.labelCantidadBaja.AutoSize = true;
                this.labelCantidadBaja.Location = new System.Drawing.Point(40, 120);
                this.labelCantidadBaja.Name = "labelCantidadBaja";
                this.labelCantidadBaja.Size = new System.Drawing.Size(87, 13);
                this.labelCantidadBaja.TabIndex = 7;
                this.labelCantidadBaja.Text = "Cantidad Baja:";

                // 
                // labelCantidadAlta
                // 
                this.labelCantidadAlta.AutoSize = true;
                this.labelCantidadAlta.Location = new System.Drawing.Point(40, 160);
                this.labelCantidadAlta.Name = "labelCantidadAlta";
                this.labelCantidadAlta.Size = new System.Drawing.Size(81, 13);
                this.labelCantidadAlta.TabIndex = 8;
                this.labelCantidadAlta.Text = "Cantidad Alta:";

                // 
                // frm_GestionDescuentos
                // 
                this.ClientSize = new System.Drawing.Size(400, 250);
                this.Controls.Add(this.labelCantidadAlta);
                this.Controls.Add(this.labelCantidadBaja);
                this.Controls.Add(this.labelDescuento);
                this.Controls.Add(this.labelTienda);
                this.Controls.Add(this.btnGuardar);
                this.Controls.Add(this.numericUpDownCantidadAlta);
                this.Controls.Add(this.numericUpDownCantidadBaja);
                this.Controls.Add(this.numericUpDownDescuento);
                this.Controls.Add(this.cboTienda);
                this.Name = "frm_GestionDescuentos";
                this.Text = "Gestión de Descuentos";
                this.ResumeLayout(false);
                this.PerformLayout();

                ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescuento)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadBaja)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidadAlta)).EndInit();
            }

            
            private System.Windows.Forms.ComboBox cboTienda;
            private System.Windows.Forms.NumericUpDown numericUpDownDescuento;
            private System.Windows.Forms.NumericUpDown numericUpDownCantidadBaja;
            private System.Windows.Forms.NumericUpDown numericUpDownCantidadAlta;
            private System.Windows.Forms.Button btnGuardar;
            private System.Windows.Forms.Label labelTienda;
            private System.Windows.Forms.Label labelDescuento;
            private System.Windows.Forms.Label labelCantidadBaja;
            private System.Windows.Forms.Label labelCantidadAlta;
        }

}