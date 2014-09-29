using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personapp
{
    public partial class PersonUIForm : Form
    {
        public PersonUIForm()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            person aPerson = new person();


            aPerson.firstName = firstNameTextBox.Text;
            aPerson.lastName = lastNameTextBox.Text;
            aPerson.middleName = middleNameTextBox.Text;


            fullNameTextBox.Text = aPerson.GetFullName();
            revarseNameTextBox.Text = aPerson.GetReverseName();

        }
    }
}
