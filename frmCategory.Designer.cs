namespace BusniessManagementSystem
{
    partial class frmCategory
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
            groupBox3 = new GroupBox();
            label3 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            lblNoImageSelected = new Label();
            btnBrowsePic = new Button();
            pbCatePic = new PictureBox();
            groupBox4 = new GroupBox();
            label4 = new Label();
            label1 = new Label();
            txtCategoryName = new TextBox();
            lblCategoryName = new Label();
            txtDescription = new TextBox();
            lblCategoryDes = new Label();
            ofdCategoryPicture = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCatePic).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Location = new Point(10, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(1222, 658);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnCancel);
            groupBox3.Controls.Add(btnSave);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(0, 527);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1222, 110);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(3, 8);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 2;
            label3.Text = "Action";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.RoyalBlue;
            btnCancel.Image = Properties.Resources.icons8_close_32;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(449, 33);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 44);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "  Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources.icons8_package_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(598, 33);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(184, 44);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(lblNoImageSelected);
            groupBox2.Controls.Add(btnBrowsePic);
            groupBox2.Controls.Add(pbCatePic);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(673, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(549, 465);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(0, 13);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 3;
            label2.Text = "Category Picture";
            // 
            // lblNoImageSelected
            // 
            lblNoImageSelected.AutoSize = true;
            lblNoImageSelected.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoImageSelected.ForeColor = Color.Gray;
            lblNoImageSelected.Location = new Point(186, 187);
            lblNoImageSelected.Name = "lblNoImageSelected";
            lblNoImageSelected.Size = new Size(177, 28);
            lblNoImageSelected.TabIndex = 2;
            lblNoImageSelected.Text = "No Image Selected";
            lblNoImageSelected.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBrowsePic
            // 
            btnBrowsePic.BackColor = SystemColors.Control;
            btnBrowsePic.FlatStyle = FlatStyle.Flat;
            btnBrowsePic.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowsePic.ForeColor = Color.Black;
            btnBrowsePic.Image = Properties.Resources.icons8_full_image_32;
            btnBrowsePic.ImageAlign = ContentAlignment.MiddleLeft;
            btnBrowsePic.Location = new Point(165, 301);
            btnBrowsePic.Name = "btnBrowsePic";
            btnBrowsePic.Size = new Size(219, 48);
            btnBrowsePic.TabIndex = 1;
            btnBrowsePic.Text = "Browse Picture";
            btnBrowsePic.UseVisualStyleBackColor = false;
            btnBrowsePic.Click += btnBrowsePic_Click;
            // 
            // pbCatePic
            // 
            pbCatePic.BorderStyle = BorderStyle.FixedSingle;
            pbCatePic.Location = new Point(165, 115);
            pbCatePic.Name = "pbCatePic";
            pbCatePic.Size = new Size(219, 166);
            pbCatePic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCatePic.TabIndex = 0;
            pbCatePic.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(txtCategoryName);
            groupBox4.Controls.Add(lblCategoryName);
            groupBox4.Controls.Add(txtDescription);
            groupBox4.Controls.Add(lblCategoryDes);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(3, 21);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(549, 465);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(162, 75);
            label4.Name = "label4";
            label4.Size = new Size(25, 32);
            label4.TabIndex = 5;
            label4.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(3, -4);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 4;
            label1.Text = "Category Information";
            // 
            // txtCategoryName
            // 
            txtCategoryName.BackColor = SystemColors.Control;
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoryName.Location = new Point(193, 72);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(341, 34);
            txtCategoryName.TabIndex = 2;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryName.Location = new Point(22, 75);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(148, 28);
            lblCategoryName.TabIndex = 0;
            lblCategoryName.Text = "CategoryName";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ControlLight;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(191, 147);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(334, 213);
            txtDescription.TabIndex = 3;
            // 
            // lblCategoryDes
            // 
            lblCategoryDes.AutoSize = true;
            lblCategoryDes.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryDes.Location = new Point(22, 147);
            lblCategoryDes.Name = "lblCategoryDes";
            lblCategoryDes.Size = new Size(115, 28);
            lblCategoryDes.TabIndex = 1;
            lblCategoryDes.Text = "Description";
            // 
            // ofdCategoryPicture
            // 
            ofdCategoryPicture.FileName = "openFileDialog1";
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1242, 658);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategory";
            Padding = new Padding(10, 0, 10, 0);
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategory";
            WindowState = FormWindowState.Maximized;
            Load += frmCategory_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCatePic).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnCancel;
        private Button btnSave;
        private GroupBox groupBox2;
        private Label lblNoImageSelected;
        private Button btnBrowsePic;
        private PictureBox pbCatePic;
        private GroupBox groupBox4;
        private TextBox txtCategoryName;
        private Label lblCategoryName;
        private TextBox txtDescription;
        private Label lblCategoryDes;
        private OpenFileDialog ofdCategoryPicture;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}