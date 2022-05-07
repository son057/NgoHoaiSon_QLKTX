using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKiTucXa
{
    class PHONG
    {

        public string MAPHG { get; set; }

        public string TENPHG { get; set; }

        public float DIENTICH { get; set; }

        public int SOGIUONG { get; set; }

        public int GIATHUE { get; set; }

        public PHONG() { }

        public PHONG(string MAPHG, string TENPHG, float DIENTICH, int SOGIUONG, int GIATHUE)
        {
            this.MAPHG = MAPHG;
            this.TENPHG = TENPHG;
            this.DIENTICH = DIENTICH;
            this.SOGIUONG = SOGIUONG;
            this.GIATHUE = GIATHUE;
        }
    }
}
