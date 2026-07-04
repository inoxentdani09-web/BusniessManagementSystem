namespace BusniessManagementSystem
{
    partial class frmProduct
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
            gbProduct = new GroupBox();
            button2 = new Button();
            button1 = new Button();
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
            gbProduct.SuspendLayout();
            SuspendLayout();
            // 
            // gbProduct
            // 
            gbProduct.Anchor = AnchorStyles.None;
            gbProduct.BackColor = Color.White;
            gbProduct.Controls.Add(button2);
            gbProduct.Controls.Add(button1);
            gbProduct.Controls.Add(label1);
            gbProduct.Controls.Add(chkDiscontinued);
            gbProduct.Controls.Add(cmbSupplier);
            gbProduct.Controls.Add(cmbCategory);
            gbProduct.Controls.Add(txtProductName);
            gbProduct.Controls.Add(txtQuantityPerUnit);
            gbProduct.Controls.Add(txtUnitPrice);
            gbProduct.Controls.Add(txtUnitsInStock);
            gbProduct.Controls.Add(txtUnitsOnOrder);
            gbProduct.Controls.Add(txtRecoderLevel);
            gbProduct.Controls.Add(lblDiscontinued);
            gbProduct.Controls.Add(lblReorderLavel);
            gbProduct.Controls.Add(lblUnitsOnOrder);
            gbProduct.Controls.Add(lblUnitsInStock);
            gbProduct.Controls.Add(lblUnitPrice);
            gbProduct.Controls.Add(lblQuantityPerUnit);
            gbProduct.Controls.Add(lblCategory);
            gbProduct.Controls.Add(lblSupplier);
            gbProduct.Controls.Add(lblProductName);
            gbProduct.FlatStyle = FlatStyle.Flat;
            gbProduct.Location = new Point(-8, 1);
            gbProduct.Name = "gbProduct";
            gbProduct.Size = new Size(1310, 833);
            gbProduct.TabIndex = 0;
            gbProduct.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(610, 649);
            button2.Name = "button2";
            button2.Size = new Size(200, 43);
            button2.TabIndex = 20;
            button2.Text = "Sa&ve Product";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.RoyalBlue;
            button1.Image = Properties.Resources.icons8_close_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(501, 649);
            button1.Name = "button1";
            button1.Size = new Size(103, 43);
            button1.TabIndex = 19;
            button1.Text = "     Ca&ncel";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(131, 38);
            label1.TabIndex = 0;
            label1.Text = "Product :";
            // 
            // chkDiscontinued
            // 
            chkDiscontinued.AutoSize = true;
            chkDiscontinued.Cursor = Cursors.Hand;
            chkDiscontinued.Location = new Point(942, 472);
            chkDiscontinued.Name = "chkDiscontinued";
            chkDiscontinued.Size = new Size(22, 21);
            chkDiscontinued.TabIndex = 17;
            chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // cmbSupplier
            // 
            cmbSupplier.BackColor = SystemColors.Control;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(525, 174);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(286, 33);
            cmbSupplier.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = SystemColors.Control;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(962, 174);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(286, 33);
            cmbCategory.TabIndex = 6;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.Control;
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Location = new Point(93, 175);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(286, 31);
            txtProductName.TabIndex = 4;
            // 
            // txtQuantityPerUnit
            // 
            txtQuantityPerUnit.BackColor = SystemColors.Control;
            txtQuantityPerUnit.BorderStyle = BorderStyle.FixedSingle;
            txtQuantityPerUnit.Location = new Point(93, 324);
            txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            txtQuantityPerUnit.Size = new Size(286, 31);
            txtQuantityPerUnit.TabIndex = 10;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = SystemColors.Control;
            txtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            txtUnitPrice.Location = new Point(522, 324);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(286, 31);
            txtUnitPrice.TabIndex = 11;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.BackColor = SystemColors.Control;
            txtUnitsInStock.BorderStyle = BorderStyle.FixedSingle;
            txtUnitsInStock.Location = new Point(959, 324);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(286, 31);
            txtUnitsInStock.TabIndex = 12;
            // 
            // txtUnitsOnOrder
            // 
            txtUnitsOnOrder.BackColor = SystemColors.Control;
            txtUnitsOnOrder.BorderStyle = BorderStyle.FixedSingle;
            txtUnitsOnOrder.Location = new Point(93, 463);
            txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            txtUnitsOnOrder.Size = new Size(286, 31);
            txtUnitsOnOrder.TabIndex = 15;
            // 
            // txtRecoderLevel
            // 
            txtRecoderLevel.BackColor = SystemColors.Control;
            txtRecoderLevel.BorderStyle = BorderStyle.FixedSingle;
            txtRecoderLevel.Location = new Point(522, 472);
            txtRecoderLevel.Name = "txtRecoderLevel";
            txtRecoderLevel.Size = new Size(286, 31);
            txtRecoderLevel.TabIndex = 16;
            // 
            // lblDiscontinued
            // 
            lblDiscontinued.AutoSize = true;
            lblDiscontinued.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscontinued.Location = new Point(963, 463);
            lblDiscontinued.Name = "lblDiscontinued";
            lblDiscontinued.Size = new Size(145, 30);
            lblDiscontinued.TabIndex = 18;
            lblDiscontinued.Text = "&Discontinued";
            // 
            // lblReorderLavel
            // 
            lblReorderLavel.AutoSize = true;
            lblReorderLavel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReorderLavel.Location = new Point(522, 421);
            lblReorderLavel.Name = "lblReorderLavel";
            lblReorderLavel.Size = new Size(149, 30);
            lblReorderLavel.TabIndex = 14;
            lblReorderLavel.Text = "&Reorder Lavel";
            // 
            // lblUnitsOnOrder
            // 
            lblUnitsOnOrder.AutoSize = true;
            lblUnitsOnOrder.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitsOnOrder.Location = new Point(93, 421);
            lblUnitsOnOrder.Name = "lblUnitsOnOrder";
            lblUnitsOnOrder.Size = new Size(164, 30);
            lblUnitsOnOrder.TabIndex = 13;
            lblUnitsOnOrder.Text = "Units On &Order";
            // 
            // lblUnitsInStock
            // 
            lblUnitsInStock.AutoSize = true;
            lblUnitsInStock.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitsInStock.Location = new Point(959, 276);
            lblUnitsInStock.Name = "lblUnitsInStock";
            lblUnitsInStock.Size = new Size(149, 30);
            lblUnitsInStock.TabIndex = 9;
            lblUnitsInStock.Text = "Units In Stoc&k";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitPrice.Location = new Point(522, 276);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(110, 30);
            lblUnitPrice.TabIndex = 8;
            lblUnitPrice.Text = "&Unit Price";
            // 
            // lblQuantityPerUnit
            // 
            lblQuantityPerUnit.AutoSize = true;
            lblQuantityPerUnit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantityPerUnit.Location = new Point(93, 276);
            lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            lblQuantityPerUnit.Size = new Size(186, 30);
            lblQuantityPerUnit.TabIndex = 7;
            lblQuantityPerUnit.Text = "&Quantity Per Unit";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(959, 131);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(104, 30);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "&Category";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplier.Location = new Point(522, 131);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(96, 30);
            lblSupplier.TabIndex = 2;
            lblSupplier.Text = "&Supplier";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(93, 131);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(156, 30);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "&Product Name";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1295, 838);
            Controls.Add(gbProduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProduct";
            ShowIcon = false;
            Text = "frmProduct";
            WindowState = FormWindowState.Maximized;
            gbProduct.ResumeLayout(false);
            gbProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbProduct;
        private Label lblDiscontinued;
        private Label lblReorderLavel;
        private Label lblUnitsOnOrder;
        private Label lblUnitsInStock;
        private Label lblUnitPrice;
        private Label lblQuantityPerUnit;
        private Label lblCategory;
        private Label lblSupplier;
        private Label lblProductName;
        private CheckBox chkDiscontinued;
        private ComboBox cmbSupplier;
        private ComboBox cmbCategory;
        private TextBox txtProductName;
        private TextBox txtQuantityPerUnit;
        private TextBox txtUnitPrice;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitsOnOrder;
        private TextBox txtRecoderLevel;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}