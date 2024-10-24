namespace Lab05
{
    partial class frmRegisterMajor
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInformationStudentRegister = new System.Windows.Forms.DataGridView();
            this.btnRegisterMajor = new System.Windows.Forms.Button();
            this.dgvChoose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvIdStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformationStudentRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(357, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(385, 39);
            this.label6.TabIndex = 15;
            this.label6.Text = "Đăng Ký Chuyên Ngành";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(307, 115);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(528, 24);
            this.cmbFaculty.TabIndex = 18;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(198, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Khoa";
            // 
            // cmbMajor
            // 
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Location = new System.Drawing.Point(307, 168);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(528, 24);
            this.cmbMajor.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(198, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Chuyên ngành";
            // 
            // dgvInformationStudentRegister
            // 
            this.dgvInformationStudentRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformationStudentRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvChoose,
            this.dgvIdStudent,
            this.dgvNameStudent,
            this.dgvFaculty,
            this.dgvAverageScore});
            this.dgvInformationStudentRegister.Location = new System.Drawing.Point(142, 224);
            this.dgvInformationStudentRegister.Name = "dgvInformationStudentRegister";
            this.dgvInformationStudentRegister.RowHeadersWidth = 51;
            this.dgvInformationStudentRegister.RowTemplate.Height = 24;
            this.dgvInformationStudentRegister.Size = new System.Drawing.Size(904, 345);
            this.dgvInformationStudentRegister.TabIndex = 21;
            // 
            // btnRegisterMajor
            // 
            this.btnRegisterMajor.Location = new System.Drawing.Point(166, 575);
            this.btnRegisterMajor.Name = "btnRegisterMajor";
            this.btnRegisterMajor.Size = new System.Drawing.Size(100, 36);
            this.btnRegisterMajor.TabIndex = 22;
            this.btnRegisterMajor.Text = "Register";
            this.btnRegisterMajor.UseVisualStyleBackColor = true;
            this.btnRegisterMajor.Click += new System.EventHandler(this.btnRegisterMajor_Click);
            // 
            // dgvChoose
            // 
            this.dgvChoose.HeaderText = "Chọn";
            this.dgvChoose.MinimumWidth = 6;
            this.dgvChoose.Name = "dgvChoose";
            this.dgvChoose.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChoose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChoose.Width = 125;
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
            // frmRegisterMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 613);
            this.Controls.Add(this.btnRegisterMajor);
            this.Controls.Add(this.dgvInformationStudentRegister);
            this.Controls.Add(this.cmbMajor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Name = "frmRegisterMajor";
            this.Text = "frmRegisterMajor";
            this.Load += new System.EventHandler(this.frmRegisterMajor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformationStudentRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInformationStudentRegister;
        private System.Windows.Forms.Button btnRegisterMajor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAverageScore;
    }
}