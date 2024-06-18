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
    public partial class frmParadas : Form
    {
        int paradas = 0;
        public frmParadas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form frmPlanificar = new frmPlanificar();
            frmPlanificar.Show();
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (txtOrigen.Text.Length > 0 & txtDestino.Text.Length > 0 & txtParada1.Text.Length > 0 || txtParada2.Text.Length > 0 || txtParada3.Text.Length > 0 || txtParada4.Text.Length > 0 || txtParada5.Text.Length > 0 || txtParada6.Text.Length > 0)
            {
                Form frmEntregas = new frmEntregas();
                frmEntregas.Show();
                this.Hide();
            }
            else { MessageBox.Show("Se debe agregar origen, destino y al menos una parada."); };
        }
    }
}
