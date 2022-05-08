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
using QLKhoHang;

namespace QLBH
{
    public partial class LoaiSP_Form : Form
    {
        private LoaiSP loaiSp = new LoaiSP();

        public LoaiSP_Form()
        {
            InitializeComponent();
        }

        public void Hienthi()
        {
            DataTable dt = new DataTable();
            dt = loaiSp.HienThi_Loai();
            dgv_LoaiSP.DataSource = dt;
        }

        private void dgv_LoaiSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoaiSP_Form_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã loại!");
                txtMaLoai.Focus();
            }
            else
            {
                try
                {
                    loaiSp.ThemLoaiSP(txtMaLoai.Text, txtTenLoai.Text);
                    Hienthi();
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
            txtMaLoai.Clear();
            txtMaLoai.Enabled = true;
            txtTenLoai.Clear();
        }

        private void dgv_LoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoai.Enabled = false;
            txtMaLoai.Text = dgv_LoaiSP.CurrentRow.Cells["Maloai"].Value.ToString();
            txtTenLoai.Text = dgv_LoaiSP.CurrentRow.Cells["Tenloai"].Value.ToString();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                loaiSp.SuaLoaiSP(txtMaLoai.Text, txtTenLoai.Text);
                Hienthi();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    loaiSp.XoaLoaiSP(txtMaLoai.Text);
                    Hienthi();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void LoaiSP_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhoHangForm khf = new KhoHangForm();
            khf.Show();
            this.Hide();
        }

        private void LoaiSPFormClosing(object sender, FormClosingEventArgs e)
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
