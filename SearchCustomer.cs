using BusniessManagementSystem.Modules;
using BusniessManagementSystem.Repositories;

namespace BusniessManagementSystem
{
    public partial class SearchCustomer : Form
    {
        CustomerRepository repo = new CustomerRepository();
        frmCustomers frm = new frmCustomers();

        public SearchCustomer()
        {
            InitializeComponent();
        }

        private void SearchCustomer_Load(object sender, EventArgs e)
        {
            SearchCustomerGrid.DataSource = repo.GetAll().Tables[0];

        }

        private void SearchCustomerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SearchCustomerGrid.Columns[e.ColumnIndex].Name == "EditColumn")
            {
                var CellValue = SearchCustomerGrid.Rows[e.RowIndex].Cells["CustomerID"].Value?.ToString();
                string id = CellValue != null ? Convert.ToString(CellValue) : "";
                EditCustomer(id);
            }
            if (SearchCustomerGrid.Columns[e.ColumnIndex].Name == "DeleteColumn")
            {
                var CellValue = SearchCustomerGrid.Rows[e.RowIndex].Cells["CustomerID"].Value?.ToString();
                string id = CellValue != null ? Convert.ToString(CellValue) : "";
                DeleteCustomer(id);
            }
            if (SearchCustomerGrid.Columns[e.ColumnIndex].Name == "ViewColumn")
            {
                var CellValue = SearchCustomerGrid.Rows[e.RowIndex].Cells["CustomerID"].Value?.ToString();
                string id = CellValue != null ? Convert.ToString(CellValue) : "";
                ViewCustomer(id);
            }
        }

        private void ViewCustomer(string id)
        {
            ViewCustomer view = new ViewCustomer();
            view.CustomerID = id;

            view.Show();

        }
        private void DeleteCustomer(string id)
        {
            bool result = repo.Delete(id);
            if (result)
            {
                MessageBox.Show("Employee Deleted");
            }
        }
        private void EditCustomer(string id)
        {
            frm.Cus = repo.GetById(id);
            frm.MdiParent = this.MdiParent;
            frm.isEdit = true;
            frm.Show();
        }
        private void CustomerSearch()
        {
            Customer cus = new Customer();
            cus.CustomerID = txtCustomerID.Text;
            cus.CompanyName = txtCompanyName.Text;
            cus.PostalCode = txtPostalCode.Text;
            cus.ContactName = txtContactName.Text;
            cus.City = txtCity.Text;

            SearchCustomerGrid.DataSource = repo.SearchCustomer(cus);
        }
        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            CustomerSearch();
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            CustomerSearch();

        }

        private void txtContactName_TextChanged(object sender, EventArgs e)
        {
            CustomerSearch();

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            CustomerSearch();

        }

        private void txtPostalCode_TextChanged(object sender, EventArgs e)
        {
            CustomerSearch();

        }
    }
}
