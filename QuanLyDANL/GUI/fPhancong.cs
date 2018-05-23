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
    public partial class fPhancong : Form
    {
        public fPhancong()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dGVdsQDA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fPhancong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            PhieuPhanCongBLL PPC = new PhieuPhanCongBLL();
            dGVdsphieupc.DataSource = PPC.GetData();
        }



        //thêm
        //    int index = e.RowIndex;
        //    tbxmssv1.Text = dGVdsphieudangky["Column5", index].Value.ToString();
        //    tbxmapdk.Text = dGVdsphieudangky["Column1", index].Value.ToString();
        //    tbxmaquyenda.Text = dGVdsphieudangky["Column2", index].Value.ToString();

        //    dtpngaydkdt.Text = dGVdsphieudangky["Column4", index].Value.ToString();
        //    tbxmadt.Text = dGVdsphieudangky["Column3", index].Value.ToString();


        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuPhanCong PPC = new PhieuPhanCong();
                PPC.MaPhieuPC = tbxmaphieuphancong.Text.Trim();
                PPC.NgayPC = dtpngayphancong.Value;
                PPC.MaGV = tbxmaGV.Text.Trim();
                PPC.MaQuyenDA = tbxmaquyendoan.Text.Trim();
                PPC.MaChucVu = tbxmachucvu.Text.Trim();
                PhieuPhanCongBLL PPCBLL = new PhieuPhanCongBLL();

                string _MaPhieuPC = tbxmaphieuphancong.Text.Trim();
                if (!(PPCBLL.CheckID(_MaPhieuPC)))
                {
                    PPCBLL.Insert(PPC);
                    LoadData();
                }
                else
                    MessageBox.Show("Mã phieu phan cong " + _MaPhieuPC.ToString() + "đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string _MaPhieuPC = tbxmaphieuphancong.Text.Trim();
                PhieuPhanCongBLL PPCBLL = new PhieuPhanCongBLL();
                PPCBLL.Delete(_MaPhieuPC);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuPhanCong PPC = new PhieuPhanCong();
                PPC.MaPhieuPC = tbxmaphieuphancong.Text.Trim();
                PPC.NgayPC = dtpngayphancong.Value;
                PPC.MaGV = tbxmaGV.Text.Trim();
                PPC.MaQuyenDA = tbxmaquyendoan.Text.Trim();
                PPC.MaChucVu = tbxmachucvu.Text.Trim();

                PhieuPhanCongBLL PPCBLL = new PhieuPhanCongBLL();

                string _MaPhieuPC = tbxmaphieuphancong.Text.Trim();
                PPCBLL.Update(PPC);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dGVdsphieupc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbxmaphieuphancong.Text = dGVdsphieupc["Column1", index].Value.ToString();
            dtpngayphancong.Text = dGVdsphieupc["Column2", index].Value.ToString();
            tbxmaGV.Text = dGVdsphieupc["Column3", index].Value.ToString();
            tbxmachucvu.Text = dGVdsphieupc["Column4", index].Value.ToString();
            tbxmaquyendoan.Text = dGVdsphieupc["Column5", index].Value.ToString();

        }
    }
}
