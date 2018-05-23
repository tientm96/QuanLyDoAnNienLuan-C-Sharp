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
    public partial class fDangky : Form
    {
        public fDangky()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dGVdsdetai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fDangky_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            PhieuDangKyBLL Dt = new PhieuDangKyBLL();
            dGVdsphieudangky.DataSource = Dt.GetData();
        }

        private void dGVdsphieudangky_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbxmssv.Text = dGVdsphieudangky["Column1", index].Value.ToString();
            tbxmapdk.Text = dGVdsphieudangky["Column2", index].Value.ToString();
            dtpngaydkdt.Text = dGVdsphieudangky["Column4", index].Value.ToString();
            tbxmadt.Text = dGVdsphieudangky["Column3", index].Value.ToString();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuDangKy PDK = new PhieuDangKy();
                PDK.MaPhieuDK = tbxmapdk.Text.Trim();
                PDK.MaDeTai = tbxmadt.Text.Trim();
                
                PDK.NgayDK = dtpngaydkdt.Value;
                PDK.MSSV = tbxmssv.Text.Trim();
                PhieuDangKyBLL PDKBLL = new PhieuDangKyBLL();
                string _MaPhieuDK = tbxmapdk.Text.Trim();
                if (!(PDKBLL.CheckID(_MaPhieuDK)))
                {
                    PDKBLL.Insert(PDK);
                    LoadData();
                }
               else
                    MessageBox.Show("Mã lớp " + _MaPhieuDK.ToString()+"đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }



            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuDangKy PDK = new PhieuDangKy();
                PDK.MaPhieuDK = tbxmapdk.Text.Trim();
                PDK.MaDeTai = tbxmadt.Text.Trim();
              
                PDK.NgayDK = dtpngaydkdt.Value;
                PDK.MSSV = tbxmssv.Text.Trim();
                PhieuDangKyBLL PDKBLL = new PhieuDangKyBLL();
               
                string _MaPhieuDK = tbxmapdk.Text.Trim();
                PDKBLL.Update(PDK);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string _MaPhieuDK = tbxmapdk.Text.Trim();
                PhieuDangKyBLL PDKBLL = new PhieuDangKyBLL();
                PDKBLL.Delete(_MaPhieuDK);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
