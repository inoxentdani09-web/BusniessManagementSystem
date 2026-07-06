using BusniessManagementSystem.Repositories;

namespace BusniessManagementSystem
{
    public partial class SearchProduct : Form
    {
        ProductRepository repo = new ProductRepository();

        public int id { get; private set; }

        public SearchProduct()
        {
            InitializeComponent();
        }

        private void SearchProduct_Load(object sender, EventArgs e)
        {
            LoadComboCategory();
            LoadComboSupplier();
            LoadProductRecords(id);
        }
        private void LoadComboCategory()
        {
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.DataSource = new CategoryRepository().GetAll();
        }
        private void LoadComboSupplier()
        {
            cmbSupplier.ValueMember = "SupplierID";
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.DataSource = repo.LoadComboSupplier();
        }
        private void LoadProductRecords(int id)
        {
            try
            {
                dgvSearchProduct.DataSource = repo.GetAll(id).Tables[0];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSearchProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearchProduct.Columns[e.ColumnIndex].Name == "EditColumn")
            {
                var RawId = dgvSearchProduct.Rows[e.RowIndex].Cells["ProductID"].Value?.ToString();
                int id = !string.IsNullOrEmpty(RawId) ? Convert.ToInt32(RawId) : 0;
                EditProduct(id);
            }
            if (dgvSearchProduct.Columns[e.ColumnIndex].Name == "DeleteColumn")
            {
                var RawId = dgvSearchProduct.Rows[e.RowIndex].Cells["ProductID"].Value?.ToString();
                int id = !string.IsNullOrEmpty(RawId) ? Convert.ToInt32(RawId) : 0;
                DeleteProduct(id);
            }
            if (dgvSearchProduct.Columns[e.ColumnIndex].Name == "ViewColumn")
            {
                var RawId = dgvSearchProduct.Rows[e.RowIndex].Cells["ProductID"].Value?.ToString();
                int id = !string.IsNullOrEmpty(RawId) ? Convert.ToInt32(RawId) : 0;
                ProductView(id);
            }
        }
        private void EditProduct(int id)
        {
            if (dgvSearchProduct == null)
            {
                MessageBox.Show("Please Slect First.", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            frmProduct pro = new frmProduct();
            pro.FrmPro = repo.GetById(id);
            pro.MdiParent = MdiParent;
            pro.Show();
        }
        private void ProductView(int id)
        {
            if (dgvSearchProduct == null)
            {
                MessageBox.Show("Please select first.");
                return;
            }
            ViewProduct pro = new ViewProduct();
            pro.ProductID = id;
            pro.MdiParent = MdiParent;
            pro.Show();
        }

        private void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        private void SearchProduct_Activated(object sender, EventArgs e)
        {
            LoadProductRecords(id);
        }
    }
}
