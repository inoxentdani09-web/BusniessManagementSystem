using BusniessManagementSystem.EmployeeRepositories;
using BusniessManagementSystem.Modules;
using System.ComponentModel;

namespace BusniessManagementSystem
{
    public partial class ViewEmployee : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Employeeid { get; set; }
        public ViewEmployee()
        {

            InitializeComponent();


        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            EmployeeRepository repo = new EmployeeRepository();
            Employee emp = repo.GetById(Employeeid);

            txtFirstName.Text = emp.FirstName;
            txtLastName.Text = emp.LastName;
            txtCity.Text = emp.City;
            txtPhoneNumber.Text = emp.HomePhone;
            txtExtension.Text = emp.Extension;
            txtCity.Text = emp.City;
            txtCountry.Text = emp.Country;
            txtNotes.Text = emp.Notes;
            txtPostalCode.Text = emp.PostCode;
            txtAddress.Text = emp.Address;
            txtRegion.Text = emp.Region;
            txtTittle.Text = emp.Title;
            dtDOB.Value = Convert.ToDateTime(emp.BirthDate.Value);
            dtHireDate.Value = Convert.ToDateTime(emp.HireDate.Value);
            cmbCourtesy.Text = emp.TitleOfCourtesy;
            cmbReports.Text = emp.ReportsToName;
            if (emp.Photo != null)
            {
                using (MemoryStream ms = new MemoryStream(emp.Photo))
                {
                    picEmployee.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
