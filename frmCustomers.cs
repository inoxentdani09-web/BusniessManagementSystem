using BusniessManagementSystem.Modules;
using BusniessManagementSystem.Repositories;


namespace BusniessManagementSystem
{
    public partial class frmCustomers : Form
    {
        public Customer Cus = new Customer();
        public bool isEdit = false;

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            (bool output, string Msg) = ValidationForm();
            if (output == true)
            { 
                var repo = new CustomerRepository();
                if (isEdit)
                {
                    repo.Update(Cus);
                    MessageBox.Show("Customer update successfullly.", "Update", MessageBoxButtons.OK);
                   
                }
                else
                { 
                    repo.Insert(Cus);
                    MessageBox.Show("Customer save successfullly.", "Save", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show(Msg, "Customer Saved Faild!.",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private (bool, string) ValidationForm()
        {
            bool found = true;
            string msg = "";

            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                found = false;
                msg += "Please enter your Customer ID.";
            }
            else
            {
                Cus.CustomerID = txtCustomerID.Text.ToUpper();
            }
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                found = false;
                msg += "Please enter your Company Name.";
            }
            else
            {
                Cus.CompanyName = txtCompanyName.Text;
            }
            if (string.IsNullOrEmpty(txtContactName.Text))
            {
                found = false;
                msg += "Please enter your Contact Name.";
            }
            else
            {
                Cus.ContactName = txtContactName.Text;
            }
            if (string.IsNullOrEmpty(txtContactTitle.Text))
            {
                found = false;
                msg += "Please enter your ContactTitle.";
            }
            else
            {
                Cus.ContactTitle = txtContactTitle.Text;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                found = false;
                msg += "Please enter your Address.";
            }
            else
            {
                Cus.Address = txtAddress.Text;
            }
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                found = false;
                msg += "Please enter your City.";
            }
            else
            {
                Cus.City = txtCity.Text;
            }
            if (string.IsNullOrEmpty(txtRegion.Text))
            {
                found = false;
                msg += "Please enter your Region.";
            }
            else
            {
                Cus.Region = txtRegion.Text;
            }
            if (string.IsNullOrEmpty(txtPostalCode.Text))
            {
                found = false;
                msg += "Please enter your PostalCode.";
            }
            else
            {
                Cus.PostalCode = txtPostalCode.Text;
            }
            if (string.IsNullOrEmpty(cmbCountry.Text))
            {
                found = false;
                msg += "Please enter your Country.";
            }
            else
            {
                Cus.Country = cmbCountry.Text;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                found = false;
                msg += "Please enter your PostalCode.";
            }
            else
            {
                Cus.Phone = txtPhone.Text;
            }
            if (string.IsNullOrEmpty(txtFax.Text))
            {
                found = false;
                msg += "Please enter your PostalCode.";
            }
            else
            {
                Cus.Fax = txtFax.Text;
            }
            return (found, msg);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
            {
                this.Dispose();
                return;
            }
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Cus.CustomerID))
            {
                txtCustomerID.Text = this.Cus.CustomerID;
            }
            if (!string.IsNullOrEmpty(this.Cus.CompanyName))
            {
                txtCompanyName.Text = this.Cus.CompanyName;
            }
            if (!string.IsNullOrEmpty(this.Cus.ContactName))
            {
                txtContactName.Text = this.Cus.ContactName;
            }
            if (!string.IsNullOrEmpty(this.Cus.ContactTitle))
            {
                txtContactTitle.Text = this.Cus.ContactTitle;
            }
            if (!string.IsNullOrEmpty(this.Cus.Phone))
            {
                txtPhone.Text = this.Cus.Phone;
            }
            if (!string.IsNullOrEmpty(this.Cus.Fax))
            {
                txtFax.Text = this.Cus.Fax;
            }
            if (!string.IsNullOrEmpty(this.Cus.Country))
            {
                cmbCountry.Text = this.Cus.Country;
            }
            if (!string.IsNullOrEmpty(this.Cus.Address))
            {
                txtAddress.Text = this.Cus.Address;
            }
            if (!string.IsNullOrEmpty(this.Cus.Region))
            {
                txtRegion.Text = this.Cus.Region;
            }
            if (!string.IsNullOrEmpty(this.Cus.PostalCode))
            {
                txtPostalCode.Text = this.Cus.PostalCode;
            }
            if (!string.IsNullOrEmpty(this.Cus.City))
            {
                txtCity.Text = this.Cus.City;
            }

        }
    }
}
