using BusniessManagementSystem.Modules;
using BusniessManagementSystem.Repositories;
using System.ComponentModel;

namespace BusniessManagementSystem
{
    public partial class ViewCustomer : Form
    {
        Customer Cus = new Customer();
        CustomerRepository repo = new CustomerRepository();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CustomerID { get; set; }
        public ViewCustomer()
        {
            InitializeComponent();
        }
        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.CustomerID))
            {
                MessageBox.Show("Customer ID not set.");
                return;
            }

            this.Cus = repo.GetById(this.CustomerID);
            if (this.Cus == null)
            {
                MessageBox.Show($"Customer '{this.CustomerID}' not found.");
                return;
            }

            txtCustomerID.Text = this.Cus.CustomerID;
            txtCompanyName.Text = this.Cus.CompanyName;
            txtContactName.Text = this.Cus.ContactName;
            txtContactTitle.Text = this.Cus.ContactTitle;
            txtPhone.Text = this.Cus.Phone;
            txtFax.Text = this.Cus.Fax;
            cmbCountry.Text = this.Cus.Country;
            txtAddress.Text = this.Cus.Address;
            txtRegion.Text = this.Cus.Region;
            txtPostalCode.Text = this.Cus.PostalCode;
            txtCity.Text = this.Cus.City;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to close this window?", "Close",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
