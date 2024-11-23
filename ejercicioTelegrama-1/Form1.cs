using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            double coste = 0;
            textoTelegrama = txtTelegrama.Text;

            char[] delimitadores = new char[] { ' ', '\r', '\n' };
            int numPalabras = textoTelegrama.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries).Length;

            if (rbOrdinario.Checked == false && rbUrgente.Checked == false)
            {
                MessageBox.Show("Por favor, indique el tipo de telegrama a enviar.");

            }
            if (rbOrdinario.Checked)
            {
                if (numPalabras <= 10 && numPalabras > 0)
                {
                    coste = 2.5;
                }
                else if (numPalabras > 10)
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
                else if (numPalabras == 0)
                {
                    MessageBox.Show("Por favor, escriba su telegrama a enviar");
                }
                txtPrecio.Text = coste.ToString() + " euros";
            }

            if (rbUrgente.Checked)
            {
                if (numPalabras <= 10 && numPalabras > 0)
                {
                    coste = 5;
                }
                else if (numPalabras > 10)
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
                else if (numPalabras == 0)
                {
                    MessageBox.Show("Por favor, escriba su telegrama a enviar");
                }
                txtPrecio.Text = coste.ToString() + " euros";
            }

        }
    }
}