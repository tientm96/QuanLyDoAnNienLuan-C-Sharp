
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDANL.DTO
{
    class TaiKhoan
    {
        //  public int TaiKhoanID { get; set; }
        private string _TaiKhoanID;
        public string TaiKhoanID
        {
            get { return _TaiKhoanID; }
            set { _TaiKhoanID = value; }
        }
        //  public string PassWord { get; set; }
        private string _Pass;
        public string Pass
        {
            get { return _Pass; }
            set { _Pass = value; }
        }
        //  public string TaiKhoanGhiChu { get; set; }
        private string _TaiKhoanGhiChu;
        public string TaiKahoanGhiChu
        {
            get { return _TaiKhoanGhiChu; }
            set { _TaiKhoanGhiChu = value; }
        }


    }
}
