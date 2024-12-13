namespace T3_Gestor_ALLANM.Gestión_de_Publicadores
{
        partial class frm_GestionPublicadores
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
            txtNombrePublicador = new TextBox();
            txtCiudad = new TextBox();
            txtEstado = new TextBox();
            txtPais = new TextBox();
            btnGuardar = new Button();
            labelNombrePublicador = new Label();
            labelCiudad = new Label();
            labelEstado = new Label();
            labelPais = new Label();
            SuspendLayout();
            // 
            // txtNombrePublicador
            // 
            txtNombrePublicador.Location = new Point(201, 40);
            txtNombrePublicador.Name = "txtNombrePublicador";
            txtNombrePublicador.Size = new Size(200, 23);
            txtNombrePublicador.TabIndex = 0;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(201, 80);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(200, 23);
            txtCiudad.TabIndex = 1;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(201, 120);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(200, 23);
            txtEstado.TabIndex = 2;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(201, 160);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(200, 23);
            txtPais.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(201, 200);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // labelNombrePublicador
            // 
            labelNombrePublicador.AutoSize = true;
            labelNombrePublicador.Location = new Point(40, 40);
            labelNombrePublicador.Name = "labelNombrePublicador";
            labelNombrePublicador.Size = new Size(133, 15);
            labelNombrePublicador.TabIndex = 5;
            labelNombrePublicador.Text = "Nombre del Publicador:";
            // 
            // labelCiudad
            // 
            labelCiudad.AutoSize = true;
            labelCiudad.Location = new Point(40, 80);
            labelCiudad.Name = "labelCiudad";
            labelCiudad.Size = new Size(48, 15);
            labelCiudad.TabIndex = 6;
            labelCiudad.Text = "Ciudad:";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(40, 120);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(45, 15);
            labelEstado.TabIndex = 7;
            labelEstado.Text = "Estado:";
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Location = new Point(40, 160);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(31, 15);
            labelPais.TabIndex = 8;
            labelPais.Text = "País:";
            // 
            // frm_GestionPublicadores
            // 
            ClientSize = new Size(482, 250);
            Controls.Add(labelPais);
            Controls.Add(labelEstado);
            Controls.Add(labelCiudad);
            Controls.Add(labelNombrePublicador);
            Controls.Add(btnGuardar);
            Controls.Add(txtPais);
            Controls.Add(txtEstado);
            Controls.Add(txtCiudad);
            Controls.Add(txtNombrePublicador);
            Name = "frm_GestionPublicadores";
            Text = "Gestión de Publicadores";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNombrePublicador;
            private System.Windows.Forms.TextBox txtCiudad;
            private System.Windows.Forms.TextBox txtEstado;
            private System.Windows.Forms.TextBox txtPais;
            private System.Windows.Forms.Button btnGuardar;
            private System.Windows.Forms.Label labelNombrePublicador;
            private System.Windows.Forms.Label labelCiudad;
            private System.Windows.Forms.Label labelEstado;
            private System.Windows.Forms.Label labelPais;
        }

}