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
    public partial class P_Xuat : Form
    {
        private Phieuxuat phieu = new Phieuxuat();
        public P_Xuat()
        {
            InitializeComponent();
        }

        private void P_Xuat_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
        {
            DataTable tb = new DataTable();
            tb = phieu.Load_PhieuXuat();
            dgvPhieuXuat.DataSource = tb;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                phieu.ThemPhieuXuat(txtMaPhieuXuat.Text, tpNgayXuat.Text);
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

                phieu.SuaPhieuXuat(txtMaPhieuXuat.Text, tpNgayXuat.Text);
                HienThi();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    phieu.XoaPhieuXuat(txtMaPhieuXuat.Text);
                    HienThi();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPhieuXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieuXuat.Text = dgvPhieuXuat.CurrentRow.Cells["idphieuxuat"].Value.ToString();
            tpNgayXuat.Text = dgvPhieuXuat.CurrentRow.Cells["NgayXuat"].Value.ToString();
        }

        private void qlttpxBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuxuatForm ttpx = new PhieuxuatForm();
            ttpx.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void P_Xuat_Formclosing(object sender, FormClosingEventArgs e)
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
            HomeFrom home =  new HomeFrom();
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
