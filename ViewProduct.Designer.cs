namespace BusniessManagementSystem
{
    partial class ViewProduct
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
            btnCancel = new Button();
            label1 = new Label();
            chkDiscontinued = new CheckBox();
            cmbSupplier = new ComboBox();
            cmbCategory = new ComboBox();
            txtProductName = new TextBox();
            txtQuantityPerUnit = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnitsInStock = new TextBox();
            txtUnitsOnOrder = new TextBox();
            txtRecoderLevel = new TextBox();
            lblDiscontinued = new Label();
            lblReorderLavel = new Label();
            lblUnitsOnOrder = new Label();
            lblUnitsInStock = new Label();
            lblUnitPrice = new Label();
            lblQuantityPerUnit = new Label();
            lblCategory = new Label();
            lblSupplier = new Label();
            lblProductName = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(chkDiscontinued);
            groupBox1.Controls.Add(cmbSupplier);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtQuantityPerUnit);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtUnitsInStock);
            groupBox1.Controls.Add(txtUnitsOnOrder);
            groupBox1.Controls.Add(txtRecoderLevel);
            groupBox1.Controls.Add(lblDiscontinued);
            groupBox1.Controls.Add(lblReorderLavel);
            groupBox1.Controls.Add(lblUnitsOnOrder);
            groupBox1.Controls.Add(lblUnitsInStock);
            groupBox1.Controls.Add(lblUnitPrice);
            groupBox1.Controls.Add(lblQuantityPerUnit);
            groupBox1.Controls.Add(lblCategory);
            groupBox1.Controls.Add(lblSupplier);
            groupBox1.Controls.Add(lblProductName);
            groupBox1.Location = new Point(0, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1302, 729);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.RoyalBlue;
            btnCancel.Image = Properties.Resources.icons8_close_32;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(578, 609);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 43);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "     Ca&ncel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(33, -1);
            label1.Name = "label1";
            label1.Size = new Size(200, 38);
            label1.TabIndex = 21;
            label1.Text = "View Product :";
            // 
            // chkDiscontinued
            // 
            chkDiscontinued.AutoSize = true;
            chkDiscontinued.Cursor = Cursors.Hand;
            chkDiscontinued.Location = new Point(963, 435);
            chkDiscontinued.Name = "chkDiscontinued";
            chkDiscontinued.Size = new Size(22, 21);
            chkDiscontinued.TabIndex = 38;
            chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // cmbSupplier
            // 
            cmbSupplier.BackColor = SystemColors.Control;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(546, 137);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(286, 33);
            cmbSupplier.TabIndex = 26;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = SystemColors.Control;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(983, 137);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(286, 33);
            cmbCategory.TabIndex = 27;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.Control;
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Location = new Point(114, 138);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(286, 31);
            txtProductName.TabIndex = 25;
            // 
            // txtQuantityPerUnit
            // 
            txtQuantityPerUnit.BackColor = SystemColors.Control;
            txtQuantityPerUnit.BorderStyle = BorderStyle.FixedSingle;
            txtQuantityPerUnit.Location = new Point(114, 287);
            txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            txtQuantityPerUnit.Size = new Size(286, 31);
            txtQuantityPerUnit.TabIndex = 31;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = SystemColors.Control;
            txtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            txtUnitPrice.Location = new Point(543, 287);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(286, 31);
            txtUnitPrice.TabIndex = 32;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.BackColor = SystemColors.Control;
            txtUnitsInStock.BorderStyle = BorderStyle.FixedSingle;
            txtUnitsInStock.Location = new Point(980, 287);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(286, 31);
            txtUnitsInStock.TabIndex = 33;
            // 
            // txtUnitsOnOrder
            // 
            txtUnitsOnOrder.BackColor = SystemColors.Control;
            txtUnitsOnOrder.BorderStyle = BorderStyle.FixedSingle;
            txtUnitsOnOrder.Location = new Point(114, 426);
            txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            txtUnitsOnOrder.Size = new Size(286, 31);
            txtUnitsOnOrder.TabIndex = 36;
            // 
            // txtRecoderLevel
            // 
            txtRecoderLevel.BackColor = SystemColors.Control;
            txtRecoderLevel.BorderStyle = BorderStyle.FixedSingle;
            txtRecoderLevel.Location = new Point(543, 435);
            txtRecoderLevel.Name = "txtRecoderLevel";
            txtRecoderLevel.Size = new Size(286, 31);
            txtRecoderLevel.TabIndex = 37;
            // 
            // lblDiscontinued
            // 
            lblDiscontinued.AutoSize = true;
            lblDiscontinued.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscontinued.Location = new Point(984, 426);
            lblDiscontinued.Name = "lblDiscontinued";
            lblDiscontinued.Size = new Size(145, 30);
            lblDiscontinued.TabIndex = 39;
            lblDiscontinued.Text = "&Discontinued";
            // 
            // lblReorderLavel
            // 
            lblReorderLavel.AutoSize = true;
            lblReorderLavel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReorderLavel.Location = new Point(543, 384);
            lblReorderLavel.Name = "lblReorderLavel";
            lblReorderLavel.Size = new Size(149, 30);
            lblReorderLavel.TabIndex = 35;
            lblReorderLavel.Text = "&Reorder Lavel";
            // 
            // lblUnitsOnOrder
            // 
            lblUnitsOnOrder.AutoSize = true;
            lblUnitsOnOrder.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitsOnOrder.Location = new Point(114, 384);
            lblUnitsOnOrder.Name = "lblUnitsOnOrder";
            lblUnitsOnOrder.Size = new Size(164, 30);
            lblUnitsOnOrder.TabIndex = 34;
            lblUnitsOnOrder.Text = "Units On &Order";
            // 
            // lblUnitsInStock
            // 
            lblUnitsInStock.AutoSize = true;
            lblUnitsInStock.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitsInStock.Location = new Point(980, 239);
            lblUnitsInStock.Name = "lblUnitsInStock";
            lblUnitsInStock.Size = new Size(149, 30);
            lblUnitsInStock.TabIndex = 30;
            lblUnitsInStock.Text = "Units In Stoc&k";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitPrice.Location = new Point(543, 239);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(110, 30);
            lblUnitPrice.TabIndex = 29;
            lblUnitPrice.Text = "&Unit Price";
            // 
            // lblQuantityPerUnit
            // 
            lblQuantityPerUnit.AutoSize = true;
            lblQuantityPerUnit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantityPerUnit.Location = new Point(114, 239);
            lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            lblQuantityPerUnit.Size = new Size(186, 30);
            lblQuantityPerUnit.TabIndex = 28;
            lblQuantityPerUnit.Text = "&Quantity Per Unit";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(980, 94);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(104, 30);
            lblCategory.TabIndex = 24;
            lblCategory.Text = "&Category";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplier.Location = new Point(543, 94);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(96, 30);
            lblSupplier.TabIndex = 23;
            lblSupplier.Text = "&Supplier";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(114, 94);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(156, 30);
            lblProductName.TabIndex = 22;
            lblProductName.Text = "&Product Name";
            // 
            // ViewProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 732);
            Controls.Add(groupBox1);
            Name = "ViewProduct";
            Text = "ViewProduct";
            Load += ViewProduct_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCancel;
        private Label label1;
        private CheckBox chkDiscontinued;
        private ComboBox cmbSupplier;
        private ComboBox cmbCategory;
        private TextBox txtProductName;
        private TextBox txtQuantityPerUnit;
        private TextBox txtUnitPrice;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitsOnOrder;
        private TextBox txtRecoderLevel;
        private Label lblDiscontinued;
        private Label lblReorderLavel;
        private Label lblUnitsOnOrder;
        private Label lblUnitsInStock;
        private Label lblUnitPrice;
        private Label lblQuantityPerUnit;
        private Label lblCategory;
        private Label lblSupplier;
        private Label lblProductName;
    }
}