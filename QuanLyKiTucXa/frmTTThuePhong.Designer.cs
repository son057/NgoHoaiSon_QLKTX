
namespace QuanLyKiTucXa
{
    partial class frmTTThuePhong
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
            this.dtpNGAYTHANHTOAN = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTHANGNAM = new System.Windows.Forms.DateTimePicker();
            this.txtSOTIEN = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.txtMAHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTTThuePhong = new System.Windows.Forms.DataGridView();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANGNAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTHANHTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTThuePhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ THÔNG TIN THUÊ PHÒNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNGAYTHANHTOAN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpTHANGNAM);
            this.groupBox1.Controls.Add(this.txtSOTIEN);
            this.groupBox1.Controls.Add(this.txtMANV);
            this.groupBox1.Controls.Add(this.txtMAHD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 185);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // dtpNGAYTHANHTOAN
            // 
            this.dtpNGAYTHANHTOAN.CustomFormat = "dd/MM/yyyy";
            this.dtpNGAYTHANHTOAN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNGAYTHANHTOAN.Location = new System.Drawing.Point(120, 138);
            this.dtpNGAYTHANHTOAN.Name = "dtpNGAYTHANHTOAN";
            this.dtpNGAYTHANHTOAN.Size = new System.Drawing.Size(106, 22);
            this.dtpNGAYTHANHTOAN.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày Thanh Toán";
            // 
            // dtpTHANGNAM
            // 
            this.dtpTHANGNAM.CustomFormat = "dd/MM/yyyy";
            this.dtpTHANGNAM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTHANGNAM.Location = new System.Drawing.Point(323, 31);
            this.dtpTHANGNAM.Name = "dtpTHANGNAM";
            this.dtpTHANGNAM.Size = new System.Drawing.Size(106, 22);
            this.dtpTHANGNAM.TabIndex = 16;
            // 
            // txtSOTIEN
            // 
            this.txtSOTIEN.Location = new System.Drawing.Point(557, 31);
            this.txtSOTIEN.Name = "txtSOTIEN";
            this.txtSOTIEN.Size = new System.Drawing.Size(100, 22);
            this.txtSOTIEN.TabIndex = 15;
            // 
            // txtMANV
            // 
            this.txtMANV.Location = new System.Drawing.Point(416, 137);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 22);
            this.txtMANV.TabIndex = 12;
            // 
            // txtMAHD
            // 
            this.txtMAHD.Location = new System.Drawing.Point(103, 34);
            this.txtMAHD.Name = "txtMAHD";
            this.txtMAHD.Size = new System.Drawing.Size(87, 22);
            this.txtMAHD.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tháng Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hợp Đồng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnCapNhat);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(767, 70);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(505, 21);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTTThuePhong);
            this.groupBox2.Location = new System.Drawing.Point(12, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 134);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // dgvTTThuePhong
            // 
            this.dgvTTThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.THANGNAM,
            this.SOTIEN,
            this.NGAYTHANHTOAN,
            this.MANV});
            this.dgvTTThuePhong.Location = new System.Drawing.Point(16, 19);
            this.dgvTTThuePhong.Name = "dgvTTThuePhong";
            this.dgvTTThuePhong.Size = new System.Drawing.Size(745, 115);
            this.dgvTTThuePhong.TabIndex = 0;
            this.dgvTTThuePhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTThuePhong_CellClick);
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "Mã Hợp Đồng";
            this.MAHD.Name = "MAHD";
            // 
            // THANGNAM
            // 
            this.THANGNAM.DataPropertyName = "THANGNAM";
            this.THANGNAM.HeaderText = "Tháng Năm";
            this.THANGNAM.Name = "THANGNAM";
            // 
            // SOTIEN
            // 
            this.SOTIEN.DataPropertyName = "SOTIEN";
            this.SOTIEN.HeaderText = "Số Tiền";
            this.SOTIEN.Name = "SOTIEN";
            // 
            // NGAYTHANHTOAN
            // 
            this.NGAYTHANHTOAN.DataPropertyName = "NGAYTHANHTOAN";
            this.NGAYTHANHTOAN.HeaderText = "Ngày Thanh Toán";
            this.NGAYTHANHTOAN.Name = "NGAYTHANHTOAN";
            // 
            // MANV
            // 
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã Nhân Viên";
            this.MANV.Name = "MANV";
            // 
            // frmTTThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmTTThuePhong";
            this.Text = "QUẢN LÝ THÔNG TIN THUÊ PHÒNG";
            this.Load += new System.EventHandler(this.frmTTThuePhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTThuePhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSOTIEN;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.TextBox txtMAHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTHANGNAM;
        private System.Windows.Forms.DateTimePicker dtpNGAYTHANHTOAN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTTThuePhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANGNAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHANHTOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
    }
}