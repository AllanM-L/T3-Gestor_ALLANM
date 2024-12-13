using T3_Gestor_ALLANM.Asignación_de_Autores_a_Títulos;
using T3_Gestor_ALLANM.Gestión_de_Autores;
using T3_Gestor_ALLANM.Gestión_de_Descuentos;
using T3_Gestor_ALLANM.Gestión_de_Empleados;
using T3_Gestor_ALLANM.Gestión_de_Información_Editorial;
using T3_Gestor_ALLANM.Gestión_de_Programación_de_Regalías;
using T3_Gestor_ALLANM.Gestión_de_Publicadores;
using T3_Gestor_ALLANM.Gestión_de_Tiendas;
using T3_Gestor_ALLANM.Gestión_de_Títulos;
using T3_Gestor_ALLANM.Gestión_de_Trabajos;
using T3_Gestor_ALLANM.Gestión_de_Ventas;

namespace T3_Gestor_ALLANM
{
    public partial class frm_MenuPrincipal : Form
    {
        public frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_GestionTiendas_click(object sender, EventArgs e)
        {
            Form GestionTienda = new frm_GestionTiendas();
            GestionTienda.Show();
        }

        private void btn_GestionEmpleados_Click(object sender, EventArgs e)
        {
            Form GestionEmpleados = new frm_GestionEmpleados();
            GestionEmpleados.Show();
        }

        private void btn_GestiónTrabajos_Click(object sender, EventArgs e)
        {
            Form GestionTrabajos = new frm_GestionTrabajos();
            GestionTrabajos.Show();
        }

        private void btn_GestionDescuentos_Click(object sender, EventArgs e)
        {
            Form GestionDescuentos = new frm_GestionDescuentos();
            GestionDescuentos.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_GestionProgramacionRegalias_Click(object sender, EventArgs e)
        {
            Form GestionProgramacionRegalias = new frm_GestionProgramacionRegalias();
            GestionProgramacionRegalias.Show();
        }

        private void btn_GestionVentas_Click(object sender, EventArgs e)
        {
            Form GestionVentas = new frm_GestionVentas();
            GestionVentas.Show();
        }

        private void btn_GestionTitulos_Click(object sender, EventArgs e)
        {
            Form GestionTitulos = new frm_GestionTitulos();
            GestionTitulos.Show();
        }

        private void btn_GestionAutores_Click(object sender, EventArgs e)
        {
            Form GestionAutores = new frm_GestionAutores();
            GestionAutores.Show();
        }

        private void btn_AsignacionAutoresTitulos_Click(object sender, EventArgs e)
        {
            Form AsignacionAutoresTitulos = new frm_AsignacionAutoresTitulos();
            AsignacionAutoresTitulos.Show();
        }

        private void btn_GestionPublicadores_Click(object sender, EventArgs e)
        {
            Form GestionPublicadores = new frm_GestionPublicadores();
            GestionPublicadores.Show();
        }

        private void btn_GestionInformacionEditorial_Click(object sender, EventArgs e)
        {
            Form GestionInformacionEditorial = new frm_GestionInformacionEditorial();
            GestionInformacionEditorial.Show();
        }
    }
}
