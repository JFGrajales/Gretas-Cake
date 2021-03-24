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
    public partial class SubMenuMateriaPrima : Form
    {
        public SubMenuMateriaPrima()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 VentanaAnterior = new Form1();

            VentanaAnterior.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarRegistroMateriaPrima NuevaVentana = new ModificarRegistroMateriaPrima();

            NuevaVentana.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarRegistroMateriaPrima NuevaVentana = new ConsultarRegistroMateriaPrima();

            NuevaVentana.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearRegistroMateriaPrima NuevaVentana = new CrearRegistroMateriaPrima();

            NuevaVentana.Show();
        }

        private void SubMenuMateriaPrima_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarRegistroMateria_Prima NuevaVentana = new EliminarRegistroMateria_Prima();

            NuevaVentana.Show();
        }

        private void btnGenerarConteo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("     Se generará un informe de las Materias Primas registradas en el inventario hasta el momento en que se ejecute esta acción    ");
        }
    }
}
