using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCantallops1
{
    public partial class FrmVentana : Form
    {
        public FrmVentana()
        {
            InitializeComponent();
        }

        private void FrmVentana_Load(object sender, EventArgs e)
        {

        }

        private void BtnMegusta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muchas gracias por su aporte, nos alegra que disfrute del producto.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muchas gracias por su aporte, esperamos mejorar para cumplir sus expectativas.");
        }
    }
}
