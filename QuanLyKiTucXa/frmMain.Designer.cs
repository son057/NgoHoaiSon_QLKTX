
namespace QuanLyKiTucXa
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThuePhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongTinThuePhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SinhVienToolStripMenuItem,
            this.PhongToolStripMenuItem,
            this.ThuePhongToolStripMenuItem,
            this.ThongTinThuePhongToolStripMenuItem,
            this.ThoatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SinhVienToolStripMenuItem
            // 
            this.SinhVienToolStripMenuItem.Name = "SinhVienToolStripMenuItem";
            this.SinhVienToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.SinhVienToolStripMenuItem.Text = "Quản Lý Sinh Viên";
            this.SinhVienToolStripMenuItem.Click += new System.EventHandler(this.SinhVienToolStripMenuItem_Click);
            // 
            // PhongToolStripMenuItem
            // 
            this.PhongToolStripMenuItem.Name = "PhongToolStripMenuItem";
            this.PhongToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.PhongToolStripMenuItem.Text = "Quản Lý Phòng";
            this.PhongToolStripMenuItem.Click += new System.EventHandler(this.PhongToolStripMenuItem_Click);
            // 
            // ThuePhongToolStripMenuItem
            // 
            this.ThuePhongToolStripMenuItem.Name = "ThuePhongToolStripMenuItem";
            this.ThuePhongToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.ThuePhongToolStripMenuItem.Text = "Quản Lý Thuê Phòng";
            this.ThuePhongToolStripMenuItem.Click += new System.EventHandler(this.ThuePhongToolStripMenuItem_Click);
            // 
            // ThongTinThuePhongToolStripMenuItem
            // 
            this.ThongTinThuePhongToolStripMenuItem.Name = "ThongTinThuePhongToolStripMenuItem";
            this.ThongTinThuePhongToolStripMenuItem.Size = new System.Drawing.Size(185, 20);
            this.ThongTinThuePhongToolStripMenuItem.Text = "Quản Lý Thông Tin Thuê Phòng";
            this.ThongTinThuePhongToolStripMenuItem.Click += new System.EventHandler(this.ThongTinThuePhongToolStripMenuItem_Click);
            // 
            // ThoatToolStripMenuItem
            // 
            this.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem";
            this.ThoatToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ThoatToolStripMenuItem.Text = "Thoát";
            this.ThoatToolStripMenuItem.Click += new System.EventHandler(this.ThoatToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(554, 409);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thời gian hiện tại";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(129, 401);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(94, 36);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "QUẢN LÝ KÍ TÚC XÁ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThuePhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThongTinThuePhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThoatToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangXuat;
    }
}