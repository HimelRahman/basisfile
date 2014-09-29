using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        Calculator calculate = new Calculator();
        double sndnumber;
        double fstnumber;

        private void addbutton_Click(object sender, EventArgs e)
        {
            initialize();
            resulttextBox.Text = Convert.ToString(calculate.Add(fstnumber,sndnumber));
        }

        private void initialize()
        {
            fstnumber = Convert.ToDouble(firstnumbertextBox.Text);
            sndnumber = Convert.ToDouble(secondnumbertextBox.Text);
        }

        private void subtractbutton_Click(object sender, EventArgs e)
        {
            initialize();
            resulttextBox.Text = Convert.ToString(calculate.Subtract(fstnumber, sndnumber));
        }

        private void multiplybutton_Click(object sender, EventArgs e)
        {
           initialize();
           resulttextBox.Text = Convert.ToString(calculate.Multiply(fstnumber, sndnumber));
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            initialize();
            resulttextBox.Text = Convert.ToString(calculate.Divide(fstnumber, sndnumber));
        }
    }
}
