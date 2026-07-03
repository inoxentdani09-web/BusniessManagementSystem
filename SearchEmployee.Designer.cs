namespace BusniessManagementSystem
{
    partial class SearchEmployee
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
            cmbReports = new ComboBox();
            txtAddress = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            txtPostalCode = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblSearchEmployee = new Label();
            panel1 = new Panel();
            dgvSearchEmployee = new DataGridView();
            EditCol = new DataGridViewButtonColumn();
            ViewCol = new DataGridViewButtonColumn();
            DeleteCol = new DataGridViewButtonColumn();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchEmployee).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(cmbReports);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPostalCode);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(lblFirstName);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(lblSearchEmployee);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1345, 488);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cmbReports
            // 
            cmbReports.FormattingEnabled = true;
            cmbReports.Location = new Point(491, 208);
            cmbReports.Name = "cmbReports";
            cmbReports.Size = new Size(250, 33);
            cmbReports.TabIndex = 35;
            cmbReports.SelectedIndexChanged += cmbReports_SelectedIndexChanged;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(114, 296);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 70);
            txtAddress.TabIndex = 32;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(491, 166);
            label10.Name = "label10";
            label10.Size = new Size(155, 30);
            label10.TabIndex = 30;
            label10.Text = "      R&eports To";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Image = Properties.Resources.icons8_home_32;
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(114, 257);
            label9.Name = "label9";
            label9.Size = new Size(128, 30);
            label9.TabIndex = 29;
            label9.Text = "      &Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Image = Properties.Resources.icons8_bag_24;
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(491, 86);
            label7.Name = "label7";
            label7.Size = new Size(160, 30);
            label7.TabIndex = 23;
            label7.Text = "      Po&stalCode";
            // 
            // txtPostalCode
            // 
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Location = new Point(491, 119);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(250, 31);
            txtPostalCode.TabIndex = 19;
            txtPostalCode.TextChanged += txtPostalCode_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(114, 209);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 31);
            txtLastName.TabIndex = 7;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(114, 119);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 31);
            txtFirstName.TabIndex = 6;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Image = Properties.Resources.icons8_name_32;
            lblFirstName.ImageAlign = ContentAlignment.MiddleLeft;
            lblFirstName.Location = new Point(114, 86);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(150, 30);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "      &FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Image = Properties.Resources.icons8_name_32;
            lblLastName.ImageAlign = ContentAlignment.MiddleLeft;
            lblLastName.Location = new Point(114, 166);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(153, 30);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "      &Last Name";
            // 
            // lblSearchEmployee
            // 
            lblSearchEmployee.AutoSize = true;
            lblSearchEmployee.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSearchEmployee.ForeColor = Color.RoyalBlue;
            lblSearchEmployee.Location = new Point(7, 3);
            lblSearchEmployee.Name = "lblSearchEmployee";
            lblSearchEmployee.Size = new Size(234, 38);
            lblSearchEmployee.TabIndex = 0;
            lblSearchEmployee.Text = "Search Employee";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvSearchEmployee);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 488);
            panel1.Name = "panel1";
            panel1.Size = new Size(1345, 476);
            panel1.TabIndex = 1;
            // 
            // dgvSearchEmployee
            // 
            dgvSearchEmployee.AllowUserToAddRows = false;
            dgvSearchEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvSearchEmployee.BackgroundColor = Color.White;
            dgvSearchEmployee.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSearchEmployee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvSearchEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchEmployee.Columns.AddRange(new DataGridViewColumn[] { EditCol, ViewCol, DeleteCol });
            dgvSearchEmployee.Dock = DockStyle.Fill;
            dgvSearchEmployee.Location = new Point(0, 0);
            dgvSearchEmployee.Margin = new Padding(0);
            dgvSearchEmployee.Name = "dgvSearchEmployee";
            dgvSearchEmployee.ReadOnly = true;
            dgvSearchEmployee.RowHeadersVisible = false;
            dgvSearchEmployee.RowHeadersWidth = 62;
            dgvSearchEmployee.ScrollBars = ScrollBars.Horizontal;
            dgvSearchEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchEmployee.Size = new Size(1345, 476);
            dgvSearchEmployee.TabIndex = 0;
            dgvSearchEmployee.CellClick += dgvSearchEmployee_CellClick;
            // 
            // EditCol
            // 
            EditCol.HeaderText = "Edit";
            EditCol.MinimumWidth = 30;
            EditCol.Name = "EditCol";
            EditCol.ReadOnly = true;
            EditCol.Text = "Edit";
            EditCol.ToolTipText = "Edit Employee Record";
            EditCol.UseColumnTextForButtonValue = true;
            EditCol.Width = 48;
            // 
            // ViewCol
            // 
            ViewCol.HeaderText = "View";
            ViewCol.MinimumWidth = 30;
            ViewCol.Name = "ViewCol";
            ViewCol.ReadOnly = true;
            ViewCol.Text = "View";
            ViewCol.ToolTipText = "View Employee Record";
            ViewCol.UseColumnTextForButtonValue = true;
            ViewCol.Width = 55;
            // 
            // DeleteCol
            // 
            DeleteCol.HeaderText = "Delete";
            DeleteCol.MinimumWidth = 30;
            DeleteCol.Name = "DeleteCol";
            DeleteCol.ReadOnly = true;
            DeleteCol.Text = "Delete";
            DeleteCol.ToolTipText = "Delete Records";
            DeleteCol.UseColumnTextForButtonValue = true;
            DeleteCol.Width = 68;
            // 
            // SearchEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1345, 964);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchEmployee";
            ShowIcon = false;
            Text = "SearchEmployee";
            WindowState = FormWindowState.Maximized;
            Load += SearchEmployee_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSearchEmployee).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Label lblSearchEmployee;
        private DataGridView dgvSearchEmployee;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtPostalCode;
        private Label label7;
        private TextBox txtAddress;
        private Label label10;
        private Label label9;
        private ComboBox cmbReports;
        private DataGridViewButtonColumn EditCol;
        private DataGridViewButtonColumn ViewCol;
        private DataGridViewButtonColumn DeleteCol;
    }
}