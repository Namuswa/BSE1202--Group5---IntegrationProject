using System;
using System.Windows.Forms;

namespace HostelFinderPrototype
{
    public partial class PaymentForm : Form
    {
        // 1. Create a private variable to hold the passed hostel data
        private Hostel currentHostel;

        // 2. Modify the constructor to require the Hostel object
        public PaymentForm(Hostel selectedHostel)
        {
            InitializeComponent();

            // Save the caught data
            currentHostel = selectedHostel;

            // 3. Load the manager's contact dynamically
            lblContact.Text = "Manager Contact: " + currentHostel.ManagerContact;

            // 4. Populate the dropdown list with payment options
            cmbPaymentMethod.Items.Add("MTN Mobile Money");
            cmbPaymentMethod.Items.Add("Airtel Money");
            cmbPaymentMethod.Items.Add("Cash on Arrival");
            cmbPaymentMethod.Items.Add("Bank Transfer");
        }

        // 5. The Confirm Button Logic
        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            // Validate that a payment method was actually selected
            if (cmbPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Please select a payment method before proceeding.");
                return;
            }

            // Grab the selected method as text
            string method = cmbPaymentMethod.SelectedItem.ToString();

            // Simulate a successful transaction and instruct the student on next steps
            MessageBox.Show($"Payment process initiated via {method}.\n\nPlease contact the manager at {currentHostel.ManagerContact} to finalize your booking.", "Booking Successful");

            // Close the payment window to return to the details screen
            this.Close();
        }

        // 6. The Cancel Button Logic
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Simply closes the payment window without doing anything
        }
    }
}