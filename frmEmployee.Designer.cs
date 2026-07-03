namespace BusniessManagementSystem
{
    partial class frmEmployee
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
            textBox1 = new TextBox();
            UploadPic = new OpenFileDialog();
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
            btnRemovepic = new Button();
            picEmployee = new PictureBox();
            btnUploadPic = new Button();
            lblEmployee = new Label();
            groupBox1 = new GroupBox();
            btnSave = new Button();
            btnCancel = new Button();
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
            ((System.ComponentModel.ISupportInitialize)picEmployee).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(-134, -235);
            textBox1.Margin = new Padding(10, 10, 3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 24);
            textBox1.TabIndex = 14;
            // 
            // UploadPic
            // 
            UploadPic.FileName = "OpenFileDialog";
            // 
            // cmbReports
            // 
            cmbReports.BackColor = SystemColors.Control;
            cmbReports.FormattingEnabled = true;
            cmbReports.Location = new Point(58, 828);
            cmbReports.Name = "cmbReports";
            cmbReports.Size = new Size(359, 33);
            cmbReports.TabIndex = 56;
            // 
            // lblReportsTo
            // 
            lblReportsTo.AutoSize = true;
            lblReportsTo.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportsTo.Image = Properties.Resources.icons8_reports_32;
            lblReportsTo.ImageAlign = ContentAlignment.MiddleLeft;
            lblReportsTo.Location = new Point(58, 784);
            lblReportsTo.Name = "lblReportsTo";
            lblReportsTo.Size = new Size(161, 30);
            lblReportsTo.TabIndex = 55;
            lblReportsTo.Text = "       &Reports To";
            // 
            // cmbCourtesy
            // 
            cmbCourtesy.BackColor = SystemColors.Control;
            cmbCourtesy.FlatStyle = FlatStyle.Flat;
            cmbCourtesy.FormattingEnabled = true;
            cmbCourtesy.Items.AddRange(new object[] { "MS.", "Mrs.", "DR.", "MR." });
            cmbCourtesy.Location = new Point(473, 713);
            cmbCourtesy.Name = "cmbCourtesy";
            cmbCourtesy.Size = new Size(359, 33);
            cmbCourtesy.TabIndex = 54;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Image = Properties.Resources.icons8_title_32;
            lblTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitle.Location = new Point(890, 669);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(99, 30);
            lblTitle.TabIndex = 41;
            lblTitle.Text = "       &Title";
            // 
            // lblTitleOfCourtesy
            // 
            lblTitleOfCourtesy.AutoSize = true;
            lblTitleOfCourtesy.BackColor = Color.Transparent;
            lblTitleOfCourtesy.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleOfCourtesy.Image = Properties.Resources.icons8_id_card_32;
            lblTitleOfCourtesy.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitleOfCourtesy.Location = new Point(473, 669);
            lblTitleOfCourtesy.Name = "lblTitleOfCourtesy";
            lblTitleOfCourtesy.Size = new Size(225, 30);
            lblTitleOfCourtesy.TabIndex = 42;
            lblTitleOfCourtesy.Text = "       Titl&e Of Courtesy";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = SystemColors.Control;
            txtNotes.BorderStyle = BorderStyle.FixedSingle;
            txtNotes.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.Location = new Point(890, 825);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(360, 36);
            txtNotes.TabIndex = 53;
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.BackColor = Color.Transparent;
            lblHireDate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHireDate.Image = Properties.Resources.icons8_schedule_32;
            lblHireDate.ImageAlign = ContentAlignment.MiddleLeft;
            lblHireDate.Location = new Point(58, 560);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(144, 30);
            lblHireDate.TabIndex = 43;
            lblHireDate.Text = "       &HireDate";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.BackColor = Color.Transparent;
            lblNotes.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotes.Image = Properties.Resources.icons8_notes_32;
            lblNotes.ImageAlign = ContentAlignment.MiddleLeft;
            lblNotes.Location = new Point(890, 781);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(114, 30);
            lblNotes.TabIndex = 52;
            lblNotes.Text = "       &Notes";
            // 
            // lblExtension
            // 
            lblExtension.AutoSize = true;
            lblExtension.BackColor = Color.Transparent;
            lblExtension.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExtension.Image = Properties.Resources.icons8_extension_32;
            lblExtension.ImageAlign = ContentAlignment.MiddleLeft;
            lblExtension.Location = new Point(58, 672);
            lblExtension.Name = "lblExtension";
            lblExtension.Size = new Size(151, 30);
            lblExtension.TabIndex = 45;
            lblExtension.Text = "       E&xtension";
            // 
            // txtTittle
            // 
            txtTittle.BackColor = SystemColors.Control;
            txtTittle.BorderStyle = BorderStyle.FixedSingle;
            txtTittle.Font = new Font("Nirmala UI", 10F);
            txtTittle.Location = new Point(890, 713);
            txtTittle.Name = "txtTittle";
            txtTittle.Size = new Size(359, 34);
            txtTittle.TabIndex = 51;
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.BackColor = Color.Transparent;
            lblRegion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegion.Image = Properties.Resources.icons8_region_32;
            lblRegion.ImageAlign = ContentAlignment.MiddleLeft;
            lblRegion.Location = new Point(58, 448);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(125, 30);
            lblRegion.TabIndex = 46;
            lblRegion.Text = "       Region";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.BackColor = Color.Transparent;
            lblPostalCode.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPostalCode.Image = Properties.Resources.icons8_bag_24;
            lblPostalCode.ImageAlign = ContentAlignment.MiddleLeft;
            lblPostalCode.Location = new Point(890, 557);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(166, 30);
            lblPostalCode.TabIndex = 49;
            lblPostalCode.Text = "       PostalCode";
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = SystemColors.Control;
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Font = new Font("Nirmala UI", 10F);
            txtPostalCode.Location = new Point(890, 601);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(359, 34);
            txtPostalCode.TabIndex = 50;
            // 
            // txtExtension
            // 
            txtExtension.BackColor = SystemColors.Control;
            txtExtension.BorderStyle = BorderStyle.FixedSingle;
            txtExtension.Font = new Font("Nirmala UI", 10F);
            txtExtension.Location = new Point(58, 716);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(359, 34);
            txtExtension.TabIndex = 44;
            // 
            // dtHireDate
            // 
            dtHireDate.Font = new Font("Nirmala UI", 10F);
            dtHireDate.Location = new Point(58, 604);
            dtHireDate.Name = "dtHireDate";
            dtHireDate.Size = new Size(359, 34);
            dtHireDate.TabIndex = 47;
            // 
            // txtRegion
            // 
            txtRegion.BackColor = SystemColors.Control;
            txtRegion.BorderStyle = BorderStyle.FixedSingle;
            txtRegion.Font = new Font("Nirmala UI", 10F);
            txtRegion.Location = new Point(58, 492);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(359, 34);
            txtRegion.TabIndex = 48;
            // 
            // btnRemovepic
            // 
            btnRemovepic.AutoSize = true;
            btnRemovepic.BackColor = Color.RoyalBlue;
            btnRemovepic.Cursor = Cursors.Hand;
            btnRemovepic.FlatStyle = FlatStyle.Flat;
            btnRemovepic.Font = new Font("Nirmala UI", 9F);
            btnRemovepic.ForeColor = Color.White;
            btnRemovepic.Location = new Point(517, 291);
            btnRemovepic.Name = "btnRemovepic";
            btnRemovepic.Size = new Size(236, 37);
            btnRemovepic.TabIndex = 76;
            btnRemovepic.Text = "Remove";
            btnRemovepic.UseVisualStyleBackColor = false;
            btnRemovepic.Click += btnRemovepic_Click_1;
            // 
            // picEmployee
            // 
            picEmployee.BackgroundImageLayout = ImageLayout.Zoom;
            picEmployee.BorderStyle = BorderStyle.FixedSingle;
            picEmployee.InitialImage = null;
            picEmployee.Location = new Point(583, 134);
            picEmployee.Name = "picEmployee";
            picEmployee.Size = new Size(115, 104);
            picEmployee.SizeMode = PictureBoxSizeMode.Zoom;
            picEmployee.TabIndex = 74;
            picEmployee.TabStop = false;
            // 
            // btnUploadPic
            // 
            btnUploadPic.BackColor = SystemColors.Control;
            btnUploadPic.Cursor = Cursors.Hand;
            btnUploadPic.FlatStyle = FlatStyle.Flat;
            btnUploadPic.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUploadPic.ForeColor = Color.RoyalBlue;
            btnUploadPic.Image = Properties.Resources.icons8_full_image_32;
            btnUploadPic.ImageAlign = ContentAlignment.MiddleLeft;
            btnUploadPic.Location = new Point(517, 250);
            btnUploadPic.Name = "btnUploadPic";
            btnUploadPic.Size = new Size(236, 35);
            btnUploadPic.TabIndex = 75;
            btnUploadPic.Text = "    Upload  New Avatar";
            btnUploadPic.UseVisualStyleBackColor = false;
            btnUploadPic.Click += btnUploadPic_Click_1;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.BackColor = Color.Transparent;
            lblEmployee.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblEmployee.ForeColor = Color.RoyalBlue;
            lblEmployee.Location = new Point(12, 102);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(142, 38);
            lblEmployee.TabIndex = 73;
            lblEmployee.Text = "Employee";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(lblEmployee);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(cmbReports);
            groupBox1.Controls.Add(lblFirstName);
            groupBox1.Controls.Add(lblReportsTo);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(cmbCourtesy);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Controls.Add(dtDOB);
            groupBox1.Controls.Add(lblTitleOfCourtesy);
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(lblHireDate);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(lblNotes);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(lblExtension);
            groupBox1.Controls.Add(lblCity);
            groupBox1.Controls.Add(txtTittle);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(lblRegion);
            groupBox1.Controls.Add(txtCountry);
            groupBox1.Controls.Add(lblPostalCode);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(txtPostalCode);
            groupBox1.Controls.Add(lblCountry);
            groupBox1.Controls.Add(txtExtension);
            groupBox1.Controls.Add(lblPhoneNumber);
            groupBox1.Controls.Add(dtHireDate);
            groupBox1.Controls.Add(lblDOB);
            groupBox1.Controls.Add(txtRegion);
            groupBox1.Controls.Add(btnUploadPic);
            groupBox1.Controls.Add(btnRemovepic);
            groupBox1.Controls.Add(picEmployee);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1301, 1106);
            groupBox1.TabIndex = 77;
            groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 44);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(627, 879);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(222, 46);
            btnSave.TabIndex = 91;
            btnSave.Text = "Sa&ve Employee";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.Black;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.RoyalBlue;
            btnCancel.Image = Properties.Resources.icons8_close_32;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(473, 879);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 46);
            btnCancel.TabIndex = 92;
            btnCancel.Text = "      Ca&ncel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblFirstName.Image = Properties.Resources.icons8_name_32;
            lblFirstName.ImageAlign = ContentAlignment.MiddleLeft;
            lblFirstName.Location = new Point(58, 336);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(162, 30);
            lblFirstName.TabIndex = 77;
            lblFirstName.Text = "       &First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.Control;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Nirmala UI", 10F);
            txtFirstName.Location = new Point(58, 380);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(359, 34);
            txtFirstName.TabIndex = 79;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblLastName.Image = Properties.Resources.icons8_name_32;
            lblLastName.ImageAlign = ContentAlignment.MiddleLeft;
            lblLastName.Location = new Point(473, 336);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(159, 30);
            lblLastName.TabIndex = 78;
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
            dtDOB.Location = new Point(473, 604);
            dtDOB.Name = "dtDOB";
            dtDOB.RightToLeft = RightToLeft.No;
            dtDOB.Size = new Size(359, 31);
            dtDOB.TabIndex = 82;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.Control;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Nirmala UI", 10F);
            txtLastName.ForeColor = SystemColors.WindowText;
            txtLastName.Location = new Point(473, 380);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(359, 34);
            txtLastName.TabIndex = 80;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Image = Properties.Resources.icons8_home_32;
            lblAddress.ImageAlign = ContentAlignment.MiddleLeft;
            lblAddress.Location = new Point(473, 780);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(134, 30);
            lblAddress.TabIndex = 87;
            lblAddress.Text = "       &Address";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Control;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(473, 824);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(359, 37);
            txtAddress.TabIndex = 89;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.Transparent;
            lblCity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCity.Image = Properties.Resources.icons8_mountain_city_32;
            lblCity.ImageAlign = ContentAlignment.MiddleLeft;
            lblCity.Location = new Point(890, 336);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(94, 30);
            lblCity.TabIndex = 88;
            lblCity.Text = "       &City";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.Control;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(890, 494);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(359, 31);
            txtPhoneNumber.TabIndex = 85;
            // 
            // txtCountry
            // 
            txtCountry.BackColor = SystemColors.Control;
            txtCountry.BorderStyle = BorderStyle.FixedSingle;
            txtCountry.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCountry.Location = new Point(473, 492);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(359, 34);
            txtCountry.TabIndex = 86;
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.Control;
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.Location = new Point(890, 380);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(359, 34);
            txtCity.TabIndex = 90;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.BackColor = Color.Transparent;
            lblCountry.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountry.Image = Properties.Resources.icons8_world_32;
            lblCountry.ImageAlign = ContentAlignment.MiddleLeft;
            lblCountry.Location = new Point(473, 448);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(136, 30);
            lblCountry.TabIndex = 84;
            lblCountry.Text = "       &Country";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = Color.Transparent;
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNumber.Image = Properties.Resources.icons8_phone_32;
            lblPhoneNumber.ImageAlign = ContentAlignment.MiddleLeft;
            lblPhoneNumber.Location = new Point(890, 448);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(207, 30);
            lblPhoneNumber.TabIndex = 83;
            lblPhoneNumber.Text = "       &Phone Number";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.BackColor = Color.Transparent;
            lblDOB.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDOB.Image = Properties.Resources.icons8_birthday_date_32;
            lblDOB.ImageAlign = ContentAlignment.MiddleLeft;
            lblDOB.Location = new Point(473, 560);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(184, 30);
            lblDOB.TabIndex = 81;
            lblDOB.Text = "       &Date of &Birth";
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1301, 1106);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmployee";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Maximized;
            Load += frmEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)picEmployee).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion


        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text))
            {
                txtFirstName.BackColor = Color.White;
            }
            
        }
        private TextBox textBox1;
        private OpenFileDialog UploadPic;
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
        private Button btnRemovepic;
        private PictureBox picEmployee;
        private Button btnUploadPic;
        private Label lblEmployee;
        private GroupBox groupBox1;
        private Button btnSave;
        private Button btnCancel;
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