using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankTransactionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Account customer = new Account();
        Double amount = 0.0;
        private void createBbutton_Click(object sender, EventArgs e)
        {
            customer.Number = numbertextBox.Text;
            customer.Name = nametextBox.Text;
            clear();
            MessageBox.Show(customer.Name +" your account have created and account number is " + customer.Number);
        }

        private void clear()
        {
            numbertextBox.Text = string.Empty;
            nametextBox.Text = " ";
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amounttextBox.Text);
            customer.Deposit(amount);
            clearamount();
        }

        private void clearamount()
        {
            amounttextBox.Text = string.Empty;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amounttextBox.Text);
            customer.Withdraw(amount);
            clearamount();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string msg = customer.Report();
            MessageBox.Show(msg);
        }
    }
}
