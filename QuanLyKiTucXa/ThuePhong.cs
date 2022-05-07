using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKiTucXa
{
    class THUEPHONG
    {


        public string MAHD { get; set; }

        public string MSSV { get; set; }

        public string MAPHG { get; set; }

        public DateTime NGAYVAO { get; set; }

        public DateTime NGAYRA { get; set; }

        public int TIENDATCOC { get; set; }


        public int GIATHUE { get; set; }



        public THUEPHONG() { }

        public THUEPHONG(string MAHD, string MSSV, string MAPHG, DateTime NGAYVAO, DateTime NGAYRA, int TIENDATCOC, int GIATHUE)
        {
            this.MAHD = MAHD;
            this.MSSV = MSSV;
            this.MAPHG = MAPHG;
            this.NGAYVAO = NGAYVAO;
            this.NGAYRA = NGAYRA;
            this.TIENDATCOC = TIENDATCOC;
            this.GIATHUE = GIATHUE;
        }

	}
}
