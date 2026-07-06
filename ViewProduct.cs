using BusniessManagementSystem.Models;
using BusniessManagementSystem.Repositories;
using System.ComponentModel;

namespace BusniessManagementSystem
{
    public partial class ViewProduct : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ProductID { get; set; }
        ProductRepository repo = new ProductRepository();
        public ViewProduct()
        {
            InitializeComponent();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
            ProductRepository repo = new ProductRepository();
            Product pro = repo.GetById(ProductID);

            txtProductName.Text = pro.ProductName;
            txtQuantityPerUnit.Text = pro.QuantityPerUnit;
            txtRecoderLevel.Text = pro.ReorderLevel.ToString();
            txtUnitPrice.Text = Convert.ToDecimal(pro.UnitPrice).ToString();
            txtUnitsInStock.Text = pro.UnitsInStock.ToString();
            txtUnitsOnOrder.Text = pro.UnitsOnOrder.ToString();
            cmbSupplier.SelectedValue = pro.SupplierID;
            cmbCategory.SelectedValue = pro.CategoryID.ToString();
            chkDiscontinued.Checked = pro.Discontinued;
        }

        private void LoadProducts()
        {
            cmbSupplier.ValueMember = "SupplierID";
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.DataSource = repo.LoadComboSupplier();

        }

        private void LoadCategories()
        {
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.DataSource = new CategoryRepository().GetAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
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
