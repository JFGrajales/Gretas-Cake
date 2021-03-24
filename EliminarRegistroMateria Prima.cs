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
    public partial class EliminarRegistroMateria_Prima : Form
    {
        public EliminarRegistroMateria_Prima()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

            SubMenuMateriaPrima VentanaAnterior = new SubMenuMateriaPrima();

            VentanaAnterior.Show();
        }
    }
}
