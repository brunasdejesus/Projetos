using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero, Resultado, i;
            i = 1;
            numero = int.Parse(txtNúmero.Text);
            while (i <= 10)
                {
                Resultado = i * numero;
                lstTabuada.Items.Add(string.Concat(numero, "*", i, "=", Resultado));
                i = i + 1;


            }
           

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNúmero.Text = "";
            lstTabuada.Items.Clear();



            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
