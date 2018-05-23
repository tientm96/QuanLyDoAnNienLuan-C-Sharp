
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDANL.DTO
{
    class DeTai
    {
        //ma de tai
        private string _MaDeTai;
        public string MaDeTai
        {
            get { return _MaDeTai; }
            set { _MaDeTai = value; }
        }
        //ten de tai
        private string _TenDeTai;
        public string TenDeTai
        {
            get { return _TenDeTai; }
            set { _TenDeTai = value; }
        }
        //loai de tai
        private string _LoaiDeTai;
        public string LoaiDeTai
        {
            get { return _LoaiDeTai; }
            set { _LoaiDeTai = value; }
        }
        //ngay ra de tai
        private DateTime _NgayRaDT;
        public DateTime NgayRaDT
        {
            get { return _NgayRaDT; }
            set { _NgayRaDT = value;}
        }
        // ma gv
        private string _MaGV;
        public string MaGV
        {
            get { return _MaGV; }
            set { _MaGV = value; }
        }

    }

}
