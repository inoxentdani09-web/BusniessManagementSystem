namespace BusniessManagementSystem
{
    partial class ViewCustomer
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
            label1 = new Label();
            button1 = new Button();
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cmbCountry);
            groupBox1.Controls.Add(txtFax);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtPostalCode);
            groupBox1.Controls.Add(txtRegion);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtContactTitle);
            groupBox1.Controls.Add(txtContactName);
            groupBox1.Controls.Add(txtCompanyName);
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(lblFax);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(lblCountry);
            groupBox1.Controls.Add(lblPostalCode);
            groupBox1.Controls.Add(lblRegion);
            groupBox1.Controls.Add(lblCity);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(lblContactTitle);
            groupBox1.Controls.Add(lblContactName);
            groupBox1.Controls.Add(lblCompanyName);
            groupBox1.Controls.Add(lblCustomerID);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1284, 932);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 38);
            label1.TabIndex = 45;
            label1.Text = "Customer Details";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(576, 839);
            button1.Name = "button1";
            button1.Size = new Size(150, 47);
            button1.TabIndex = 1;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbCountry
            // 
            cmbCountry.BackColor = SystemColors.Control;
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountry.FlatStyle = FlatStyle.Popup;
            cmbCountry.Font = new Font("Segoe UI", 11F);
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Items.AddRange(new object[] { "Afghanistan", "Argentina", "Australia", "Austria", "Bangladesh", "Belgium", "Brazil", "Canada", "China", "Egypt", "France", "Germany", "India", "Indonesia", "Iran", "Iraq", "Italy", "Japan", "Malaysia", "Mexico", "Nepal", "New Zealand", "Nigeria", "Pakistan", "Qatar", "Russia", "Saudi Arabia", "Singapore", "South Africa", "South Korea", "Spain", "Sri Lanka", "Thailand", "Turkey", "United Arab Emirates", "United Kingdom", "United States" });
            cmbCountry.Location = new Point(681, 542);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(431, 38);
            cmbCountry.TabIndex = 44;
            // 
            // txtFax
            // 
            txtFax.BackColor = SystemColors.Control;
            txtFax.BorderStyle = BorderStyle.FixedSingle;
            txtFax.Font = new Font("Segoe UI", 11F);
            txtFax.Location = new Point(681, 720);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(431, 37);
            txtFax.TabIndex = 43;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.Control;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.Location = new Point(681, 632);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(431, 37);
            txtPhone.TabIndex = 42;
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = SystemColors.Control;
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Font = new Font("Segoe UI", 11F);
            txtPostalCode.Location = new Point(678, 447);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(431, 37);
            txtPostalCode.TabIndex = 41;
            // 
            // txtRegion
            // 
            txtRegion.BackColor = SystemColors.Control;
            txtRegion.BorderStyle = BorderStyle.FixedSingle;
            txtRegion.Font = new Font("Segoe UI", 11F);
            txtRegion.Location = new Point(678, 346);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(431, 37);
            txtRegion.TabIndex = 40;
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.Control;
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Segoe UI", 11F);
            txtCity.Location = new Point(675, 246);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(431, 37);
            txtCity.TabIndex = 39;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Control;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.Location = new Point(152, 636);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(431, 121);
            txtAddress.TabIndex = 38;
            // 
            // txtContactTitle
            // 
            txtContactTitle.BackColor = SystemColors.Control;
            txtContactTitle.BorderStyle = BorderStyle.FixedSingle;
            txtContactTitle.Font = new Font("Segoe UI", 11F);
            txtContactTitle.Location = new Point(152, 543);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(431, 37);
            txtContactTitle.TabIndex = 37;
            // 
            // txtContactName
            // 
            txtContactName.BackColor = SystemColors.Control;
            txtContactName.BorderStyle = BorderStyle.FixedSingle;
            txtContactName.Font = new Font("Segoe UI", 11F);
            txtContactName.Location = new Point(152, 447);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(431, 37);
            txtContactName.TabIndex = 36;
            // 
            // txtCompanyName
            // 
            txtCompanyName.BackColor = SystemColors.Control;
            txtCompanyName.BorderStyle = BorderStyle.FixedSingle;
            txtCompanyName.Font = new Font("Segoe UI", 11F);
            txtCompanyName.Location = new Point(152, 346);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(431, 37);
            txtCompanyName.TabIndex = 35;
            // 
            // txtCustomerID
            // 
            txtCustomerID.BackColor = SystemColors.Control;
            txtCustomerID.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerID.Font = new Font("Segoe UI", 11F);
            txtCustomerID.Location = new Point(152, 246);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(431, 37);
            txtCustomerID.TabIndex = 34;
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.BackColor = Color.Transparent;
            lblFax.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFax.Image = Properties.Resources.icons8_print_file_32;
            lblFax.ImageAlign = ContentAlignment.MiddleLeft;
            lblFax.Location = new Point(681, 685);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(87, 30);
            lblFax.TabIndex = 33;
            lblFax.Text = "       Fax";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPhone.Image = Properties.Resources.icons8_phone_32;
            lblPhone.ImageAlign = ContentAlignment.MiddleLeft;
            lblPhone.Location = new Point(681, 597);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(119, 30);
            lblPhone.TabIndex = 32;
            lblPhone.Text = "       Phone";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.BackColor = Color.Transparent;
            lblCountry.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCountry.Image = Properties.Resources.icons8_world_32;
            lblCountry.ImageAlign = ContentAlignment.MiddleLeft;
            lblCountry.Location = new Point(681, 504);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(136, 30);
            lblCountry.TabIndex = 31;
            lblCountry.Text = "       Country";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.BackColor = Color.Transparent;
            lblPostalCode.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPostalCode.Image = Properties.Resources.icons8_open_message_32;
            lblPostalCode.ImageAlign = ContentAlignment.MiddleLeft;
            lblPostalCode.Location = new Point(678, 407);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(172, 30);
            lblPostalCode.TabIndex = 30;
            lblPostalCode.Text = "       Postal Code";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.BackColor = Color.Transparent;
            lblRegion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblRegion.Image = Properties.Resources.icons8_region_32;
            lblRegion.ImageAlign = ContentAlignment.MiddleLeft;
            lblRegion.Location = new Point(678, 310);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(125, 30);
            lblRegion.TabIndex = 29;
            lblRegion.Text = "       Region";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.Transparent;
            lblCity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCity.Image = Properties.Resources.icons8_mountain_city_32;
            lblCity.ImageAlign = ContentAlignment.MiddleLeft;
            lblCity.Location = new Point(675, 211);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(106, 30);
            lblCity.TabIndex = 28;
            lblCity.Text = "         City";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblAddress.Image = Properties.Resources.icons8_home_32;
            lblAddress.ImageAlign = ContentAlignment.MiddleLeft;
            lblAddress.Location = new Point(152, 599);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(134, 30);
            lblAddress.TabIndex = 27;
            lblAddress.Text = "       Address";
            // 
            // lblContactTitle
            // 
            lblContactTitle.AutoSize = true;
            lblContactTitle.BackColor = Color.Transparent;
            lblContactTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblContactTitle.Image = Properties.Resources.icons8_bag_24;
            lblContactTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblContactTitle.Location = new Point(152, 505);
            lblContactTitle.Name = "lblContactTitle";
            lblContactTitle.Size = new Size(182, 30);
            lblContactTitle.TabIndex = 26;
            lblContactTitle.Text = "       Contact Title";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.BackColor = Color.Transparent;
            lblContactName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblContactName.Image = Properties.Resources.icons8_contact_details_32;
            lblContactName.ImageAlign = ContentAlignment.MiddleLeft;
            lblContactName.Location = new Point(152, 408);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(197, 30);
            lblContactName.TabIndex = 25;
            lblContactName.Text = "       Contact Name";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.BackColor = Color.Transparent;
            lblCompanyName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCompanyName.Image = Properties.Resources.icons8_company_30;
            lblCompanyName.ImageAlign = ContentAlignment.MiddleLeft;
            lblCompanyName.Location = new Point(152, 311);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(214, 30);
            lblCompanyName.TabIndex = 24;
            lblCompanyName.Text = "       Company Name";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.BackColor = Color.Transparent;
            lblCustomerID.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblCustomerID.Image = Properties.Resources.icons8_id_verified_32;
            lblCustomerID.ImageAlign = ContentAlignment.MiddleLeft;
            lblCustomerID.Location = new Point(152, 211);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(179, 30);
            lblCustomerID.TabIndex = 23;
            lblCustomerID.Text = "       Customer ID";
            // 
            // ViewCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 928);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ViewCustomer";
            Text = "View Customer";
            Load += ViewCustomer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
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
        private Label label1;
    }
}