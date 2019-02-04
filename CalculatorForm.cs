using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {

        private CalcLogic calcLogic;
        private string symbols;
        public CalculatorForm()
        {
            InitializeComponent();
            calcLogic = new CalcLogic();
            symbols = "()+-*/";
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            string str = ((Button)sender).Text;
            if(!(display.Text == "0"))
            {
                display.Text += str;
            }
            else if(str != "0")
            {
                display.Text = str;
            }
        }

        private void ButtonOperation_Click(object sender, EventArgs e)
        {
            string buttonMsg = ((Button)sender).Text;
            char lastElement = display.Text[display.Text.Length - 1];
            char beforeLastElement = '1';
            if (display.Text.Length > 2)
            {
                beforeLastElement = display.Text[display.Text.Length - 2];
            }
            if (lastElement != ',' && !symbols.Contains(beforeLastElement))
            {
                display.Text += " " + buttonMsg + " ";
            }
            else if (lastElement == ')')
            {
                return;
            }
            else if (lastElement == ' ' && beforeLastElement != '(' && beforeLastElement != ')')
            {
                display.Text = display.Text.Remove(display.Text.Length - 2, 1).Insert(display.Text.Length - 2, buttonMsg);
            }
        }

        private void buttonLBrace_Click(object sender, EventArgs e)
        {
            char lastElement = display.Text[display.Text.Length - 1];
            if(lastElement == ' ')
            {
                calcLogic.Braces++;
                display.Text += "( ";
            }
            else if (display.Text == "0")
            {
                calcLogic.Braces++;
                display.Text = "( ";
            }
        }

        private void buttonRBrace_Click(object sender, EventArgs e)
        {
            char lastElement = display.Text[display.Text.Length - 1];
            if (lastElement != ',' && lastElement != ' ' && calcLogic.Braces > 0)
            {
                calcLogic.Braces--;
                display.Text += " )";
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            char lastElement = display.Text[display.Text.Length - 1];
            if (Char.IsDigit(lastElement))
            {
                display.Text += ",";
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            display.Text = calcLogic.Calculate(display.Text);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            calcLogic.CurrentValue = 0;
            calcLogic.Braces = 0;
            display.Text = "0";
        }

        private void buttonClr_Click(object sender, EventArgs e)
        {
            display.Text = calcLogic.CurrentValue.ToString();
        }
    }
}
