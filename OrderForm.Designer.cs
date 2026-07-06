namespace BusniessManagementSystem
{
    partial class OrderForm
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
            groupBox1 = new GroupBox();
            dtOrderDate = new DateTimePicker();
            cmbEmployee = new ComboBox();
            cmbCustomer = new ComboBox();
            lblEmployee = new Label();
            lblOrderDate = new Label();
            lblCustomer = new Label();
            groupBox2 = new GroupBox();
            btnSave = new Button();
            groupBox3 = new GroupBox();
            dgOrderDetails = new DataGridView();
            EditCol = new DataGridViewButtonColumn();
            DeleteCol = new DataGridViewButtonColumn();
            btnAddItem = new Button();
            txtDiscount = new TextBox();
            txtQuantity = new TextBox();
            cmbProduct = new ComboBox();
            cmbCategory = new ComboBox();
            lblQuantity = new Label();
            lblProduct = new Label();
            lblDiscount = new Label();
            lblCategory = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtOrderDate);
            groupBox1.Controls.Add(cmbEmployee);
            groupBox1.Controls.Add(cmbCustomer);
            groupBox1.Controls.Add(lblEmployee);
            groupBox1.Controls.Add(lblOrderDate);
            groupBox1.Controls.Add(lblCustomer);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1222, 240);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dtOrderDate
            // 
            dtOrderDate.Location = new Point(26, 184);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(347, 31);
            dtOrderDate.TabIndex = 5;
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(563, 55);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(347, 33);
            cmbEmployee.TabIndex = 4;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(26, 55);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(347, 33);
            cmbCustomer.TabIndex = 3;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblEmployee.Location = new Point(567, 22);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(101, 28);
            lblEmployee.TabIndex = 2;
            lblEmployee.Text = "Employee";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderDate.Location = new Point(30, 150);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(112, 28);
            lblOrderDate.TabIndex = 1;
            lblOrderDate.Text = "Order Date";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCustomer.Location = new Point(31, 21);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(100, 28);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSave);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(10, 963);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1222, 77);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 0, 192);
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatAppearance.BorderSize = 4;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(528, 26);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 44);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save Order";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgOrderDetails);
            groupBox3.Controls.Add(btnAddItem);
            groupBox3.Controls.Add(txtDiscount);
            groupBox3.Controls.Add(txtQuantity);
            groupBox3.Controls.Add(cmbProduct);
            groupBox3.Controls.Add(cmbCategory);
            groupBox3.Controls.Add(lblQuantity);
            groupBox3.Controls.Add(lblProduct);
            groupBox3.Controls.Add(lblDiscount);
            groupBox3.Controls.Add(lblCategory);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.FlatStyle = FlatStyle.Popup;
            groupBox3.Location = new Point(10, 250);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1222, 713);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // dgOrderDetails
            // 
            dgOrderDetails.AllowUserToAddRows = false;
            dgOrderDetails.BackgroundColor = Color.White;
            dgOrderDetails.BorderStyle = BorderStyle.Fixed3D;
            dgOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrderDetails.Columns.AddRange(new DataGridViewColumn[] { EditCol, DeleteCol });
            dgOrderDetails.Dock = DockStyle.Bottom;
            dgOrderDetails.Location = new Point(3, 513);
            dgOrderDetails.Name = "dgOrderDetails";
            dgOrderDetails.RowHeadersVisible = false;
            dgOrderDetails.RowHeadersWidth = 62;
            dgOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOrderDetails.Size = new Size(1216, 197);
            dgOrderDetails.TabIndex = 9;
            dgOrderDetails.CellClick += dgOrderDetails_CellClick;
            // 
            // EditCol
            // 
            EditCol.FlatStyle = FlatStyle.Flat;
            EditCol.HeaderText = "Edit";
            EditCol.MinimumWidth = 8;
            EditCol.Name = "EditCol";
            EditCol.Text = "Edit";
            EditCol.ToolTipText = "Edit Records";
            EditCol.UseColumnTextForButtonValue = true;
            EditCol.Width = 150;
            // 
            // DeleteCol
            // 
            DeleteCol.HeaderText = "Delete";
            DeleteCol.MinimumWidth = 8;
            DeleteCol.Name = "DeleteCol";
            DeleteCol.Text = "Delete";
            DeleteCol.ToolTipText = "Delete Records";
            DeleteCol.UseColumnTextForButtonValue = true;
            DeleteCol.Width = 150;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = SystemColors.GradientActiveCaption;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddItem.ForeColor = Color.FromArgb(0, 0, 192);
            btnAddItem.Location = new Point(26, 345);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(112, 34);
            btnAddItem.TabIndex = 8;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // txtDiscount
            // 
            txtDiscount.BorderStyle = BorderStyle.FixedSingle;
            txtDiscount.Location = new Point(503, 85);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(238, 31);
            txtDiscount.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Location = new Point(26, 282);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "123";
            txtQuantity.Size = new Size(247, 31);
            txtQuantity.TabIndex = 6;
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(26, 181);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(313, 33);
            cmbProduct.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(26, 85);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(313, 33);
            cmbCategory.TabIndex = 4;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(33, 246);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(90, 28);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProduct.Location = new Point(31, 147);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(83, 28);
            lblProduct.TabIndex = 2;
            lblProduct.Text = "Product";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDiscount.Location = new Point(509, 49);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(129, 28);
            lblDiscount.TabIndex = 1;
            lblDiscount.Text = "Discount (%)";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCategory.Location = new Point(32, 50);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(94, 28);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1242, 1050);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "OrderForm";
            Padding = new Padding(10);
            ShowIcon = false;
            Text = "OrderForm";
            WindowState = FormWindowState.Maximized;
            Load += OrderForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrderDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtOrderDate;
        private ComboBox cmbEmployee;
        private ComboBox cmbCustomer;
        private Label lblEmployee;
        private Label lblOrderDate;
        private Label lblCustomer;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtDiscount;
        private TextBox txtQuantity;
        private ComboBox cmbProduct;
        private ComboBox cmbCategory;
        private Label lblQuantity;
        private Label lblProduct;
        private Label lblDiscount;
        private Label lblCategory;
        private DataGridView dgOrderDetails;
        private Button btnAddItem;
        private DataGridViewButtonColumn EditCol;
        private DataGridViewButtonColumn DeleteCol;
        private Button btnSave;
    }
}