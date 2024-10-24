namespace Lab05
{
    partial class frmStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.txtAvgScore = new System.Windows.Forms.TextBox();
            this.txtNameStudent = new System.Windows.Forms.TextBox();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnAddOrUpdateStudent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexits = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvInformationStudent = new System.Windows.Forms.DataGridView();
            this.dgvIdStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.chkUnregisterMajor = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRegisterMajor = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformationStudent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.picAvatar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbFaculty);
            this.groupBox1.Controls.Add(this.txtAvgScore);
            this.groupBox1.Controls.Add(this.txtNameStudent);
            this.groupBox1.Controls.Add(this.txtIdStudent);
            this.groupBox1.Controls.Add(this.btnDeleteStudent);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.btnAddOrUpdateStudent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Location = new System.Drawing.Point(4, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(341, 351);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(86, 151);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(206, 159);
            this.picAvatar.TabIndex = 18;
            this.picAvatar.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(7, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ảnh đại diện";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(86, 87);
            this.cmbFaculty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(207, 21);
            this.cmbFaculty.TabIndex = 16;
            // 
            // txtAvgScore
            // 
            this.txtAvgScore.Location = new System.Drawing.Point(86, 119);
            this.txtAvgScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAvgScore.Name = "txtAvgScore";
            this.txtAvgScore.Size = new System.Drawing.Size(207, 20);
            this.txtAvgScore.TabIndex = 13;
            // 
            // txtNameStudent
            // 
            this.txtNameStudent.Location = new System.Drawing.Point(86, 58);
            this.txtNameStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameStudent.Name = "txtNameStudent";
            this.txtNameStudent.Size = new System.Drawing.Size(207, 20);
            this.txtNameStudent.TabIndex = 11;
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Location = new System.Drawing.Point(86, 26);
            this.txtIdStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(207, 20);
            this.txtIdStudent.TabIndex = 10;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteStudent.Location = new System.Drawing.Point(193, 315);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(68, 31);
            this.btnDeleteStudent.TabIndex = 7;
            this.btnDeleteStudent.Text = "Xóa";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Red;
            this.btnUpload.Location = new System.Drawing.Point(297, 214);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(31, 31);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "...";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnAddOrUpdateStudent
            // 
            this.btnAddOrUpdateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddOrUpdateStudent.Location = new System.Drawing.Point(74, 315);
            this.btnAddOrUpdateStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddOrUpdateStudent.Name = "btnAddOrUpdateStudent";
            this.btnAddOrUpdateStudent.Size = new System.Drawing.Size(99, 31);
            this.btnAddOrUpdateStudent.TabIndex = 5;
            this.btnAddOrUpdateStudent.Text = "Thêm/Cập nhật";
            this.btnAddOrUpdateStudent.UseVisualStyleBackColor = false;
            this.btnAddOrUpdateStudent.Click += new System.EventHandler(this.btnAddOrUpdateStudent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(4, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm trung bình:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(4, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sinh viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // btnexits
            // 
            this.btnexits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnexits.Location = new System.Drawing.Point(849, 404);
            this.btnexits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexits.Name = "btnexits";
            this.btnexits.Size = new System.Drawing.Size(80, 32);
            this.btnexits.TabIndex = 13;
            this.btnexits.Text = "Thoát";
            this.btnexits.UseVisualStyleBackColor = true;
            this.btnexits.Click += new System.EventHandler(this.btnexits_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // dgvInformationStudent
            // 
            this.dgvInformationStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformationStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdStudent,
            this.dgvNameStudent,
            this.dgvFaculty,
            this.dgvAverageScore,
            this.dgvMajor});
            this.dgvInformationStudent.Location = new System.Drawing.Point(350, 119);
            this.dgvInformationStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvInformationStudent.Name = "dgvInformationStudent";
            this.dgvInformationStudent.RowHeadersWidth = 51;
            this.dgvInformationStudent.RowTemplate.Height = 24;
            this.dgvInformationStudent.Size = new System.Drawing.Size(579, 280);
            this.dgvInformationStudent.TabIndex = 11;
            this.dgvInformationStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformationStudent_CellClick);
            // 
            // dgvIdStudent
            // 
            this.dgvIdStudent.HeaderText = "Mã SV";
            this.dgvIdStudent.MinimumWidth = 6;
            this.dgvIdStudent.Name = "dgvIdStudent";
            this.dgvIdStudent.Width = 125;
            // 
            // dgvNameStudent
            // 
            this.dgvNameStudent.HeaderText = "Tên sinh viên";
            this.dgvNameStudent.MinimumWidth = 6;
            this.dgvNameStudent.Name = "dgvNameStudent";
            this.dgvNameStudent.Width = 125;
            // 
            // dgvFaculty
            // 
            this.dgvFaculty.HeaderText = "Khoa";
            this.dgvFaculty.MinimumWidth = 6;
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.Width = 125;
            // 
            // dgvAverageScore
            // 
            this.dgvAverageScore.HeaderText = "Điểm TB";
            this.dgvAverageScore.MinimumWidth = 6;
            this.dgvAverageScore.Name = "dgvAverageScore";
            this.dgvAverageScore.Width = 125;
            // 
            // dgvMajor
            // 
            this.dgvMajor.HeaderText = "Chuyên ngành";
            this.dgvMajor.MinimumWidth = 6;
            this.dgvMajor.Name = "dgvMajor";
            this.dgvMajor.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Magenta;
            this.label6.Location = new System.Drawing.Point(248, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(435, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // chkUnregisterMajor
            // 
            this.chkUnregisterMajor.AutoSize = true;
            this.chkUnregisterMajor.Location = new System.Drawing.Point(779, 85);
            this.chkUnregisterMajor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkUnregisterMajor.Name = "chkUnregisterMajor";
            this.chkUnregisterMajor.Size = new System.Drawing.Size(160, 17);
            this.chkUnregisterMajor.TabIndex = 15;
            this.chkUnregisterMajor.Text = "Chưa DangKi chuyên ngành";
            this.chkUnregisterMajor.UseVisualStyleBackColor = true;
            this.chkUnregisterMajor.CheckedChanged += new System.EventHandler(this.chkUnregisterMajor_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRegisterMajor});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.hệThốngToolStripMenuItem.Text = "Chức năng";
            // 
            // toolStripRegisterMajor
            // 
            this.toolStripRegisterMajor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRegisterMajor.Image")));
            this.toolStripRegisterMajor.Name = "toolStripRegisterMajor";
            this.toolStripRegisterMajor.Size = new System.Drawing.Size(200, 22);
            this.toolStripRegisterMajor.Text = "Đăng Ký Chuyên Ngành";
            this.toolStripRegisterMajor.Click += new System.EventHandler(this.toolStripRegisterMajor_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 437);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chkUnregisterMajor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnexits);
            this.Controls.Add(this.dgvInformationStudent);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmStudent";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformationStudent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.TextBox txtAvgScore;
        private System.Windows.Forms.TextBox txtNameStudent;
        public System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnAddOrUpdateStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexits;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DataGridView dgvInformationStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkUnregisterMajor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAverageScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMajor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripRegisterMajor;
    }
}

