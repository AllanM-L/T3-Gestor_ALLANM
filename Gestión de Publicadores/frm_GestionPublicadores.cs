using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_Gestor_ALLANM.Gestión_de_Publicadores
{
    public partial class frm_GestionPublicadores : Form
    {
        public frm_GestionPublicadores()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string nombrePublicador = txtNombrePublicador.Text;
            string ciudad = txtCiudad.Text;
            string estado = txtEstado.Text;
            string pais = txtPais.Text;
            MessageBox.Show("Los datos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
