namespace T3_Gestor_ALLANM.Gestión_de_Información_Editorial
{
        partial class frm_GestionInformacionEditorial
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
            cboPublicador = new ComboBox();
            txtLogo = new TextBox();
            txtInformacionAdicional = new TextBox();
            btnGuardar = new Button();
            labelPublicador = new Label();
            labelLogo = new Label();
            labelInformacionAdicional = new Label();
            SuspendLayout();
            // 
            // cboPublicador
            // 
            cboPublicador.FormattingEnabled = true;
            cboPublicador.Location = new Point(192, 40);
            cboPublicador.Name = "cboPublicador";
            cboPublicador.Size = new Size(200, 23);
            cboPublicador.TabIndex = 0;
            // 
            // txtLogo
            // 
            txtLogo.Location = new Point(192, 80);
            txtLogo.Name = "txtLogo";
            txtLogo.Size = new Size(200, 23);
            txtLogo.TabIndex = 1;
            // 
            // txtInformacionAdicional
            // 
            txtInformacionAdicional.Location = new Point(192, 120);
            txtInformacionAdicional.Multiline = true;
            txtInformacionAdicional.Name = "txtInformacionAdicional";
            txtInformacionAdicional.Size = new Size(200, 60);
            txtInformacionAdicional.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(192, 200);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // labelPublicador
            // 
            labelPublicador.AutoSize = true;
            labelPublicador.Location = new Point(40, 40);
            labelPublicador.Name = "labelPublicador";
            labelPublicador.Size = new Size(130, 15);
            labelPublicador.TabIndex = 4;
            labelPublicador.Text = "Seleccionar Publicador:";
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Location = new Point(40, 80);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(37, 15);
            labelLogo.TabIndex = 5;
            labelLogo.Text = "Logo:";
            // 
            // labelInformacionAdicional
            // 
            labelInformacionAdicional.AutoSize = true;
            labelInformacionAdicional.Location = new Point(40, 120);
            labelInformacionAdicional.Name = "labelInformacionAdicional";
            labelInformacionAdicional.Size = new Size(128, 15);
            labelInformacionAdicional.TabIndex = 6;
            labelInformacionAdicional.Text = "Información Adicional:";
            // 
            // frm_GestionInformacionEditorial
            // 
            ClientSize = new Size(475, 296);
            Controls.Add(labelInformacionAdicional);
            Controls.Add(labelLogo);
            Controls.Add(labelPublicador);
            Controls.Add(btnGuardar);
            Controls.Add(txtInformacionAdicional);
            Controls.Add(txtLogo);
            Controls.Add(cboPublicador);
            Name = "frm_GestionInformacionEditorial";
            Text = "Gestión de Información Editorial";
            ResumeLayout(false);
            PerformLayout();
        }

        // Declaración de los controles
        private System.Windows.Forms.ComboBox cboPublicador;
            private System.Windows.Forms.TextBox txtLogo;
            private System.Windows.Forms.TextBox txtInformacionAdicional;
            private System.Windows.Forms.Button btnGuardar;
            private System.Windows.Forms.Label labelPublicador;
            private System.Windows.Forms.Label labelLogo;
            private System.Windows.Forms.Label labelInformacionAdicional;
        }

}