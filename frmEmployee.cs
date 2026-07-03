using BusniessManagementSystem.Modules;
using BusniessManagementSystem.EmployeeRepositories;
using BusniessManagementSystem.Repositories;
using System.IO;
using System.Drawing;

namespace BusniessManagementSystem
{
    public partial class frmEmployee : Form
    {


        public Employee MyEmp = new Employee();

        public frmEmployee()
        {
            InitializeComponent();
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            var (Output, Msg) = ValidationForm();
            if (Output == true)
            {
                var reop = new EmployeeRepository();
                if (MyEmp.Id == 0)
                {
                    reop.Insert(MyEmp);
                    MessageBox.Show("Customer Save Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    reop.Update(MyEmp);
                    MessageBox.Show("Customer Update Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show(Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private (bool, string) ValidationForm()
        {
            bool validInput = true;
            string msg = "";
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                validInput = false;
                msg = "Please enter your first name.";
                txtFirstName.BackColor = Color.IndianRed;
            }
            else
            {
                MyEmp.FirstName = txtFirstName.Text;
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                validInput = false;
                msg += "Please enter your last name.";
                txtLastName.BackColor = Color.IndianRed;

            }
            else
            {
                MyEmp.LastName = txtLastName.Text;
            }
            if (dtDOB.Value == DateTime.MinValue)
            {
                validInput = false;
                msg += "Please enter your DOB.";
                dtDOB.BackColor = Color.IndianRed;
            }
            else
            {
                MyEmp.BirthDate = dtDOB.Value;
            }
            if (dtHireDate.Value == DateTime.MinValue)
            {
                validInput = false;
                msg += "Please enter your Hire Date.";
                dtHireDate.BackColor = Color.IndianRed;

            }
            else
            {
                MyEmp.HireDate = dtHireDate.Value;
            }
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                validInput = false;
                msg += "Please enter your phone number.";
                txtPhoneNumber.BackColor = Color.IndianRed;

            }
            else
            {
                MyEmp.HomePhone = txtPhoneNumber.Text;
            }
            if (string.IsNullOrEmpty(txtCountry.Text))
            {
                validInput = false;
                msg += "Please enter your Country.";
                txtCountry.BackColor = Color.IndianRed;

            }
            else
            {
                MyEmp.Country = txtCountry.Text;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                validInput = false;
                msg += "Please enter your address.";
                txtAddress.BackColor = Color.IndianRed;

            }
            else
            {
                MyEmp.Address = txtAddress.Text;
            }
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                validInput = false;
                msg += "Please enter your city.";
                txtCity.BackColor = Color.IndianRed;

            }
            else
            {
                MyEmp.City = txtCity.Text;
            }
            if (string.IsNullOrEmpty(cmbCourtesy.Text))
            {
                validInput = false;
                msg = "Please enter your TitleOfCourtesy.";
                cmbCourtesy.BackColor = Color.IndianRed;

            }
            else
            {
                MyEmp.TitleOfCourtesy = cmbCourtesy.Text;
            }
            if (string.IsNullOrEmpty(txtExtension.Text))
            {
                validInput = false;
                msg += "Please enter your Extension.";
                txtExtension.BackColor = Color.IndianRed;

            }
            else
            {
                MyEmp.Extension = txtExtension.Text;
            }
            if (string.IsNullOrEmpty(txtTittle.Text))
            {
                validInput = false;
                msg += "Please enter your Tittle.";
                txtTittle.BackColor = Color.IndianRed;

            }
            else
            {
                MyEmp.Title = txtTittle.Text;
            }
            if (string.IsNullOrEmpty(txtRegion.Text))
            {
                validInput = false;
                msg += "Please enter your Region.";
                txtRegion.BackColor = Color.IndianRed;

            }
            else
            {
                MyEmp.Region = txtRegion.Text;
            }
            if (string.IsNullOrEmpty(txtPostalCode.Text))
            {
                validInput = false;
                msg += "Please enter your Postal Code.";
                txtPostalCode.BackColor = Color.IndianRed;

            }
            else
            {
                MyEmp.PostCode = txtPostalCode.Text;
            }
            if (string.IsNullOrEmpty(txtNotes.Text))
            {
                validInput = false;
                msg += "Please enter your Notes.";
                txtNotes.BackColor = Color.IndianRed;

            }
            else
            {
                MyEmp.Notes = txtNotes.Text;
            }
            if (cmbReports.SelectedIndex == -1)
            {
                validInput = false;
                msg += "Please enter your Reports.";
                cmbReports.BackColor = Color.IndianRed;

            }
            else
            {
                MyEmp.ReportsTo = cmbReports.SelectedIndex == -1 ? null : Convert.ToInt32(cmbReports.SelectedValue);

            }
            return (validInput, msg);
        }
        public void LoadReportsCombo()
        {
            var repo = new ReportsComboRepository();
            cmbReports.ValueMember = "EmployeeID";
            cmbReports.DisplayMember = "FullName";
            cmbReports.DataSource = repo.GetReportsCombo();

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure.", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Dispose();
            }
            else
            {
                txtFirstName.Focus();
            }
        }


        string imagePath = "";
        private void btnUploadPic_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image File|*.jpg;*.png;*.jpeg;*.bmp;";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = fileDialog.FileName;
                picEmployee.Image = System.Drawing.Image.FromFile(imagePath);

                byte[] Photo = null;
                if (imagePath != "")
                {
                    MyEmp.Photo = File.ReadAllBytes(imagePath);
                    MyEmp.PhotoPath = (imagePath);
                }

                MessageBox.Show(imagePath);
            }
        }
        private void btnRemovepic_Click_1(object sender, EventArgs e)
        {
            if (picEmployee.Image != null)
            {
                picEmployee.Image.Dispose();
                picEmployee.Image = null;

                MyEmp.Photo = null;
                MyEmp.PhotoPath = "";

                imagePath = "";
            }
        }

