using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_do_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Declaração de Variáveis
             * Variável recebe o valor do TextBox*/

            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);

            /*textBox recebe o valor da variável IMC = Resultado do Calculo
             * Definição de utilização de duas casas decimais*/

            txtIMC.Text = imc.ToString("0.00");
            
            /*Condições de acordo com os Resultados
             * serão exibidas mensagens, 
             * configuração das mensagens (mensagens, botões e ícones)
             * como são várias condições, temos um encadeamento de "ifs"*/

            if(imc < 18.49)
            {
                MessageBox.Show("Situação: Você está abaixo do peso", "Cáculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if(imc < 24.99)
                {
                MessageBox.Show("Situação: Você está com o peso ideal", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if(imc < 29.99)
            {
                MessageBox.Show("Situação: Você está acima do peso", "Cáculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if(imc < 34.99)
            {
                MessageBox.Show("Atenção! Você está com obesidade grau I", "Cáculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else if(imc < 39.99)
            {
                MessageBox.Show("Atenção! Você está com obesidade grau II", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                MessageBox.Show("Atenção! Você está com grau de obesidade grau III ( Mórbido)", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtIMC.Text = "";
            txtPeso.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
