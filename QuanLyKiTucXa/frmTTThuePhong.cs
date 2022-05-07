using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLyKiTucXa
{
    public partial class frmTTThuePhong : Form
    {
       
        public frmTTThuePhong()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void frmTTThuePhong_Load(object sender, EventArgs e)
        {
            loadTTThuePhong();
        }

        public void loadTTThuePhong()
        {
            string sql = "SELECT * FROM TTTHUEPHONG";
            DataTable dulieu = kn.getData(sql);
            dgvTTThuePhong.DataSource = dulieu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                string mahd = txtMAHD.Text;
                DateTime thangnam = Convert.ToDateTime(dtpTHANGNAM.Text);
                int sotien = int.Parse(txtSOTIEN.Text);
                DateTime ngaythanhtoan = Convert.ToDateTime(dtpNGAYTHANHTOAN.Text);
                int manv = int.Parse(txtMANV.Text);
                TTTHUEPHONG tttp = new TTTHUEPHONG(mahd, thangnam, sotien, ngaythanhtoan, manv);
                string sql = "INSERT INTO TTTHUEPHONG(mahd, thangnam, sotien, ngaythanhtoan, manv) VALUES('" + mahd + "','" + thangnam + "','" + sotien + "','" + ngaythanhtoan + "','" + manv + "')";
                kn.setData(sql);
                loadTTThuePhong();
        }

        private void dgvTTThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang_chon = e.RowIndex;
            txtMAHD.Text = dgvTTThuePhong.Rows[hang_chon].Cells["MAHD"].Value.ToString();
            dtpTHANGNAM.Text = dgvTTThuePhong.Rows[hang_chon].Cells["THANGNAM"].Value.ToString();
            txtSOTIEN.Text = dgvTTThuePhong.Rows[hang_chon].Cells["SOTIEN"].Value.ToString();
            dtpNGAYTHANHTOAN.Text = dgvTTThuePhong.Rows[hang_chon].Cells["NGAYTHANHTOAN"].Value.ToString();
            txtMANV.Text = dgvTTThuePhong.Rows[hang_chon].Cells["MANV"].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txtMAHD.Text;
                DateTime thangnam = Convert.ToDateTime(dtpTHANGNAM.Text);
                int sotien = int.Parse(txtSOTIEN.Text);
                DateTime ngaythanhtoan = Convert.ToDateTime(dtpNGAYTHANHTOAN.Text);
                int manv = int.Parse(txtMANV.Text);

                if (!Regex.Match(txtMAHD.Text, "^[0-9]*$").Success)
                {
                    throw new Exception("Mã hợp đồng nhập sai");
                }

                if (txtMAHD.Text.Trim() == "")
                {
                    throw new Exception("Mã hợp đồng không được để trống");
                }

                if (!Regex.Match(txtSOTIEN.Text, "^[0-9]*$").Success)
                {
                    throw new Exception("Số tiền nhập sai");
                }

                TTTHUEPHONG tttp = new TTTHUEPHONG(mahd, thangnam, sotien, ngaythanhtoan, manv);
                string sql = "UPDATE TTTHUEPHONG SET THANGNAM = N'" + thangnam + "',SOTIEN = '" + sotien + "',NGAYTHANHTOAN = '" + ngaythanhtoan + "',MANV = '" + manv + "' where MAHD = '" + mahd + "' ";
                kn.setData(sql);
                loadTTThuePhong();
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mahd = txtMAHD.Text;
            string sql = "DELETE FROM TTTHUEPHONG WHERE MAHD='" + mahd + "'";
            kn.setData(sql);
            loadTTThuePhong();
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
