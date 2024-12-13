using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_Gestor_ALLANM.Gestión_de_Programación_de_Regalías
{
    public partial class frm_GestionProgramacionRegalias : Form
    {
        public frm_GestionProgramacionRegalias()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            decimal rangoBajo = numericUpDownRangoBajo.Value;
            decimal rangoAlto = numericUpDownRangoAlto.Value;
            decimal porcentajeRegalias = numericUpDownRegalias.Value;
            MessageBox.Show("Los datos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
