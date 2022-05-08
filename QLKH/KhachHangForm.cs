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
using QLBH;

namespace QLKhoHang
{
    public partial class KhachHangForm : Form
    {
        private KhachHang kh = new KhachHang();
        public KhachHangForm()
        {
            InitializeComponent();
        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt = kh.HienThi_KH();
            dg.DataSource = dt;
        }

        private void LoadData_Search()
        {
            DataTable dt = new DataTable();
            dt = kh.Search(txtSearch.Text);
            dg.DataSource = dt;
        }

        private void thoatBtn_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã khách hàng!");
                txtMaKH.Focus();
            }
            else
            {
                try
                {
                    kh.ThemKH(txtMaKH.Text, txtHoTen.Text, cbGioiTinh.Text, txtDiaChi.Text, txtEmail.Text, txtSDT.Text);
                    LoadData();
                    Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void Clear()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtSearch.Clear();
            cbGioiTinh.Text = null;
        }

        private string keys;
        private void suaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                kh.SuaKH(txtMaKH.Text, txtHoTen.Text, cbGioiTinh.Text, txtDiaChi.Text, 
                    txtEmail.Text, txtSDT.Text, keys);
                LoadData();
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                kh.XoaKH(txtMaKH.Text);
                LoadData();
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void searchBtb_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData_Search();
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            HomeFrom h = new HomeFrom();
            h.Show();
            this.Dispose();
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            keys = dg.CurrentRow.Cells["MaKH"].Value.ToString();
            txtMaKH.Text = dg.CurrentRow.Cells["MaKH"].Value.ToString();
            txtHoTen.Text = dg.CurrentRow.Cells["hoten"].Value.ToString();
            txtDiaChi.Text = dg.CurrentRow.Cells["diachi"].Value.ToString();
            txtEmail.Text = dg.CurrentRow.Cells["email"].Value.ToString();
            txtSDT.Text = dg.CurrentRow.Cells["sodienthoai"].Value.ToString();
            cbGioiTinh.Text = dg.CurrentRow.Cells["gioitinh"].Value.ToString();
        }

        private void trangChuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhoHangForm khf = new KhoHangForm();
            khf.Show();
            this.Hide();
        }

        private void KhachHang_Formclosing(object sender, FormClosingEventArgs e)
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
    }
}
