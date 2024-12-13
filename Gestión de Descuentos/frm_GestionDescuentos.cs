using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_Gestor_ALLANM.Gestión_de_Descuentos
{
    public partial class frm_GestionDescuentos : Form
    {
        public frm_GestionDescuentos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            
            decimal valorDescuento = numericUpDownDescuento.Value;
            int cantidadBaja = (int)numericUpDownCantidadBaja.Value;
            int cantidadAlta = (int)numericUpDownCantidadAlta.Value;

            MessageBox.Show("Los datos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
