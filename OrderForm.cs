using BusniessManagementSystem.EmployeeRepositories;
using BusniessManagementSystem.Repositories;
using System.Data;

namespace BusniessManagementSystem
{
    public partial class OrderForm : Form
    {
        DataTable dtOrderDetails = new DataTable();
        private int editRowIndex = -1;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadEmployees();
            LoadCategories();
            CreatOrderTable();
        }

        private void CreatOrderTable()
        {
            dtOrderDetails.Columns.Add("ProductID");
            dtOrderDetails.Columns.Add("ProductName");
            dtOrderDetails.Columns.Add("UnitPrice");
            dtOrderDetails.Columns.Add("Quantity");
            dtOrderDetails.Columns.Add("Discount");
            dgOrderDetails.DataSource = dtOrderDetails;
        }

        private void LoadCategories()
        {
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = new CategoryRepository().GetAll().Tables[0];
        }
        private void LoadEmployees()
        {
            var repo = new EmployeeRepository();
            cmbEmployee.DisplayMember = "EmployeeName";
            cmbEmployee.ValueMember = "EmployeeID";
            cmbEmployee.DataSource = new EmployeeRepository().GetAll().Tables[0];
        }

        private void LoadCustomers()
        {
            var repo = new CustomerRepository();
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerID";
            cmbCustomer.DataSource = new CustomerRepository().GetAll().Tables[0];
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCategory.SelectedIndex > 0)
            {
                LoadProduct(Convert.ToInt16(this.cmbCategory.SelectedValue));
            }
            else
            {
                cmbCategory.DataSource = null;
            }
        }
        private void LoadProduct(int id)
        {
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
            cmbProduct.DataSource = new ProductRepository().GetAll(id).Tables[0];
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (editRowIndex == -1)
            {
                DataRow row = this.dtOrderDetails.NewRow();
                DataRowView dr = (DataRowView)this.cmbProduct.SelectedItem;
                if (dr == null)
                {
                    MessageBox.Show("Please select a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                row["ProductID"] = dr["ProductID"];
                row["ProductName"] = dr["ProductName"];
                row["UnitPrice"] = dr["UnitPrice"];
                row["Quantity"] = txtQuantity.Text;
                row["Discount"] = txtDiscount.Text;
                this.dtOrderDetails.Rows.Add(row);
            }
            else
            {
                DataRowView dr = (DataRowView)this.cmbProduct.SelectedItem;
                dtOrderDetails.Rows[editRowIndex]["ProductID"] = dr["ProductID"];
                dtOrderDetails.Rows[editRowIndex]["ProductName"] = dr["ProductName"];
                dtOrderDetails.Rows[editRowIndex]["UnitPrice"] = dr["UnitPrice"];
                dtOrderDetails.Rows[editRowIndex]["Quantity"] = txtQuantity.Text;
                dtOrderDetails.Rows[editRowIndex]["Discount"] = txtDiscount.Text;
                editRowIndex = -1;
            }

        }

        private void dgOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgOrderDetails.Columns[e.ColumnIndex].Name == "EditCol")
            {
                EditOrderDetails(e.RowIndex);
            }
            if (dgOrderDetails.Columns[e.ColumnIndex].Name == "DeleteCol")
            {
                DeleteOrderDetails(e.RowIndex);
            }
        }

        private void EditOrderDetails(int rowIndex)
        {
            editRowIndex = rowIndex;
            cmbProduct.SelectedValue = dtOrderDetails.Rows[rowIndex]["ProductID"];
            txtDiscount.Text = dtOrderDetails.Rows[rowIndex]["Discount"].ToString();
            txtQuantity.Text = dtOrderDetails.Rows[rowIndex]["Quantity"].ToString();
        }

        private void DeleteOrderDetails(int rowIndex)
        {
            dtOrderDetails.Rows.RemoveAt(rowIndex);
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
