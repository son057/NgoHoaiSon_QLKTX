using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKiTucXa
{
    class NHANVIEN
    {

        public int MANV { get; set; }

        public string HOTEN { get; set; }

        public string DIENTHOAI { get; set; }

        public string GHICHU { get; set; }

        public NHANVIEN() { }

        public NHANVIEN(int MANV, string HOTEN, string DIENTHOAI, string GHICHU)
        {
            this.MANV = MANV;
            this.HOTEN = HOTEN;
            this.DIENTHOAI = DIENTHOAI;
            this.GHICHU = GHICHU;
        }

    }
}
