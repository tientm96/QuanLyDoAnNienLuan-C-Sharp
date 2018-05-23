
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
    class GiangVienBLL
    {
        //ham get data
        public DataTable GetData() //lay du lieu
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();//tao ket noi
            string strQuery = "select * from GIANGVIEN";// table GIANG VIEN
            result = config.GetData(strQuery);// form load len thi thuc hien load data
            return result;
        }
        ////ham tim kiem
        //public DataTable TimKiem(string chuoi)
        //{
        //    DataTable result = new DataTable();
        //    DataConfig config = new DataConfig();//tao ket noi
        //    string strQuery = "select * from GIANGVIEN Where MaGV like'%" + chuoi + "%' or HoTenGV like '%" + chuoi + "%'";   // tim kiem theo ten va ma
        //    result = config.GetData(strQuery);// form load len thi thuc hien load data
        //    return result;
        //}
        //them csdl
        public int Insert(GiangVien obj)
        {
            int result = 0;
            string strQuery = "insert into GIANGVIEN (MaGV,HoTenGV,MaChucDanh,Phai,Email,SDT,SoDARa,SoDACham) values ('" + obj.MaGV + "',N'" + obj.HoTenGV + "','" + obj.MaChucDanh + "',N'" + obj.Phai + "','" + obj.Email + "','" + obj.SDT + "','" + obj.SoDARa + "','" + obj.SoDACham + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
        //check ID
        public bool CheckID(string _MaGV)
        {
            //bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select * from GIANGVIEN where MaGV='" + _MaGV + "'";
            DataTable DT = new DataTable();
            DT = config.GetData(strQuery);
            if (DT.Rows.Count > 0)
                return true;
            return false;
        }
        public int Update(GiangVien obj)
        {
            int result = 0;
            string strQuery = "update GIANGVIEN set HoTenGV=N'" + obj.HoTenGV + "',MaChucDanh='" + obj.MaChucDanh + "',Phai=N'" + obj.Phai + "',Email='" + obj.Email+ "',SDT='" + obj.SDT + "',SoDARa ='" + obj.SoDARa + "',SoDACham='" + obj.SoDACham+ "' where MaGV='" + obj.MaGV + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
        // xoa
        public int Delete(string _MaGV)
        {
            int result = 0;
            string strQuery = "delete from GIANGVIEN where MaGV='" + _MaGV + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
    }
}
