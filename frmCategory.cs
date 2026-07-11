using BusniessManagementSystem.Models;
using BusniessManagementSystem.Repositories;
namespace BusniessManagementSystem
{
    public partial class frmCategory : Form
    {
        CategoryRepository cateRepo = new CategoryRepository();
        Category cate = new Category();
        public frmCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            (bool result, string Msg) = ValidationInput();
            if (result == true)
            {
                if (cate.CategoryID == 0)
                {
                    cateRepo.Insert(cate);
                }
                else
                {
                    cateRepo.Update(cate);
                }

            }
            else
            {
                MessageBox.Show(Msg, "Save faield", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private (bool result, string Msg) ValidationInput()
        {
            bool found = true;
            string msg = "";
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                found = false;
                msg = "Please enter a Category Name.\n";
            }
            else
            {
                cate.CategoryName = txtCategoryName.Text;
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                found = false;
                msg += "Please enter a Description.\n";
            }
            else
            {
                cate.Descriptipn = txtDescription.Text;
            }
            if (pbCatePic.Image != null)
            {

                using (MemoryStream ms = new())
                {
                    pbCatePic.Image.Save(ms, pbCatePic.Image.RawFormat);
                    cate.Photo = ms.ToArray();
                }
                msg += "Please select Image.\n";
            }
            else
            {
                cate.Photo = null;
            }
            return (found, msg);

        }

        private void btnBrowsePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select Category Pic";
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbCatePic.Image = Image.FromFile(openFile.FileName);

            }
            lblNoImageSelected.Visible = false;
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.cate.CategoryName))
            {
                txtCategoryName.Text = this.cate.CategoryName;
            }

            if (!string.IsNullOrEmpty(this.cate.Descriptipn))
            {
                txtDescription.Text = this.cate.Descriptipn;

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure.", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Dispose();
            }
            else
            {
                txtCategoryName.Focus();
            }
        }
    }
}
