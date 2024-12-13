namespace T3_Gestor_ALLANM.Gestión_de_Empleados
{
    partial class frm_GestionEmpleados
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnGuardar;
        private TextBox txtNombre;
        private TextBox txtInicialSegundoNombre;
        private TextBox txtApellido;
        private DateTimePicker dtpFechaContratacion;
        private Label lblNombre;
        private Label lblInicialSegundoNombre;
        private Label lblApellido;
        private Label lblFechaContratacion;
        private Label lblTrabajo;

        private void InitializeComponent()
        {
            btnGuardar = new Button();
            txtNombre = new TextBox();
            txtInicialSegundoNombre = new TextBox();
            txtApellido = new TextBox();
            dtpFechaContratacion = new DateTimePicker();
            lblNombre = new Label();
            lblInicialSegundoNombre = new Label();
            lblApellido = new Label();
            lblFechaContratacion = new Label();
            lblTrabajo = new Label();
            txtTrabajo = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(132, 252);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 43);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(211, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtInicialSegundoNombre
            // 
            txtInicialSegundoNombre.Location = new Point(272, 67);
            txtInicialSegundoNombre.Name = "txtInicialSegundoNombre";
            txtInicialSegundoNombre.Size = new Size(50, 23);
            txtInicialSegundoNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(211, 110);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 23);
            txtApellido.TabIndex = 3;
            // 
            // dtpFechaContratacion
            // 
            dtpFechaContratacion.Location = new Point(211, 150);
            dtpFechaContratacion.Name = "dtpFechaContratacion";
            dtpFechaContratacion.Size = new Size(200, 23);
            dtpFechaContratacion.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(30, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblInicialSegundoNombre
            // 
            lblInicialSegundoNombre.AutoSize = true;
            lblInicialSegundoNombre.Location = new Point(30, 70);
            lblInicialSegundoNombre.Name = "lblInicialSegundoNombre";
            lblInicialSegundoNombre.Size = new Size(135, 15);
            lblInicialSegundoNombre.TabIndex = 7;
            lblInicialSegundoNombre.Text = "Inicial Segundo Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(30, 110);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido";
            // 
            // lblFechaContratacion
            // 
            lblFechaContratacion.AutoSize = true;
            lblFechaContratacion.Location = new Point(30, 150);
            lblFechaContratacion.Name = "lblFechaContratacion";
            lblFechaContratacion.Size = new Size(126, 15);
            lblFechaContratacion.TabIndex = 9;
            lblFechaContratacion.Text = "Fecha de Contratación";
            // 
            // lblTrabajo
            // 
            lblTrabajo.AutoSize = true;
            lblTrabajo.Location = new Point(30, 190);
            lblTrabajo.Name = "lblTrabajo";
            lblTrabajo.Size = new Size(45, 15);
            lblTrabajo.TabIndex = 10;
            lblTrabajo.Text = "Trabajo";
            // 
            // txtTrabajo
            // 
            txtTrabajo.Location = new Point(211, 190);
            txtTrabajo.Name = "txtTrabajo";
            txtTrabajo.Size = new Size(200, 23);
            txtTrabajo.TabIndex = 11;
            txtTrabajo.TextChanged += txtTrabajo_TextChanged;
            // 
            // frm_GestionEmpleados
            // 
            ClientSize = new Size(455, 324);
            Controls.Add(txtTrabajo);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(txtInicialSegundoNombre);
            Controls.Add(txtApellido);
            Controls.Add(dtpFechaContratacion);
            Controls.Add(lblNombre);
            Controls.Add(lblInicialSegundoNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblFechaContratacion);
            Controls.Add(lblTrabajo);
            Name = "frm_GestionEmpleados";
            Text = "Gestión de Empleados";
            Load += frm_GestionEmpleados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtTrabajo;
    }

}