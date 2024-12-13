namespace T3_Gestor_ALLANM.Gestión_de_Trabajos
{
        partial class frm_GestionTrabajos
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
            txtDescripcionTrabajo = new TextBox();
            numericUpDownSalarioMinimo = new NumericUpDown();
            numericUpDownSalarioMaximo = new NumericUpDown();
            btnGuardar = new Button();
            labelDescripcion = new Label();
            labelSalarioMinimo = new Label();
            labelSalarioMaximo = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalarioMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalarioMaximo).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcionTrabajo
            // 
            txtDescripcionTrabajo.Location = new Point(211, 40);
            txtDescripcionTrabajo.Name = "txtDescripcionTrabajo";
            txtDescripcionTrabajo.Size = new Size(200, 23);
            txtDescripcionTrabajo.TabIndex = 0;
            // 
            // numericUpDownSalarioMinimo
            // 
            numericUpDownSalarioMinimo.Location = new Point(211, 80);
            numericUpDownSalarioMinimo.Name = "numericUpDownSalarioMinimo";
            numericUpDownSalarioMinimo.Size = new Size(200, 23);
            numericUpDownSalarioMinimo.TabIndex = 1;
            // 
            // numericUpDownSalarioMaximo
            // 
            numericUpDownSalarioMaximo.Location = new Point(211, 120);
            numericUpDownSalarioMaximo.Name = "numericUpDownSalarioMaximo";
            numericUpDownSalarioMaximo.Size = new Size(200, 23);
            numericUpDownSalarioMaximo.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(211, 160);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(40, 40);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(132, 15);
            labelDescripcion.TabIndex = 4;
            labelDescripcion.Text = "Descripción del Trabajo:";
            // 
            // labelSalarioMinimo
            // 
            labelSalarioMinimo.AutoSize = true;
            labelSalarioMinimo.Location = new Point(40, 80);
            labelSalarioMinimo.Name = "labelSalarioMinimo";
            labelSalarioMinimo.Size = new Size(90, 15);
            labelSalarioMinimo.TabIndex = 5;
            labelSalarioMinimo.Text = "Salario Mínimo:";
            // 
            // labelSalarioMaximo
            // 
            labelSalarioMaximo.AutoSize = true;
            labelSalarioMaximo.Location = new Point(40, 120);
            labelSalarioMaximo.Name = "labelSalarioMaximo";
            labelSalarioMaximo.Size = new Size(92, 15);
            labelSalarioMaximo.TabIndex = 6;
            labelSalarioMaximo.Text = "Salario Máximo:";
            // 
            // frm_GestionTrabajos
            // 
            ClientSize = new Size(510, 250);
            Controls.Add(labelSalarioMaximo);
            Controls.Add(labelSalarioMinimo);
            Controls.Add(labelDescripcion);
            Controls.Add(btnGuardar);
            Controls.Add(numericUpDownSalarioMaximo);
            Controls.Add(numericUpDownSalarioMinimo);
            Controls.Add(txtDescripcionTrabajo);
            Name = "frm_GestionTrabajos";
            Text = "Gestión de Trabajos";
            Load += frm_GestionTrabajos_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalarioMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalarioMaximo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtDescripcionTrabajo;
            private System.Windows.Forms.NumericUpDown numericUpDownSalarioMinimo;
            private System.Windows.Forms.NumericUpDown numericUpDownSalarioMaximo;
            private System.Windows.Forms.Button btnGuardar;
            private System.Windows.Forms.Label labelDescripcion;
            private System.Windows.Forms.Label labelSalarioMinimo;
            private System.Windows.Forms.Label labelSalarioMaximo;
        }
    

}
