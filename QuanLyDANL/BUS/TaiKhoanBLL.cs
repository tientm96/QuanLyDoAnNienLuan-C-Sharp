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
    class TaiKhoanDLL
    {

        //ham get data
        public DataTable GetData() //lay du lieu
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();//tao ket noi
            string strQuery = "select * from TAIKHOAN";// table DETAI
            result = config.GetData(strQuery);// form load len thi thuc hien load data
            return result;
        }
        ////ham tim kiem
        //public DataTable TimKiem(string chuoi)
        //{
        //    DataTable result = new DataTable();
        //    DataConfig config = new DataConfig();//tao ket noi
        //    string strQuery = "select * from D Where MaDeTai like'%" + chuoi + "%' or TenDeTai like '%" + chuoi + "%'";   // tim kiem theo ten va ma
        //    result = config.GetData(strQuery);// form load len thi thuc hien load data
        //    return result;
        //}
        //them csdl
        public int Insert(TaiKhoan obj)
        {
            int result = 0;
            string strQuery = "insert into TAIKHOAN (TaiKhoanID,Pass,TaiKhoanGhiChu) values ('" + obj.TaiKhoanID + "','" + obj.Pass + "',N'" + obj.TaiKahoanGhiChu + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
        //check ID
        public bool CheckID(string _TaiKhoanID)
        {
            //bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select * from TAIKHOAN where TaiKhoanID ='" + _TaiKhoanID + "'";
            DataTable DT = new DataTable();
            DT = config.GetData(strQuery);
            if (DT.Rows.Count > 0)
                return true;
            return false;
        }
        public int Update(TaiKhoan obj)
        {
            int result = 0;
            string strQuery = "update TAIKHOAN set Pass ='" + obj.Pass + "' where TaiKhoanID =N'" + obj.TaiKhoanID+ "'";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
        // xoa
        public int Delete(string _TaiKhoanID)
        {
            int result = 0;
            string strQuery = "delete from TAIKHOAN where TaiKhoanID ='" + _TaiKhoanID + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
    }
}
