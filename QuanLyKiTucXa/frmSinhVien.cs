using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace QuanLyKiTucXa
{
    public partial class frmSinhVien : Form
    {
        
        public frmSinhVien()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            //Tao KetNoi
            //SINH VIEN
            loadSinhVien();

        }
        public void loadSinhVien()
        {
            string sql = "SELECT * FROM SINHVIEN";
            DataTable dulieu = kn.getData(sql);
            dgvSinhVien.DataSource = dulieu;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string mssv = txtMSSV.Text;
                string hoten = txtHOTEN.Text;
                string gioitinh = cbGIOITINH.SelectedText;
                string dienthoai = txtDIENTHOAI.Text;
                int malop = int.Parse(txtMALOP.Text);
                DateTime ngayvaoktx = Convert.ToDateTime(dtpNGAYVAOKTX.Text);
                DateTime ngayraktx = Convert.ToDateTime(dtpNGAYRAKTX.Text);
                if (!Regex.Match(txtMSSV.Text, "^[0-9]*$").Success)
                {
                    throw new Exception("Mã SV nhập sai");
                }    
                if (txtMSSV.Text.Length != 10)
                {
                    throw new Exception("Mã SV nhập sai");
                }

                if (txtMSSV.Text.Trim() == "")
                {
                    throw new Exception("Mã SV không được để trống");
                }

                if (txtHOTEN.Text.Trim() == "")
                {
                    throw new Exception("Họ tên không được để trống");
                }

                if (txtDIENTHOAI.Text.Length != 10)
                {
                    throw new Exception("Điện thoại nhập sai");
                }

                SINHVIEN sv = new SINHVIEN(mssv, hoten, gioitinh, dienthoai, malop, ngayvaoktx, ngayraktx);
                string sql = "INSERT INTO SINHVIEN(mssv,hoten,gioitinh,dienthoai,malop,ngayvaoktx,ngayraktx) VALUES('" + mssv + "',N'" + hoten + "','" + gioitinh + "','" + dienthoai + "','" + malop + "','" + ngayvaoktx + "','" + ngayraktx + "')";
                kn.setData(sql);
                loadSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang_chon = e.RowIndex;
            txtMSSV.Text = dgvSinhVien.Rows[hang_chon].Cells["MSSV"].Value.ToString();
            txtHOTEN.Text = dgvSinhVien.Rows[hang_chon].Cells["HOTEN"].Value.ToString();
            cbGIOITINH.Text = dgvSinhVien.Rows[hang_chon].Cells["GIOITINH"].Value.ToString();
            txtDIENTHOAI.Text = dgvSinhVien.Rows[hang_chon].Cells["DIENTHOAI"].Value.ToString();
            txtMALOP.Text = dgvSinhVien.Rows[hang_chon].Cells["MALOP"].Value.ToString();
            dtpNGAYVAOKTX.Text = dgvSinhVien.Rows[hang_chon].Cells["NGAYVAOKTX"].Value.ToString();
            dtpNGAYRAKTX.Text = dgvSinhVien.Rows[hang_chon].Cells["NGAYRAKTX"].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string mssv = txtMSSV.Text;
                string hoten = txtHOTEN.Text;
                string gioitinh = cbGIOITINH.SelectedText;
                string dienthoai = txtDIENTHOAI.Text;
                int malop = int.Parse(txtMALOP.Text.ToString());
                DateTime ngayvaoktx = Convert.ToDateTime(dtpNGAYVAOKTX.Text);
                DateTime ngayraktx = Convert.ToDateTime(dtpNGAYRAKTX.Text);
                if (!Regex.Match(txtMSSV.Text, "^[0-9]*$").Success)
                {
                    throw new Exception("Mã SV nhập sai");
                }
                if (txtMSSV.Text.Length != 10)
                {
                    throw new Exception("Mã SV nhập sai");
                }

                if (txtMSSV.Text.Trim() == "")
                {
                    throw new Exception("Mã SV không được để trống");
                }

                if (txtHOTEN.Text.Trim() == "")
                {
                    throw new Exception("Họ tên không được để trống");
                }

                if (txtDIENTHOAI.Text.Length != 10)
                {
                    throw new Exception("Điện thoại nhập sai");
                }


                SINHVIEN sv = new SINHVIEN(mssv, hoten, gioitinh, dienthoai, malop, ngayvaoktx, ngayraktx);
                string sql = "UPDATE SINHVIEN SET HOTEN = N'" + hoten + "',GIOITINH = '" + gioitinh + "',DIENTHOAI = '" + dienthoai + "',MALOP = '" + malop + "',NGAYVAOKTX = '" + ngayvaoktx + "',NGAYRAKTX = '" + ngayraktx + "' where MSSV = '" + mssv + "' ";
                kn.setData(sql);
                loadSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            string sql = "DELETE FROM SINHVIEN WHERE MSSV='" + mssv + "'";
            kn.setData(sql);
            loadSinhVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
