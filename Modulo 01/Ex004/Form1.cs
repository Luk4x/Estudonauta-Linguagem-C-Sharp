using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            float num = 0f;
            float.TryParse(textBox1.Text, out num);
            label2.Text = $"Você digitou o valor {num:n3}\nA parte inteira é {(UInt16)num}\nArredondando, temos {Convert.ToInt16(num)}";
        }
    }
}
