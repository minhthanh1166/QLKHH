namespace QLBH
{
    partial class KhoHangForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoHangForm));
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongdanhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongdaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluongton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbox = new System.Windows.Forms.GroupBox();
            this.lbSLTonKho = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
            this.grbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(415, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHO HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvTonKho
            // 
            this.dgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.soluongdanhap,
            this.soluongdaban,
            this.Soluongton});
            this.dgvTonKho.Location = new System.Drawing.Point(120, 46);
            this.dgvTonKho.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.RowHeadersWidth = 51;
            this.dgvTonKho.Size = new System.Drawing.Size(716, 171);
            this.dgvTonKho.TabIndex = 3;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHH";
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.Width = 125;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHH";
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 125;
            // 
            // soluongdanhap
            // 
            this.soluongdanhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soluongdanhap.DataPropertyName = "soluongdanhap";
            this.soluongdanhap.HeaderText = "Số lượng nhập";
            this.soluongdanhap.MinimumWidth = 6;
            this.soluongdanhap.Name = "soluongdanhap";
            this.soluongdanhap.Width = 112;
            // 
            // soluongdaban
            // 
            this.soluongdaban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soluongdaban.DataPropertyName = "soluongdaban";
            this.soluongdaban.HeaderText = "Số lượng đã bán";
            this.soluongdaban.MinimumWidth = 6;
            this.soluongdaban.Name = "soluongdaban";
            this.soluongdaban.Width = 102;
            // 
            // Soluongton
            // 
            this.Soluongton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Soluongton.DataPropertyName = "Soluongton";
            this.Soluongton.HeaderText = "Số lượng tồn";
            this.Soluongton.MinimumWidth = 6;
            this.Soluongton.Name = "Soluongton";
            this.Soluongton.Width = 101;
            // 
            // grbox
            // 
            this.grbox.Controls.Add(this.lbSLTonKho);
            this.grbox.Controls.Add(this.label3);
            this.grbox.Controls.Add(this.dgvTonKho);
            this.grbox.Location = new System.Drawing.Point(83, 112);
            this.grbox.Margin = new System.Windows.Forms.Padding(4);
            this.grbox.Name = "grbox";
            this.grbox.Padding = new System.Windows.Forms.Padding(4);
            this.grbox.Size = new System.Drawing.Size(921, 321);
            this.grbox.TabIndex = 4;
            this.grbox.TabStop = false;
            this.grbox.Text = "Thống kê hàng tồn kho";
            this.grbox.Enter += new System.EventHandler(this.grbox_Enter);
            // 
            // lbSLTonKho
            // 
            this.lbSLTonKho.AutoSize = true;
            this.lbSLTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLTonKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbSLTonKho.Location = new System.Drawing.Point(351, 242);
            this.lbSLTonKho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSLTonKho.Name = "lbSLTonKho";
            this.lbSLTonKho.Size = new System.Drawing.Size(17, 25);
            this.lbSLTonKho.TabIndex = 5;
            this.lbSLTonKho.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(116, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng số hàng tồn kho:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshBtn.Location = new System.Drawing.Point(83, 453);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(159, 42);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Resets";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(270, 453);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(159, 42);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // KhoHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.grbox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KhoHangForm";
            this.Text = "QuanLyKhoHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KhoHangFormClosing);
            this.Load += new System.EventHandler(this.KhoHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            this.grbox.ResumeLayout(false);
            this.grbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvTonKho;
        private System.Windows.Forms.GroupBox grbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongdanhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongdaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluongton;
        private System.Windows.Forms.Label lbSLTonKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button btnThoat;
    }
}

