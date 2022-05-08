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
    public partial class PhieuxuatForm : Form
    {
        private Phieuxuat px = new Phieuxuat();
        public PhieuxuatForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PhieuxuatForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCB_IDPhieuNhap();
            LoadCB_KhachHang();
            LoadCB_MaHang();
        }



        private void LoadData()
        {
            DataTable tb = new DataTable();
            tb = px.Load_TTPhieuXuat();
            dgvPhieuXuat.DataSource = tb;
        }


        private void PhieuxuatFromClosing(object sender, FormClosingEventArgs e)
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

        private void dgvPhieuXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            keyid = dgvPhieuXuat.CurrentRow.Cells["Id"].Value.ToString();
            txtID.Text = dgvPhieuXuat.CurrentRow.Cells["Id"].Value.ToString();
            cbIDPhieuXuat.Text = dgvPhieuXuat.CurrentRow.Cells["idPX"].Value.ToString();
            cbMaHang.Text = dgvPhieuXuat.CurrentRow.Cells["MaHang"].Value.ToString();
            cbKH.Text = dgvPhieuXuat.CurrentRow.Cells["KhachHang"].Value.ToString();
            txtSoLuong.Text = dgvPhieuXuat.CurrentRow.Cells["Soluong"].Value.ToString();

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                px.ThemTTPX(txtID.Text, cbMaHang.Text, Int32.Parse(txtSoLuong.Text), cbKH.Text, cbIDPhieuXuat.Text);
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private string keyid;
        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
               
                    px.SuaTTPX(txtID.Text, cbMaHang.Text, cbKH.Text,
                        int.Parse(txtSoLuong.Text), cbIDPhieuXuat.Text, keyid);
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
                    px.XoaTTPX(txtID.Text);
                   LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadCB_IDPhieuNhap()
        {
            DataTable dt = new DataTable();
            dt = px.Get_CB_IDPhieuXuat();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbIDPhieuXuat.Items.Add(dt.Rows[i].Field<string>(0));

            }
        }

        private void LoadCB_MaHang()
        {
            DataTable dt = new DataTable();
            dt = px.Get_CB_MaHang();
            cbMaHang.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbMaHang.Items.Add(dt.Rows[i].Field<string>(0));

            }
        }

        private void LoadCB_KhachHang()
        {
            DataTable dt = new DataTable();
            dt = px.Get_CB_KhachHang();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbKH.Items.Add(dt.Rows[i].Field<string>(0));

            }
        }

        private void BtnQuaylai_Click(object sender, EventArgs e)
        {
            P_Xuat xuat =  new P_Xuat();
            xuat.Show();
            this.Hide();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }
    }
}
