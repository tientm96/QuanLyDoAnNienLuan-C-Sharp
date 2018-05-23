using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDANL.BUS;
using QuanLyDANL.DTO;
namespace QuanLyDANL
{
    public partial class fQuyendoan : Form
    {
        public fQuyendoan()
        {
            InitializeComponent();
        }

       
        private void fQuyendoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            QuyenDoAnBLL QDABLL = new QuyenDoAnBLL();
            dGVdsQDA.DataSource =QDABLL.GetData();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnnop_Click(object sender, EventArgs e)
        {
            try
            {
                QuyenDoAn QDA = new QuyenDoAn();
                QDA.MaQuyenDA = tbxmaQDA.Text.Trim();
                QDA.MaPhieuDK = tbxmaPDK.Text.Trim();
                QDA.NgayNop = dTPngaynop.Value;
                QDA.DiemDA = tbxdiemda.Text.Trim();  //h
                QDA.NhanXet = tbxnhanxet.Text.Trim();  //f
                QuyenDoAnBLL QDABLL = new QuyenDoAnBLL();
                string _MaQuyenDA = tbxmaQDA.Text.Trim();
                if (!(QDABLL.CheckID(_MaQuyenDA)))
                {
                    QDABLL.Insert(QDA);
                    LoadData();
                }
                else
                    MessageBox.Show("Mã quyen do an " + _MaQuyenDA.ToString() + "đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //CẬP NHẬT-SỬA
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                QuyenDoAn QDA = new QuyenDoAn();
                QDA.MaQuyenDA = tbxmaQDA.Text.Trim();
                QDA.MaPhieuDK = tbxmaPDK.Text.Trim();
                QDA.NgayNop = dTPngaynop.Value;


                QuyenDoAnBLL QDABLL = new QuyenDoAnBLL();

                string _MaQuyenDA = tbxmaQDA.Text.Trim();
                QDABLL.Update(QDA);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sua bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string _MaQuyenDA = tbxmaQDA.Text.Trim();
                QuyenDoAnBLL QDABLL = new QuyenDoAnBLL();
                QDABLL.Delete(_MaQuyenDA);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dGVdsQDA_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbxmaQDA.Text = dGVdsQDA["Column1", index].Value.ToString();
            dTPngaynop.Text = dGVdsQDA["Column2", index].Value.ToString();
            tbxmaPDK.Text = dGVdsQDA["Column5", index].Value.ToString();

        }
    }
}
