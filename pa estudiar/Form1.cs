using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pa_estudiar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, suma, resta, multiplicacion, division, potencia, raiz,raiz2;
            num1 = double.Parse(txtNumero1.Text);
            num2 = Convert.ToDouble(txtNumero2.Text);
            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = num1 / num2;
            potencia = Math.Pow(num1, num2);
            raiz = Math.Sqrt(num1);
            raiz2 = Math.Sqrt(num2);
            txtSuma.Text = Convert.ToString(suma);
            txtResta.Text = Convert.ToString(resta);
            txtMultiplicacion.Text = Convert.ToString(multiplicacion);
            txtDivision.Text = Convert.ToString(division);
            txtPotencia.Text = Convert.ToString(potencia);
            txtRaiz.Text = Convert.ToString(raiz);
            txtRaiz2.Text = Convert.ToString(raiz2);
        }

        private void txtSuma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSuma.Clear();
            txtResta.Clear();
            txtMultiplicacion.Clear();
            txtDivision.Clear();
            txtPotencia.Clear();
            txtRaiz.Clear();
        }

        private void txtPotencia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
