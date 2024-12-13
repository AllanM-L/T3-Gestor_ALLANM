using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_Gestor_ALLANM.Gestión_de_Ventas
{
    public partial class frm_GestionVentas : Form
    {
        public frm_GestionVentas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string numeroOrden = txtNumeroOrden.Text;
            DateTime fechaOrden = dtpFechaOrden.Value;
            string terminosPago = txtTerminosPago.Text;
            MessageBox.Show("Los datos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }

}
