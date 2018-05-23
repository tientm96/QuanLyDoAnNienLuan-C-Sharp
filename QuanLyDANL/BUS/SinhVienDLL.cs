
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
    class SinhVienBLL
    {
        //ham get data
        public DataTable GetData() //lay du lieu
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();//tao ket noi
            string strQuery = "select * from SINHVIEN";// table SINHVIEN
            result = config.GetData(strQuery);// form load len thi thuc hien load data
            return result;
        }
        ////ham tim kiem
        //public DataTable TimKiem(string chuoi)
        //{
        //    DataTable result = new DataTable();
        //    DataConfig config = new DataConfig();//tao ket noi
        //    string strQuery = "select * from SINHVIEN Where MSSV like'%" + chuoi + "%' or HoTen like '%" + chuoi + "%'";   // tim kiem theo ten va ma
        //    result = config.GetData(strQuery);// form load len thi thuc hien load data
        //    return result;
        //}
        //them csdl
        public int Insert(SinhVien obj)
        {
            int result = 0;
            string strQuery = "insert into SINHVIEN (MSSV,HoTen,NgaySinh,Phai,Email,SDT,Khoa) values ('" + obj.MSSV + "',N'" + obj.HoTen + "','" + obj.NgaySinh + "',N'" + obj.Phai + "','" + obj.Email+ "','" + obj.SDT + "',N'" + obj.Khoa + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
        //check ID
        public bool CheckID(string _MSSV)
        {
            //  bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select * from SINHVIEN where MSSV='" + _MSSV + "'";
            DataTable DT = new DataTable();
            DT = config.GetData(strQuery);
            if (DT.Rows.Count > 0)
                return true;
            return false;
        }
        public int Update(SinhVien obj)
        {
            int result = 0;
            string strQuery = "update SINHVIEN set HoTen=N'" + obj.HoTen + "',NgaySinh='" + obj.NgaySinh + "',Phai=N'" + obj.Phai + "',Email='" + obj.Email + "',SDT='" + obj.SDT + "' where MSSV='" + obj.MSSV + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
        // xoa
        public int Delete(string _MSSV)
        {
            int result = 0;
            string strQuery = "delete from SINHVIEN where MSSV='" + _MSSV + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
    }
}
