using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularSoma
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInteiro_Click(object sender, EventArgs e)
        {
            // Declarando as variáveis
            int a, b, soma;

            // Entrada de dados
            a = Int32.Parse(txtValorA.Text);

            b = Int32.Parse(txtValorB.Text);

            // Processamento
            soma = a + b;

            // Saida de dados e conversão de inteiro para string

            txtResultado.Text = soma.ToString();
        }

        private void btnReais_Click(object sender, EventArgs e)
        {
            // Declarando as variáveis de double
            double a, b, soma;

            // Entrada de dados 
            a = Convert.ToDouble(txtValorA.Text);

            b = Convert.ToDouble(txtValorB.Text);

            // Processando
            soma = a + b;

            // Saida de dados e conversão de double para string
            txtResultado.Text = soma.ToString();

        }
    }
}
