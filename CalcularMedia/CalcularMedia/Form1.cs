using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularMedia
{
    public partial class FormMedia : Form
    {
        public FormMedia()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //declarando a variável media
            double media;

            //variavel media recebe o valor que foi digitado no TextBox
            //Convert.ToDouble, converter o texto do TextBox para o tipo double
            media = Convert.ToDouble(txtMedia.Text);

            //testa a condicao: se média é maior ou igual a sete
            //se condição verdadeira, apresenta a mensagem no MessageBox
            if (media >= 7.0)
            {
                MessageBox.Show($"Aluno aprovado!! Com a média de {media}", "Média");
            } 
            else
            {
                MessageBox.Show($"Aluno reprovado! Com a média de {media}", "Média");
            }

           
        }
    }
}
