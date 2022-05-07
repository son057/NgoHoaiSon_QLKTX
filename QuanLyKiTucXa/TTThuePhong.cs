using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKiTucXa
{
    class TTTHUEPHONG
    {

        public string MAHD { get; set; }


        public DateTime THANGNAM { get; set; }

        public int SOTIEN { get; set; }


        public DateTime NGAYTHANHTOAN { get; set; }

        public int MANV { get; set; }

        public TTTHUEPHONG() { }

        public TTTHUEPHONG(string MAHD, DateTime THANGNAM, int SOTIEN, DateTime NGAYTHANHTOAN, int MANV)
        {
            this.MAHD = MAHD;
            this.THANGNAM = THANGNAM;
            this.SOTIEN = SOTIEN;
            this.NGAYTHANHTOAN = NGAYTHANHTOAN;
            this.MANV = MANV;
        }
    }
}
