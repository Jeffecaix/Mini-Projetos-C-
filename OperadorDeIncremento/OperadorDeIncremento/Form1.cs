using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadorDeIncremento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            int x, y;      //declaração das variáveis
            x = Convert.ToInt32(txtX.Text);      //entrada de dados, converte o texto do TexBox para int

            y = ++x;          //incremento pré-fixado

            MessageBox.Show("Y = " + y + " X = " + x, "Incremento Pré-fixado");     //saída de dados
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            int x, y;      //declaração das variáveis
            x = Convert.ToInt32(txtX.Text);   //entrada de dados, converte o texto do TextBox para int

            y = x++;      //incremento pós-fixado

            MessageBox.Show("Y = " + y + " X = " + x, "Incremento Pós_Fixado");    //saída de dados
        }
    }
}
