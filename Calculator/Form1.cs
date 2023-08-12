using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();

            //Set the text in the display to "0"
            textBoxDisplay.Text = "0";
        }

     
        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "2";
            }
            else 
            { 
                textBoxDisplay.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "3";
            }
            else
            {
                textBoxDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "4";
            }
            else
            {
                textBoxDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "5";
            }
            else
            {
                textBoxDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "6";
            }
            else
            {
                textBoxDisplay.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "7";
            }
            else
            {
                textBoxDisplay.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "8";
            }
            else
            {
                textBoxDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "9";
            }
            else
            {
                textBoxDisplay.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //Check if current text in the display is "0"
            if (textBoxDisplay.Text != "0")
            {
                //If it is not, append "0" to the end of the current text
                textBoxDisplay.Text += "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Set the text in the display to "0"
            textBoxDisplay.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Check for current text in the display is "0"
            if (textBoxDisplay.Text == "0")
            {
                //If it is, replace the text with "1"
                textBoxDisplay.Text = "1";
            }
            else
            {
                //otherwise, append "1" to the end of the current text
                textBoxDisplay.Text += "1";
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            //Check if the current text in the display is not empty
            if (!string.IsNullOrEmpty(textBoxDisplay.Text))
            {
                //If it is not, parse the current text as a double
                double currentValue = double.Parse(textBoxDisplay.Text);

                //Negate the current value
                currentValue = -currentValue;

                //Update the text in the display with the new value
                textBoxDisplay.Text = currentValue.ToString();
            }
        }

        private void btnOpenParanthesis_Click(object sender, EventArgs e)
        {
            //Append "(" to the end of the current text
            textBoxDisplay.Text += "(";
        }

        private void btnCloseParanthesis_Click(object sender, EventArgs e)
        {
            //Append ")" to the end of the current text
            textBoxDisplay.Text += ")";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            //Check if the current text in the display is not empty
            if (!string.IsNullOrEmpty(textBoxDisplay.Text))
            {
                //If it is not, parse the current text as a double
                double currentValue = double.Parse(textBoxDisplay.Text);

                //Calculate the percentage value
                currentValue= currentValue / 100;

                //Update the text in the display with the new value
                textBoxDisplay.Text = currentValue.ToString();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //Append "/" to the end of the current text
            textBoxDisplay.Text += "/";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            //Evaluate the current expression in the display
            double result = EvaluateExpression(textBoxDisplay.Text);

            //Update the text in the display with the result
            textBoxDisplay.Text = result.ToString();
        }
        private double EvaluateExpression(string expression)
        {
            //Replace commas with periods in the expression
            expression = expression.Replace(",", ".");
            try
            {
                var dataTable = new DataTable();
                var result = dataTable.Compute(expression, "");
                return Convert.ToDouble(result);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that are thrown
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //Append "*" to the end of the current text
            textBoxDisplay.Text += "*";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            //Append "-" to the end of the current text
            textBoxDisplay.Text += "-";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Append "+" to the end of the current text
            textBoxDisplay.Text +="+";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            //Check if the current text in the disply does not already contain a decimal point
            if (!textBoxDisplay.Text.Contains(","))
            {
                //If it deos not, append "," to the end of the current text
                textBoxDisplay.Text += ",";
            }
        }
    }
}
