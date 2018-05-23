
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDANL.DTO
{
    class BoMon
    {
        // ma bo mon
        private string _MaChucVu;
        public string MaChucVu
        {
            get { return _MaChucVu; }
            set { _MaChucVu = value; }
        }
        //ten bo mon
        private string _ChucVu;
        public string ChucVu
        {
            get { return _ChucVu; }
            set { _ChucVu = value; }
        }
        //ten bo mon
        private string _TenCanBo;
        public string TenCanBo
        {
            get { return _TenCanBo; }
            set { _TenCanBo = value; }
        }
    }
}
