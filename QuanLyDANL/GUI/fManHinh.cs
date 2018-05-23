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
    public partial class fManHinh : Form
    {
        public fManHinh()
        {
            InitializeComponent();
        }

        private void fManHinh_Load(object sender, EventArgs e)
        {
            //Đổ dữ liệu vào cho ComboBox
            cmbox_timtheo.Items.Add("Mã");
            cmbox_timtheo.Items.Add("Tên");

            cbxGTGV.Items.Add("Nam");
            cbxGTGV.Items.Add("Nữ");

            cbxGTSV.Items.Add("Nam");
            cbxGTSV.Items.Add("Nữ");

            LoadDataDeTai();
            LoadDataGiangVien();
            LoadDataSinhVien();

            //cbxGTGV.SelectedIndex = 0;

        }
        private void LoadDataDeTai()
        {
            DeTaiBLL Dt = new DeTaiBLL();
            dgvdanhsachdetai.DataSource = Dt.GetData();
          }
        private void LoadDataGiangVien()
        {
            GiangVienBLL Dt = new GiangVienBLL();
            dGvdsGV.DataSource = Dt.GetData();
        }
        private void LoadDataSinhVien()
        {
            SinhVienBLL Dt = new SinhVienBLL();
            dgvdsSV.DataSource = Dt.GetData();
        }
        private void btnthemgv_Click(object sender, EventArgs e)
        {
            try
            {
                GiangVien GV = new GiangVien();
                GV.MaGV = tbxmagv.Text.Trim();
                GV.HoTenGV = tbxtengv.Text.Trim();
                GV.Phai = cbxGTGV.Text.Trim();
                GV.MaChucDanh = tbxmachucdanh.Text.Trim();
                GV.SDT = tbxsdtgv.Text.Trim();
                GV.Email = tbxemailgv.Text.Trim();
                GV.SoDARa = int.Parse(nUDraDT.Value.ToString());
                GV.SoDACham = int.Parse(nUDhhuongdan.Value.ToString());
                GiangVienBLL GVBLL = new GiangVienBLL();
                string _MaGV = tbxmagv.Text.Trim();
                if (!(GVBLL.CheckID(_MaGV)))
                {
                    GVBLL.Insert(GV);
                    LoadDataGiangVien();
                }
                else
                    MessageBox.Show("Mã lớp " + _MaGV.ToString() + "đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void listV_dsGv_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        
        //CẬP NHẬT
        private void btncapnhatgv_Click(object sender, EventArgs e)
        {
            try
            {
                GiangVien GV = new GiangVien();
                GV.MaGV = tbxmagv.Text.Trim();
                GV.HoTenGV = tbxtengv.Text.Trim();
                GV.Phai = cbxGTGV.Text.Trim();
                GV.MaChucDanh = tbxmachucdanh.Text.Trim();
                GV.SDT = tbxsdtgv.Text.Trim();
                GV.Email = tbxemailgv.Text.Trim();
                GV.SoDARa = int.Parse(nUDraDT.Value.ToString());
                GV.SoDACham = int.Parse(nUDhhuongdan.Value.ToString());
                GiangVienBLL GVBLL = new GiangVienBLL();

                string _MaPhieuDK = tbxmagv.Text.Trim();
                GVBLL.Update(GV);
                LoadDataGiangVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //XÓA
        private void btnxoagv_Click(object sender, EventArgs e)
        {
            try
            {
                string _MaGV = tbxmagv.Text.Trim();
                GiangVienBLL PDKBLL = new GiangVienBLL();
                PDKBLL.Delete(_MaGV);
                LoadDataGiangVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btntaikhoan_Click(object sender, EventArgs e)
        {
          
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            this.Hide();
            fThongke f = new fThongke();
            f.ShowDialog();
            this.Show();
        }

        private void btntaikhoan_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            fTaikhoan f = new fTaikhoan();
            f.ShowDialog();

            this.Show();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDangky f = new fDangky();
            f.ShowDialog();
            this.Show();
        }

        private void btnradt_Click(object sender, EventArgs e)
        {
            this.Hide();
            fRadetai f = new fRadetai();
            f.ShowDialog();
            this.Show();
        }

        private void btnphancong_Click(object sender, EventArgs e)
        {
            this.Hide();
            fPhancong f = new fPhancong();
            f.ShowDialog();
            this.Show();
        }

        private void btndanhgia_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDanhgia f = new fDanhgia();
            f.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            fQuyendoan f = new fQuyendoan();
            f.ShowDialog();
            this.Show();
        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void btnphancong_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            fPhancong f = new fPhancong();
            f.ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dgvdanhsachdetai_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbxmadetai.Text = dgvdanhsachdetai["Column1", index].Value.ToString();
            tbxtendt.Text = dgvdanhsachdetai["Column5", index].Value.ToString();
            dtpngayradetai.Text = dgvdanhsachdetai["Column3", index].Value.ToString();
            tbxgvradt.Text = dgvdanhsachdetai["Column4", index].Value.ToString();
            tbxloaidetai.Text = dgvdanhsachdetai["Column2", index].Value.ToString();
        }

        private void dtGdsGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbxmagv.Text = dGvdsGV["Column13", index].Value.ToString();
            tbxtengv.Text = dGvdsGV["Column14", index].Value.ToString();
            cbxGTGV.Text = dGvdsGV["Column15", index].Value.ToString();
            tbxemailgv.Text = dGvdsGV["Column16", index].Value.ToString();

            tbxsdtgv.Text = dGvdsGV["Column17", index].Value.ToString();
            tbxmachucdanh.Text = dGvdsGV["Column18", index].Value.ToString();
            nUDhhuongdan.Text = dGvdsGV["Column19", index].Value.ToString();
            nUDraDT.Text = dGvdsGV["Column20", index].Value.ToString();
        }

        private void dGvdsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvsv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tbxmssv.Text = dgvdsSV["Column6", index].Value.ToString();
            tbxtensv.Text = dgvdsSV["Column7", index].Value.ToString();

            dtpngaysinh.Text = dgvdsSV["Column8", index].Value.ToString();
            cbxGTSV.Text = dgvdsSV["Column9", index].Value.ToString();
            tbxkhoa.Text = dgvdsSV["Column10", index].Value.ToString();
            tbxemailsv.Text = dgvdsSV["Column11", index].Value.ToString();
            tbxsdtsv.Text = dgvdsSV["Column12", index].Value.ToString();
        }
        // thêm sinh viên
        private void btnthemsv_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien SV = new SinhVien();
                SV.MSSV = tbxmssv.Text.Trim();
                SV.HoTen = tbxtensv.Text.Trim();
                SV.NgaySinh = dtpngaysinh.Value;
                SV.Phai = cbxGTSV.Text.Trim();
                SV.Khoa = tbxkhoa.Text.Trim();
                SV.SDT = tbxsdtsv.Text.Trim();
                SV.Email = tbxemailsv.Text.Trim();
              
                SinhVienBLL SVBLL = new SinhVienBLL();
                string _MSSV = tbxmssv.Text.Trim();
                if (!(SVBLL.CheckID(_MSSV)))
                {
                    SVBLL.Insert(SV);
                    LoadDataSinhVien();
                }
                else
                    MessageBox.Show("Mã sinh viên " + _MSSV.ToString() + "đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // tìm kiếm đề tài
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string _TimKiem = tbxtimkiem.Text.Trim();
            DeTaiBLL DTBLL = new DeTaiBLL();
            dgvdanhsachdetai.DataSource = DTBLL.TimKiem(_TimKiem);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string _TimKiem = tbxtimkiem.Text.Trim();
            DeTaiBLL DTBLL = new DeTaiBLL();
            dgvdanhsachdetai.DataSource = DTBLL.TimKiem(_TimKiem);
        }
        // xóa sinh viên
        private void btnxoasv_Click(object sender, EventArgs e)
        {
            try
            {
                string _MSSV = tbxmssv.Text.Trim();
                SinhVienBLL SVBLL = new SinhVienBLL();
                SVBLL.Delete(_MSSV);
                LoadDataSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        // cập nhật sinh viên
        private void btncapnhatsv_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien SV = new SinhVien();
                SV.MSSV = tbxmssv.Text.Trim();
                SV.HoTen = tbxtensv.Text.Trim();
                SV.Phai = cbxGTSV.Text.Trim();
                SV.NgaySinh = dtpngaysinh.Value;
                SV.Khoa = tbxkhoa.Text.Trim();
                SV.SDT = tbxsdtsv.Text.Trim();
                SV.Email = tbxemailsv.Text.Trim();


                SinhVienBLL SVBLL = new SinhVienBLL();

                string _MSSV = tbxmssv.Text.Trim();
                SVBLL.Update(SV);

                LoadDataSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
