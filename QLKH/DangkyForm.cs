using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using QLBH;

namespace QLKhoHang
{
    public partial class DangkyForm : Form
    {
        private Dangky dk = new Dangky(); 
        public DangkyForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DangkyFormClosing(object sender, FormClosedEventArgs e)
        {
           Application.ExitThread();
        }
        
        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            dk.checkDk(txtTendangnhap.Text, txtMatkhau.Text);
            DangNhapForm dn = new DangNhapForm();
            dn.Show();
            this.Hide();
        }

        private void DangkyFormClosing(object sender, FormClosingEventArgs e)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DangNhapForm dn = new DangNhapForm();
            dn.Show();
            this.Hide();
        }
    }
}
