using System;
using System.Windows.Forms;

namespace Calculator.WindowsFormUT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           label3.Text=Libarary.Calculator.Divide(int.Parse(textBox1.Text), (int.Parse(textBox2.Text))).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = Libarary.Calculator.Add(int.Parse(textBox1.Text), (int.Parse(textBox2.Text))).ToString();
        }
    }
}
