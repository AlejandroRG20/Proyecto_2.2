using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Alejandro.Views
{
    public partial class Utilidad : Form
    {
        public Utilidad()
        {
            InitializeComponent();
        }

        private void Utilidad_Load(object sender, EventArgs e)
        {
            txtUB.Enabled = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            float UtB;
            float ing = float.Parse(txtIngresos.Text);
            float egr = float.Parse(txtEgresos.Text);

            if (egr <= ing)
            {
                UtB = ing - egr;
                txtUB.Text = UtB.ToString("0.00");

            }
            else
            {
                MessageBox.Show("El egreso no puede ser mayor al ingreso");
                txtEgresos.Text = "";
                txtEgresos.Focus();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtEgresos.Text = "";
            txtIngresos.Text = "";
            txtUB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
