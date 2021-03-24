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
    public partial class SubMenuProductosTerminados : Form
    {
        public SubMenuProductosTerminados()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 VentanaAnterior = new Form1();

            VentanaAnterior.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearRegistroProductosTerminados NuevaVentana = new CrearRegistroProductosTerminados();

            NuevaVentana.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarRegistroProductoTerminado NuevaVentana = new ConsultarRegistroProductoTerminado();

            NuevaVentana.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarRegistroProductoTerminado NuevaVentana = new ModificarRegistroProductoTerminado();

            NuevaVentana.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarRegistroProductoTerminado NuevaVentana = new EliminarRegistroProductoTerminado();

            NuevaVentana.Show();
        }

        private void btnGenerarConteo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("     Se generará un informe de los Productos Terminados registrados en el inventario hasta el momento en que se ejecute esta acción    ");
        }
    }
}
