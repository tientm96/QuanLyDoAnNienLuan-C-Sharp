using QuanLyDANL.BUS;
using QuanLyDANL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDANL
{
    public partial class fTaikhoan : Form
    {
        public fTaikhoan()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btxthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btxthem_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan TK = new TaiKhoan();
                TK.TaiKhoanID = tbxtkid.Text.Trim();
                TK.Pass = tbxpassold.Text.Trim();
                TK.TaiKahoanGhiChu = tbxghichu.Text.Trim();
                TaiKhoanDLL TKBLL = new TaiKhoanDLL();
                string _TaiKhoanID = tbxtkid.Text.Trim();
                if (!(TKBLL.CheckID(_TaiKhoanID)))
                {
                    TKBLL.Insert(TK);
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Mã lớp " + _TaiKhoanID.ToString() + "đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btxthaydoi_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan TK = new TaiKhoan();
                TK.Pass = tbxpassold.Text.Trim();

                TaiKhoanDLL TKBLL = new TaiKhoanDLL();

                string _TaiKhoanID = tbxtkid.Text.Trim();
                TKBLL.Update(TK);

                MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa bị lỗi: " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fTaikhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
