using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HostelFinderPrototype;

namespace HOSTEL_FINDER_PROTOTYPE_GROUP_5
{
    public partial class StudentDashboard : Form
    {
        private DataGridView dgvHostels;
        private Button btnBack;
        private Button btnPay;

        public StudentDashboard()
        {
            InitializeComponent();
            InitializeStudentDashboard();
            RefreshHostelList();
            // Subscribe to changes so the student view updates when manager changes hostels
            DataStore.HostelsChanged += RefreshHostelList;
            this.FormClosed += (s, e) => DataStore.HostelsChanged -= RefreshHostelList;
        }

        private void InitializeStudentDashboard()
        {
            this.Text = "Student Dashboard";

            dgvHostels = new DataGridView
            {
                Location = new Point(20, 20),
                Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 100),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            dgvHostels.Columns.Add("Name", "Hostel Name");
            dgvHostels.Columns.Add("Location", "Location");
            dgvHostels.Columns.Add("Price", "Price");
            dgvHostels.Columns.Add("Condition", "Condition");
            dgvHostels.Columns.Add("AvailableRooms", "Available Rooms");
            dgvHostels.Columns.Add("Rating", "Rating");

            dgvHostels.CellDoubleClick += DgvHostels_CellDoubleClick;
            dgvHostels.SelectionChanged += DgvHostels_SelectionChanged;
            this.Controls.Add(dgvHostels);

            // Back button bottom-left
            btnBack = new Button
            {
                Text = "Back",
                Size = new Size(100, 30),
                Location = new Point(20, this.ClientSize.Height - 60),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };
            btnBack.Click += BtnBack_Click;
            this.Controls.Add(btnBack);

            // Payment button bottom-right
            btnPay = new Button
            {
                Text = "Pay",
                Size = new Size(120, 36),
                Location = new Point(this.ClientSize.Width - 140, this.ClientSize.Height - 64),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Enabled = false
            };
            btnPay.Click += BtnPay_Click;
            this.Controls.Add(btnPay);
        }

        private void RefreshHostelList()
        {
            if (dgvHostels == null) return;
            dgvHostels.Rows.Clear();
            foreach (var h in DataStore.Hostels)
            {
                dgvHostels.Rows.Add(h.Name, h.Location, h.Price.ToString("C"), h.Condition, h.AvailableRooms, h.Rating);
            }
        }

        private void DgvHostels_SelectionChanged(object sender, EventArgs e)
        {
            btnPay.Enabled = dgvHostels.SelectedRows.Count > 0;
        }

        private void DgvHostels_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only respond when user double-clicks the Hostel Name column (index 0)
            if (e.RowIndex < 0 || e.ColumnIndex != 0) return;
            OpenPaymentForRow(e.RowIndex);
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (dgvHostels.SelectedRows.Count == 0) return;
            int idx = dgvHostels.SelectedRows[0].Index;
            OpenPaymentForRow(idx);
        }

        private void OpenPaymentForRow(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= DataStore.Hostels.Count) return;
            var hostel = DataStore.Hostels[rowIndex];
            // PaymentForm is in HostelFinderPrototype namespace and expects a Hostel
            var payment = new StudentPaymentForm(hostel);
            payment.StartPosition = FormStartPosition.CenterParent;
            payment.ShowDialog(this);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Try to find the original LoginForm instance and show it. If not found, create a new one.
            var login = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            if (login != null)
            {
                login.Show();
            }
            else
            {
                var newLogin = new LoginForm();
                newLogin.Show();
            }

            // Hide the student dashboard instead of closing to avoid triggering any FormClosed handlers
            this.Hide();
        }
    }
}
