using System;
using System.Windows.Forms;

namespace HostelFinderPrototype
{
    public partial class HostelDetailsForm : Form
    {
        // 1. Create a private variable to hold the specific hostel data we are looking at
        private Hostel currentHostel;

        // 2. We modify the constructor to "catch" the hostel sent from the Dashboard
        public HostelDetailsForm(Hostel selectedHostel)
        {
            InitializeComponent();

            // Save the caught data into our private variable
            currentHostel = selectedHostel;

            // Call a method to update the screen
            LoadHostelData();
        }

        // 3. This method takes the data and pushes it into the Labels you just drew
        private void LoadHostelData()
        {
            lblHostelName.Text = currentHostel.Name;
            lblLocation.Text = "Location: " + currentHostel.Location;
            lblPrice.Text = "Price: UGX " + currentHostel.Price.ToString("N0"); // "N0" formats it with commas (e.g., 500,000)
            lblCondition.Text = "Condition: " + currentHostel.Condition;
            lblRating.Text = "Rating: " + currentHostel.Rating.ToString() + " / 5.0";
            lblAvailable.Text = "Rooms Available: " + currentHostel.AvailableRooms.ToString();
        }

        // 4. The Back Button Logic
        private void btnBack_Click(object sender, EventArgs e)
        {
            // The Back Button Logic
private void btnBack_Click(object sender, EventArgs e)
        {
            // This command simply closes the details screen.
            // Because the Student Dashboard was never closed (just sitting underneath), 
            // closing this form naturally returns the user to the dashboard.
            this.Close();
        }

        // The Payment Button Logic
        private void btnPayment_Click(object sender, EventArgs e)
        {
            // 1. Create a new instance of the Payment screen.
            // We pass 'currentHostel' into it so the payment screen knows exactly which hostel to bill for.
            PaymentForm paymentForm = new PaymentForm(currentHostel);

            // 2. Show the payment screen. 
            // Using .ShowDialog() instead of .Show() is a neat trick: it forces the payment window 
            // to pop up on top and prevents the user from clicking anything else until they finish or cancel the payment.
            paymentForm.ShowDialog();
        }
            this.Close(); // This simply closes the details screen, revealing the dashboard underneath
        }

        // 5. The Payment Button Logic
        private void btnPayment_Click(object sender, EventArgs e)
        {
            
            // For now, we will just show a message. 
            // We will replace this with the actual PaymentForm connection later!
            MessageBox.Show("Opening the payment gateway...", "Proceeding");
        }
    }
}
