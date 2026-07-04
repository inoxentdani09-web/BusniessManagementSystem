using BusniessManagementSystem.EmployeeRepositories;
using BusniessManagementSystem.Modules;
using BusniessManagementSystem.Repositories;


namespace BusniessManagementSystem
{
    public partial class SearchEmployee : Form
    {
        EmployeeRepository repo = new EmployeeRepository();
        public SearchEmployee()
        {
            InitializeComponent();
        }
        private void SearchEmployee_Load(object sender, EventArgs e)
        {
            LoadReportsCombo();
            LoadEmployeeRecords();
        }
        public void LoadReportsCombo()
        {
            var repo = new ReportsComboRepository();
            cmbReports.ValueMember = "EmployeeID";
            cmbReports.DisplayMember = "FullName";
            cmbReports.DataSource = repo.GetReportsCombo();

        }
        public void LoadEmployeeRecords()
        {
            try
            {

                dgvSearchEmployee.DataSource = repo.GetAll().Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSearchEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearchEmployee.Columns[e.ColumnIndex].Name == "EditCol")
            {
                var cellValue = dgvSearchEmployee.Rows[e.RowIndex].Cells["EmployeeID"].Value;
                int id = (cellValue != null && cellValue != DBNull.Value) ? Convert.ToInt32(cellValue) : 0;
                EditEmployee(id);
            }
            if (dgvSearchEmployee.Columns[e.ColumnIndex].Name == "ViewCol")
            {
                var cellValue = dgvSearchEmployee.Rows[e.RowIndex].Cells["EmployeeID"].Value;
                int id = (cellValue != null && cellValue != DBNull.Value) ? Convert.ToInt32(cellValue) : 0;
                EmployeeView(id);
            }
            if (dgvSearchEmployee.Columns[e.ColumnIndex].Name == "DeleteCol")
            {
                var cellValue = dgvSearchEmployee.Rows[e.RowIndex].Cells["EmployeeID"].Value;
                int id = (cellValue != null && cellValue != DBNull.Value) ? Convert.ToInt32(cellValue) : 0;
                DeleteEmployee(id);
            }
        }

        private void DeleteEmployee(int id)
        {
            if (dgvSearchEmployee.CurrentRow == null)
            {
                MessageBox.Show("Please select employee first.");
                return;
            }
            bool result = repo.Delete(id);
            if (result)
            {
                MessageBox.Show("Employee Deleted");
                LoadEmployeeRecords();
            }
        }

        private void EmployeeView(int id)
        {
            if (dgvSearchEmployee == null)
            {
                MessageBox.Show("Please select first.");
                return;
            }
            ViewEmployee Vemp = new ViewEmployee();
            Vemp.Employeeid = id;
            Vemp.Show();
        }

        private void EditEmployee(int id)
        {
            if (dgvSearchEmployee.CurrentRow == null)
            {
                MessageBox.Show("Please Select Employee");
                return;
            }

            frmEmployee frm = new frmEmployee();
            frm.MyEmp = repo.GetById(id);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void EmployeeSearch()
        {
            Employee emp = new Employee();
            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;
            emp.Address = txtAddress.Text;
            emp.PostCode = txtPostalCode.Text;
            if (cmbReports.Text != null)
            {
                emp.ReportsTo = Convert.ToInt32(cmbReports.SelectedValue);
            }
            dgvSearchEmployee.DataSource = repo.SearchEmployee(emp);
        }

        private void txtFirstName_TextChanged_1(object sender, EventArgs e)
        {
            EmployeeSearch();
        }
        private void txtLastName_TextChanged_1(object sender, EventArgs e)
        {
            EmployeeSearch();
        }
        private void txtPostalCode_TextChanged_1(object sender, EventArgs e)
        {
            EmployeeSearch();
        }

        private void cmbReports_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            EmployeeSearch();
        }

        private void txtAddress_TextChanged_1(object sender, EventArgs e)
        {
            EmployeeSearch();
        }
    }
}