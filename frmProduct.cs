using BusniessManagementSystem.Models;
using BusniessManagementSystem.Repositories;

namespace BusniessManagementSystem
{
    public partial class frmProduct : Form
    {
        public Product FrmPro = new Product();
        ProductRepository repo = new ProductRepository();
        public frmProduct()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            (bool output, string Msg) = ValidationInput();
            if (output == true)
            {
                if (FrmPro.ProductID > 0)
                {
                    repo.Update(FrmPro);
                }
                else
                {
                    repo.Insert(FrmPro);
                }

            }
            else
            {
                MessageBox.Show(Msg, "Save Faield", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private (bool, string) ValidationInput()
        {
            bool ValidInput = true;
            string msg = "";

            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                ValidInput = false;
                msg += "Plesae enter product name.\n";
            }
            else
            {
                FrmPro.ProductName = txtProductName.Text;
            }
            if (string.IsNullOrEmpty(cmbSupplier.Text))
            {
                ValidInput = false;
                msg += "Plesae enter Supplier.\n";
            }
            else
            {
                FrmPro.SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue);
            }
            if (string.IsNullOrEmpty(cmbCategory.Text))
            {
                ValidInput = false;
                msg += "Plesae enter Category.\n";
            }
            else
            {
                FrmPro.CategoryID = Convert.ToInt32(cmbCategory.SelectedValue);
            }
            if (string.IsNullOrEmpty(txtQuantityPerUnit.Text))
            {
                ValidInput = false;
                msg += "Plesae enter Quantity per unit.\n";

            }
            else
            {
                FrmPro.QuantityPerUnit = txtQuantityPerUnit.Text;
            }
            if (string.IsNullOrEmpty(txtUnitPrice.Text))
            {
                ValidInput = false;
                msg += "Plesae enter Unit Price.\n";

            }
            else
            {
                FrmPro.UnitPrice = decimal.Parse(txtUnitPrice.Text);
            }
            if (string.IsNullOrEmpty(txtUnitsInStock.Text))
            {
                ValidInput = false;
                msg += "Plesae enter Units In Stock.\n";
            }
            else
            {
                FrmPro.UnitsInStock = short.Parse(txtUnitsInStock.Text);
            }
            if (string.IsNullOrEmpty(txtUnitsOnOrder.Text))
            {
                ValidInput = false;
                msg += "Plesae enter Units On Order.\n";
            }
            else
            {
                FrmPro.UnitsOnOrder = short.Parse(txtUnitsOnOrder.Text);
            }
            if (string.IsNullOrEmpty(txtRecoderLevel.Text))
            {
                ValidInput = false;
                msg += "Plesae enter Recoder Level.\n";
            }
            else
            {
                FrmPro.ReorderLevel = short.Parse(txtRecoderLevel.Text);
            }
            FrmPro.Discontinued = chkDiscontinued.Checked;

            return (ValidInput, msg);
        }
        private void LoadSupplierCombo()
        {
            cmbSupplier.ValueMember = "SupplierID";
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.DataSource = repo.LoadComboSupplier();
        }
        private void LoadCategoryCombo()
        {
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.DataSource = repo.LoadComboCategory();
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadSupplierCombo();
            LoadCategoryCombo();
            if (!string.IsNullOrEmpty(this.FrmPro.ProductName))
            {
                txtProductName.Text = this.FrmPro.ProductName;
            }
            if (this.FrmPro.SupplierID > 0)
            {
                cmbSupplier.SelectedValue = this.FrmPro.SupplierID;
            }
            if (this.FrmPro.CategoryID > 0)
            {
                cmbCategory.SelectedValue = this.FrmPro.CategoryID;
            }
            if (!string.IsNullOrEmpty(this.FrmPro.QuantityPerUnit))
            {
                txtQuantityPerUnit.Text = this.FrmPro.QuantityPerUnit;
            }
            if (this.FrmPro.UnitPrice > 0)
            {
                txtUnitPrice.Text = this.FrmPro.UnitPrice.ToString();
            }
            if (this.FrmPro.UnitsInStock > 0)
            {
                txtUnitsInStock.Text = this.FrmPro.UnitsInStock.ToString();
            }
            if (this.FrmPro.UnitsOnOrder > 0)
            {
                txtUnitsOnOrder.Text = this.FrmPro.UnitsOnOrder.ToString();
            }
            if (this.FrmPro.ReorderLevel > 0)
            {
                txtRecoderLevel.Text = this.FrmPro.ReorderLevel.ToString();
            }
            chkDiscontinued.Checked = FrmPro.Discontinued;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure.", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                
                this.Dispose();
            }
            else
            {
                txtProductName.Focus();
            }
        }
    }
}
