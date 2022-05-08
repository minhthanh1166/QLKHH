using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKhoHang;
using BUS;
namespace QLBH
{
    public partial class KhoHangForm : Form
    {
        private Khohang kho = new Khohang();
        public KhoHangForm()
        {
            InitializeComponent();
        }

        private void KhoHangForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        

        private void dmlsp_mt_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoaiSP_Form loaiSpForm = new LoaiSP_Form();
            loaiSpForm.Show();
        }

        private void qlncc_mt_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaCungCapForm ncc_form = new NhaCungCapForm();
            ncc_form.Show();
        }

        private void thoat_item_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void HangHoaItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HangHoaForm hh_form = new HangHoaForm();
            hh_form.Show();
        }

        private void KhoHangForm_Load(object sender, EventArgs e)
        {
            Load_TonKho_Data();
        }

        private void Load_TonKho_Data()
        {
            
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Load_TonKho_Data();
        }

        private void qLNhapKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuNhapForm pn = new PhieuNhapForm();
            pn.Show();
            this.Hide();
        }

        private void grbox_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }

        private void KhoHangFormClosing(object sender, FormClosingEventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
