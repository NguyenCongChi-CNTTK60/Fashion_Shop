
namespace WindowsFormsApp
{
    partial class FormCoupon
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
            this.cbbSanPham = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            //    this.quanLyCuaHangThoiTrangDataSet3 = new WindowsFormsApp3.QuanLyCuaHangThoiTrangDataSet3();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //   this.nhaCungCapTableAdapter = new WindowsFormsApp3.QuanLyCuaHangThoiTrangDataSet3TableAdapters.NhaCungCapTableAdapter();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            //     ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangThoiTrangDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbSanPham
            // 
            this.cbbSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbbSanPham.FormattingEnabled = true;
            this.cbbSanPham.Location = new System.Drawing.Point(146, 36);
            this.cbbSanPham.Name = "cbbSanPham";
            this.cbbSanPham.Size = new System.Drawing.Size(197, 24);
            this.cbbSanPham.TabIndex = 0;
           /* this.cbbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbbSanPham_SelectedIndexChanged);*/
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng Tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 387);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.SoLuong,
            this.DonGia,
            this.NgayLapPhieu,
            this.NguoiLap});
            this.dgvCTPN.Location = new System.Drawing.Point(32, 83);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.RowHeadersWidth = 51;
            this.dgvCTPN.RowTemplate.Height = 24;
            this.dgvCTPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPN.Size = new System.Drawing.Size(739, 283);
            this.dgvCTPN.TabIndex = 7;
       /*     this.dgvCTPN.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPN_CellEndEdit);*/
            // 
            // MaHang
            // 
            this.MaHang.FillWeight = 60F;
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            // 
            // TenHang
            // 
            this.TenHang.FillWeight = 120F;
            this.TenHang.HeaderText = "Tên Hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.FillWeight = 60F;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // NgayLapPhieu
            // 
            this.NgayLapPhieu.HeaderText = "Ngày Lập Phiếu";
            this.NgayLapPhieu.MinimumWidth = 6;
            this.NgayLapPhieu.Name = "NgayLapPhieu";
            this.NgayLapPhieu.ReadOnly = true;
            // 
            // NguoiLap
            // 
            this.NguoiLap.HeaderText = "Người Lập ";
            this.NguoiLap.MinimumWidth = 6;
            this.NguoiLap.Name = "NguoiLap";
            this.NguoiLap.ReadOnly = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(32, 372);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(129, 43);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Xác Nhận";
        
            // 
            // cbbNCC
            // 
            this.cbbNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbNCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(612, 39);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(159, 24);
            this.cbbNCC.TabIndex = 9;
            // 
            // quanLyCuaHangThoiTrangDataSet3
            // 
            //   this.quanLyCuaHangThoiTrangDataSet3.DataSetName = "QuanLyCuaHangThoiTrangDataSet3";
            //   this.quanLyCuaHangThoiTrangDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            //  this.nhaCungCapBindingSource.DataSource = this.quanLyCuaHangThoiTrangDataSet3;
            // 
            // nhaCungCapTableAdapter
            // 
            //   this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // btnXoa
            // 
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(178, 372);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(129, 43);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
 
            // 
            // Form_PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 447);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cbbNCC);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.dgvCTPN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbSanPham);
            this.Name = "Form_PhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_PhieuNhap";
          
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            //  ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangThoiTrangDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiLap;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
    }
}