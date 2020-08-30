using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Login_Senha
{
    public partial class Form1 : Form

    {
        Thread Nt;


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)

            
        {
            if (textBox1.Text == "Bruna" && textBox2.Text == "0754")

            {
                this.Close();

                Nt = new Thread(novoForm);
                Nt.SetApartmentState(ApartmentState.STA);
                Nt.Start();

            }

            else
            {
                MessageBox.Show("Login ou senha inválidos");
            }


        }

        private void novoForm()
        {
            Application.Run(new Form2());
        }
    }
}
