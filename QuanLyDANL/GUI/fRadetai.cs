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
    public partial class fRadetai : Form
    {
        public fRadetai()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DeTaiBLL Dt = new DeTaiBLL();
            dGVdsDT.DataSource = Dt.GetData();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnradt_Click(object sender, EventArgs e)
        {
            try
            {
                DeTai DT = new DeTai();
                DT.MaDeTai = tbxmadt.Text.Trim();
                DT.TenDeTai = tbxtendt.Text.Trim();
                DT.NgayRaDT = dptngayraDT.Value;
                DT.LoaiDeTai = tbxloaidt.Text.Trim();
                DT.MaGV = tbxmaGV.Text.Trim();
                DeTaiBLL DTBLL = new DeTaiBLL();

                string _MaDeTai = tbxmadt.Text.Trim();
                if (!(DTBLL.CheckID(_MaDeTai)))
                {
                    DTBLL.Insert(DT);
                    LoadData();
                }
                else
                    MessageBox.Show("Mã lớp " + _MaDeTai.ToString() + "đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string _MaDeTai = tbxmadt.Text.Trim();
                PhieuDangKyBLL PDKBLL = new PhieuDangKyBLL();
                PDKBLL.Delete(_MaDeTai);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fRadetai_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dGVdsDT_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbxmadt.Text = dGVdsDT["Column1", index].Value.ToString();
            tbxtendt.Text = dGVdsDT["Column2", index].Value.ToString();
            tbxloaidt.Text = dGVdsDT["Column3", index].Value.ToString();

            dptngayraDT.Text = dGVdsDT["Column4", index].Value.ToString();
            tbxmaGV.Text = dGVdsDT["Column5", index].Value.ToString();

        }
    }
}
