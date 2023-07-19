namespace QLSV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new System.Windows.Forms.GroupBox();
            dgv = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnKhoiTao = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnThem = new System.Windows.Forms.Button();
            dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            cbGioiTinh = new System.Windows.Forms.ComboBox();
            txtTenNV = new System.Windows.Forms.TextBox();
            txtChucVu = new System.Windows.Forms.TextBox();
            txtTienHoc = new System.Windows.Forms.TextBox();
            txtMaNV = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv);
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(767, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new System.Drawing.Point(45, 19);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new System.Drawing.Size(715, 277);
            dgv.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnKhoiTao);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(dtNgaySinh);
            groupBox2.Controls.Add(cbGioiTinh);
            groupBox2.Controls.Add(txtTenNV);
            groupBox2.Controls.Add(txtChucVu);
            groupBox2.Controls.Add(txtTienHoc);
            groupBox2.Controls.Add(txtMaNV);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new System.Drawing.Point(0, 308);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1023, 296);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Chi Tiết";
            // 
            // btnKhoiTao
            // 
            btnKhoiTao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnKhoiTao.Location = new System.Drawing.Point(815, 175);
            btnKhoiTao.Name = "btnKhoiTao";
            btnKhoiTao.Size = new System.Drawing.Size(75, 23);
            btnKhoiTao.TabIndex = 18;
            btnKhoiTao.Text = "Khởi Tạo";
            btnKhoiTao.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnXoa.Location = new System.Drawing.Point(815, 126);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(75, 23);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSua.Location = new System.Drawing.Point(815, 73);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(75, 23);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnThem.Location = new System.Drawing.Point(815, 19);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(75, 23);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtNgaySinh.Location = new System.Drawing.Point(486, 19);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new System.Drawing.Size(200, 25);
            dtNgaySinh.TabIndex = 14;
            dtNgaySinh.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGioiTinh.Location = new System.Drawing.Point(67, 173);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new System.Drawing.Size(74, 25);
            cbGioiTinh.TabIndex = 13;
            // 
            // txtTenNV
            // 
            txtTenNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTenNV.Location = new System.Drawing.Point(67, 93);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new System.Drawing.Size(312, 25);
            txtTenNV.TabIndex = 11;
            // 
            // txtChucVu
            // 
            txtChucVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtChucVu.Location = new System.Drawing.Point(486, 93);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new System.Drawing.Size(267, 25);
            txtChucVu.TabIndex = 10;
            // 
            // txtTienHoc
            // 
            txtTienHoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTienHoc.Location = new System.Drawing.Point(486, 170);
            txtTienHoc.Name = "txtTienHoc";
            txtTienHoc.Size = new System.Drawing.Size(174, 25);
            txtTienHoc.TabIndex = 9;
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMaNV.Location = new System.Drawing.Point(67, 28);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new System.Drawing.Size(199, 25);
            txtMaNV.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(425, 173);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 17);
            label6.TabIndex = 7;
            label6.Text = "TienHoc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(425, 96);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 17);
            label5.TabIndex = 6;
            label5.Text = "ChucVu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(425, 22);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 17);
            label4.TabIndex = 5;
            label4.Text = "NgaySinh";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(12, 173);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 17);
            label3.TabIndex = 4;
            label3.Text = "GioiTinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 96);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 17);
            label2.TabIndex = 3;
            label2.Text = "TenNV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 17);
            label1.TabIndex = 2;
            label1.Text = "MaNV";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1123, 644);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "QLSV";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtTienHoc;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKhoiTao;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}
