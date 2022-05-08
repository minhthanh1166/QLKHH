using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhoHang
{
    public partial class ReportGUI : Form
    {
        public ReportGUI()
        {
            InitializeComponent();
        }

        private void ReportGUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlkhDataSet12.HangHoaView' table. You can move, or remove it, as needed.
            this.hangHoaViewTableAdapter.Fill(this.qlkhDataSet12.HangHoaView);


            this.reportViewer1.RefreshReport();
        }

        private void ReportGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void ReportGUI__FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeFrom home = new HomeFrom();
            home.Show();
            this.Hide();
        }
    }
}
