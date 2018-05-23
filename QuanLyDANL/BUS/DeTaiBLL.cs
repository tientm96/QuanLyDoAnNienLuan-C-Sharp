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
    class DeTaiBLL
    {
        //ham get data
        public DataTable GetData() //lay du lieu
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();//tao ket noi
            string strQuery = "select * from DETAI";// table DETAI
            result = config.GetData(strQuery);// form load len thi thuc hien load data
            return result;
        }
        //ham tim kiem
        public DataTable TimKiem(string chuoi)
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();//tao ket noi
            string strQuery = "select * from DETAI Where MaDeTai like'%" + chuoi + "%' or TenDeTai like '%" + chuoi + "%'";   // tim kiem theo ten va ma
            result = config.GetData(strQuery);// form load len thi thuc hien load data
            return result;
        }
     //them csdl
        public int Insert(DeTai obj)
        {
            int result = 0;
            string strQuery = "insert into DETAI (MaDeTai,TenDeTai,LoaiDeTai,NgayRaDT,FK_MaGV) values ('" + obj.MaDeTai + "',N'" + obj.TenDeTai + "',N'" + obj.LoaiDeTai + "','" + obj.NgayRaDT + "','" + obj.MaGV + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
        //check ID
        public bool CheckID(string _MaDeTai)
        {
            //bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select * from DETAI where MaDeTai='" + _MaDeTai + "'";
            DataTable DT = new DataTable();
            DT = config.GetData(strQuery);
            if (DT.Rows.Count > 0)
                return true;
            return false;
        }
        public int Update(DeTai obj)
        {
            int result = 0;
            string strQuery = "update DETAI set TenDeTai=N'" + obj.TenDeTai + "',LoaiDeTai=N'" + obj.LoaiDeTai + "',NgayRaDT='" + obj.NgayRaDT + "',FK_MaGV='" + obj.MaGV + "' where MaDeTai='" + obj.MaDeTai + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
        // xoa
        public int Delete(string _MaDeTai)
        {
            int result = 0;
            string strQuery = "delete from DETAI where MaDeTai='" + _MaDeTai + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
    }
}
