using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoubleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double number1, number2;

            double Addition, Subtraction, Division, Multiplication;
            
            number1= Convert.ToDouble(textBox3.Text);
            number2 = Convert.ToDouble(textBox4.Text);

            Addition = number1 + number2;
            label7.Text = Addition.ToString();

            Subtraction = number1 - number2;
            label8.Text = Subtraction.ToString();

            Division = number1 / number2;
            label9.Text = Division.ToString();

            Multiplication = number1 * number2;
            label10.Text = Multiplication.ToString();
        }
    }
}
