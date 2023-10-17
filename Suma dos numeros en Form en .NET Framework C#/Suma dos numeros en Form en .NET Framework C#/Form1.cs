using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma_dos_numeros_en_Form_en.NET_Framework_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = double.Parse(txtNumero1.Text);
                double numero2 = double.Parse(txtNumero2.Text);

                double resultado = numero1 + numero2;

                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa números válidos en los campos 1 y 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
