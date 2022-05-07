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
    public partial class frmPhong : Form
    {
        KetNoi kn = new KetNoi();
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Click(object sender, EventArgs e)
        {

        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            loadPhong();
            loadThuePhong();
        }

        public void loadPhong()
        {
            string sql = "SELECT * FROM PHONG";
            DataTable dulieu = kn.getData(sql);
            dgvPhong.DataSource = dulieu;
        }

        public void loadThuePhong()
        {
            string sqlphong = "SELECT * FROM THUEPHONG";
            DataTable dlphong = kn.getData(sqlphong);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maphg = txtMAPHG.Text;
                string TENPHG = txtTENPHG.Text;
                float dientich = float.Parse(txtDIENTICH.Text);
                int sogiuong = int.Parse(txtSOGIUONG.Text);
                int giathue = int.Parse(txtGIATHUE.Text);
                if (!Regex.Match(txtMAPHG.Text, "^[0-9]*$").Success)
                {
                    throw new Exception("Mã SV nhập sai");
                }
                if (txtMAPHG.Text.Length != 4)
                {
                    throw new Exception("Mã Phòng nhập sai");
                }

                if (txtMAPHG.Text.Trim() == "")
                {
                    throw new Exception("Mã Phòng không được để trống");
                }

                if (txtTENPHG.Text.Trim() == "")
                {
                    throw new Exception("Tên Phòng không được để trống");
                }


                PHONG p = new PHONG(maphg, TENPHG, dientich, sogiuong, giathue);
                string sql = "INSERT INTO PHONG(maphg,TENPHG,dientich,sogiuong,giathue) VALUES(N'" + maphg + "',N'" + TENPHG + "','" + dientich + "','" + sogiuong + "','" + giathue + "')";
                kn.setData(sql);
                loadPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang_chon = e.RowIndex;
            txtMAPHG.Text = dgvPhong.Rows[hang_chon].Cells["MAPHG"].Value.ToString();
            txtTENPHG.Text = dgvPhong.Rows[hang_chon].Cells["TENPHG"].Value.ToString();
            txtDIENTICH.Text = dgvPhong.Rows[hang_chon].Cells["DIENTICH"].Value.ToString();
            txtSOGIUONG.Text = dgvPhong.Rows[hang_chon].Cells["SOGIUONG"].Value.ToString();
            txtGIATHUE.Text = dgvPhong.Rows[hang_chon].Cells["GIATHUE"].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string maphg = txtMAPHG.Text;
                string TENPHG = txtTENPHG.Text;
                float dientich = float.Parse(txtDIENTICH.Text);
                int sogiuong = int.Parse(txtSOGIUONG.Text);
                int giathue = int.Parse(txtGIATHUE.Text);

                if (!Regex.Match(txtMAPHG.Text, "^[0-9]*$").Success)
                {
                    throw new Exception("Mã SV nhập sai");
                }

                if (txtMAPHG.Text.Length != 4)
                {
                    throw new Exception("Mã Phòng nhập sai");
                }

                if (txtMAPHG.Text.Trim() == "")
                {
                    throw new Exception("Mã Phòng không được để trống");
                }

                if (txtTENPHG.Text.Trim() == "")
                {
                    throw new Exception("Tên Phòng không được để trống");
                }

                PHONG p = new PHONG(maphg, TENPHG, dientich, sogiuong, giathue);
                string sql = "UPDATE PHONG SET TENPHG = N'" + TENPHG + "',DIENTICH = '" + dientich + "',SOGIUONG = '" + sogiuong + "',GIATHUE = '" + giathue + "'WHERE  MAPHG = '" + maphg + "' ";
                kn.setData(sql);
                loadPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maphg = txtMAPHG.Text;
            string sql = "DELETE FROM PHONG WHERE MAPHG='" + maphg + "'";
            kn.setData(sql);
            loadPhong();
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
