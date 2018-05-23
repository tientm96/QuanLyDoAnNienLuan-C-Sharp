

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDANL.DAO;
using QuanLyDANL.DTO;
using System.Data;


namespace QuanLyDANL.BUS
{
    class PhieuDangKyBLL
    {
        //ham get data
        public DataTable GetData() //lay du lieu
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();//tao ket noi
            string strQuery = "select * from PHIEUDANGKI";// table PHIEUDANGKY
            result = config.GetData(strQuery);// form load len thi thuc hien load data
            return result;
        }
        //ham tim kiem
        //public DataTable TimKiem(string chuoi)
        //{
        //    DataTable result = new DataTable();
        //    DataConfig config = new DataConfig();//tao ket noi
        //    string strQuery = "select * from PHIEUDANGKI where MaPhieuDK like'%" + chuoi + "%'";   // tim kiem theo ma
        //    result = config.GetData(strQuery);// form load len thi thuc hien load data
        //    return result;
        //}
        //them csdl
        public int Insert(PhieuDangKy obj)
        {
            int result = 0;
            string strQuery = "insert into PHIEUDANGKI (MaPhieuDK,NgayDK,FK_MaDeTai,FK_MSSV) values ('" + obj.MaPhieuDK + "','" + obj.NgayDK + "','" + obj.MaDeTai + "','" + obj.MSSV + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
        //check ID
        public bool CheckID(string _MaPhieuDK)
        {
            //bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select * from PHIEUDANGKI  where MaPhieuDK='" + _MaPhieuDK + "'";
            DataTable DT = new DataTable();
            DT = config.GetData(strQuery);
            if (DT.Rows.Count > 0)
                return true;
            return false;
        }
        public int Update(PhieuDangKy obj)
        {
            int result = 0;
            string strQuery = "update PHIEUDANGKI set NgayDK='" + obj.NgayDK + "',FK_MaDeTai='" + obj.MaDeTai + "' where MaPhieuDK='" + obj.MaPhieuDK + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
        // xoa
        public int Delete(string _MaPhieuDK)
        {
            int result = 0;
            string strQuery = "delete from PHIEUDANGKI where MaPhieuDK='" + _MaPhieuDK + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
    }
}
