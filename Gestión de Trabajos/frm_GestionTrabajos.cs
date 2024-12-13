using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_Gestor_ALLANM.Gestión_de_Trabajos
{
    public partial class frm_GestionTrabajos : Form
    {
        public frm_GestionTrabajos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string descripcionTrabajo = txtDescripcionTrabajo.Text;
            decimal salarioMinimo = numericUpDownSalarioMinimo.Value;
            decimal salarioMaximo = numericUpDownSalarioMaximo.Value;
            MessageBox.Show("Los datos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frm_GestionTrabajos_Load(object sender, EventArgs e)
        {
           
        }
    }

}
