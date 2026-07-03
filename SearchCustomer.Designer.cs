namespace BusniessManagementSystem
{
    partial class SearchCustomer
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
            SearchCustomerGrid = new DataGridView();
            EditColumn = new DataGridViewButtonColumn();
            DeleteColumn = new DataGridViewButtonColumn();
            ViewColumn = new DataGridViewButtonColumn();
            panel3 = new Panel();
            lblCustomerID = new Label();
            lblCompanyName = new Label();
            lblContactName = new Label();
            txtCustomerID = new TextBox();
            txtCompanyName = new TextBox();
            txtContactName = new TextBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtPostalCode = new TextBox();
            lblPostalCode = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)SearchCustomerGrid).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // SearchCustomerGrid
            // 
            SearchCustomerGrid.AllowUserToAddRows = false;
            SearchCustomerGrid.AllowUserToDeleteRows = false;
            SearchCustomerGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SearchCustomerGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SearchCustomerGrid.BackgroundColor = Color.White;
            SearchCustomerGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SearchCustomerGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchCustomerGrid.Columns.AddRange(new DataGridViewColumn[] { EditColumn, DeleteColumn, ViewColumn });
            SearchCustomerGrid.Dock = DockStyle.Fill;
            SearchCustomerGrid.Location = new Point(0, 0);
            SearchCustomerGrid.Name = "SearchCustomerGrid";
            SearchCustomerGrid.ReadOnly = true;
            SearchCustomerGrid.RowHeadersVisible = false;
            SearchCustomerGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            SearchCustomerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SearchCustomerGrid.Size = new Size(1311, 300);
            SearchCustomerGrid.TabIndex = 1;
            SearchCustomerGrid.CellClick += SearchCustomerGrid_CellClick;
            // 
            // EditColumn
            // 
            EditColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EditColumn.HeaderText = "Edit";
            EditColumn.MinimumWidth = 8;
            EditColumn.Name = "EditColumn";
            EditColumn.ReadOnly = true;
            EditColumn.Text = "Edit";
            EditColumn.ToolTipText = "Edit Customer Reords";
            EditColumn.UseColumnTextForButtonValue = true;
            // 
            // DeleteColumn
            // 
            DeleteColumn.HeaderText = "Delete";
            DeleteColumn.MinimumWidth = 8;
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.ReadOnly = true;
            DeleteColumn.Text = "Delete";
            DeleteColumn.ToolTipText = "Delete Customer Records";
            DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // ViewColumn
            // 
            ViewColumn.HeaderText = "View";
            ViewColumn.MinimumWidth = 8;
            ViewColumn.Name = "ViewColumn";
            ViewColumn.ReadOnly = true;
            ViewColumn.Text = "View";
            ViewColumn.ToolTipText = "View Customer";
            ViewColumn.UseColumnTextForButtonValue = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(SearchCustomerGrid);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 587);
            panel3.Name = "panel3";
            panel3.Size = new Size(1311, 300);
            panel3.TabIndex = 2;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.BackColor = Color.Transparent;
            lblCustomerID.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCustomerID.Image = Properties.Resources.icons8_id_verified_32;
            lblCustomerID.ImageAlign = ContentAlignment.MiddleLeft;
            lblCustomerID.Location = new Point(194, 171);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(179, 30);
            lblCustomerID.TabIndex = 15;
            lblCustomerID.Text = "       Customer ID";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.BackColor = Color.Transparent;
            lblCompanyName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCompanyName.Image = Properties.Resources.icons8_company_30;
            lblCompanyName.ImageAlign = ContentAlignment.MiddleLeft;
            lblCompanyName.Location = new Point(194, 287);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(214, 30);
            lblCompanyName.TabIndex = 16;
            lblCompanyName.Text = "       Company Name";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.BackColor = Color.Transparent;
            lblContactName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblContactName.Image = Properties.Resources.icons8_contact_details_32;
            lblContactName.ImageAlign = ContentAlignment.MiddleLeft;
            lblContactName.Location = new Point(194, 384);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(197, 30);
            lblContactName.TabIndex = 17;
            lblContactName.Text = "       Contact Name";
            // 
            // txtCustomerID
            // 
            txtCustomerID.BackColor = SystemColors.Control;
            txtCustomerID.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerID.Font = new Font("Segoe UI", 11F);
            txtCustomerID.Location = new Point(194, 206);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(431, 37);
            txtCustomerID.TabIndex = 18;
            txtCustomerID.TextChanged += txtCustomerID_TextChanged;
            // 
            // txtCompanyName
            // 
            txtCompanyName.BackColor = SystemColors.Control;
            txtCompanyName.BorderStyle = BorderStyle.FixedSingle;
            txtCompanyName.Font = new Font("Segoe UI", 11F);
            txtCompanyName.Location = new Point(194, 322);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(431, 37);
            txtCompanyName.TabIndex = 19;
            txtCompanyName.TextChanged += txtCompanyName_TextChanged;
            // 
            // txtContactName
            // 
            txtContactName.BackColor = SystemColors.Control;
            txtContactName.BorderStyle = BorderStyle.FixedSingle;
            txtContactName.Font = new Font("Segoe UI", 11F);
            txtContactName.Location = new Point(194, 423);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(431, 37);
            txtContactName.TabIndex = 20;
            txtContactName.TextChanged += txtContactName_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1311, 584);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPostalCode);
            groupBox1.Controls.Add(lblPostalCode);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(lblCity);
            groupBox1.Controls.Add(txtContactName);
            groupBox1.Controls.Add(txtCompanyName);
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(lblContactName);
            groupBox1.Controls.Add(lblCompanyName);
            groupBox1.Controls.Add(lblCustomerID);
            groupBox1.Location = new Point(6, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1295, 560);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(6, 57);
            label1.Name = "label1";
            label1.Size = new Size(238, 38);
            label1.TabIndex = 25;
            label1.Text = "Search Customer";
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = SystemColors.Control;
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Font = new Font("Segoe UI", 11F);
            txtPostalCode.Location = new Point(757, 327);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(431, 37);
            txtPostalCode.TabIndex = 24;
            txtPostalCode.TextChanged += txtPostalCode_TextChanged;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.BackColor = Color.Transparent;
            lblPostalCode.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPostalCode.Image = Properties.Resources.icons8_open_message_32;
            lblPostalCode.ImageAlign = ContentAlignment.MiddleLeft;
            lblPostalCode.Location = new Point(757, 287);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(172, 30);
            lblPostalCode.TabIndex = 23;
            lblPostalCode.Text = "       Postal Code";
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.Control;
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Segoe UI", 11F);
            txtCity.Location = new Point(757, 206);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(431, 37);
            txtCity.TabIndex = 22;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.Transparent;
            lblCity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCity.Image = Properties.Resources.icons8_mountain_city_32;
            lblCity.ImageAlign = ContentAlignment.MiddleLeft;
            lblCity.Location = new Point(757, 171);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(106, 30);
            lblCity.TabIndex = 21;
            lblCity.Text = "         City";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1311, 587);
            panel4.TabIndex = 3;
            // 
            // SearchCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 887);
            Controls.Add(panel4);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchCustomer";
            ShowIcon = false;
            Text = "SearchCustomer";
            WindowState = FormWindowState.Maximized;
            Load += SearchCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)SearchCustomerGrid).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView SearchCustomerGrid;
        private Panel panel3;
        private Label lblCustomerID;
        private Label lblCompanyName;
        private Label lblContactName;
        private TextBox txtCustomerID;
        private TextBox txtCompanyName;
        private TextBox txtContactName;
        private Panel panel2;
        private Panel panel4;
        private TextBox txtCity;
        private Label lblCity;
        private TextBox txtPostalCode;
        private Label lblPostalCode;
        private Label label1;
        private DataGridViewButtonColumn EditColumn;
        private DataGridViewButtonColumn DeleteColumn;
        private DataGridViewButtonColumn ViewColumn;
        private GroupBox groupBox1;
    }
}