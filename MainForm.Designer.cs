namespace BusniessManagementSystem
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            addNewEmployeeToolStripMenuItem = new ToolStripMenuItem();
            searchEmployeeToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            addNewCustomerToolStripMenuItem = new ToolStripMenuItem();
            searchCustomerToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            addNewProductToolStripMenuItem = new ToolStripMenuItem();
            searchProductToolStripMenuItem = new ToolStripMenuItem();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            addNewCategoryToolStripMenuItem = new ToolStripMenuItem();
            searchCategoryToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            purchaseToolStripMenuItem = new ToolStripMenuItem();
            newOrderToolStripMenuItem = new ToolStripMenuItem();
            searchOrderToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { employeesToolStripMenuItem, customersToolStripMenuItem, productsToolStripMenuItem, categoriesToolStripMenuItem, exitToolStripMenuItem, purchaseToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1199, 35);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewEmployeeToolStripMenuItem, searchEmployeeToolStripMenuItem });
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(114, 29);
            employeesToolStripMenuItem.Text = "&Employees";
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            addNewEmployeeToolStripMenuItem.Size = new Size(271, 34);
            addNewEmployeeToolStripMenuItem.Text = "Add New Employee";
            addNewEmployeeToolStripMenuItem.Click += addNewEmployeeToolStripMenuItem_Click;
            // 
            // searchEmployeeToolStripMenuItem
            // 
            searchEmployeeToolStripMenuItem.Name = "searchEmployeeToolStripMenuItem";
            searchEmployeeToolStripMenuItem.Size = new Size(271, 34);
            searchEmployeeToolStripMenuItem.Text = "Search Employee";
            searchEmployeeToolStripMenuItem.Click += searchEmployeeToolStripMenuItem_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewCustomerToolStripMenuItem, searchCustomerToolStripMenuItem });
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(113, 29);
            customersToolStripMenuItem.Text = "&Customers";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            addNewCustomerToolStripMenuItem.Size = new Size(270, 34);
            addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            addNewCustomerToolStripMenuItem.Click += addNewCustomerToolStripMenuItem_Click;
            // 
            // searchCustomerToolStripMenuItem
            // 
            searchCustomerToolStripMenuItem.Name = "searchCustomerToolStripMenuItem";
            searchCustomerToolStripMenuItem.Size = new Size(270, 34);
            searchCustomerToolStripMenuItem.Text = "Search Customer";
            searchCustomerToolStripMenuItem.Click += searchCustomerToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewProductToolStripMenuItem, searchProductToolStripMenuItem });
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(98, 29);
            productsToolStripMenuItem.Text = "&Products";
            // 
            // addNewProductToolStripMenuItem
            // 
            addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            addNewProductToolStripMenuItem.Size = new Size(255, 34);
            addNewProductToolStripMenuItem.Text = "Add New Product";
            addNewProductToolStripMenuItem.Click += addNewProductToolStripMenuItem_Click;
            // 
            // searchProductToolStripMenuItem
            // 
            searchProductToolStripMenuItem.Name = "searchProductToolStripMenuItem";
            searchProductToolStripMenuItem.Size = new Size(255, 34);
            searchProductToolStripMenuItem.Text = "Search Product";
            searchProductToolStripMenuItem.Click += searchProductToolStripMenuItem_Click;
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewCategoryToolStripMenuItem, searchCategoryToolStripMenuItem });
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(112, 29);
            categoriesToolStripMenuItem.Text = "C&ategories";
            // 
            // addNewCategoryToolStripMenuItem
            // 
            addNewCategoryToolStripMenuItem.Name = "addNewCategoryToolStripMenuItem";
            addNewCategoryToolStripMenuItem.Size = new Size(265, 34);
            addNewCategoryToolStripMenuItem.Text = "Add New Category";
            // 
            // searchCategoryToolStripMenuItem
            // 
            searchCategoryToolStripMenuItem.Name = "searchCategoryToolStripMenuItem";
            searchCategoryToolStripMenuItem.Size = new Size(265, 34);
            searchCategoryToolStripMenuItem.Text = "Search Category";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(55, 29);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // purchaseToolStripMenuItem
            // 
            purchaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newOrderToolStripMenuItem, searchOrderToolStripMenuItem });
            purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            purchaseToolStripMenuItem.Size = new Size(98, 29);
            purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // newOrderToolStripMenuItem
            // 
            newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            newOrderToolStripMenuItem.Size = new Size(270, 34);
            newOrderToolStripMenuItem.Text = "New Order";
            newOrderToolStripMenuItem.Click += newOrderToolStripMenuItem_Click;
            // 
            // searchOrderToolStripMenuItem
            // 
            searchOrderToolStripMenuItem.Name = "searchOrderToolStripMenuItem";
            searchOrderToolStripMenuItem.Size = new Size(270, 34);
            searchOrderToolStripMenuItem.Text = "Search Order";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1199, 915);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 7, 6, 7);
            Name = "MainForm";
            Text = "Busniess Management System";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private ToolStripMenuItem searchEmployeeToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private ToolStripMenuItem searchCustomerToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem addNewProductToolStripMenuItem;
        private ToolStripMenuItem searchProductToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem addNewCategoryToolStripMenuItem;
        private ToolStripMenuItem searchCategoryToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem newOrderToolStripMenuItem;
        private ToolStripMenuItem searchOrderToolStripMenuItem;
    }
}



