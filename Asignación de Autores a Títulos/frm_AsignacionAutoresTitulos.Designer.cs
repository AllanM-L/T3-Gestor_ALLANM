namespace T3_Gestor_ALLANM.Asignación_de_Autores_a_Títulos
{
        partial class frm_AsignacionAutoresTitulos
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
                this.cboAutor = new System.Windows.Forms.ComboBox();
                this.cboTitulo = new System.Windows.Forms.ComboBox();
                this.numericUpDownRegalias = new System.Windows.Forms.NumericUpDown();
                this.btnGuardar = new System.Windows.Forms.Button();
                this.labelAutor = new System.Windows.Forms.Label();
                this.labelTitulo = new System.Windows.Forms.Label();
                this.labelRegalias = new System.Windows.Forms.Label();

                ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegalias)).BeginInit();
                this.SuspendLayout();

                // 
                // cboAutor
                // 
                this.cboAutor.FormattingEnabled = true;
                this.cboAutor.Location = new System.Drawing.Point(160, 40);
                this.cboAutor.Name = "cboAutor";
                this.cboAutor.Size = new System.Drawing.Size(200, 21);
                this.cboAutor.TabIndex = 0;

                // 
                // cboTitulo
                // 
                this.cboTitulo.FormattingEnabled = true;
                this.cboTitulo.Location = new System.Drawing.Point(160, 80);
                this.cboTitulo.Name = "cboTitulo";
                this.cboTitulo.Size = new System.Drawing.Size(200, 21);
                this.cboTitulo.TabIndex = 1;

                // 
                // numericUpDownRegalias
                // 
                this.numericUpDownRegalias.DecimalPlaces = 2;
                this.numericUpDownRegalias.Location = new System.Drawing.Point(160, 120);
                this.numericUpDownRegalias.Name = "numericUpDownRegalias";
                this.numericUpDownRegalias.Size = new System.Drawing.Size(200, 20);
                this.numericUpDownRegalias.TabIndex = 2;

                // 
                // btnGuardar
                // 
                this.btnGuardar.Location = new System.Drawing.Point(160, 160);
                this.btnGuardar.Name = "btnGuardar";
                this.btnGuardar.Size = new System.Drawing.Size(100, 30);
                this.btnGuardar.TabIndex = 3;
                this.btnGuardar.Text = "Guardar";
                this.btnGuardar.UseVisualStyleBackColor = true;
                this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

                // 
                // labelAutor
                // 
                this.labelAutor.AutoSize = true;
                this.labelAutor.Location = new System.Drawing.Point(40, 40);
                this.labelAutor.Name = "labelAutor";
                this.labelAutor.Size = new System.Drawing.Size(35, 13);
                this.labelAutor.TabIndex = 4;
                this.labelAutor.Text = "Autor:";

                // 
                // labelTitulo
                // 
                this.labelTitulo.AutoSize = true;
                this.labelTitulo.Location = new System.Drawing.Point(40, 80);
                this.labelTitulo.Name = "labelTitulo";
                this.labelTitulo.Size = new System.Drawing.Size(38, 13);
                this.labelTitulo.TabIndex = 5;
                this.labelTitulo.Text = "Título:";

                // 
                // labelRegalias
                // 
                this.labelRegalias.AutoSize = true;
                this.labelRegalias.Location = new System.Drawing.Point(40, 120);
                this.labelRegalias.Name = "labelRegalias";
                this.labelRegalias.Size = new System.Drawing.Size(55, 13);
                this.labelRegalias.TabIndex = 6;
                this.labelRegalias.Text = "Regalías:";

                // 
                // frm_AsignacionAutoresTitulos
                // 
                this.ClientSize = new System.Drawing.Size(400, 220);
                this.Controls.Add(this.labelRegalias);
                this.Controls.Add(this.labelTitulo);
                this.Controls.Add(this.labelAutor);
                this.Controls.Add(this.btnGuardar);
                this.Controls.Add(this.numericUpDownRegalias);
                this.Controls.Add(this.cboTitulo);
                this.Controls.Add(this.cboAutor);
                this.Name = "frm_AsignacionAutoresTitulos";
                this.Text = "Asignación de Autores a Títulos";
                ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegalias)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            
            private System.Windows.Forms.ComboBox cboAutor;
            private System.Windows.Forms.ComboBox cboTitulo;
            private System.Windows.Forms.NumericUpDown numericUpDownRegalias;
            private System.Windows.Forms.Button btnGuardar;
            private System.Windows.Forms.Label labelAutor;
            private System.Windows.Forms.Label labelTitulo;
            private System.Windows.Forms.Label labelRegalias;
        }

}