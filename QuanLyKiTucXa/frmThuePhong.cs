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
    public partial class frmThuePhong : Form
    {
        KetNoi kn = new KetNoi();
        public frmThuePhong()
        {
            InitializeComponent();
        }

        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            loadThuePhong();
        }
        public void loadThuePhong()
        {
            string sql = "SELECT * FROM THUEPHONG";
            DataTable dulieu = kn.getData(sql);
            dgvThuePhong.DataSource = dulieu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahd = txtMAHD.Text;
            string mssv = txtMSSV.Text;
            string MAPHG = txtMAPHG.Text;
            DateTime ngayvao = Convert.ToDateTime(dtpNGAYVAO.Text);
            DateTime ngayra = Convert.ToDateTime(dtpNGAYRA.Text);
            int tiendatcoc = int.Parse(txtTIENDATCOC.Text);
            int giathue = int.Parse(txtGIATHUE.Text);

            THUEPHONG tp = new THUEPHONG(mahd, mssv, MAPHG, ngayvao, ngayra, tiendatcoc, giathue);
            string sql = "INSERT INTO THUEPHONG(mahd,mssv,MAPHG, ngayvao, ngayra, tiendatcoc, giathue) VALUES('" + mahd + "','" + mssv + "','" + MAPHG + "','" + ngayvao + "','" + ngayra + "','" + tiendatcoc + "','" + giathue + "')";
            kn.setData(sql);
            loadThuePhong();
        }

        private void dgvThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang_chon = e.RowIndex;
            txtMAHD.Text = dgvThuePhong.Rows[hang_chon].Cells["MAHD"].Value.ToString();
            txtMSSV.Text = dgvThuePhong.Rows[hang_chon].Cells["MSSV"].Value.ToString();
            txtMAPHG.Text = dgvThuePhong.Rows[hang_chon].Cells["MAPHG"].Value.ToString();
            dtpNGAYVAO.Text = dgvThuePhong.Rows[hang_chon].Cells["NGAYVAO"].Value.ToString();
            dtpNGAYRA.Text = dgvThuePhong.Rows[hang_chon].Cells["NGAYRA"].Value.ToString();
            txtTIENDATCOC.Text= dgvThuePhong.Rows[hang_chon].Cells["TIENDATCOC"].Value.ToString();
            txtGIATHUE.Text = dgvThuePhong.Rows[hang_chon].Cells["GIATHUE"].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string mahd = txtMAHD.Text;
            string mssv = txtMSSV.Text;
            string MAPHG = txtMAPHG.Text;
            DateTime ngayvao = Convert.ToDateTime(dtpNGAYVAO.Text);
            DateTime ngayra = Convert.ToDateTime(dtpNGAYRA.Text);
            int tiendatcoc = int.Parse(txtTIENDATCOC.Text);
            int giathue = int.Parse(txtGIATHUE.Text);
            THUEPHONG tp = new THUEPHONG(mahd, mssv, MAPHG, ngayvao, ngayra, tiendatcoc, giathue);
            string sql = "UPDATE THUEPHONG SET MSSV = N'" + mssv + "',MAPHG = '" + MAPHG + "',NGAYVAO = '" + ngayvao + "',NGAYRA = '" + ngayra + "',TIENDATCOC = '" + tiendatcoc + "',GIATHUE = '" + giathue + "' where MAHD = '" + mahd + "' ";
            kn.setData(sql);
            loadThuePhong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mahd = txtMAHD.Text;
            string sql = "DELETE FROM THUEPHONG WHERE MAHD='" + mahd + "'";
            kn.setData(sql);
            loadThuePhong();
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
