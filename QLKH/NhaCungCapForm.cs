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
    public partial class NhaCungCapForm : Form
    {
        private NhaCungCap ncc = new NhaCungCap();
        public NhaCungCapForm()
        {
            InitializeComponent();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }

        private void NhaCungCapForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void HienThi()
        {
            DataTable dt = new DataTable();
            dt = ncc.HT_NhaCungCap();
            dgv_NCC.DataSource = dt;
        }

        private void NhaCungCapForm_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {

            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã nhà cung cấp!");
                txtMaNCC.Focus();
            }
            else
            {
                try
                {
                    ncc.ThemNCC(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtEmail.Text, txtSDT.Text);
                    HienThi();
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
           txtMaNCC.Clear();
           txtTenNCC.Clear();
           txtDiaChi.Clear();
           txtEmail.Clear();
           txtSDT.Clear();
        }

        private string key = "";

        private void dgv_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            key = dgv_NCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtMaNCC.Text = dgv_NCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = dgv_NCC.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtDiaChi.Text = dgv_NCC.CurrentRow.Cells["Diachi"].Value.ToString();
            txtEmail.Text = dgv_NCC.CurrentRow.Cells["Email"].Value.ToString();
            txtSDT.Text = dgv_NCC.CurrentRow.Cells["Sodienthoai"].Value.ToString();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ncc.SuaNCC(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtEmail.Text, txtSDT.Text, key);
                HienThi();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DialogResult r = MessageBox.Show("Bạn có muốn xoá Nhà cung cấp này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    ncc.XoaNCC(key);
                    HienThi();
                    Clear();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void home_item_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoHangForm khf = new KhoHangForm();
            khf.Show();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void NhaCungCapFormClosing(object sender, FormClosingEventArgs e)
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
