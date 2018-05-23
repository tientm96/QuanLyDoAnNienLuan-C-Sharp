using QuanLyDANL.DAO;
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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btxthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát !", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btxdangnhap_Click(object sender, EventArgs e)
        {
            if (txt_taikhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin tài khoản", "Thông báo");
            }
            else if (txt_matkhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo");
            }
            else
            {
                string userName = txt_taikhoan.Text;
                string passWord = txt_matkhau.Text;
                if (Login(userName, passWord) == true)
                {
                    fManHinh f = new fManHinh();
                    this.Hide();
                    f.ShowDialog();

                    this.Show();
                }
                //NHỚ CHECK CSDL  ???

                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }
            }
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }


        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
