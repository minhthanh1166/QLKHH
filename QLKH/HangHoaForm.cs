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
    public partial class HangHoaForm : Form
    {
        private HangHoa hang = new HangHoa();

        private string maHang;

        public HangHoaForm()
        {
            InitializeComponent();
        }

        private void HangHoaForm_Load(object sender, EventArgs e)
        {
            HienThi();
            DisplayCB_Loai();
            DisplayCB_Nhacungcap();
            DisplayCB_Donvitinh();
        }


        public void DisplayCB_Loai()
        {
            DataTable dt = new DataTable();
            dt = hang.Get_CB_Loai();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbLoai.Items.Add(dt.Rows[i].Field<string>(0));

            }
        }

        public void DisplayCB_Nhacungcap()
        {
            DataTable dt = new DataTable();
            dt = hang.Get_CB_NhaCungCap();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbNCC.Items.Add(dt.Rows[i].Field<string>(0));
                

            }
        }

        public void DisplayCB_Donvitinh()
        {
            DataTable dt = new DataTable();
            dt = hang.GetCb_Donvitinh();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbMaDVT.Items.Add(dt.Rows[i].Field<int>(0));


            }
        }



        private void HienThi()
        {
            DataTable dt = new DataTable();
            dt = hang.HT_HangHoa();
            dgvHangHoa.DataSource = dt;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }

        private void HangHoaForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbLoai_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbNCC_TextChanged(object sender, EventArgs e)
        {
        }


        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã hàng!");
                txtMaHang.Focus();
            }
            else
            {
                try
                {
                    hang.ThemHang(txtMaHang.Text, txtTenHang.Text, cbLoai.Text,
                        cbNCC.Text, int.Parse(cbMaDVT.Text));
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
            txtMaHang.Clear();
            txtTenHang.Clear();
            
            cbLoai.Text = "";
           
            cbNCC.Text = "";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                hang.SuaHang(txtMaHang.Text, txtTenHang.Text, cbNCC.Text, cbLoai.Text, int.Parse(cbMaDVT.Text), maHang);
                HienThi();
                Clear();
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
                    hang.XoaHang(txtMaHang.Text);
                    HienThi();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maHang = dgvHangHoa.CurrentRow.Cells["MaHH"].Value.ToString();
            txtMaHang.Text = dgvHangHoa.CurrentRow.Cells["MaHH"].Value.ToString();
            txtTenHang.Text = dgvHangHoa.CurrentRow.Cells["TenHang"].Value.ToString();
            cbNCC.Text = dgvHangHoa.CurrentRow.Cells["NhaCungCap"].Value.ToString();
            cbLoai.Text = dgvHangHoa.CurrentRow.Cells["Loai"].Value.ToString();
            cbMaDVT.Text = dgvHangHoa.CurrentRow.Cells["madvt"].Value.ToString();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhoHangForm khf = new KhoHangForm();
            khf.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
