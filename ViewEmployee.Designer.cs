namespace BusniessManagementSystem
{
    partial class ViewEmployee
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
            lblEmployee = new Label();
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            cmbReports = new ComboBox();
            lblReportsTo = new Label();
            cmbCourtesy = new ComboBox();
            lblTitle = new Label();
            lblTitleOfCourtesy = new Label();
            txtNotes = new TextBox();
            lblHireDate = new Label();
            lblNotes = new Label();
            lblExtension = new Label();
            txtTittle = new TextBox();
            lblRegion = new Label();
            lblPostalCode = new Label();
            txtPostalCode = new TextBox();
            txtExtension = new TextBox();
            dtHireDate = new DateTimePicker();
            txtRegion = new TextBox();
            picEmployee = new PictureBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            dtDOB = new DateTimePicker();
            txtLastName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblCity = new Label();
            txtPhoneNumber = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            lblCountry = new Label();
            lblPhoneNumber = new Label();
            lblDOB = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEmployee).BeginInit();
            SuspendLayout();
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.BackColor = Color.Transparent;
            lblEmployee.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEmployee.ForeColor = Color.RoyalBlue;
            lblEmployee.Location = new Point(0, 27);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(236, 38);
            lblEmployee.TabIndex = 36;
            lblEmployee.Text = "Employee Details";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(cmbReports);
            groupBox1.Controls.Add(lblReportsTo);
            groupBox1.Controls.Add(cmbCourtesy);
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Controls.Add(lblTitleOfCourtesy);
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Controls.Add(lblHireDate);
            groupBox1.Controls.Add(lblNotes);
            groupBox1.Controls.Add(lblExtension);
            groupBox1.Controls.Add(txtTittle);
            groupBox1.Controls.Add(lblRegion);
            groupBox1.Controls.Add(lblPostalCode);
            groupBox1.Controls.Add(txtPostalCode);
            groupBox1.Controls.Add(txtExtension);
            groupBox1.Controls.Add(dtHireDate);
            groupBox1.Controls.Add(txtRegion);
            groupBox1.Controls.Add(picEmployee);
            groupBox1.Controls.Add(lblFirstName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(dtDOB);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(lblCity);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(txtCountry);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(lblCountry);
            groupBox1.Controls.Add(lblPhoneNumber);
            groupBox1.Controls.Add(lblDOB);
            groupBox1.Controls.Add(lblEmployee);
            groupBox1.Location = new Point(1, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1280, 986);
            groupBox1.TabIndex = 74;
            groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.FlatAppearance.BorderColor = Color.Black;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(591, 888);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 45);
            btnCancel.TabIndex = 105;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // cmbReports
            // 
            cmbReports.BackColor = SystemColors.Control;
            cmbReports.FormattingEnabled = true;
            cmbReports.Items.AddRange(new object[] { "Nancy Davolio", "", "Andrew Fuller", "", "Janet Leverling", "", "Margaret Peacock", "", "Steven Buchanan", "", "Michael Suyama", "", "Robert King", "", "Laura Callahan", "", "Anne Dodsworth" });
            cmbReports.Location = new Point(711, 695);
            cmbReports.Name = "cmbReports";
            cmbReports.Size = new Size(359, 33);
            cmbReports.TabIndex = 104;
            // 
            // lblReportsTo
            // 
            lblReportsTo.AutoSize = true;
            lblReportsTo.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportsTo.Image = Properties.Resources.icons8_reports_32;
            lblReportsTo.ImageAlign = ContentAlignment.MiddleLeft;
            lblReportsTo.Location = new Point(712, 662);
            lblReportsTo.Name = "lblReportsTo";
            lblReportsTo.Size = new Size(161, 30);
            lblReportsTo.TabIndex = 103;
            lblReportsTo.Text = "       &Reports To";
            // 
            // cmbCourtesy
            // 
            cmbCourtesy.BackColor = SystemColors.Control;
            cmbCourtesy.FlatStyle = FlatStyle.Flat;
            cmbCourtesy.FormattingEnabled = true;
            cmbCourtesy.Items.AddRange(new object[] { "MS.", "Mrs.", "DR.", "MR." });
            cmbCourtesy.Location = new Point(712, 427);
            cmbCourtesy.Name = "cmbCourtesy";
            cmbCourtesy.Size = new Size(359, 33);
            cmbCourtesy.TabIndex = 102;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Image = Properties.Resources.icons8_title_32;
            lblTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitle.Location = new Point(712, 114);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(99, 30);
            lblTitle.TabIndex = 89;
            lblTitle.Text = "       &Title";
            // 
            // lblTitleOfCourtesy
            // 
            lblTitleOfCourtesy.AutoSize = true;
            lblTitleOfCourtesy.BackColor = Color.Transparent;
            lblTitleOfCourtesy.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleOfCourtesy.Image = Properties.Resources.icons8_id_card_32;
            lblTitleOfCourtesy.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitleOfCourtesy.Location = new Point(711, 394);
            lblTitleOfCourtesy.Name = "lblTitleOfCourtesy";
            lblTitleOfCourtesy.Size = new Size(225, 30);
            lblTitleOfCourtesy.TabIndex = 90;
            lblTitleOfCourtesy.Text = "       Titl&e Of Courtesy";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = SystemColors.Control;
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(710, 780);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(360, 74);
            txtNotes.TabIndex = 101;
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.BackColor = Color.Transparent;
            lblHireDate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHireDate.Image = Properties.Resources.icons8_schedule_32;
            lblHireDate.ImageAlign = ContentAlignment.MiddleLeft;
            lblHireDate.Location = new Point(710, 492);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(144, 30);
            lblHireDate.TabIndex = 91;
            lblHireDate.Text = "       &HireDate";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.BackColor = Color.Transparent;
            lblNotes.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotes.Image = Properties.Resources.icons8_notes_32;
            lblNotes.ImageAlign = ContentAlignment.MiddleLeft;
            lblNotes.Location = new Point(710, 744);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(114, 30);
            lblNotes.TabIndex = 100;
            lblNotes.Text = "       &Notes";
            // 
            // lblExtension
            // 
            lblExtension.AutoSize = true;
            lblExtension.BackColor = Color.Transparent;
            lblExtension.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExtension.Image = Properties.Resources.icons8_extension_32;
            lblExtension.ImageAlign = ContentAlignment.MiddleLeft;
            lblExtension.Location = new Point(712, 295);
            lblExtension.Name = "lblExtension";
            lblExtension.Size = new Size(151, 30);
            lblExtension.TabIndex = 93;
            lblExtension.Text = "       E&xtension";
            // 
            // txtTittle
            // 
            txtTittle.BackColor = SystemColors.Control;
            txtTittle.BorderStyle = BorderStyle.FixedSingle;
            txtTittle.Font = new Font("Nirmala UI", 10F);
            txtTittle.Location = new Point(712, 224);
            txtTittle.Name = "txtTittle";
            txtTittle.Size = new Size(359, 34);
            txtTittle.TabIndex = 99;
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.BackColor = Color.Transparent;
            lblRegion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegion.Image = Properties.Resources.icons8_region_32;
            lblRegion.ImageAlign = ContentAlignment.MiddleLeft;
            lblRegion.Location = new Point(710, 191);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(125, 30);
            lblRegion.TabIndex = 94;
            lblRegion.Text = "       Region";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.BackColor = Color.Transparent;
            lblPostalCode.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPostalCode.Image = Properties.Resources.icons8_bag_24;
            lblPostalCode.ImageAlign = ContentAlignment.MiddleLeft;
            lblPostalCode.Location = new Point(712, 578);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(166, 30);
            lblPostalCode.TabIndex = 97;
            lblPostalCode.Text = "       PostalCode";
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = SystemColors.Control;
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Font = new Font("Nirmala UI", 10F);
            txtPostalCode.Location = new Point(710, 611);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(359, 34);
            txtPostalCode.TabIndex = 98;
            // 
            // txtExtension
            // 
            txtExtension.BackColor = SystemColors.Control;
            txtExtension.BorderStyle = BorderStyle.FixedSingle;
            txtExtension.Font = new Font("Nirmala UI", 10F);
            txtExtension.Location = new Point(710, 328);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(359, 34);
            txtExtension.TabIndex = 92;
            // 
            // dtHireDate
            // 
            dtHireDate.Font = new Font("Nirmala UI", 10F);
            dtHireDate.Location = new Point(710, 525);
            dtHireDate.Name = "dtHireDate";
            dtHireDate.Size = new Size(359, 34);
            dtHireDate.TabIndex = 95;
            // 
            // txtRegion
            // 
            txtRegion.BackColor = SystemColors.Control;
            txtRegion.BorderStyle = BorderStyle.FixedSingle;
            txtRegion.Font = new Font("Nirmala UI", 10F);
            txtRegion.Location = new Point(710, 147);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(359, 34);
            txtRegion.TabIndex = 96;
            // 
            // picEmployee
            // 
            picEmployee.BackgroundImageLayout = ImageLayout.Zoom;
            picEmployee.BorderStyle = BorderStyle.FixedSingle;
            picEmployee.InitialImage = null;
            picEmployee.Location = new Point(320, 92);
            picEmployee.Name = "picEmployee";
            picEmployee.Size = new Size(156, 143);
            picEmployee.SizeMode = PictureBoxSizeMode.Zoom;
            picEmployee.TabIndex = 88;
            picEmployee.TabStop = false;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblFirstName.Image = Properties.Resources.icons8_name_32;
            lblFirstName.ImageAlign = ContentAlignment.MiddleLeft;
            lblFirstName.Location = new Point(205, 267);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(162, 30);
            lblFirstName.TabIndex = 74;
            lblFirstName.Text = "       &First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.Control;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Nirmala UI", 10F);
            txtFirstName.Location = new Point(205, 304);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(174, 34);
            txtFirstName.TabIndex = 76;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblLastName.Image = Properties.Resources.icons8_name_32;
            lblLastName.ImageAlign = ContentAlignment.MiddleLeft;
            lblLastName.Location = new Point(392, 267);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(159, 30);
            lblLastName.TabIndex = 75;
            lblLastName.Text = "       &Last Name";
            // 
            // dtDOB
            // 
            dtDOB.CalendarFont = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtDOB.CalendarMonthBackground = SystemColors.Control;
            dtDOB.CalendarTitleBackColor = SystemColors.Control;
            dtDOB.CalendarTitleForeColor = SystemColors.Control;
            dtDOB.CalendarTrailingForeColor = SystemColors.Control;
            dtDOB.Cursor = Cursors.Hand;
            dtDOB.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtDOB.Format = DateTimePickerFormat.Short;
            dtDOB.ImeMode = ImeMode.NoControl;
            dtDOB.Location = new Point(207, 566);
            dtDOB.Name = "dtDOB";
            dtDOB.RightToLeft = RightToLeft.No;
            dtDOB.Size = new Size(359, 31);
            dtDOB.TabIndex = 79;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.Control;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Nirmala UI", 10F);
            txtLastName.ForeColor = SystemColors.WindowText;
            txtLastName.Location = new Point(392, 304);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(174, 34);
            txtLastName.TabIndex = 77;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Image = Properties.Resources.icons8_home_32;
            lblAddress.ImageAlign = ContentAlignment.MiddleLeft;
            lblAddress.Location = new Point(207, 353);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(134, 30);
            lblAddress.TabIndex = 84;
            lblAddress.Text = "       &Address";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Control;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(207, 386);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(359, 121);
            txtAddress.TabIndex = 86;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.Transparent;
            lblCity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCity.Image = Properties.Resources.icons8_mountain_city_32;
            lblCity.ImageAlign = ContentAlignment.MiddleLeft;
            lblCity.Location = new Point(207, 615);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(94, 30);
            lblCity.TabIndex = 85;
            lblCity.Text = "       &City";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.Control;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(207, 823);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(359, 31);
            txtPhoneNumber.TabIndex = 82;
            // 
            // txtCountry
            // 
            txtCountry.BackColor = SystemColors.Control;
            txtCountry.BorderStyle = BorderStyle.FixedSingle;
            txtCountry.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCountry.Location = new Point(205, 735);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(359, 34);
            txtCountry.TabIndex = 83;
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.Control;
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.Location = new Point(207, 652);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(359, 34);
            txtCity.TabIndex = 87;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.BackColor = Color.Transparent;
            lblCountry.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountry.Image = Properties.Resources.icons8_world_32;
            lblCountry.ImageAlign = ContentAlignment.MiddleLeft;
            lblCountry.Location = new Point(205, 698);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(136, 30);
            lblCountry.TabIndex = 81;
            lblCountry.Text = "       &Country";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = Color.Transparent;
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNumber.Image = Properties.Resources.icons8_phone_32;
            lblPhoneNumber.ImageAlign = ContentAlignment.MiddleLeft;
            lblPhoneNumber.Location = new Point(207, 786);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(207, 30);
            lblPhoneNumber.TabIndex = 80;
            lblPhoneNumber.Text = "       &Phone Number";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.BackColor = Color.Transparent;
            lblDOB.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDOB.Image = Properties.Resources.icons8_birthday_date_32;
            lblDOB.ImageAlign = ContentAlignment.MiddleLeft;
            lblDOB.Location = new Point(207, 529);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(184, 30);
            lblDOB.TabIndex = 78;
            lblDOB.Text = "       &Date of &Birth";
            // 
            // ViewEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1279, 980);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ViewEmployee";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "View Employee";
            Load += ViewEmployee_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblEmployee;
        private GroupBox groupBox1;
        private Button btnCancel;
        private ComboBox cmbReports;
        private Label lblReportsTo;
        private ComboBox cmbCourtesy;
        private Label lblTitle;
        private Label lblTitleOfCourtesy;
        private TextBox txtNotes;
        private Label lblHireDate;
        private Label lblNotes;
        private Label lblExtension;
        private TextBox txtTittle;
        private Label lblRegion;
        private Label lblPostalCode;
        private TextBox txtPostalCode;
        private TextBox txtExtension;
        private DateTimePicker dtHireDate;
        private TextBox txtRegion;
        private PictureBox picEmployee;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private DateTimePicker dtDOB;
        private TextBox txtLastName;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblCity;
        private TextBox txtPhoneNumber;
        private TextBox txtCountry;
        private TextBox txtCity;
        private Label lblCountry;
        private Label lblPhoneNumber;
        private Label lblDOB;
    }
}