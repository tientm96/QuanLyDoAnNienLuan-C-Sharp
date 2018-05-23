
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
    class PhieuPhanCongBLL
    {

        //ham get data
        public DataTable GetData() //lay du lieu
        {
            DataTable result = new DataTable();
            DataConfig config = new DataConfig();//tao ket noi
            string strQuery = "select * from PHIEUPHANCONG";// table PHIEUPHANCONG
            result = config.GetData(strQuery);// form load len thi thuc hien load data
            return result;
        }
        ////ham tim kiem
        //public DataTable TimKiem(string chuoi)
        //{
        //    DataTable result = new DataTable();
        //    DataConfig config = new DataConfig();//tao ket noi
        //    string strQuery = "select * from PHIEUPHANCONG Where MaPhieuPC like'%" + chuoi + "%'";   // tim kiem theo ma
        //    result = config.GetData(strQuery);// form load len thi thuc hien load data
        //    return result;
        //}
        //them csdl
        public int Insert(PhieuPhanCong obj)
        {
            int result = 0;
            string strQuery = "insert into PHIEUPHANCONG (MaPhieuPC,NgayPC,FK_MaQuyenDA,FK_MaGV,FK_MaChucVu) values ('" + obj.MaPhieuPC 
                                + "','" + obj.NgayPC + "','" + obj.MaQuyenDA + "','" + obj.MaGV + "','" + obj.MaChucVu + "')";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
        //check ID
        public bool CheckID(string _MaPhieuPC)
        {
            //bool result = true;
            DataConfig config = new DataConfig();
            string strQuery = "select * from PHIEUPHANCONG where MaPhieuPC='" + _MaPhieuPC + "'";
            DataTable DT = new DataTable();
            DT = config.GetData(strQuery);
            if (DT.Rows.Count > 0)
                return true;
            return false;
        }
        public int Update(PhieuPhanCong obj)
        {
            int result = 0;
            string strQuery = "update PHIEUPHANCONG set NgayPC='" + obj.NgayPC + "',FK_MaQuyenDA='" + obj.MaQuyenDA + "',FK_MaGV='" + obj.MaGV + "',FK_MaChucVu='" + obj.MaChucVu + "' where MaPhieuPC='" + obj.MaPhieuPC + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
        // xoa
        public int Delete(string _MaPhieuPC)
        {
            int result = 0;
            string strQuery = "delete from PHIEUPHANCONG where MaPhieuPC='" + _MaPhieuPC + "'";
            DataConfig config = new DataConfig();
            result = config.excuteNoneQuery(strQuery);
            return result; //tra ve so ghi nhan thuc hien
        }
    }
}
