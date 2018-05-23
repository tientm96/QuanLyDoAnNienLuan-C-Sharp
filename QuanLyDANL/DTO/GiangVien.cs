
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDANL.DTO
{
    class GiangVien
    {
        //ma giang vien
        private string _MaGV;
        public string MaGV
        {
            get { return _MaGV; }
            set { _MaGV = value; }
        }
        //Ho ten giang vien
        private string _HoTenGV;
        public string HoTenGV
        {
            get { return _HoTenGV; }
            set { _HoTenGV = value; }
        }

        // gioi tinh gv
        private string _Phai;
        public string Phai
        {
            get { return _Phai; }
            set { _Phai = value; }
        }
        // Email giang vien
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        // Std gv
        private string _SDT;
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        //ma chuc danh
        private string _MaChucDanh;
        public string MaChucDanh
        {
            get { return _MaChucDanh; }
            set { _MaChucDanh = value; }
        }
        // so do an ra
        private int _SoDARa;
        public int SoDARa
        {
            get { return _SoDARa; }
            set { _SoDARa = value; }
        }
        // so do an cham
        private int _SoDACham;
        public int SoDACham
        {
            get { return _SoDACham; }
            set { _SoDACham = value; }
        }

    }
}
