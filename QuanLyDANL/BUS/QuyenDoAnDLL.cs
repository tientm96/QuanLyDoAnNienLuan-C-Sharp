
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
    class QuyenDoAnBLL
    {
        //ham get data
        public DataTable GetData() //lay du lieu
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();//tao ket noi
            string strQuery = "select * from QUYENDOAN";// table DETAI
            result = config.GetData(strQuery);// form load len thi thuc hien load data
            return result;
        }
        ////ham tim kiem
        //public DataTable TimKiem(string chuoi)
        //{
        //    DataTable result = new DataTable();
        //    DataConfig config = new DataConfig();//tao ket noi
        //    string strQuery = "select * from QUYENDOAN Where MaQuyenDA like'%" + chuoi + "%'";   // tim kiem theo ma
        //    result = config.GetData(strQuery);// form load len thi thuc hien load data
        //    return result;
        //}
        //them csdl
        public int Insert(QuyenDoAn obj)
        {
            int result = 0;
            string strQuery = "insert into QUYENDOAN (MaQuyenDA,NgayNop,NhanXet,DiemDA,FK_MaPhieuDK) values ('" + obj.MaQuyenDA+ "','" + obj.NgayNop + "',N'" + obj.NhanXet + "','" + obj.DiemDA + "','" + obj.MaPhieuDK + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
        //check ID
        public bool CheckID(string _MaQuyenDA)
        {
            //bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select * from QUYENDOAN  where MaQuyenDA='" + _MaQuyenDA + "'";
            DataTable DT = new DataTable();
            DT = config.GetData(strQuery);
            if (DT.Rows.Count > 0)
                return true;
            return false;
        }
        public int Update(QuyenDoAn obj)
        {
            int result = 0;
            string strQuery = "update QUYENDOAN set NgayNop='" + obj.NgayNop + "',DiemDA='" + obj.DiemDA + "',NhanXet=N'" + obj.NhanXet + "',FK_MaPhieuDK='" + obj.MaPhieuDK + "' where MaQuyenDA='" + obj.MaQuyenDA + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
        // xoa
        public int Delete(string _MaQuyenDA)
        {
            int result = 0;
            string strQuery = "delete from QUYENDOAN where MaQuyenDA='" + _MaQuyenDA + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
    }
}
