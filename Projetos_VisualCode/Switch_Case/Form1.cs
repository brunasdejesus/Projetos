using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbnSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
           switch(cboSemana.Text)
            {
                case "Domingo":
                    MessageBox.Show("Você escolheu: Domingo, que é o 1ª dia da semana", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Segunda":
                    MessageBox.Show("Você escolheu: Segunda, que é o 2ª dia da semana", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Terça":
                    MessageBox.Show("Você escolheu: Terça, que é o 3ª dia da semana", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quarta":
                    MessageBox.Show("Você escolheu: Quarta, que é o 4ª dia da semana", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quinta":
                    MessageBox.Show("Você escolheu: Quinta, que é o 5ª dia da semana", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sexta":
                    MessageBox.Show("Você escolheu: Sexta, que é o 6ª dia da semana", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sábado":
                    MessageBox.Show("Você escolheu: Sábado, que é o 7ª dia da semana", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;


            }



        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;



        }
    }
}
