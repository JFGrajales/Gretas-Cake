using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gretas_Cake
{
    public partial class ConsultarRegistroProductoTerminado : Form
    {
        public ConsultarRegistroProductoTerminado()
        {
            InitializeComponent();
        }

        private void btnConsultarRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

            SubMenuProductosTerminados VentanaAnterior = new SubMenuProductosTerminados();

            VentanaAnterior.Show();
        }
    }
}
