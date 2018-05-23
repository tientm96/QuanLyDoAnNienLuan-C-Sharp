
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDANL.DTO
{
    class QuyenDoAn
    {
        //ma quyen do an
        private string _MaQuyenDA;
        public string MaQuyenDA
        {
            get { return _MaQuyenDA; }
            set { _MaQuyenDA = value; }
        }
        //ngay nop
        private DateTime _NgayNop;
        public DateTime NgayNop
        {
            get { return _NgayNop; }
            set { _NgayNop = value; }
        }
        //diem quyen do an
        private string _DiemDA;
        public string DiemDA
        {
            get { return _DiemDA; }
            set { _DiemDA = value; }
        }
        //nhan xet
        private string _NhanXet;
        public string NhanXet
        {
            get { return _NhanXet; }
            set { _NhanXet = value; }
        }
       
        //ma phieu dang ky
        private string _MaPhieuDK;
        public string MaPhieuDK
        {
            get { return _MaPhieuDK; }
            set { _MaPhieuDK = value; }
        }
    }
}

