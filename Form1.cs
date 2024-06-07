using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_Soma_e_mutiplicacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(textBoxValor1.Text);
            int valor2 = Convert.ToInt32(textBoxValor2.Text);
            int valor3 = Convert.ToInt32(textBoxValor3.Text);
            int valor4 = Convert.ToInt32(textBoxValor4.Text);

            double Soma = (valor1 + valor2 + valor3 + valor4);
            lblSoma.Text = "Soma é: " + Soma.ToString();

            double Multi = (valor1 * valor2 * valor3 * valor4);
            lblMulti.Text = "Mutiplicação é: " + Multi.ToString();
        }
    }
}
