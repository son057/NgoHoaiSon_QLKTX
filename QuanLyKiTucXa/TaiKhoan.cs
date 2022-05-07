using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKiTucXa
{
    public class TaiKhoan
    {
        private string tenTaiKhoan;
        public string TenTaiKhoan 
        { 
            get => tenTaiKhoan; 
            set => tenTaiKhoan = value; 
        }
        

        private string matkhau;

        public string Matkhau 
        { 
            get => matkhau; 
            set => matkhau = value; 
        }


        public TaiKhoan(string tentaikhoan, string matkhau)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.Matkhau = matkhau;
        }

    }
}
