using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_Gestor_ALLANM.Gestión_de_Empleados
{
    public partial class frm_GestionEmpleados : Form
    {
        public frm_GestionEmpleados()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string inicialSegundoNombre = txtInicialSegundoNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fechaContratacion = dtpFechaContratacion.Value;
            string idTrabajo = txtTrabajo.Text;
            MessageBox.Show("Los datos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtTrabajo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_GestionEmpleados_Load(object sender, EventArgs e)
        {

        }
    }

}
