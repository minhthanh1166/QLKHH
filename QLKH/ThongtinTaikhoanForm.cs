using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace QLKhoHang
{
    public partial class ThongtinTaikhoanForm : Form
    {
        private Thongtintaikhoan tttk = new Thongtintaikhoan();
        public ThongtinTaikhoanForm()
        {
            InitializeComponent();
        }

        private void txtMaPhieuNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThongtinTaikhoanForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt = tttk.HT_TaiKhoan();
            dgvTTTK.DataSource = dt;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {

            try
            {
                tttk.ThemTaiKhoang(txtTendangnhap.Text, txtMatkhau.Text);
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    tttk.XoaTaiKhoan(txtTendangnhap.Text);
                    LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string key;
        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
               tttk.Suataikhoan(txtTendangnhap.Text, txtMatkhau.Text, key);
               LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTTTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTendangnhap.Text = dgvTTTK.CurrentRow.Cells[0].Value.ToString();
            txtMatkhau.Text = dgvTTTK.CurrentRow.Cells[1].Value.ToString();
            key = dgvTTTK.CurrentRow.Cells[0].Value.ToString();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            HomeFrom hf = new HomeFrom();
            hf.Show();
        }
    }
}
