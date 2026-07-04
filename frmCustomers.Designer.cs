namespace BusniessManagementSystem
{
    partial class frmCustomers
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
            gbCustomer = new GroupBox();
            btnSaveCustomer = new Button();
            btnClose = new Button();
            cmbCountry = new ComboBox();
            txtFax = new TextBox();
            txtPhone = new TextBox();
            txtPostalCode = new TextBox();
            txtRegion = new TextBox();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            txtContactTitle = new TextBox();
            txtContactName = new TextBox();
            txtCompanyName = new TextBox();
            txtCustomerID = new TextBox();
            lblCustomerDetails = new Label();
            lblFax = new Label();
            lblPhone = new Label();
            lblCountry = new Label();
            lblPostalCode = new Label();
            lblRegion = new Label();
            lblCity = new Label();
            lblAddress = new Label();
            lblContactTitle = new Label();
            lblContactName = new Label();
            lblCompanyName = new Label();
            lblCustomerID = new Label();
            gbCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // gbCustomer
            // 
            gbCustomer.Anchor = AnchorStyles.None;
            gbCustomer.Controls.Add(btnSaveCustomer);
            gbCustomer.Controls.Add(btnClose);
            gbCustomer.Controls.Add(cmbCountry);
            gbCustomer.Controls.Add(txtFax);
            gbCustomer.Controls.Add(txtPhone);
            gbCustomer.Controls.Add(txtPostalCode);
            gbCustomer.Controls.Add(txtRegion);
            gbCustomer.Controls.Add(txtCity);
            gbCustomer.Controls.Add(txtAddress);
            gbCustomer.Controls.Add(txtContactTitle);
            gbCustomer.Controls.Add(txtContactName);
            gbCustomer.Controls.Add(txtCompanyName);
            gbCustomer.Controls.Add(txtCustomerID);
            gbCustomer.Controls.Add(lblCustomerDetails);
            gbCustomer.Controls.Add(lblFax);
            gbCustomer.Controls.Add(lblPhone);
            gbCustomer.Controls.Add(lblCountry);
            gbCustomer.Controls.Add(lblPostalCode);
            gbCustomer.Controls.Add(lblRegion);
            gbCustomer.Controls.Add(lblCity);
            gbCustomer.Controls.Add(lblAddress);
            gbCustomer.Controls.Add(lblContactTitle);
            gbCustomer.Controls.Add(lblContactName);
            gbCustomer.Controls.Add(lblCompanyName);
            gbCustomer.Controls.Add(lblCustomerID);
            gbCustomer.Location = new Point(0, 0);
            gbCustomer.Name = "gbCustomer";
            gbCustomer.Size = new Size(1295, 838);
            gbCustomer.TabIndex = 0;
            gbCustomer.TabStop = false;
            // 
            // btnSaveCustomer
            // 
            btnSaveCustomer.BackColor = Color.RoyalBlue;
            btnSaveCustomer.Cursor = Cursors.Hand;
            btnSaveCustomer.FlatStyle = FlatStyle.Flat;
            btnSaveCustomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveCustomer.ForeColor = Color.White;
            btnSaveCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveCustomer.Location = new Point(623, 733);
            btnSaveCustomer.Name = "btnSaveCustomer";
            btnSaveCustomer.Size = new Size(202, 46);
            btnSaveCustomer.TabIndex = 49;
            btnSaveCustomer.Text = "Save Customer";
            btnSaveCustomer.UseVisualStyleBackColor = false;
            btnSaveCustomer.Click += btnSaveCustomer_Click_1;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.Gainsboro;
            btnClose.FlatAppearance.BorderSize = 2;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.RoyalBlue;
            btnClose.Image = Properties.Resources.icons8_close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(481, 733);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 46);
            btnClose.TabIndex = 48;
            btnClose.Text = "  Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // cmbCountry
            // 
            cmbCountry.BackColor = SystemColors.Control;
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountry.FlatStyle = FlatStyle.Popup;
            cmbCountry.Font = new Font("Segoe UI", 11F);
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Items.AddRange(new object[] { "Afghanistan", "Argentina", "Australia", "Austria", "Bangladesh", "Belgium", "Brazil", "Canada", "China", "Egypt", "France", "Germany", "India", "Indonesia", "Iran", "Iraq", "Italy", "Japan", "Malaysia", "Mexico", "Nepal", "New Zealand", "Nigeria", "Pakistan", "Qatar", "Russia", "Saudi Arabia", "Singapore", "South Africa", "South Korea", "Spain", "Sri Lanka", "Thailand", "Turkey", "United Arab Emirates", "United Kingdom", "United States" });
            cmbCountry.Location = new Point(620, 454);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(431, 38);
            cmbCountry.TabIndex = 47;
            // 
            // txtFax
            // 
            txtFax.BackColor = SystemColors.Control;
            txtFax.BorderStyle = BorderStyle.FixedSingle;
            txtFax.Font = new Font("Segoe UI", 11F);
            txtFax.Location = new Point(620, 632);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(431, 37);
            txtFax.TabIndex = 46;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.Control;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.Location = new Point(620, 544);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(431, 37);
            txtPhone.TabIndex = 45;
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = SystemColors.Control;
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Font = new Font("Segoe UI", 11F);
            txtPostalCode.Location = new Point(617, 359);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(431, 37);
            txtPostalCode.TabIndex = 44;
            // 
            // txtRegion
            // 
            txtRegion.BackColor = SystemColors.Control;
            txtRegion.BorderStyle = BorderStyle.FixedSingle;
            txtRegion.Font = new Font("Segoe UI", 11F);
            txtRegion.Location = new Point(617, 258);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(431, 37);
            txtRegion.TabIndex = 43;
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.Control;
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Segoe UI", 11F);
            txtCity.Location = new Point(614, 158);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(431, 37);
            txtCity.TabIndex = 42;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Control;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(91, 548);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(431, 121);
            txtAddress.TabIndex = 41;
            // 
            // txtContactTitle
            // 
            txtContactTitle.BackColor = SystemColors.Control;
            txtContactTitle.BorderStyle = BorderStyle.FixedSingle;
            txtContactTitle.Font = new Font("Segoe UI", 11F);
            txtContactTitle.Location = new Point(91, 455);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(431, 37);
            txtContactTitle.TabIndex = 40;
            // 
            // txtContactName
            // 
            txtContactName.BackColor = SystemColors.Control;
            txtContactName.BorderStyle = BorderStyle.FixedSingle;
            txtContactName.Font = new Font("Segoe UI", 11F);
            txtContactName.Location = new Point(91, 359);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(431, 37);
            txtContactName.TabIndex = 39;
            // 
            // txtCompanyName
            // 
            txtCompanyName.BackColor = SystemColors.Control;
            txtCompanyName.BorderStyle = BorderStyle.FixedSingle;
            txtCompanyName.Font = new Font("Segoe UI", 11F);
            txtCompanyName.Location = new Point(91, 258);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(431, 37);
            txtCompanyName.TabIndex = 38;
            // 
            // txtCustomerID
            // 
            txtCustomerID.BackColor = SystemColors.Control;
            txtCustomerID.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerID.Font = new Font("Segoe UI", 11F);
            txtCustomerID.Location = new Point(91, 158);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(431, 37);
            txtCustomerID.TabIndex = 37;
            // 
            // lblCustomerDetails
            // 
            lblCustomerDetails.AutoSize = true;
            lblCustomerDetails.BackColor = Color.Transparent;
            lblCustomerDetails.FlatStyle = FlatStyle.Flat;
            lblCustomerDetails.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 186);
            lblCustomerDetails.ForeColor = Color.RoyalBlue;
            lblCustomerDetails.Location = new Point(4, 40);
            lblCustomerDetails.Name = "lblCustomerDetails";
            lblCustomerDetails.Size = new Size(248, 38);
            lblCustomerDetails.TabIndex = 25;
            lblCustomerDetails.Text = "Customer Details :";
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.BackColor = Color.Transparent;
            lblFax.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFax.Image = Properties.Resources.icons8_print_file_32;
            lblFax.ImageAlign = ContentAlignment.MiddleLeft;
            lblFax.Location = new Point(620, 597);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(87, 30);
            lblFax.TabIndex = 36;
            lblFax.Text = "       Fax";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPhone.Image = Properties.Resources.icons8_phone_32;
            lblPhone.ImageAlign = ContentAlignment.MiddleLeft;
            lblPhone.Location = new Point(620, 509);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(119, 30);
            lblPhone.TabIndex = 35;
            lblPhone.Text = "       Phone";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.BackColor = Color.Transparent;
            lblCountry.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCountry.Image = Properties.Resources.icons8_world_32;
            lblCountry.ImageAlign = ContentAlignment.MiddleLeft;
            lblCountry.Location = new Point(620, 416);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(136, 30);
            lblCountry.TabIndex = 34;
            lblCountry.Text = "       Country";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.BackColor = Color.Transparent;
            lblPostalCode.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPostalCode.Image = Properties.Resources.icons8_open_message_32;
            lblPostalCode.ImageAlign = ContentAlignment.MiddleLeft;
            lblPostalCode.Location = new Point(617, 319);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(172, 30);
            lblPostalCode.TabIndex = 33;
            lblPostalCode.Text = "       Postal Code";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.BackColor = Color.Transparent;
            lblRegion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblRegion.Image = Properties.Resources.icons8_region_32;
            lblRegion.ImageAlign = ContentAlignment.MiddleLeft;
            lblRegion.Location = new Point(617, 222);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(125, 30);
            lblRegion.TabIndex = 32;
            lblRegion.Text = "       Region";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.Transparent;
            lblCity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCity.Image = Properties.Resources.icons8_mountain_city_32;
            lblCity.ImageAlign = ContentAlignment.MiddleLeft;
            lblCity.Location = new Point(614, 123);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(106, 30);
            lblCity.TabIndex = 31;
            lblCity.Text = "         City";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblAddress.Image = Properties.Resources.icons8_home_32;
            lblAddress.ImageAlign = ContentAlignment.MiddleLeft;
            lblAddress.Location = new Point(91, 511);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(134, 30);
            lblAddress.TabIndex = 30;
            lblAddress.Text = "       Address";
            // 
            // lblContactTitle
            // 
            lblContactTitle.AutoSize = true;
            lblContactTitle.BackColor = Color.Transparent;
            lblContactTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblContactTitle.Image = Properties.Resources.icons8_bag_24;
            lblContactTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblContactTitle.Location = new Point(91, 417);
            lblContactTitle.Name = "lblContactTitle";
            lblContactTitle.Size = new Size(182, 30);
            lblContactTitle.TabIndex = 29;
            lblContactTitle.Text = "       Contact Title";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.BackColor = Color.Transparent;
            lblContactName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblContactName.Image = Properties.Resources.icons8_contact_details_32;
            lblContactName.ImageAlign = ContentAlignment.MiddleLeft;
            lblContactName.Location = new Point(91, 320);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(197, 30);
            lblContactName.TabIndex = 28;
            lblContactName.Text = "       Contact Name";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.BackColor = Color.Transparent;
            lblCompanyName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCompanyName.Image = Properties.Resources.icons8_company_30;
            lblCompanyName.ImageAlign = ContentAlignment.MiddleLeft;
            lblCompanyName.Location = new Point(91, 223);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(214, 30);
            lblCompanyName.TabIndex = 27;
            lblCompanyName.Text = "       Company Name";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.BackColor = Color.Transparent;
            lblCustomerID.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCustomerID.Image = Properties.Resources.icons8_id_verified_32;
            lblCustomerID.ImageAlign = ContentAlignment.MiddleLeft;
            lblCustomerID.Location = new Point(91, 123);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(179, 30);
            lblCustomerID.TabIndex = 26;
            lblCustomerID.Text = "       Customer ID";
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1297, 838);
            Controls.Add(gbCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomers";
            Opacity = 0.5D;
            ShowIcon = false;
            Text = "Customercs Dtails";
            WindowState = FormWindowState.Maximized;
            Load += frmCustomers_Load;
            gbCustomer.ResumeLayout(false);
            gbCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCustomer;
        private Button btnSaveCustomer;
        private Button btnClose;
        private ComboBox cmbCountry;
        private TextBox txtFax;
        private TextBox txtPhone;
        private TextBox txtPostalCode;
        private TextBox txtRegion;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtContactTitle;
        private TextBox txtContactName;
        private TextBox txtCompanyName;
        private TextBox txtCustomerID;
        private Label lblCustomerDetails;
        private Label lblFax;
        private Label lblPhone;
        private Label lblCountry;
        private Label lblPostalCode;
        private Label lblRegion;
        private Label lblCity;
        private Label lblAddress;
        private Label lblContactTitle;
        private Label lblContactName;
        private Label lblCompanyName;
        private Label lblCustomerID;
    }
}