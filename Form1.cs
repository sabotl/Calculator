using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        Calculating calculating = new Calculating();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            clearOneSymbol.Text = "\u232b";
        }
        private void clickButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (inputData.Text == "0")
                inputData.Text = button.Text;
            else inputData.AppendText(calculating.UpdateInput(button));

        }

        private void button12_Click(object sender, EventArgs e)
        {
            inputData.Text = "";
        }
       
        private void ButtonResult_Click(object sender, EventArgs e)
        {
            double dataFirst;
            dataFirst = Convert.ToDouble(inputData.Text);
            inputData.Text = Convert.ToString(calculating.calculateData(dataFirst));
        }
        private void checkOperation(object sender, EventArgs e)
        {
            Button check = (Button)sender;
            calculating.operation = Convert.ToChar(check.Text);
            Calculating.dataNumber = Convert.ToDouble(inputData.Text);
            inputData.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            inputData.Text = Convert.ToString(calculating.CalculateSQRT(Convert.ToDouble(inputData.Text)));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculating.operation = '^';
            Calculating.dataNumber = Convert.ToDouble(inputData.Text);
            inputData.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            inputData.Text = Convert.ToString(calculating.CalculateDivisionByX(Convert.ToDouble(inputData.Text)));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            inputData.Text = Convert.ToString(-Convert.ToDouble(inputData.Text));
        }

        private void ButtonPi_Click(object sender, EventArgs e)
        {
            Calculating.dataNumber = 3.14;
            inputData.Text = "п";
        }
     
        private void button17_Click(object sender, EventArgs e)
        {
            inputData.Text = Convert.ToString(calculating.fib(Convert.ToDouble(inputData.Text)));
        }
  
        private void button19_Click(object sender, EventArgs e)
        {
            inputData.Text = Convert.ToString(calculating.Factorial(Convert.ToDouble(inputData.Text)));
        }

    }
}
