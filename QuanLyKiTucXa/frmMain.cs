using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKiTucXa
{
    public partial class frmMain : Form
    {
        bool isThoat = true;
        public frmMain()
        {
            InitializeComponent();
        }

        private void SinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmSV = new frmSinhVien();
            frmSV.ShowDialog();
        }

        private void PhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPhong = new frmPhong();
            frmPhong.ShowDialog();
        }

        private void ThuePhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThuePhong = new frmThuePhong();
            frmThuePhong.ShowDialog();
        }

        private void ThongTinThuePhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmTTThuePhong = new frmTTThuePhong();
            frmTTThuePhong.ShowDialog();
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToLongTimeString();
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            frmDangNhap f = new frmDangNhap();
            f.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isThoat)
                Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                if (MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }    
                
        }
    }
}
