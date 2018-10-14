using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomerMaintenanceClasses;

namespace CustomerMaintenance
{
    public partial class frmCloneCustomer : Form
    {
        public static Customer customer;

        public frmCloneCustomer(Customer c)
        {
            InitializeComponent();
            customer = c;
            ShowDialog();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(copiesTextBox) &&
                Validator.IsInt32(copiesTextBox))
            {
                int numberOfClones = Int32.Parse(copiesTextBox.Text);
                List<Customer> clones = new List<Customer>();
                while (numberOfClones > 0)
                {
                    clones.Add((Customer)customer.Clone());
                    numberOfClones--;
                }
                foreach (Customer c in clones)
                    clonesListBox.Items.Add(c);
            }
        }

        private void frmCloneCustomer_Load(object sender, EventArgs e)
        {
            customerLabel.Text = customer.ToString();
        }

    }
}
