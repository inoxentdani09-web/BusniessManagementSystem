namespace BusniessManagementSystem
{
    partial class SearchProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dgvSearchProduct = new DataGridView();
            EditColumn = new DataGridViewButtonColumn();
            DeleteColumn = new DataGridViewButtonColumn();
            ViewColumn = new DataGridViewButtonColumn();
            gbSearchProduct = new GroupBox();
            lblSearchProduct = new Label();
            cmbSupplier = new ComboBox();
            cmbCategory = new ComboBox();
            txtProductName = new TextBox();
            lblCategory = new Label();
            lblSupplier = new Label();
            lblProductName = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchProduct).BeginInit();
            gbSearchProduct.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgvSearchProduct);
            panel1.Location = new Point(0, 405);
            panel1.Name = "panel1";
            panel1.Size = new Size(1311, 348);
            panel1.TabIndex = 0;
            // 
            // dgvSearchProduct
            // 
            dgvSearchProduct.AllowUserToAddRows = false;
            dgvSearchProduct.BackgroundColor = Color.White;
            dgvSearchProduct.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSearchProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchProduct.Columns.AddRange(new DataGridViewColumn[] { EditColumn, DeleteColumn, ViewColumn });
            dgvSearchProduct.Dock = DockStyle.Bottom;
            dgvSearchProduct.GridColor = Color.White;
            dgvSearchProduct.Location = new Point(0, 0);
            dgvSearchProduct.Name = "dgvSearchProduct";
            dgvSearchProduct.RowHeadersVisible = false;
            dgvSearchProduct.RowHeadersWidth = 62;
            dgvSearchProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchProduct.Size = new Size(1311, 348);
            dgvSearchProduct.TabIndex = 0;
            // 
            // EditColumn
            // 
            EditColumn.HeaderText = "Edit";
            EditColumn.MinimumWidth = 8;
            EditColumn.Name = "EditColumn";
            EditColumn.Text = "Edit";
            EditColumn.ToolTipText = "Edit Records Products";
            EditColumn.UseColumnTextForButtonValue = true;
            EditColumn.Width = 150;
            // 
            // DeleteColumn
            // 
            DeleteColumn.HeaderText = "Delete";
            DeleteColumn.MinimumWidth = 8;
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.Text = "Delete";
            DeleteColumn.ToolTipText = "Delete Records Products";
            DeleteColumn.UseColumnTextForButtonValue = true;
            DeleteColumn.Width = 150;
            // 
            // ViewColumn
            // 
            ViewColumn.HeaderText = "View";
            ViewColumn.MinimumWidth = 8;
            ViewColumn.Name = "ViewColumn";
            ViewColumn.Text = "View";
            ViewColumn.ToolTipText = "View Product";
            ViewColumn.UseColumnTextForButtonValue = true;
            ViewColumn.Width = 150;
            // 
            // gbSearchProduct
            // 
            gbSearchProduct.Anchor = AnchorStyles.None;
            gbSearchProduct.Controls.Add(lblSearchProduct);
            gbSearchProduct.Controls.Add(cmbSupplier);
            gbSearchProduct.Controls.Add(cmbCategory);
            gbSearchProduct.Controls.Add(txtProductName);
            gbSearchProduct.Controls.Add(lblCategory);
            gbSearchProduct.Controls.Add(lblSupplier);
            gbSearchProduct.Controls.Add(lblProductName);
            gbSearchProduct.FlatStyle = FlatStyle.Flat;
            gbSearchProduct.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbSearchProduct.Location = new Point(0, 0);
            gbSearchProduct.Name = "gbSearchProduct";
            gbSearchProduct.Size = new Size(1309, 399);
            gbSearchProduct.TabIndex = 1;
            gbSearchProduct.TabStop = false;
            // 
            // lblSearchProduct
            // 
            lblSearchProduct.AutoSize = true;
            lblSearchProduct.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSearchProduct.ForeColor = Color.RoyalBlue;
            lblSearchProduct.Location = new Point(6, 27);
            lblSearchProduct.Name = "lblSearchProduct";
            lblSearchProduct.Size = new Size(223, 38);
            lblSearchProduct.TabIndex = 13;
            lblSearchProduct.Text = "Search Product :";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(509, 160);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(286, 36);
            cmbSupplier.TabIndex = 11;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(946, 160);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(286, 36);
            cmbCategory.TabIndex = 12;
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Location = new Point(77, 161);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(254, 34);
            txtProductName.TabIndex = 10;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(943, 117);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(104, 30);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "&Category";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplier.Location = new Point(506, 117);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(96, 30);
            lblSupplier.TabIndex = 8;
            lblSupplier.Text = "&Supplier";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(77, 117);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(156, 30);
            lblProductName.TabIndex = 7;
            lblProductName.Text = "&Product Name";
            // 
            // SearchProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1309, 765);
            Controls.Add(gbSearchProduct);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchProduct";
            ShowIcon = false;
            Text = "SearchProduct";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSearchProduct).EndInit();
            gbSearchProduct.ResumeLayout(false);
            gbSearchProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvSearchProduct;
        private DataGridViewButtonColumn EditColumn;
        private DataGridViewButtonColumn DeleteColumn;
        private DataGridViewButtonColumn ViewColumn;
        private GroupBox gbSearchProduct;
        private ComboBox cmbSupplier;
        private ComboBox cmbCategory;
        private TextBox txtProductName;
        private Label lblCategory;
        private Label lblSupplier;
        private Label lblProductName;
        private Label lblSearchProduct;
    }
}