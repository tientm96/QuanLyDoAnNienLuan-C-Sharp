
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDANL.DTO
{
    class SinhVien
    {
        //MSSV
        private string _MSSV;
        public string MSSV
        {
            get { return _MSSV; }
            set { _MSSV = value; }
        }
        //Ho ten sinh vien
        private string _HoTen;
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        // ngay sinh sv
        private DateTime _NgaySinh;
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        // gioi tinh sv
        private string _Phai;
        public string Phai
        {
            get { return _Phai; }
            set { _Phai = value; }
        }
        // khoa sv
        private string _Khoa;
        public string Khoa
        {
            get { return _Khoa; }
            set { _Khoa = value; }
        }
        // Email sinh vien
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        // Std sv
        private string _SDT;
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

    }
}
