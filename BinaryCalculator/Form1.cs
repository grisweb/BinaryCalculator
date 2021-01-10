using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();    
        }
        
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = (new Expression()).Execute(textBox1.Text);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText.Length != 0)
            {
                textBox1.SelectedText = "";
            }
            else
            {
                if (textBox1.SelectionStart != 0)
                {
                    int pos = textBox1.SelectionStart;

                    textBox1.Text = textBox1.Text.Remove(pos - 1, 1);

                    textBox1.SelectionStart = pos - 1;
                }
            }
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "0";
        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "1";
        }

        private void buttonAnd_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "&";
        }

        private void buttonOr_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "|";
        }

        private void buttonXor_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "^";
        }

        private void buttonLeftBracket_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "(";
        }

        private void buttonRightBracket_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = ")";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                buttonCalculate_Click(buttonCalculate, null);
            }
        }
    }
}
