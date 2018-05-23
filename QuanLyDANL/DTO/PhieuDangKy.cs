
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDANL.DTO
{
    class PhieuDangKy
    {
        //mssv
        private string _MSSV;
        public string MSSV
        {
            get { return _MSSV; }
            set { _MSSV = value; }
        }

        //ma phieu dang ky
        private string _MaPhieuDK;
        public string MaPhieuDK
        {
            get { return _MaPhieuDK; }
            set { _MaPhieuDK = value; }
        }
        //ngay dang ky
        private DateTime _NgayDK;
        public DateTime NgayDK
        {
            get { return _NgayDK; }
            set { _NgayDK = value; }
        }
        //ma de tai
        private string _MaDeTai;
        public string MaDeTai
        {
            get { return _MaDeTai; }
            set { _MaDeTai = value; }
        }
       
    }
}
