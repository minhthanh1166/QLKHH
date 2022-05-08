namespace QLKhoHang
{
    partial class P_Xuat
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
            this.dgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.idphieuxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.qlttpxBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaPhieuXuat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhieuXuat
            // 
            this.dgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idphieuxuat,
            this.NgayXuat});
            this.dgvPhieuXuat.Location = new System.Drawing.Point(99, 284);
            this.dgvPhieuXuat.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhieuXuat.Name = "dgvPhieuXuat";
            this.dgvPhieuXuat.RowHeadersWidth = 51;
            this.dgvPhieuXuat.Size = new System.Drawing.Size(469, 133);
            this.dgvPhieuXuat.TabIndex = 22;
            this.dgvPhieuXuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuXuat_CellContentClick);
            // 
            // idphieuxuat
            // 
            this.idphieuxuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idphieuxuat.DataPropertyName = "id";
            this.idphieuxuat.HeaderText = "Id";
            this.idphieuxuat.MinimumWidth = 6;
            this.idphieuxuat.Name = "idphieuxuat";
            this.idphieuxuat.Width = 47;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "ngayxuat";
            this.NgayXuat.HeaderText = "Ngày xuất";
            this.NgayXuat.MinimumWidth = 6;
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.Width = 125;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnThem);
            this.flowLayoutPanel1.Controls.Add(this.BtnSua);
            this.flowLayoutPanel1.Controls.Add(this.BtnXoa);
            this.flowLayoutPanel1.Controls.Add(this.BtnReset);
            this.flowLayoutPanel1.Controls.Add(this.qlttpxBtn);
            this.flowLayoutPanel1.Controls.Add(this.ReturnBtn);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(95, 425);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(473, 103);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // BtnThem
            // 
            this.BtnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.Location = new System.Drawing.Point(4, 4);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(4);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(100, 39);
            this.BtnThem.TabIndex = 0;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSua.Location = new System.Drawing.Point(112, 4);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(100, 39);
            this.BtnSua.TabIndex = 1;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.Location = new System.Drawing.Point(220, 4);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(100, 39);
            this.BtnXoa.TabIndex = 2;
            this.BtnXoa.Text = "Xoá";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(328, 4);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(100, 39);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "Làm mới";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // qlttpxBtn
            // 
            this.qlttpxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlttpxBtn.Location = new System.Drawing.Point(4, 51);
            this.qlttpxBtn.Margin = new System.Windows.Forms.Padding(4);
            this.qlttpxBtn.Name = "qlttpxBtn";
            this.qlttpxBtn.Size = new System.Drawing.Size(281, 39);
            this.qlttpxBtn.TabIndex = 6;
            this.qlttpxBtn.Text = "Quản lý thông tin phiếu xuất";
            this.qlttpxBtn.UseVisualStyleBackColor = true;
            this.qlttpxBtn.Click += new System.EventHandler(this.qlttpxBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBtn.Location = new System.Drawing.Point(293, 51);
            this.ReturnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(100, 39);
            this.ReturnBtn.TabIndex = 5;
            this.ReturnBtn.Text = "Quay lại";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaPhieuXuat);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tpNgayXuat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(99, 125);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 151);
            this.panel1.TabIndex = 20;
            // 
            // txtMaPhieuXuat
            // 
            this.txtMaPhieuXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuXuat.Location = new System.Drawing.Point(199, 33);
            this.txtMaPhieuXuat.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            this.txtMaPhieuXuat.Size = new System.Drawing.Size(183, 29);
            this.txtMaPhieuXuat.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mã phiếu xuất:";
            // 
            // tpNgayXuat
            // 
            this.tpNgayXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tpNgayXuat.Location = new System.Drawing.Point(199, 92);
            this.tpNgayXuat.Margin = new System.Windows.Forms.Padding(4);
            this.tpNgayXuat.MaxDate = new System.DateTime(2022, 5, 5, 0, 0, 0, 0);
            this.tpNgayXuat.Name = "tpNgayXuat";
            this.tpNgayXuat.Size = new System.Drawing.Size(183, 29);
            this.tpNgayXuat.TabIndex = 17;
            this.tpNgayXuat.Value = new System.DateTime(2022, 5, 5, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ngày xuất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(177, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "DANH SÁCH PHIẾU XUẤT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // P_Xuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(676, 541);
            this.Controls.Add(this.dgvPhieuXuat);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "P_Xuat";
            this.Text = "P_Xuat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.P_Xuat_Formclosing);
            this.Load += new System.EventHandler(this.P_Xuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphieuxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaPhieuXuat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker tpNgayXuat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button qlttpxBtn;
    }
}