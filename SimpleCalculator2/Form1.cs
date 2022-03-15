using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator2
{
    public partial class Form1 : Form
    {
        double result = 0;
        double displayInput = 0;
        string Operations = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMode_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, MouseEventArgs e)
        {
            if (display.Text == "0")
            {
                display.Clear();
            }
            Button button = (Button)sender;
            double input = Double.Parse(button.Text);
            displayInput = Double.Parse(display.Text) + input;

            if (Operations.Equals(""))
            {
                if (Operations.Equals("-"))
                {
                    result = displayInput - input;
                }
                else if (Operations.Equals("+"))
                {
                    result = displayInput + input;
                }
                else if (Operations.Equals("/"))
                {
                    result = displayInput / input;
                }
                else if (Operations.Equals("X"))
                {
                    result = displayInput * input;
                }
            }
            else
            {

            }
        }

        private void operations_click(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            Operations = button.Text;
            displayInput = Double.Parse(display.Text);
            display.Text = displayInput.ToString() + Operations;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            display.Clear();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            display.Clear();
        }

        private void btnEqual_Click(object sender, MouseEventArgs e)
        {
            txtResult.Text = displayInput.ToString();
        }
    }
}
