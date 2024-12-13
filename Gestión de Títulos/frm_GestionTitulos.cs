using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_Gestor_ALLANM.Gestión_de_Títulos
{
    public partial class frm_GestionTitulos : Form
    {
        public frm_GestionTitulos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
         
            string nombreTitulo = txtTitulo.Text;
            string tipo = txtTipo.Text;
            decimal precio = numericUpDownPrecio.Value;
            decimal anticipo = numericUpDownAnticipo.Value;
            decimal regalias = numericUpDownRegalias.Value;
            decimal ventasAcumuladas = numericUpDownVentasAcumuladas.Value;
            DateTime fechaPublicacion = dtpFechaPublicacion.Value;
            MessageBox.Show("Los datos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
