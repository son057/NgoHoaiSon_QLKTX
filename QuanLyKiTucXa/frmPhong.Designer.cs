
namespace QuanLyKiTucXa
{
    partial class frmPhong
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
            this.txtDIENTICH = new System.Windows.Forms.TextBox();
            this.txtGIATHUE = new System.Windows.Forms.TextBox();
            this.txtSOGIUONG = new System.Windows.Forms.TextBox();
            this.txtTENPHG = new System.Windows.Forms.TextBox();
            this.txtMAPHG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.MAPHG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENPHG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTICH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOGIUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATHUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(284, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ PHÒNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDIENTICH);
            this.groupBox1.Controls.Add(this.txtGIATHUE);
            this.groupBox1.Controls.Add(this.txtSOGIUONG);
            this.groupBox1.Controls.Add(this.txtTENPHG);
            this.groupBox1.Controls.Add(this.txtMAPHG);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // txtDIENTICH
            // 
            this.txtDIENTICH.Location = new System.Drawing.Point(444, 34);
            this.txtDIENTICH.Name = "txtDIENTICH";
            this.txtDIENTICH.Size = new System.Drawing.Size(100, 22);
            this.txtDIENTICH.TabIndex = 15;
            // 
            // txtGIATHUE
            // 
            this.txtGIATHUE.Location = new System.Drawing.Point(253, 134);
            this.txtGIATHUE.Name = "txtGIATHUE";
            this.txtGIATHUE.Size = new System.Drawing.Size(100, 22);
            this.txtGIATHUE.TabIndex = 12;
            // 
            // txtSOGIUONG
            // 
            this.txtSOGIUONG.Location = new System.Drawing.Point(80, 135);
            this.txtSOGIUONG.Name = "txtSOGIUONG";
            this.txtSOGIUONG.Size = new System.Drawing.Size(100, 22);
            this.txtSOGIUONG.TabIndex = 11;
            // 
            // txtTENPHG
            // 
            this.txtTENPHG.Location = new System.Drawing.Point(245, 34);
            this.txtTENPHG.Name = "txtTENPHG";
            this.txtTENPHG.Size = new System.Drawing.Size(100, 22);
            this.txtTENPHG.TabIndex = 8;
            // 
            // txtMAPHG
            // 
            this.txtMAPHG.Location = new System.Drawing.Point(80, 34);
            this.txtMAPHG.Name = "txtMAPHG";
            this.txtMAPHG.Size = new System.Drawing.Size(87, 22);
            this.txtMAPHG.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giá thuê";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số giường";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Diện Tích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phòng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnCapNhat);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(767, 63);
            this.groupBox3.TabIndex = 16;
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
            this.groupBox2.Controls.Add(this.dgvPhong);
            this.groupBox2.Location = new System.Drawing.Point(20, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 134);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHG,
            this.TENPHG,
            this.DIENTICH,
            this.SOGIUONG,
            this.GIATHUE});
            this.dgvPhong.Location = new System.Drawing.Point(16, 19);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(745, 115);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);
            // 
            // MAPHG
            // 
            this.MAPHG.DataPropertyName = "MAPHG";
            this.MAPHG.HeaderText = "Mã Phòng";
            this.MAPHG.Name = "MAPHG";
            // 
            // TENPHG
            // 
            this.TENPHG.DataPropertyName = "TENPHG";
            this.TENPHG.HeaderText = "Tên Phòng";
            this.TENPHG.Name = "TENPHG";
            // 
            // DIENTICH
            // 
            this.DIENTICH.DataPropertyName = "DIENTICH";
            this.DIENTICH.HeaderText = "Diện Tích";
            this.DIENTICH.Name = "DIENTICH";
            // 
            // SOGIUONG
            // 
            this.SOGIUONG.DataPropertyName = "SOGIUONG";
            this.SOGIUONG.HeaderText = "Số Giường";
            this.SOGIUONG.Name = "SOGIUONG";
            // 
            // GIATHUE
            // 
            this.GIATHUE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIATHUE.DataPropertyName = "GIATHUE";
            this.GIATHUE.HeaderText = "Giá Thuê";
            this.GIATHUE.Name = "GIATHUE";
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmPhong";
            this.Text = "QUẢN LÝ PHÒNG";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.Click += new System.EventHandler(this.frmPhong_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDIENTICH;
        private System.Windows.Forms.TextBox txtGIATHUE;
        private System.Windows.Forms.TextBox txtSOGIUONG;
        private System.Windows.Forms.TextBox txtTENPHG;
        private System.Windows.Forms.TextBox txtMAPHG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENPHG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTICH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOGIUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATHUE;
    }
}