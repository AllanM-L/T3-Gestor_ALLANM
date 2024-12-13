using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_Gestor_ALLANM.Gestión_de_Tiendas
{
    public partial class frm_GestionTiendas : Form
    {
        public frm_GestionTiendas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreTienda = txtNombreTienda.Text;
            string direccionTienda = txtDireccionTienda.Text;
            string ciudad = txtCiudad.Text;
            string estado = txtEstado.Text;
            string codigoPostal = txtCodigoPostal.Text;
            MessageBox.Show("Los datos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frm_GestionTiendas_Load(object sender, EventArgs e)
        {

        }
    }

}
