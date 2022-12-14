using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

//Mike. (2018, November 7). Program to Convert Pounds to Kilograms in C#. Programming, Pseudocode Example, C# Programming Example. https://www.csharp-console-examples.com/basic/program-to-convert-pounds-to-kilograms-in-c/

namespace Activity2
{
    public partial class Form1 : Form
    {
        private const double V = 0.453592;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
                double pounds, total;
            if (double.TryParse(textBox2.Text, out total ))
            {
                pounds = (double)Convert.ToDecimal(textBox2.Text);
                total = pounds * V;
                textBox1.Text = total.ToString("n3");
            }
            else
            {
                string name = textBox1.Text.ToString();

                MessageBox.Show("Please input a number!");
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
  
            // Clear the TextBox controls.
                textBox2.Text = "";
                textBox1.Text = "";
                // Set the focus to userInputMiles.
                textBox2.Focus();
           
        }
    }
}
