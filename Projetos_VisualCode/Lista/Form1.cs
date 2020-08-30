using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista
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

        private void button1_Click(object sender, EventArgs e)
        {
            string NomeUsuario;
            DateTime DataNascimento;
            String Cidade;
            bool GêneroM;
            bool GêneroF;
            int NumeroCadastro;

            NomeUsuario = textBox1.Text;
            DataNascimento = dateTimePicker1.Value;
            Cidade = comboBox1.Text;
            GêneroM = radioButton1.Checked;
            GêneroF = radioButton2.Checked;
            NumeroCadastro = Convert.ToInt32(textBox2.Text);

            MessageBox.Show("Nome :" + NomeUsuario);
            MessageBox.Show("Data de Nascimento: " + DataNascimento);
            MessageBox.Show("Cidade: " + Cidade);
            MessageBox.Show("Gênero: " + GêneroM);
            MessageBox.Show("Gênero: " + GêneroF);
            MessageBox.Show("Número de Cadastro: " + NumeroCadastro);

            MessageBox.Show("Bem Vindo ao sistema: " +NomeUsuario);

       
           
        }
    }
}
