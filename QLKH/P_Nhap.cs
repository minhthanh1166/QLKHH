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

namespace QLKhoHang
{
    public partial class P_Nhap : Form
    {
        private Phieunhap pn = new Phieunhap();
        public P_Nhap()
        {
            InitializeComponent();
        }

        private void P_Nhap_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
        {
            DataTable tb = new DataTable();
            tb = pn.Load_PhieuNhap();
            dgvPhieuNhap.DataSource = tb;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                pn.ThemPhieuNhap(txtMaPhieuNhap.Text, tpNgayNhap.Text);
                HienThi();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {

                pn.SuaPhieuNhap(txtMaPhieuNhap.Text, tpNgayNhap.Value.ToString());
                HienThi();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                pn.XoaPhieuNhap(txtMaPhieuNhap.Text);
                HienThi();
            }
        }

        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieuNhap.Text = dgvPhieuNhap.CurrentRow.Cells["idphieunhap"].Value.ToString();
            tpNgayNhap.Text = dgvPhieuNhap.CurrentRow.Cells["NgayNhap"].Value.ToString();
        }

        private void ttpnBtn_Click(object sender, EventArgs e)
        {
            PhieuNhapForm ppnf = new PhieuNhapForm();
            ppnf.Show();
            this.Hide();
        }

        private void P_nhap_Formclosing(object sender, FormClosingEventArgs e)
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

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }
    }
}
