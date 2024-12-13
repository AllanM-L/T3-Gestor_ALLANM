namespace T3_Gestor_ALLANM.Gestión_de_Autores
{
        partial class frm_GestionAutores
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtCiudad = new TextBox();
            txtEstado = new TextBox();
            txtCodigoPostal = new TextBox();
            txtEstadoContrato = new TextBox();
            btnGuardar = new Button();
            labelNombre = new Label();
            labelApellido = new Label();
            labelTelefono = new Label();
            labelDireccion = new Label();
            labelCiudad = new Label();
            labelEstado = new Label();
            labelCodigoPostal = new Label();
            labelEstadoContrato = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(191, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(191, 80);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(191, 120);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 23);
            txtTelefono.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(191, 160);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(200, 23);
            txtDireccion.TabIndex = 3;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(191, 200);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(200, 23);
            txtCiudad.TabIndex = 4;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(191, 240);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(200, 23);
            txtEstado.TabIndex = 5;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(191, 280);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(200, 23);
            txtCodigoPostal.TabIndex = 6;
            // 
            // txtEstadoContrato
            // 
            txtEstadoContrato.Location = new Point(191, 320);
            txtEstadoContrato.Name = "txtEstadoContrato";
            txtEstadoContrato.Size = new Size(200, 23);
            txtEstadoContrato.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(191, 360);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(40, 40);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(54, 15);
            labelNombre.TabIndex = 9;
            labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(40, 80);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(54, 15);
            labelApellido.TabIndex = 10;
            labelApellido.Text = "Apellido:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(40, 120);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(55, 15);
            labelTelefono.TabIndex = 11;
            labelTelefono.Text = "Teléfono:";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(40, 160);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(60, 15);
            labelDireccion.TabIndex = 12;
            labelDireccion.Text = "Dirección:";
            // 
            // labelCiudad
            // 
            labelCiudad.AutoSize = true;
            labelCiudad.Location = new Point(40, 200);
            labelCiudad.Name = "labelCiudad";
            labelCiudad.Size = new Size(48, 15);
            labelCiudad.TabIndex = 13;
            labelCiudad.Text = "Ciudad:";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(40, 240);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(45, 15);
            labelEstado.TabIndex = 14;
            labelEstado.Text = "Estado:";
            // 
            // labelCodigoPostal
            // 
            labelCodigoPostal.AutoSize = true;
            labelCodigoPostal.Location = new Point(40, 280);
            labelCodigoPostal.Name = "labelCodigoPostal";
            labelCodigoPostal.Size = new Size(84, 15);
            labelCodigoPostal.TabIndex = 15;
            labelCodigoPostal.Text = "Código Postal:";
            // 
            // labelEstadoContrato
            // 
            labelEstadoContrato.AutoSize = true;
            labelEstadoContrato.Location = new Point(40, 320);
            labelEstadoContrato.Name = "labelEstadoContrato";
            labelEstadoContrato.Size = new Size(112, 15);
            labelEstadoContrato.TabIndex = 16;
            labelEstadoContrato.Text = "Estado del contrato:";
            // 
            // frm_GestionAutores
            // 
            ClientSize = new Size(437, 420);
            Controls.Add(labelEstadoContrato);
            Controls.Add(labelCodigoPostal);
            Controls.Add(labelEstado);
            Controls.Add(labelCiudad);
            Controls.Add(labelDireccion);
            Controls.Add(labelTelefono);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(btnGuardar);
            Controls.Add(txtEstadoContrato);
            Controls.Add(txtCodigoPostal);
            Controls.Add(txtEstado);
            Controls.Add(txtCiudad);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "frm_GestionAutores";
            Text = "Gestión de Autores";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNombre;
            private System.Windows.Forms.TextBox txtApellido;
            private System.Windows.Forms.TextBox txtTelefono;
            private System.Windows.Forms.TextBox txtDireccion;
            private System.Windows.Forms.TextBox txtCiudad;
            private System.Windows.Forms.TextBox txtEstado;
            private System.Windows.Forms.TextBox txtCodigoPostal;
            private System.Windows.Forms.TextBox txtEstadoContrato;
            private System.Windows.Forms.Button btnGuardar;
            private System.Windows.Forms.Label labelNombre;
            private System.Windows.Forms.Label labelApellido;
            private System.Windows.Forms.Label labelTelefono;
            private System.Windows.Forms.Label labelDireccion;
            private System.Windows.Forms.Label labelCiudad;
            private System.Windows.Forms.Label labelEstado;
            private System.Windows.Forms.Label labelCodigoPostal;
            private System.Windows.Forms.Label labelEstadoContrato;
        }

}