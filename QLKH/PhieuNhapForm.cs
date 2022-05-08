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
    public partial class PhieuNhapForm : Form
    {
        private Phieunhap pn = new Phieunhap();
        public PhieuNhapForm()
        {
            InitializeComponent();
        }

        private void PhieuNhapForm_Load(object sender, EventArgs e)
        {
            Display();
            LoadCBMaHang();
            LoadCB_NCC();
            LoadCB_IdPhieuNhap();

        }


        private void Display()
        {
            DataTable tb = new DataTable();
            tb = pn.Load_TTPhieuNhap();
            dgvPhieuNhap.DataSource = tb;
        }


        private void BtnThoat_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }

        private void PhieuNhapFormClosing(object sender, FormClosingEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                pn.ThemTTPN(txtID.Text, cbIdPhieuNhap.Text, cbMaHang.Text,
                    cbNCC.Text, int.Parse(txtSoLuong.Text),
                    int.Parse(txtGiaNhap.Text), int.Parse(txtGiaBan.Text));
                Display();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LoadCBMaHang()
        {
            DataTable dt = new DataTable();
            dt = pn.Get_CB_MaHang();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbMaHang.Items.Add(dt.Rows[i].Field<string>(0));

            }
        }

        private void LoadCB_NCC()
        {
            DataTable dt = new DataTable();
            dt = pn.Get_CB_NhaCungCap();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbNCC.Items.Add(dt.Rows[i].Field<string>(0));

            }
        }

        private void LoadCB_IdPhieuNhap()
        {
            DataTable dt = new DataTable();
            dt = pn.Get_CB_IdPhieuNhap();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbIdPhieuNhap.Items.Add(dt.Rows[i].Field<string>(0));

            }
        }

        private void BtnThoat_Click_1(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }

        private string idpn;
        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
               
                pn.SuaTTPN(txtID.Text, cbIdPhieuNhap.Text, cbMaHang.Text, cbNCC.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtGiaNhap.Text), int.Parse(txtGiaBan.Text), idpn);
                Display();
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
                    pn.XoaTTPN(txtID.Text);
                    Display();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idpn = dgvPhieuNhap.CurrentRow.Cells["id"].Value.ToString();
            txtID.Text = dgvPhieuNhap.CurrentRow.Cells["id"].Value.ToString();
            txtGiaNhap.Text = dgvPhieuNhap.CurrentRow.Cells["Gianhap"].Value.ToString();
            txtGiaBan.Text = dgvPhieuNhap.CurrentRow.Cells["giaban"].Value.ToString();
            cbMaHang.Text = dgvPhieuNhap.CurrentRow.Cells["MaHang"].Value.ToString();
            cbNCC.Text = dgvPhieuNhap.CurrentRow.Cells["NhaCungCap"].Value.ToString();
            txtSoLuong.Text = dgvPhieuNhap.CurrentRow.Cells["Soluong"].Value.ToString();
            cbIdPhieuNhap.Text = dgvPhieuNhap.CurrentRow.Cells["maphieunhap"].Value.ToString();
        }

        private void BtnQuaylai_Click(object sender, EventArgs e)
        {
            P_Nhap nhap = new P_Nhap();
            nhap.Show();
            this.Hide();
        }
    }
}
