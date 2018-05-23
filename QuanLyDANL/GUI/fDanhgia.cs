using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDANL.DTO;
using QuanLyDANL.BUS;


namespace QuanLyDANL
{
    public partial class fDanhgia : Form
    {
        public fDanhgia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGVdsQDA_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbxmaQDA.Text = dGVdsPPC["Column5", index].Value.ToString();
            tbxmaGV.Text = dGVdsPPC["Column3", index].Value.ToString();
        }

        private void fDanhgia_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void LoadData()
        {
            PhieuPhanCongBLL PPCBLL = new PhieuPhanCongBLL();
            dGVdsPPC.DataSource = PPCBLL.GetData();
        }

        private void btnchamdiem_Click(object sender, EventArgs e)
        {
            try
            {
                QuyenDoAn QDA = new QuyenDoAn();
                QDA.MaQuyenDA = tbxmaQDA.Text.Trim();
                QDA.DiemDA = tbxdiemDA.Text.Trim();
                QDA.NhanXet = tbxnhanxet.Text.Trim();
              //  QDA.NgayNop = dtpngaynop.Value;//
              //  QDA.DiemDA = tbxnhanxet.Text.Trim();//
              //  QDA.NhanXet = tbxnhanxet.Text.Trim();//
                QuyenDoAnBLL QDABLL = new QuyenDoAnBLL();

                string _MaQuyenDA = tbxmaQDA.Text.Trim();
                QDABLL.Update(QDA);
               // LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cham Diem bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                QuyenDoAn QDA = new QuyenDoAn();
                QDA.MaQuyenDA = tbxmaQDA.Text.Trim();
                QDA.DiemDA = tbxdiemDA.Text.Trim();
                QDA.NhanXet = tbxnhanxet.Text.Trim();

                QuyenDoAnBLL QDABLL = new QuyenDoAnBLL();

                string _MaQuyenDA = tbxmaQDA.Text.Trim();
                QDABLL.Update(QDA);
              //  LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sua bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dGVdsPPC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
