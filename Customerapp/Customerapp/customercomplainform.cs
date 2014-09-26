using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customerapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        Queue<Customer> que = new Queue<Customer>();
        int count = 1;

        private void enqueuebutton_Click(object sender, EventArgs e)
        {
            if (nametextBox.Text == "" || complaintextBox.Text == "")
                MessageBox.Show("Fill up the all info properly");
            else
            {
                Customer customerentry = new Customer();
                customerentry.serial = count++.ToString();
                customerentry.name = nametextBox.Text;
                customerentry.complain = complaintextBox.Text;
                que.Enqueue(customerentry);
                Addtolistview(customerentry);
                clearAll();
            }
        }

        private void Addtolistview(Customer customerentry)
        {
            ListViewItem itm = new ListViewItem(customerentry.serial);
            itm.SubItems.Add(customerentry.name);
            itm.SubItems.Add(customerentry.complain);
            outputlistView.Items.Add(itm);
        }
        private void clearAll()
        {
            nametextBox.Text = string.Empty;
            complaintextBox.Text = " ";
        }
        
        private void dequeuebutton_Click(object sender, EventArgs e)
        {
            if (que.Count < 1)
                MessageBox.Show("No customer complain in the waiting box");
            else
            {
                Customer storer = new Customer();
                storer = que.Dequeue();
                serialnotextBox.Text = storer.serial;
                namedqtextBox.Text = storer.name;
                complainDqtextBox.Text = storer.complain;
                updatelistview();
            }
        }

        private void updatelistview()
        {
            outputlistView.Items.Clear();
            foreach(Customer renew in que)
            {
                Addtolistview(renew);
            }
        }
    }
}
