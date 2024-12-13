namespace T3_Gestor_ALLANM
{
    partial class frm_MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_GestionTiendas = new Button();
            btn_GestionEmpleados = new Button();
            btn_GestiónTrabajos = new Button();
            btn_GestionDescuentos = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btn_GestionVentas = new Button();
            btn_GestionTitulos = new Button();
            btn_GestionAutores = new Button();
            btn_AsignacionAutoresTitulos = new Button();
            btn_GestionPublicadores = new Button();
            btn_GestionInformacionEditorial = new Button();
            btn_GestionProgramacionRegalias = new Button();
            pnl_img = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            pnl_img.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_GestionTiendas
            // 
            btn_GestionTiendas.Location = new Point(12, 160);
            btn_GestionTiendas.Name = "btn_GestionTiendas";
            btn_GestionTiendas.Size = new Size(149, 63);
            btn_GestionTiendas.TabIndex = 0;
            btn_GestionTiendas.Text = "Gestión de Tiendas";
            btn_GestionTiendas.UseVisualStyleBackColor = true;
            btn_GestionTiendas.Click += btn_GestionTiendas_click;
            // 
            // btn_GestionEmpleados
            // 
            btn_GestionEmpleados.Location = new Point(12, 293);
            btn_GestionEmpleados.Name = "btn_GestionEmpleados";
            btn_GestionEmpleados.Size = new Size(149, 63);
            btn_GestionEmpleados.TabIndex = 1;
            btn_GestionEmpleados.Text = "Gestión de Empleados";
            btn_GestionEmpleados.UseVisualStyleBackColor = true;
            btn_GestionEmpleados.Click += btn_GestionEmpleados_Click;
            // 
            // btn_GestiónTrabajos
            // 
            btn_GestiónTrabajos.Location = new Point(12, 427);
            btn_GestiónTrabajos.Name = "btn_GestiónTrabajos";
            btn_GestiónTrabajos.Size = new Size(149, 63);
            btn_GestiónTrabajos.TabIndex = 2;
            btn_GestiónTrabajos.Text = "Gestión de Trabajos";
            btn_GestiónTrabajos.UseVisualStyleBackColor = true;
            btn_GestiónTrabajos.Click += btn_GestiónTrabajos_Click;
            // 
            // btn_GestionDescuentos
            // 
            btn_GestionDescuentos.Location = new Point(12, 553);
            btn_GestionDescuentos.Name = "btn_GestionDescuentos";
            btn_GestionDescuentos.Size = new Size(149, 63);
            btn_GestionDescuentos.TabIndex = 3;
            btn_GestionDescuentos.Text = "Gestión de Descuentos";
            btn_GestionDescuentos.UseVisualStyleBackColor = true;
            btn_GestionDescuentos.Click += btn_GestionDescuentos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1274, 107);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pristina", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(430, 23);
            label1.Name = "label1";
            label1.Size = new Size(371, 63);
            label1.TabIndex = 0;
            label1.Text = "El Gestor de Gestores";
            label1.Click += label1_Click;
            // 
            // btn_GestionVentas
            // 
            btn_GestionVentas.Location = new Point(288, 160);
            btn_GestionVentas.Name = "btn_GestionVentas";
            btn_GestionVentas.Size = new Size(149, 63);
            btn_GestionVentas.TabIndex = 5;
            btn_GestionVentas.Text = "Gestion de Ventas";
            btn_GestionVentas.UseVisualStyleBackColor = true;
            btn_GestionVentas.Click += btn_GestionVentas_Click;
            // 
            // btn_GestionTitulos
            // 
            btn_GestionTitulos.Location = new Point(288, 293);
            btn_GestionTitulos.Name = "btn_GestionTitulos";
            btn_GestionTitulos.Size = new Size(149, 63);
            btn_GestionTitulos.TabIndex = 6;
            btn_GestionTitulos.Text = "Gestion de Titulos";
            btn_GestionTitulos.UseVisualStyleBackColor = true;
            btn_GestionTitulos.Click += btn_GestionTitulos_Click;
            // 
            // btn_GestionAutores
            // 
            btn_GestionAutores.Location = new Point(288, 427);
            btn_GestionAutores.Name = "btn_GestionAutores";
            btn_GestionAutores.Size = new Size(149, 63);
            btn_GestionAutores.TabIndex = 7;
            btn_GestionAutores.Text = "Gestion de Autores";
            btn_GestionAutores.UseVisualStyleBackColor = true;
            btn_GestionAutores.Click += btn_GestionAutores_Click;
            // 
            // btn_AsignacionAutoresTitulos
            // 
            btn_AsignacionAutoresTitulos.Location = new Point(288, 553);
            btn_AsignacionAutoresTitulos.Name = "btn_AsignacionAutoresTitulos";
            btn_AsignacionAutoresTitulos.Size = new Size(149, 63);
            btn_AsignacionAutoresTitulos.TabIndex = 8;
            btn_AsignacionAutoresTitulos.Text = "Asignacion de Autores de Titulos";
            btn_AsignacionAutoresTitulos.UseVisualStyleBackColor = true;
            btn_AsignacionAutoresTitulos.Click += btn_AsignacionAutoresTitulos_Click;
            // 
            // btn_GestionPublicadores
            // 
            btn_GestionPublicadores.Location = new Point(541, 160);
            btn_GestionPublicadores.Name = "btn_GestionPublicadores";
            btn_GestionPublicadores.Size = new Size(149, 63);
            btn_GestionPublicadores.TabIndex = 9;
            btn_GestionPublicadores.Text = "Gestion de Publicadores";
            btn_GestionPublicadores.UseVisualStyleBackColor = true;
            btn_GestionPublicadores.Click += btn_GestionPublicadores_Click;
            // 
            // btn_GestionInformacionEditorial
            // 
            btn_GestionInformacionEditorial.Location = new Point(541, 293);
            btn_GestionInformacionEditorial.Name = "btn_GestionInformacionEditorial";
            btn_GestionInformacionEditorial.Size = new Size(149, 63);
            btn_GestionInformacionEditorial.TabIndex = 10;
            btn_GestionInformacionEditorial.Text = "Gestion de Informacion de Editorial";
            btn_GestionInformacionEditorial.UseVisualStyleBackColor = true;
            btn_GestionInformacionEditorial.Click += btn_GestionInformacionEditorial_Click;
            // 
            // btn_GestionProgramacionRegalias
            // 
            btn_GestionProgramacionRegalias.Location = new Point(541, 427);
            btn_GestionProgramacionRegalias.Name = "btn_GestionProgramacionRegalias";
            btn_GestionProgramacionRegalias.Size = new Size(149, 63);
            btn_GestionProgramacionRegalias.TabIndex = 11;
            btn_GestionProgramacionRegalias.Text = "Gestion de Programacion en Regalías";
            btn_GestionProgramacionRegalias.UseVisualStyleBackColor = true;
            btn_GestionProgramacionRegalias.Click += btn_GestionProgramacionRegalias_Click;
            // 
            // pnl_img
            // 
            pnl_img.BackColor = Color.White;
            pnl_img.Controls.Add(pictureBox1);
            pnl_img.Location = new Point(777, 129);
            pnl_img.Name = "pnl_img";
            pnl_img.Size = new Size(497, 571);
            pnl_img.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.GESTOR;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 571);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frm_MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(211, 241, 223);
            ClientSize = new Size(1274, 712);
            Controls.Add(pnl_img);
            Controls.Add(btn_GestionProgramacionRegalias);
            Controls.Add(btn_GestionInformacionEditorial);
            Controls.Add(btn_GestionPublicadores);
            Controls.Add(btn_AsignacionAutoresTitulos);
            Controls.Add(btn_GestionAutores);
            Controls.Add(btn_GestionTitulos);
            Controls.Add(btn_GestionVentas);
            Controls.Add(panel1);
            Controls.Add(btn_GestionDescuentos);
            Controls.Add(btn_GestiónTrabajos);
            Controls.Add(btn_GestionEmpleados);
            Controls.Add(btn_GestionTiendas);
            Name = "frm_MenuPrincipal";
            Text = "Menu Principal del Gestor";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnl_img.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_GestionTiendas;
        private Button btn_GestionEmpleados;
        private Button btn_GestiónTrabajos;
        private Button btn_GestionDescuentos;
        private Panel panel1;
        private Label label1;
        private Button btn_GestionVentas;
        private Button btn_GestionTitulos;
        private Button btn_GestionAutores;
        private Button btn_AsignacionAutoresTitulos;
        private Button btn_GestionPublicadores;
        private Button btn_GestionInformacionEditorial;
        private Button btn_GestionProgramacionRegalias;
        private Panel pnl_img;
        private PictureBox pictureBox1;
    }
}