        public void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadReportsCombo();
            if (!string.IsNullOrEmpty(this.MyEmp.FirstName))
            {
                txtFirstName.Text = this.MyEmp.FirstName;
            }
            if (!string.IsNullOrEmpty(this.MyEmp.Title))
            {
                txtTittle.Text = this.MyEmp.Title;
            }
            if (!string.IsNullOrEmpty(this.MyEmp.Region))
            {
                txtRegion.Text = this.MyEmp.Region;
            }
            if (!string.IsNullOrEmpty(this.MyEmp.LastName))
            {
                txtLastName.Text = this.MyEmp.LastName;
            }
            if (!string.IsNullOrEmpty(this.MyEmp.HomePhone))
            {
                txtPhoneNumber.Text = this.MyEmp.HomePhone;
            }
            if (!string.IsNullOrEmpty(this.MyEmp.Address))
            {
                txtAddress.Text = this.MyEmp.Address;
            }
            if (!string.IsNullOrEmpty(this.MyEmp.City))
            {
                txtCity.Text = this.MyEmp.City;
            }
            if (!string.IsNullOrEmpty(this.MyEmp.Country))
            {
                txtCountry.Text = this.MyEmp.Country;
            }
            if (!string.IsNullOrEmpty(this.MyEmp.Extension))
            {
                txtExtension.Text = this.MyEmp.Extension;
            }
            if (!string.IsNullOrEmpty(this.MyEmp.Notes))
            {
                txtNotes.Text = this.MyEmp.Notes;
            }
            if (!string.IsNullOrEmpty(this.MyEmp.PostCode))
            {
                txtPostalCode.Text = this.MyEmp.PostCode;
            }
            if (this.MyEmp.BirthDate != null && this.MyEmp.BirthDate != DateTime.MinValue)
            {
                dtDOB.Value = this.MyEmp.BirthDate.Value;
            }

            if (this.MyEmp.HireDate != null && this.MyEmp.HireDate != DateTime.MinValue)
            {
                dtHireDate.Value = this.MyEmp.HireDate.Value;
            }
            cmbCourtesy.Text = this.MyEmp.TitleOfCourtesy;
            if (this.MyEmp.ReportsTo.HasValue)
            {
                cmbReports.SelectedValue = this.MyEmp.ReportsTo.Value;
            }
            else
            {
                cmbReports.SelectedIndex = -1;
            }
            if (MyEmp.Photo != null)
            {
                using (MemoryStream ms = new MemoryStream(MyEmp.Photo))
                {
                    picEmployee.Image = Image.FromStream(ms);
                }
            }
        }

       
    }
}
