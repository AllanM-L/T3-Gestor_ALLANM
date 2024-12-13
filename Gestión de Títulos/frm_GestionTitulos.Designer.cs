namespace T3_Gestor_ALLANM.Gestión_de_Títulos
{
        partial class frm_GestionTitulos
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
            txtTitulo = new TextBox();
            txtTipo = new TextBox();
            numericUpDownPrecio = new NumericUpDown();
            numericUpDownAnticipo = new NumericUpDown();
            numericUpDownRegalias = new NumericUpDown();
            numericUpDownVentasAcumuladas = new NumericUpDown();
            dtpFechaPublicacion = new DateTimePicker();
            cboPublicador = new ComboBox();
            btnGuardar = new Button();
            labelTitulo = new Label();
            labelTipo = new Label();
            labelPrecio = new Label();
            labelAnticipo = new Label();
            labelRegalias = new Label();
            labelVentasAcumuladas = new Label();
            labelFechaPublicacion = new Label();
            labelPublicador = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnticipo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegalias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVentasAcumuladas).BeginInit();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(197, 38);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(200, 23);
            txtTitulo.TabIndex = 0;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(197, 78);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(200, 23);
            txtTipo.TabIndex = 1;
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.Location = new Point(197, 118);
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(200, 23);
            numericUpDownPrecio.TabIndex = 2;
            // 
            // numericUpDownAnticipo
            // 
            numericUpDownAnticipo.Location = new Point(197, 158);
            numericUpDownAnticipo.Name = "numericUpDownAnticipo";
            numericUpDownAnticipo.Size = new Size(200, 23);
            numericUpDownAnticipo.TabIndex = 3;
            // 
            // numericUpDownRegalias
            // 
            numericUpDownRegalias.Location = new Point(197, 198);
            numericUpDownRegalias.Name = "numericUpDownRegalias";
            numericUpDownRegalias.Size = new Size(200, 23);
            numericUpDownRegalias.TabIndex = 4;
            // 
            // numericUpDownVentasAcumuladas
            // 
            numericUpDownVentasAcumuladas.Location = new Point(197, 238);
            numericUpDownVentasAcumuladas.Name = "numericUpDownVentasAcumuladas";
            numericUpDownVentasAcumuladas.Size = new Size(200, 23);
            numericUpDownVentasAcumuladas.TabIndex = 5;
            // 
            // dtpFechaPublicacion
            // 
            dtpFechaPublicacion.Format = DateTimePickerFormat.Short;
            dtpFechaPublicacion.Location = new Point(197, 278);
            dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            dtpFechaPublicacion.Size = new Size(200, 23);
            dtpFechaPublicacion.TabIndex = 6;
            // 
            // cboPublicador
            // 
            cboPublicador.FormattingEnabled = true;
            cboPublicador.Location = new Point(197, 318);
            cboPublicador.Name = "cboPublicador";
            cboPublicador.Size = new Size(200, 23);
            cboPublicador.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(160, 360);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(40, 40);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(40, 15);
            labelTitulo.TabIndex = 9;
            labelTitulo.Text = "Título:";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(40, 80);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(33, 15);
            labelTipo.TabIndex = 10;
            labelTipo.Text = "Tipo:";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(40, 120);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(43, 15);
            labelPrecio.TabIndex = 11;
            labelPrecio.Text = "Precio:";
            // 
            // labelAnticipo
            // 
            labelAnticipo.AutoSize = true;
            labelAnticipo.Location = new Point(40, 160);
            labelAnticipo.Name = "labelAnticipo";
            labelAnticipo.Size = new Size(55, 15);
            labelAnticipo.TabIndex = 12;
            labelAnticipo.Text = "Anticipo:";
            // 
            // labelRegalias
            // 
            labelRegalias.AutoSize = true;
            labelRegalias.Location = new Point(40, 200);
            labelRegalias.Name = "labelRegalias";
            labelRegalias.Size = new Size(53, 15);
            labelRegalias.TabIndex = 13;
            labelRegalias.Text = "Regalías:";
            // 
            // labelVentasAcumuladas
            // 
            labelVentasAcumuladas.AutoSize = true;
            labelVentasAcumuladas.Location = new Point(40, 240);
            labelVentasAcumuladas.Name = "labelVentasAcumuladas";
            labelVentasAcumuladas.Size = new Size(113, 15);
            labelVentasAcumuladas.TabIndex = 14;
            labelVentasAcumuladas.Text = "Ventas Acumuladas:";
            // 
            // labelFechaPublicacion
            // 
            labelFechaPublicacion.AutoSize = true;
            labelFechaPublicacion.Location = new Point(40, 280);
            labelFechaPublicacion.Name = "labelFechaPublicacion";
            labelFechaPublicacion.Size = new Size(122, 15);
            labelFechaPublicacion.TabIndex = 15;
            labelFechaPublicacion.Text = "Fecha de Publicación:";
            // 
            // labelPublicador
            // 
            labelPublicador.AutoSize = true;
            labelPublicador.Location = new Point(40, 320);
            labelPublicador.Name = "labelPublicador";
            labelPublicador.Size = new Size(67, 15);
            labelPublicador.TabIndex = 16;
            labelPublicador.Text = "Publicador:";
            // 
            // frm_GestionTitulos
            // 
            ClientSize = new Size(462, 420);
            Controls.Add(labelPublicador);
            Controls.Add(labelFechaPublicacion);
            Controls.Add(labelVentasAcumuladas);
            Controls.Add(labelRegalias);
            Controls.Add(labelAnticipo);
            Controls.Add(labelPrecio);
            Controls.Add(labelTipo);
            Controls.Add(labelTitulo);
            Controls.Add(btnGuardar);
            Controls.Add(cboPublicador);
            Controls.Add(dtpFechaPublicacion);
            Controls.Add(numericUpDownVentasAcumuladas);
            Controls.Add(numericUpDownRegalias);
            Controls.Add(numericUpDownAnticipo);
            Controls.Add(numericUpDownPrecio);
            Controls.Add(txtTipo);
            Controls.Add(txtTitulo);
            Name = "frm_GestionTitulos";
            Text = "Gestión de Títulos";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnticipo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRegalias).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVentasAcumuladas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        
        private System.Windows.Forms.TextBox txtTitulo;
            private System.Windows.Forms.TextBox txtTipo;
            private System.Windows.Forms.NumericUpDown numericUpDownPrecio;
            private System.Windows.Forms.NumericUpDown numericUpDownAnticipo;
            private System.Windows.Forms.NumericUpDown numericUpDownRegalias;
            private System.Windows.Forms.NumericUpDown numericUpDownVentasAcumuladas;
            private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;
            private System.Windows.Forms.ComboBox cboPublicador;
            private System.Windows.Forms.Button btnGuardar;
            private System.Windows.Forms.Label labelTitulo;
            private System.Windows.Forms.Label labelTipo;
            private System.Windows.Forms.Label labelPrecio;
            private System.Windows.Forms.Label labelAnticipo;
            private System.Windows.Forms.Label labelRegalias;
            private System.Windows.Forms.Label labelVentasAcumuladas;
            private System.Windows.Forms.Label labelFechaPublicacion;
            private System.Windows.Forms.Label labelPublicador;
        }

}