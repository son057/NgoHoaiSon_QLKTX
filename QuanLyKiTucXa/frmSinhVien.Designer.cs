
namespace QuanLyKiTucXa
{
    partial class frmSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGIOITINH = new System.Windows.Forms.ComboBox();
            this.dtpNGAYRAKTX = new System.Windows.Forms.DateTimePicker();
            this.dtpNGAYVAOKTX = new System.Windows.Forms.DateTimePicker();
            this.txtMALOP = new System.Windows.Forms.TextBox();
            this.txtDIENTHOAI = new System.Windows.Forms.TextBox();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYVAOKTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYRAKTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(282, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGIOITINH);
            this.groupBox1.Controls.Add(this.dtpNGAYRAKTX);
            this.groupBox1.Controls.Add(this.dtpNGAYVAOKTX);
            this.groupBox1.Controls.Add(this.txtMALOP);
            this.groupBox1.Controls.Add(this.txtDIENTHOAI);
            this.groupBox1.Controls.Add(this.txtHOTEN);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // cbGIOITINH
            // 
            this.cbGIOITINH.FormattingEnabled = true;
            this.cbGIOITINH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGIOITINH.Location = new System.Drawing.Point(450, 29);
            this.cbGIOITINH.Name = "cbGIOITINH";
            this.cbGIOITINH.Size = new System.Drawing.Size(121, 24);
            this.cbGIOITINH.TabIndex = 15;
            // 
            // dtpNGAYRAKTX
            // 
            this.dtpNGAYRAKTX.CustomFormat = "dd/MM/yyyy";
            this.dtpNGAYRAKTX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNGAYRAKTX.Location = new System.Drawing.Point(607, 135);
            this.dtpNGAYRAKTX.Name = "dtpNGAYRAKTX";
            this.dtpNGAYRAKTX.Size = new System.Drawing.Size(106, 22);
            this.dtpNGAYRAKTX.TabIndex = 14;
            // 
            // dtpNGAYVAOKTX
            // 
            this.dtpNGAYVAOKTX.CustomFormat = "dd/MM/yyyy";
            this.dtpNGAYVAOKTX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNGAYVAOKTX.Location = new System.Drawing.Point(424, 135);
            this.dtpNGAYVAOKTX.Name = "dtpNGAYVAOKTX";
            this.dtpNGAYVAOKTX.Size = new System.Drawing.Size(106, 22);
            this.dtpNGAYVAOKTX.TabIndex = 13;
            // 
            // txtMALOP
            // 
            this.txtMALOP.Location = new System.Drawing.Point(253, 134);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Size = new System.Drawing.Size(100, 22);
            this.txtMALOP.TabIndex = 12;
            // 
            // txtDIENTHOAI
            // 
            this.txtDIENTHOAI.Location = new System.Drawing.Point(80, 135);
            this.txtDIENTHOAI.Name = "txtDIENTHOAI";
            this.txtDIENTHOAI.Size = new System.Drawing.Size(100, 22);
            this.txtDIENTHOAI.TabIndex = 11;
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Location = new System.Drawing.Point(245, 34);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(100, 22);
            this.txtHOTEN.TabIndex = 8;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(80, 34);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(100, 22);
            this.txtMSSV.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày ra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày vào";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSinhVien);
            this.groupBox2.Location = new System.Drawing.Point(20, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 134);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HOTEN,
            this.GIOITINH,
            this.DIENTHOAI,
            this.MALOP,
            this.NGAYVAOKTX,
            this.NGAYRAKTX});
            this.dgvSinhVien.Location = new System.Drawing.Point(16, 19);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(745, 109);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.Name = "HOTEN";
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "Điện thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            // 
            // MALOP
            // 
            this.MALOP.DataPropertyName = "MALOP";
            this.MALOP.HeaderText = "Mã Lớp";
            this.MALOP.Name = "MALOP";
            // 
            // NGAYVAOKTX
            // 
            this.NGAYVAOKTX.DataPropertyName = "NGAYVAOKTX";
            this.NGAYVAOKTX.HeaderText = "Ngày vào KTX";
            this.NGAYVAOKTX.Name = "NGAYVAOKTX";
            // 
            // NGAYRAKTX
            // 
            this.NGAYRAKTX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYRAKTX.DataPropertyName = "NGAYRAKTX";
            this.NGAYRAKTX.HeaderText = "Ngày ra KTX";
            this.NGAYRAKTX.Name = "NGAYRAKTX";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnCapNhat);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(767, 70);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(496, 21);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(325, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(197, 21);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 32);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(55, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSinhVien";
            this.Text = "QUẢN LÝ SINH VIÊN";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNGAYRAKTX;
        private System.Windows.Forms.DateTimePicker dtpNGAYVAOKTX;
        private System.Windows.Forms.TextBox txtMALOP;
        private System.Windows.Forms.TextBox txtDIENTHOAI;
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbGIOITINH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYVAOKTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYRAKTX;
    }
}