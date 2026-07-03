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
            lblCustomerID = new Label();
            lblCompanyName = new Label();
            lblContactName = new Label();
            lblContactTitle = new Label();
            lblAddress = new Label();
            lblCity = new Label();
            lblRegion = new Label();
            lblPostalCode = new Label();
            lblCountry = new Label();
            lblPhone = new Label();
            lblFax = new Label();
            lblCustomerDetails = new Label();
            txtCustomerID = new TextBox();
            txtCompanyName = new TextBox();
            txtContactName = new TextBox();
            txtContactTitle = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtRegion = new TextBox();
            txtPostalCode = new TextBox();
            txtPhone = new TextBox();
            txtFax = new TextBox();
            cmbCountry = new ComboBox();
            btnClose = new Button();
            btnSaveCustomer = new Button();
            SuspendLayout();
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.BackColor = Color.Transparent;
            lblCustomerID.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCustomerID.Image = Properties.Resources.icons8_id_verified_32;
            lblCustomerID.ImageAlign = ContentAlignment.MiddleLeft;
            lblCustomerID.Location = new Point(86, 92);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(179, 30);
            lblCustomerID.TabIndex = 1;
            lblCustomerID.Text = "       Customer ID";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.BackColor = Color.Transparent;
            lblCompanyName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCompanyName.Image = Properties.Resources.icons8_company_30;
            lblCompanyName.ImageAlign = ContentAlignment.MiddleLeft;
            lblCompanyName.Location = new Point(86, 192);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(214, 30);
            lblCompanyName.TabIndex = 2;
            lblCompanyName.Text = "       Company Name";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.BackColor = Color.Transparent;
            lblContactName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblContactName.Image = Properties.Resources.icons8_contact_details_32;
            lblContactName.ImageAlign = ContentAlignment.MiddleLeft;
            lblContactName.Location = new Point(86, 289);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(197, 30);
            lblContactName.TabIndex = 3;
            lblContactName.Text = "       Contact Name";
            // 
            // lblContactTitle
            // 
            lblContactTitle.AutoSize = true;
            lblContactTitle.BackColor = Color.Transparent;
            lblContactTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblContactTitle.Image = Properties.Resources.icons8_bag_24;
            lblContactTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblContactTitle.Location = new Point(86, 386);
            lblContactTitle.Name = "lblContactTitle";
            lblContactTitle.Size = new Size(182, 30);
            lblContactTitle.TabIndex = 4;
            lblContactTitle.Text = "       Contact Title";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblAddress.Image = Properties.Resources.icons8_home_32;
            lblAddress.ImageAlign = ContentAlignment.MiddleLeft;
            lblAddress.Location = new Point(86, 480);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(134, 30);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "       Address";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.Transparent;
            lblCity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCity.Image = Properties.Resources.icons8_mountain_city_32;
            lblCity.ImageAlign = ContentAlignment.MiddleLeft;
            lblCity.Location = new Point(609, 92);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(106, 30);
            lblCity.TabIndex = 6;
            lblCity.Text = "         City";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.BackColor = Color.Transparent;
            lblRegion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblRegion.Image = Properties.Resources.icons8_region_32;
            lblRegion.ImageAlign = ContentAlignment.MiddleLeft;
            lblRegion.Location = new Point(612, 191);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(125, 30);
            lblRegion.TabIndex = 7;
            lblRegion.Text = "       Region";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.BackColor = Color.Transparent;
            lblPostalCode.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPostalCode.Image = Properties.Resources.icons8_open_message_32;
            lblPostalCode.ImageAlign = ContentAlignment.MiddleLeft;
            lblPostalCode.Location = new Point(612, 288);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(172, 30);
            lblPostalCode.TabIndex = 8;
            lblPostalCode.Text = "       Postal Code";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.BackColor = Color.Transparent;
            lblCountry.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCountry.Image = Properties.Resources.icons8_world_32;
            lblCountry.ImageAlign = ContentAlignment.MiddleLeft;
            lblCountry.Location = new Point(615, 385);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(136, 30);
            lblCountry.TabIndex = 9;
            lblCountry.Text = "       Country";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPhone.Image = Properties.Resources.icons8_phone_32;
            lblPhone.ImageAlign = ContentAlignment.MiddleLeft;
            lblPhone.Location = new Point(615, 478);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(119, 30);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "       Phone";
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.BackColor = Color.Transparent;
            lblFax.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFax.Image = Properties.Resources.icons8_print_file_32;
            lblFax.ImageAlign = ContentAlignment.MiddleLeft;
            lblFax.Location = new Point(615, 566);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(87, 30);
            lblFax.TabIndex = 11;
            lblFax.Text = "       Fax";
            // 
            // lblCustomerDetails
            // 
            lblCustomerDetails.AutoSize = true;
            lblCustomerDetails.BackColor = Color.Transparent;
            lblCustomerDetails.FlatStyle = FlatStyle.Flat;
            lblCustomerDetails.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 186);
            lblCustomerDetails.ForeColor = Color.RoyalBlue;
            lblCustomerDetails.Location = new Point(-1, 9);
            lblCustomerDetails.Name = "lblCustomerDetails";
            lblCustomerDetails.Size = new Size(233, 38);
            lblCustomerDetails.TabIndex = 0;
            lblCustomerDetails.Text = "Customer Details";
            // 
            // txtCustomerID
            // 
            txtCustomerID.BackColor = SystemColors.Control;
            txtCustomerID.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerID.Font = new Font("Segoe UI", 11F);
            txtCustomerID.Location = new Point(86, 127);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(431, 37);
            txtCustomerID.TabIndex = 12;
            // 
            // txtCompanyName
            // 
            txtCompanyName.BackColor = SystemColors.Control;
            txtCompanyName.BorderStyle = BorderStyle.FixedSingle;
            txtCompanyName.Font = new Font("Segoe UI", 11F);
            txtCompanyName.Location = new Point(86, 227);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(431, 37);
            txtCompanyName.TabIndex = 13;
            // 
            // txtContactName
            // 
            txtContactName.BackColor = SystemColors.Control;
            txtContactName.BorderStyle = BorderStyle.FixedSingle;
            txtContactName.Font = new Font("Segoe UI", 11F);
            txtContactName.Location = new Point(86, 328);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(431, 37);
            txtContactName.TabIndex = 14;
            // 
            // txtContactTitle
            // 
            txtContactTitle.BackColor = SystemColors.Control;
            txtContactTitle.BorderStyle = BorderStyle.FixedSingle;
            txtContactTitle.Font = new Font("Segoe UI", 11F);
            txtContactTitle.Location = new Point(86, 424);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(431, 37);
            txtContactTitle.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Control;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(86, 517);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(431, 121);
            txtAddress.TabIndex = 16;
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.Control;
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Segoe UI", 11F);
            txtCity.Location = new Point(609, 127);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(431, 37);
            txtCity.TabIndex = 17;
            // 
            // txtRegion
            // 
            txtRegion.BackColor = SystemColors.Control;
            txtRegion.BorderStyle = BorderStyle.FixedSingle;
            txtRegion.Font = new Font("Segoe UI", 11F);
            txtRegion.Location = new Point(612, 227);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(431, 37);
            txtRegion.TabIndex = 18;
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = SystemColors.Control;
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Font = new Font("Segoe UI", 11F);
            txtPostalCode.Location = new Point(612, 328);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(431, 37);
            txtPostalCode.TabIndex = 19;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.Control;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.Location = new Point(615, 513);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(431, 37);
            txtPhone.TabIndex = 20;
            // 
            // txtFax
            // 
            txtFax.BackColor = SystemColors.Control;
            txtFax.BorderStyle = BorderStyle.FixedSingle;
            txtFax.Font = new Font("Segoe UI", 11F);
            txtFax.Location = new Point(615, 601);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(431, 37);
            txtFax.TabIndex = 21;
            // 
            // cmbCountry
            // 
            cmbCountry.BackColor = SystemColors.Control;
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountry.FlatStyle = FlatStyle.Popup;
            cmbCountry.Font = new Font("Segoe UI", 11F);
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Items.AddRange(new object[] { "Afghanistan", "Argentina", "Australia", "Austria", "Bangladesh", "Belgium", "Brazil", "Canada", "China", "Egypt", "France", "Germany", "India", "Indonesia", "Iran", "Iraq", "Italy", "Japan", "Malaysia", "Mexico", "Nepal", "New Zealand", "Nigeria", "Pakistan", "Qatar", "Russia", "Saudi Arabia", "Singapore", "South Africa", "South Korea", "Spain", "Sri Lanka", "Thailand", "Turkey", "United Arab Emirates", "United Kingdom", "United States" });
            cmbCountry.Location = new Point(615, 423);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(431, 38);
            cmbCountry.TabIndex = 22;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderColor = Color.Gainsboro;
            btnClose.FlatAppearance.BorderSize = 2;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.RoyalBlue;
            btnClose.Image = Properties.Resources.icons8_close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(574, 702);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 46);
            btnClose.TabIndex = 23;
            btnClose.Text = "  Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSaveCustomer
            // 
            btnSaveCustomer.BackColor = Color.RoyalBlue;
            btnSaveCustomer.FlatStyle = FlatStyle.Flat;
            btnSaveCustomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveCustomer.ForeColor = Color.White;
            btnSaveCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveCustomer.Location = new Point(716, 702);
            btnSaveCustomer.Name = "btnSaveCustomer";
            btnSaveCustomer.Size = new Size(202, 46);
            btnSaveCustomer.TabIndex = 24;
            btnSaveCustomer.Text = "Save Customer";
            btnSaveCustomer.UseVisualStyleBackColor = false;
            btnSaveCustomer.Click += btnSaveCustomer_Click;
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.ChatGPT_Image_Jun_26__2026__02_20_00_AM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1078, 760);
            Controls.Add(btnSaveCustomer);
            Controls.Add(btnClose);
            Controls.Add(cmbCountry);
            Controls.Add(txtFax);
            Controls.Add(txtPhone);
            Controls.Add(txtPostalCode);
            Controls.Add(txtRegion);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtContactTitle);
            Controls.Add(txtContactName);
            Controls.Add(txtCompanyName);
            Controls.Add(txtCustomerID);
            Controls.Add(lblCustomerDetails);
            Controls.Add(lblFax);
            Controls.Add(lblPhone);
            Controls.Add(lblCountry);
            Controls.Add(lblPostalCode);
            Controls.Add(lblRegion);
            Controls.Add(lblCity);
            Controls.Add(lblAddress);
            Controls.Add(lblContactTitle);
            Controls.Add(lblContactName);
            Controls.Add(lblCompanyName);
            Controls.Add(lblCustomerID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomers";
            Opacity = 0.5D;
            ShowIcon = false;
            Text = "Customercs Dtails";
            WindowState = FormWindowState.Maximized;
            Load += frmCustomers_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Label lblCustomerID;
        private Label lblCompanyName;
        private Label lblContactName;
        private Label lblContactTitle;
        private Label lblAddress;
        private Label lblCity;
        private Label lblRegion;
        private Label lblPostalCode;
        private Label lblCountry;
        private Label lblPhone;
        private Label lblFax;
        private Label lblCustomerDetails;
        private TextBox txtCustomerID;
        private TextBox txtCompanyName;
        private TextBox txtContactName;
        private TextBox txtContactTitle;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtRegion;
        private TextBox txtPostalCode;
        private TextBox txtPhone;
        private TextBox txtFax;
        private ComboBox cmbCountry;
        private Button btnClose;
        private Button btnSaveCustomer;
    }
}