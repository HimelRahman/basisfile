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
    public partial class AccountUI : Form
    {
        public AccountUI()
        {
            InitializeComponent();
        }

         Account aAccount;
         double amount = 0.0;
        private void createBbutton_Click(object sender, EventArgs e)
        {
            aAccount=new Account();
            aAccount.Number=numbertextBox.Text;
            aAccount.Name=nametextBox.Text;
            clear();
            MessageBox.Show(@"your account has been created");
        }

        private void clear()
        {
            numbertextBox.Text = string.Empty;
            nametextBox.Text = string.Empty;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (aAccount != null)
            {
                amount = Convert.ToDouble(amounttextBox.Text);
                aAccount.Deposit(amount);
                clearamount();
            }
            else
                MessageBox.Show(showmeg());
        }

        private string showmeg()
        {
            return "first create an account";
        }

        private void clearamount()
        {
            amounttextBox.Text = string.Empty;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (aAccount!=null)
            {
                amount = Convert.ToDouble(amounttextBox.Text);
                aAccount.Withdraw(amount);
                clearamount();
            }
            else
            {
                MessageBox.Show(showmeg());
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string msg = aAccount.Name+ ", your account number is " + aAccount.Number + "and balance is " + aAccount.Balance;
            MessageBox.Show(msg);
        }
    }
}
