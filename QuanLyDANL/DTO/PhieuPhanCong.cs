
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDANL.DTO
{
    class PhieuPhanCong
    {
        //ma phieu phan cong
        private string _MaPhieuPC;
        public string MaPhieuPC
        {
            get { return _MaPhieuPC; }
            set { _MaPhieuPC = value; }
        }
        //ngay phan cong
        private DateTime _NgayPC;
        public DateTime NgayPC
        {
            get { return _NgayPC; }
            set { _NgayPC = value; }
        }
        // ma bo mon
        private string _MaChucVu;
        public string MaChucVu
        {
            get { return _MaChucVu; }
            set { _MaChucVu = value; }
        }

     
        //ma quyen do an
        private string _MaQuyenDA;
        public string MaQuyenDA
        {
            get { return _MaQuyenDA; }
            set { _MaQuyenDA = value; }
        }
        //ma gv
        private string _MaGV;
        public string MaGV
        {
            get { return _MaGV; }
            set { _MaGV = value; }
        }

    }
}
