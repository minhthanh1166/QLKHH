using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH;

namespace QLKhoHang
{
    public partial class HomeFrom : Form
    {
        public HomeFrom()
        {
            InitializeComponent();
        }

        private void DangkyTK_Click(object sender, EventArgs e)
        {
            DangkyForm dk = new DangkyForm();
            dk.Show();
            this.Hide();
        }

        private void HomeFormClosing(object sender, FormClosingEventArgs e)
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

        private void HanghoaForm_Click(object sender, EventArgs e)
        {
            HangHoaForm hh = new HangHoaForm();
            hh.Show();
            this.Hide();
        }

        private void NCCForm_Click(object sender, EventArgs e)
        {
            NhaCungCapForm Ncc = new NhaCungCapForm();
            Ncc.Show();
            this.Hide();
        }

        private void LoaisanphamForm_Click(object sender, EventArgs e)
        {
            LoaiSP_Form sp = new LoaiSP_Form();
            sp.Show();
            this.Hide();
        }

        private void KhohangForm_Click(object sender, EventArgs e)
        {
            KhoHangForm kh = new KhoHangForm();
            kh.Show();
            this.Hide();
        }

        private void PhieunhapForm_Click(object sender, EventArgs e)
        {
            P_Nhap phieunhap = new P_Nhap();
            phieunhap.Show();
            this.Hide();
        }

        private void DangnhapTK_Click(object sender, EventArgs e)
        {
            DangNhapForm dn = new DangNhapForm();
            dn.Show();
            this.Hide();
        }

        private void ThoatForm_Click(object sender, EventArgs e)
        {
            DangNhapForm dn = new DangNhapForm();
            dn.Show();
            this.Hide();
        }

        private void Home_From_Load(object sender, EventArgs e)
        {

        }

        private void PhieuxuatForm_Click(object sender, EventArgs e)
        {
            P_Xuat px = new P_Xuat();
            px.Show();
            this.Hide();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHangForm kh = new KhachHangForm();
            kh.Show();
            this.Dispose();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportGUI rp = new ReportGUI();
            rp.Show();
            this.Dispose();
        }

        private void tàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ThongtinTaikhoanForm tttkf = new ThongtinTaikhoanForm();
            tttkf.Show();
        }

        private void đơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonvitinhForm dvt = new DonvitinhForm(); 
            dvt.Show();
            this.Hide();
        }
    }
}
