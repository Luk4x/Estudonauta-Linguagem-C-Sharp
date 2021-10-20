using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praticando5
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

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            byte idade = 0;
            byte.TryParse(textBox2.Text, out idade);

            label2.Text = "Prazer em te conhecer, " + nome + ".";
            label2.Visible = true;
            await Task.Delay(2000);
            label2.Text += "\nVocê tem " + idade + " anos, certo?";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
