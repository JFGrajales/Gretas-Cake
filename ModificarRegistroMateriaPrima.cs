﻿using System;
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
    public partial class ModificarRegistroMateriaPrima : Form
    {
        public ModificarRegistroMateriaPrima()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbxPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxCostoUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

            SubMenuMateriaPrima VentanaAnterior = new SubMenuMateriaPrima();

            VentanaAnterior.Show();
        }
    }
}
