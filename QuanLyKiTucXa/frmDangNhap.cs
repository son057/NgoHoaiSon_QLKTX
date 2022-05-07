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
    public partial class frmDangNhap : Form
    {
        List<TaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                frmMain f = new frmMain();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
                txtTaiKhoan.Focus();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        bool  KiemTraDangNhap(string tentaikhoan,string matkhau)
        {
            for(int i =0; i<listTaiKhoan.Count;i++)
            {
                if (tentaikhoan == listTaiKhoan[i].TenTaiKhoan && matkhau == listTaiKhoan[i].Matkhau)
                    return true;
            }    

            return false;
        }
    }
}
