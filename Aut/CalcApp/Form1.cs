using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcApp
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

        private void button1_Click(object sender, EventArgs e)
        {
            string text3 = "Wrong Input";
            if( !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                int number1;
                int number2;
                if(int.TryParse(textBox1.Text, out number1) && int.TryParse(textBox2.Text, out number2))
                {
                    text3 = (number1 + number2).ToString();
                }
            }
            textBox3.Text = text3;
        }
    }
}
