namespace T3_Gestor_ALLANM.Gestión_de_Programación_de_Regalías
{

        partial class frm_GestionProgramacionRegalias
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
                this.cboTitulo = new System.Windows.Forms.ComboBox();
                this.numericUpDownRangoBajo = new System.Windows.Forms.NumericUpDown();
                this.numericUpDownRangoAlto = new System.Windows.Forms.NumericUpDown();
                this.numericUpDownRegalias = new System.Windows.Forms.NumericUpDown();
                this.btnGuardar = new System.Windows.Forms.Button();
                this.labelTitulo = new System.Windows.Forms.Label();
                this.labelRangoBajo = new System.Windows.Forms.Label();
                this.labelRangoAlto = new System.Windows.Forms.Label();
                this.labelRegalias = new System.Windows.Forms.Label();

                ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangoBajo)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangoAlto)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegalias)).BeginInit();
                this.SuspendLayout();

                // 
                // cboTitulo
                // 
                this.cboTitulo.FormattingEnabled = true;
                this.cboTitulo.Location = new System.Drawing.Point(160, 40);
                this.cboTitulo.Name = "cboTitulo";
                this.cboTitulo.Size = new System.Drawing.Size(200, 21);
                this.cboTitulo.TabIndex = 0;

                // 
                // numericUpDownRangoBajo
                // 
                this.numericUpDownRangoBajo.Location = new System.Drawing.Point(160, 80);
                this.numericUpDownRangoBajo.Name = "numericUpDownRangoBajo";
                this.numericUpDownRangoBajo.Size = new System.Drawing.Size(120, 20);
                this.numericUpDownRangoBajo.TabIndex = 1;

                // 
                // numericUpDownRangoAlto
                // 
                this.numericUpDownRangoAlto.Location = new System.Drawing.Point(160, 120);
                this.numericUpDownRangoAlto.Name = "numericUpDownRangoAlto";
                this.numericUpDownRangoAlto.Size = new System.Drawing.Size(120, 20);
                this.numericUpDownRangoAlto.TabIndex = 2;

                // 
                // numericUpDownRegalias
                // 
                this.numericUpDownRegalias.Location = new System.Drawing.Point(160, 160);
                this.numericUpDownRegalias.Name = "numericUpDownRegalias";
                this.numericUpDownRegalias.Size = new System.Drawing.Size(120, 20);
                this.numericUpDownRegalias.TabIndex = 3;

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
                // labelTitulo
                // 
                this.labelTitulo.AutoSize = true;
                this.labelTitulo.Location = new System.Drawing.Point(40, 40);
                this.labelTitulo.Name = "labelTitulo";
                this.labelTitulo.Size = new System.Drawing.Size(38, 13);
                this.labelTitulo.TabIndex = 5;
                this.labelTitulo.Text = "Título:";

                // 
                // labelRangoBajo
                // 
                this.labelRangoBajo.AutoSize = true;
                this.labelRangoBajo.Location = new System.Drawing.Point(40, 80);
                this.labelRangoBajo.Name = "labelRangoBajo";
                this.labelRangoBajo.Size = new System.Drawing.Size(72, 13);
                this.labelRangoBajo.TabIndex = 6;
                this.labelRangoBajo.Text = "Rango Bajo:";

                // 
                // labelRangoAlto
                // 
                this.labelRangoAlto.AutoSize = true;
                this.labelRangoAlto.Location = new System.Drawing.Point(40, 120);
                this.labelRangoAlto.Name = "labelRangoAlto";
                this.labelRangoAlto.Size = new System.Drawing.Size(69, 13);
                this.labelRangoAlto.TabIndex = 7;
                this.labelRangoAlto.Text = "Rango Alto:";

                // 
                // labelRegalias
                // 
                this.labelRegalias.AutoSize = true;
                this.labelRegalias.Location = new System.Drawing.Point(40, 160);
                this.labelRegalias.Name = "labelRegalias";
                this.labelRegalias.Size = new System.Drawing.Size(56, 13);
                this.labelRegalias.TabIndex = 8;
                this.labelRegalias.Text = "Regalías:";

                // 
                // frm_GestionProgramacionRegalias
                // 
                this.ClientSize = new System.Drawing.Size(400, 250);
                this.Controls.Add(this.labelRegalias);
                this.Controls.Add(this.labelRangoAlto);
                this.Controls.Add(this.labelRangoBajo);
                this.Controls.Add(this.labelTitulo);
                this.Controls.Add(this.btnGuardar);
                this.Controls.Add(this.numericUpDownRegalias);
                this.Controls.Add(this.numericUpDownRangoAlto);
                this.Controls.Add(this.numericUpDownRangoBajo);
                this.Controls.Add(this.cboTitulo);
                this.Name = "frm_GestionProgramacionRegalias";
                this.Text = "Gestión de Programación de Regalías";

                ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangoBajo)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangoAlto)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegalias)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            private System.Windows.Forms.ComboBox cboTitulo;
            private System.Windows.Forms.NumericUpDown numericUpDownRangoBajo;
            private System.Windows.Forms.NumericUpDown numericUpDownRangoAlto;
            private System.Windows.Forms.NumericUpDown numericUpDownRegalias;
            private System.Windows.Forms.Button btnGuardar;
            private System.Windows.Forms.Label labelTitulo;
            private System.Windows.Forms.Label labelRangoBajo;
            private System.Windows.Forms.Label labelRangoAlto;
            private System.Windows.Forms.Label labelRegalias;
        }

}