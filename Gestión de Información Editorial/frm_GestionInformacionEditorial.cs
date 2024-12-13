using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_Gestor_ALLANM.Gestión_de_Información_Editorial
{
    public partial class frm_GestionInformacionEditorial : Form
    {
        public frm_GestionInformacionEditorial()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string logo = txtLogo.Text;
            string informacionAdicional = txtInformacionAdicional.Text;
            MessageBox.Show("Los datos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
