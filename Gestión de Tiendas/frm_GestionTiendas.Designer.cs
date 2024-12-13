namespace T3_Gestor_ALLANM.Gestión_de_Tiendas
{
    partial class frm_GestionTiendas
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnGuardar;
        private TextBox txtNombreTienda;
        private TextBox txtDireccionTienda;
        private TextBox txtCiudad;
        private TextBox txtEstado;
        private TextBox txtCodigoPostal;
        private Label lblNombreTienda;
        private Label lblDireccionTienda;
        private Label lblCiudad;
        private Label lblEstado;
        private Label lblCodigoPostal;

        private void InitializeComponent()
        {
            btnGuardar = new Button();
            txtNombreTienda = new TextBox();
            txtDireccionTienda = new TextBox();
            txtCiudad = new TextBox();
            txtEstado = new TextBox();
            txtCodigoPostal = new TextBox();
            lblNombreTienda = new Label();
            lblDireccionTienda = new Label();
            lblCiudad = new Label();
            lblEstado = new Label();
            lblCodigoPostal = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(120, 250);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombreTienda
            // 
            txtNombreTienda.Location = new Point(141, 27);
            txtNombreTienda.Name = "txtNombreTienda";
            txtNombreTienda.Size = new Size(200, 23);
            txtNombreTienda.TabIndex = 1;
            // 
            // txtDireccionTienda
            // 
            txtDireccionTienda.Location = new Point(141, 67);
            txtDireccionTienda.Name = "txtDireccionTienda";
            txtDireccionTienda.Size = new Size(200, 23);
            txtDireccionTienda.TabIndex = 2;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(141, 107);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(200, 23);
            txtCiudad.TabIndex = 3;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(141, 150);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(200, 23);
            txtEstado.TabIndex = 4;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(141, 190);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(200, 23);
            txtCodigoPostal.TabIndex = 5;
            // 
            // lblNombreTienda
            // 
            lblNombreTienda.AutoSize = true;
            lblNombreTienda.Location = new Point(30, 30);
            lblNombreTienda.Name = "lblNombreTienda";
            lblNombreTienda.Size = new Size(105, 15);
            lblNombreTienda.TabIndex = 6;
            lblNombreTienda.Text = "Nombre de Tienda";
            // 
            // lblDireccionTienda
            // 
            lblDireccionTienda.AutoSize = true;
            lblDireccionTienda.Location = new Point(30, 70);
            lblDireccionTienda.Name = "lblDireccionTienda";
            lblDireccionTienda.Size = new Size(111, 15);
            lblDireccionTienda.TabIndex = 7;
            lblDireccionTienda.Text = "Dirección de Tienda";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Location = new Point(30, 110);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(45, 15);
            lblCiudad.TabIndex = 8;
            lblCiudad.Text = "Ciudad";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(30, 150);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Estado";
            // 
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.Location = new Point(30, 190);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(81, 15);
            lblCodigoPostal.TabIndex = 10;
            lblCodigoPostal.Text = "Código Postal";
            // 
            // frm_GestionTiendas
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombreTienda);
            Controls.Add(txtDireccionTienda);
            Controls.Add(txtCiudad);
            Controls.Add(txtEstado);
            Controls.Add(txtCodigoPostal);
            Controls.Add(lblNombreTienda);
            Controls.Add(lblDireccionTienda);
            Controls.Add(lblCiudad);
            Controls.Add(lblEstado);
            Controls.Add(lblCodigoPostal);
            Name = "frm_GestionTiendas";
            Text = "Gestión de Tiendas";
            Load += frm_GestionTiendas_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }

}