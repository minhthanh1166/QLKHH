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
    public partial class DonvitinhForm : Form
    {
        private DonViTinh dvt = new DonViTinh();
        public DonvitinhForm()
        {
            InitializeComponent();
        }

        private void DonvitinhForm_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        public void Hienthi()
        {
            DataTable dt = new DataTable();
            dt = dvt.HienThi_DVT();
            dgv_DVT.DataSource = dt;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
          
                try
                {
                    dvt.ThemDVT(txtTenDVT.Text);
                    Hienthi();
                    Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            
        }

        private void Clear()
        {
           txtMaDVT.Clear();
           txtTenDVT.Clear();
          
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {

            try
            {
                dvt.SuaDVT(txtMaDVT.Text, txtTenDVT.Text);
                Hienthi();
                Clear();

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
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn xoá không?", "Câu hỏi", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rs == DialogResult.Yes)
                {
                    dvt.XoaDVT(txtMaDVT.Text);
                    Hienthi();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Clear();
            Hienthi();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoHangForm kf = new KhoHangForm();
            kf.Show();
        }

        private void quanLyHangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HangHoaForm hhf = new HangHoaForm();
            hhf.Show();
        }

        private void dgv_DVT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDVT.Text = dgv_DVT.CurrentRow.Cells["Madvt"].Value.ToString();
            txtTenDVT.Text = dgv_DVT.CurrentRow.Cells["Tendvt"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
