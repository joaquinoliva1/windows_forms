using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryNewLogistic
{
    public partial class frmAtencion : Form
    {
        public frmAtencion()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Length > 0 & optCorreo.Checked|| optMensaje.Checked & chkMañana.Checked || chkTarde.Checked & cboServicio.Text.Length > 0) {
                MessageBox.Show("El mensaje fue enviado con éxito.");
            }
            else { MessageBox.Show("Faltan datos para completar."); };
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form frmEntregas = new frmEntregas();
            frmEntregas.Show();
            this.Close();
        }
    }
}
