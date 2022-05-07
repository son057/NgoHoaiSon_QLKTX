using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKiTucXa
{
    class SINHVIEN
    {
        public string MSSV { get; set; }

        public string HOTEN { get; set; }

        public string GIOITINH { get; set; }

        public string DIENTHOAI { get; set; }

        public int MALOP { get; set; }

        public DateTime NGAYVAOKTX { get; set; }

        public DateTime NGAYRAKTX { get; set; }


        public SINHVIEN() { }

        public SINHVIEN(string MSSV, string HOTEN, string GIOITINH, string DIENTHOAI, int MALOP, DateTime NGAYVAOKTX, DateTime NGAYRAKTX)
        {
            this.MSSV = MSSV;
            this.HOTEN = HOTEN;
            this.GIOITINH = GIOITINH;
            this.DIENTHOAI = DIENTHOAI;
            this.MALOP = MALOP;
            this.NGAYVAOKTX = NGAYVAOKTX;
            this.NGAYRAKTX = NGAYRAKTX;
        }
    }
}
