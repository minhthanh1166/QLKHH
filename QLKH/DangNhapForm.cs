using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
using QLKhoHang;

namespace QLBH
{
    public partial class DangNhapForm : Form
    {
        private Dangnhap lg = new Dangnhap();
        
        public DangNhapForm()
        {
            InitializeComponent();
        

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (lg.Check(txtTendangnhap.Text, txtMatkhau.Text))
            {
                this.Hide(); 
                HomeFrom homeFrom = new HomeFrom();
                homeFrom.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            DangkyForm dk = new DangkyForm();
            dk.Show();
            this.Hide();
            
        }

        private void DangnhapFormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Quản Lý ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }
    }
}
