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
            panel1 = new Panel();
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
            dgvSearchEmployee = new DataGridView();
            EditCol = new DataGridViewButtonColumn();
            ViewCol = new DataGridViewButtonColumn();
            DeleteCol = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchEmployee).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(dgvSearchEmployee);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1345, 964);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.White;
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
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1333, 485);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // cmbReports
            // 
            cmbReports.BackColor = SystemColors.Control;
            cmbReports.FlatStyle = FlatStyle.Popup;
            cmbReports.FormattingEnabled = true;
            cmbReports.Location = new Point(753, 245);
            cmbReports.Name = "cmbReports";
            cmbReports.Size = new Size(250, 33);
            cmbReports.TabIndex = 46;
            cmbReports.SelectedIndexChanged += cmbReports_SelectedIndexChanged_1;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Control;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(376, 369);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 70);
            txtAddress.TabIndex = 45;
            txtAddress.TextChanged += txtAddress_TextChanged_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(753, 204);
            label10.Name = "label10";
            label10.Size = new Size(155, 30);
            label10.TabIndex = 44;
            label10.Text = "      R&eports To";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Image = Properties.Resources.icons8_home_32;
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(376, 329);
            label9.Name = "label9";
            label9.Size = new Size(128, 30);
            label9.TabIndex = 43;
            label9.Text = "      &Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Image = Properties.Resources.icons8_bag_24;
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(753, 79);
            label7.Name = "label7";
            label7.Size = new Size(160, 30);
            label7.TabIndex = 42;
            label7.Text = "      Po&stalCode";
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = SystemColors.Control;
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Location = new Point(753, 124);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(250, 31);
            txtPostalCode.TabIndex = 41;
            txtPostalCode.TextChanged += txtPostalCode_TextChanged_1;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.Control;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(376, 247);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 31);
            txtLastName.TabIndex = 40;
            txtLastName.TextChanged += txtLastName_TextChanged_1;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.Control;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(376, 121);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 31);
            txtFirstName.TabIndex = 39;
            txtFirstName.TextChanged += txtFirstName_TextChanged_1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Image = Properties.Resources.icons8_name_32;
            lblFirstName.ImageAlign = ContentAlignment.MiddleLeft;
            lblFirstName.Location = new Point(376, 79);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(150, 30);
            lblFirstName.TabIndex = 37;
            lblFirstName.Text = "      &FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Image = Properties.Resources.icons8_name_32;
            lblLastName.ImageAlign = ContentAlignment.MiddleLeft;
            lblLastName.Location = new Point(376, 204);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(153, 30);
            lblLastName.TabIndex = 38;
            lblLastName.Text = "      &Last Name";
            // 
            // lblSearchEmployee
            // 
            lblSearchEmployee.AutoSize = true;
            lblSearchEmployee.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSearchEmployee.ForeColor = Color.RoyalBlue;
            lblSearchEmployee.Location = new Point(0, 45);
            lblSearchEmployee.Name = "lblSearchEmployee";
            lblSearchEmployee.Size = new Size(234, 38);
            lblSearchEmployee.TabIndex = 36;
            lblSearchEmployee.Text = "Search Employee";
            // 
            // dgvSearchEmployee
            // 
            dgvSearchEmployee.AllowUserToAddRows = false;
            dgvSearchEmployee.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSearchEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSearchEmployee.BackgroundColor = Color.White;
            dgvSearchEmployee.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSearchEmployee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgvSearchEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchEmployee.Columns.AddRange(new DataGridViewColumn[] { EditCol, ViewCol, DeleteCol });
            dgvSearchEmployee.Location = new Point(0, 488);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchEmployee";
            ShowIcon = false;
            Text = "SearchEmployee";
            WindowState = FormWindowState.Maximized;
            Load += SearchEmployee_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dgvSearchEmployee;
        private DataGridViewButtonColumn EditCol;
        private DataGridViewButtonColumn ViewCol;
        private DataGridViewButtonColumn DeleteCol;
        private GroupBox groupBox1;
        private ComboBox cmbReports;
        private TextBox txtAddress;
        private Label label10;
        private Label label9;
        private Label label7;
        private TextBox txtPostalCode;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblSearchEmployee;
    }
}