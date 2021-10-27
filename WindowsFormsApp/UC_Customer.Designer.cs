
namespace WindowsFormsApp
{
    partial class UC_Customer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvThongTinKhachHang = new System.Windows.Forms.DataGridView();
            this.Makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2txtMaKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtTenKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtGmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch2 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2cmbChucVu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKhachHang)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(31, 288);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 29);
            this.label19.TabIndex = 66;
            this.label19.Text = "Tìm kiếm:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(571, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 29);
            this.label18.TabIndex = 64;
            this.label18.Text = "Gmail:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(68, 170);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 29);
            this.label17.TabIndex = 63;
            this.label17.Text = "Điện thoại:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(68, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 29);
            this.label16.TabIndex = 61;
            this.label16.Text = "Địa chỉ:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 29);
            this.label14.TabIndex = 55;
            this.label14.Text = "Tên khách hàng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 29);
            this.label13.TabIndex = 53;
            this.label13.Text = "Mã khách hàng: ";
            // 
            // dgvThongTinKhachHang
            // 
            this.dgvThongTinKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongTinKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongTinKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvThongTinKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Makh,
            this.Column1,
            this.Gioitinh,
            this.Diachi,
            this.Sdt,
            this.Column2});
            this.dgvThongTinKhachHang.Location = new System.Drawing.Point(36, 349);
            this.dgvThongTinKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThongTinKhachHang.Name = "dgvThongTinKhachHang";
            this.dgvThongTinKhachHang.RowHeadersWidth = 62;
            this.dgvThongTinKhachHang.RowTemplate.Height = 28;
            this.dgvThongTinKhachHang.Size = new System.Drawing.Size(993, 394);
            this.dgvThongTinKhachHang.TabIndex = 51;
            // 
            // Makh
            // 
            this.Makh.HeaderText = "Mã khách hàng";
            this.Makh.MinimumWidth = 8;
            this.Makh.Name = "Makh";
            this.Makh.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên khách hàng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Gioitinh
            // 
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.MinimumWidth = 8;
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.Width = 150;
            // 
            // Diachi
            // 
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.MinimumWidth = 8;
            this.Diachi.Name = "Diachi";
            this.Diachi.Width = 150;
            // 
            // Sdt
            // 
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.MinimumWidth = 8;
            this.Sdt.Name = "Sdt";
            this.Sdt.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Gmail";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(37, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1003, 56);
            this.panel3.TabIndex = 185;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 28);
            this.label2.TabIndex = 183;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // guna2txtMaKhachHang
            // 
            this.guna2txtMaKhachHang.BorderColor = System.Drawing.Color.SteelBlue;
            this.guna2txtMaKhachHang.BorderRadius = 10;
            this.guna2txtMaKhachHang.BorderThickness = 2;
            this.guna2txtMaKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtMaKhachHang.DefaultText = "";
            this.guna2txtMaKhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtMaKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtMaKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtMaKhachHang.DisabledState.Parent = this.guna2txtMaKhachHang;
            this.guna2txtMaKhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtMaKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtMaKhachHang.FocusedState.Parent = this.guna2txtMaKhachHang;
            this.guna2txtMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtMaKhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtMaKhachHang.HoverState.Parent = this.guna2txtMaKhachHang;
            this.guna2txtMaKhachHang.Location = new System.Drawing.Point(188, 90);
            this.guna2txtMaKhachHang.Name = "guna2txtMaKhachHang";
            this.guna2txtMaKhachHang.PasswordChar = '\0';
            this.guna2txtMaKhachHang.PlaceholderText = "";
            this.guna2txtMaKhachHang.SelectedText = "";
            this.guna2txtMaKhachHang.ShadowDecoration.Parent = this.guna2txtMaKhachHang;
            this.guna2txtMaKhachHang.Size = new System.Drawing.Size(301, 31);
            this.guna2txtMaKhachHang.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2txtMaKhachHang.TabIndex = 195;
            // 
            // guna2txtTenKhachHang
            // 
            this.guna2txtTenKhachHang.BorderColor = System.Drawing.Color.SteelBlue;
            this.guna2txtTenKhachHang.BorderRadius = 10;
            this.guna2txtTenKhachHang.BorderThickness = 2;
            this.guna2txtTenKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtTenKhachHang.DefaultText = "";
            this.guna2txtTenKhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtTenKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtTenKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtTenKhachHang.DisabledState.Parent = this.guna2txtTenKhachHang;
            this.guna2txtTenKhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtTenKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtTenKhachHang.FocusedState.Parent = this.guna2txtTenKhachHang;
            this.guna2txtTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtTenKhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtTenKhachHang.HoverState.Parent = this.guna2txtTenKhachHang;
            this.guna2txtTenKhachHang.Location = new System.Drawing.Point(186, 127);
            this.guna2txtTenKhachHang.Name = "guna2txtTenKhachHang";
            this.guna2txtTenKhachHang.PasswordChar = '\0';
            this.guna2txtTenKhachHang.PlaceholderText = "";
            this.guna2txtTenKhachHang.SelectedText = "";
            this.guna2txtTenKhachHang.ShadowDecoration.Parent = this.guna2txtTenKhachHang;
            this.guna2txtTenKhachHang.Size = new System.Drawing.Size(301, 31);
            this.guna2txtTenKhachHang.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2txtTenKhachHang.TabIndex = 196;
            // 
            // guna2txtTimKiem
            // 
            this.guna2txtTimKiem.BorderColor = System.Drawing.Color.SteelBlue;
            this.guna2txtTimKiem.BorderRadius = 10;
            this.guna2txtTimKiem.BorderThickness = 2;
            this.guna2txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtTimKiem.DefaultText = "";
            this.guna2txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtTimKiem.DisabledState.Parent = this.guna2txtTimKiem;
            this.guna2txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtTimKiem.FocusedState.Parent = this.guna2txtTimKiem;
            this.guna2txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtTimKiem.HoverState.Parent = this.guna2txtTimKiem;
            this.guna2txtTimKiem.Location = new System.Drawing.Point(145, 286);
            this.guna2txtTimKiem.Name = "guna2txtTimKiem";
            this.guna2txtTimKiem.PasswordChar = '\0';
            this.guna2txtTimKiem.PlaceholderText = "";
            this.guna2txtTimKiem.SelectedText = "";
            this.guna2txtTimKiem.ShadowDecoration.Parent = this.guna2txtTimKiem;
            this.guna2txtTimKiem.Size = new System.Drawing.Size(301, 31);
            this.guna2txtTimKiem.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2txtTimKiem.TabIndex = 197;
            // 
            // guna2txtSDT
            // 
            this.guna2txtSDT.BorderColor = System.Drawing.Color.SteelBlue;
            this.guna2txtSDT.BorderRadius = 10;
            this.guna2txtSDT.BorderThickness = 2;
            this.guna2txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtSDT.DefaultText = "";
            this.guna2txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtSDT.DisabledState.Parent = this.guna2txtSDT;
            this.guna2txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtSDT.FocusedState.Parent = this.guna2txtSDT;
            this.guna2txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtSDT.HoverState.Parent = this.guna2txtSDT;
            this.guna2txtSDT.Location = new System.Drawing.Point(186, 168);
            this.guna2txtSDT.Name = "guna2txtSDT";
            this.guna2txtSDT.PasswordChar = '\0';
            this.guna2txtSDT.PlaceholderText = "";
            this.guna2txtSDT.SelectedText = "";
            this.guna2txtSDT.ShadowDecoration.Parent = this.guna2txtSDT;
            this.guna2txtSDT.Size = new System.Drawing.Size(301, 31);
            this.guna2txtSDT.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2txtSDT.TabIndex = 199;
            // 
            // guna2txtGmail
            // 
            this.guna2txtGmail.BorderColor = System.Drawing.Color.SteelBlue;
            this.guna2txtGmail.BorderRadius = 10;
            this.guna2txtGmail.BorderThickness = 2;
            this.guna2txtGmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtGmail.DefaultText = "";
            this.guna2txtGmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtGmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtGmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtGmail.DisabledState.Parent = this.guna2txtGmail;
            this.guna2txtGmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtGmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtGmail.FocusedState.Parent = this.guna2txtGmail;
            this.guna2txtGmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtGmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtGmail.HoverState.Parent = this.guna2txtGmail;
            this.guna2txtGmail.Location = new System.Drawing.Point(653, 125);
            this.guna2txtGmail.Name = "guna2txtGmail";
            this.guna2txtGmail.PasswordChar = '\0';
            this.guna2txtGmail.PlaceholderText = "";
            this.guna2txtGmail.SelectedText = "";
            this.guna2txtGmail.ShadowDecoration.Parent = this.guna2txtGmail;
            this.guna2txtGmail.Size = new System.Drawing.Size(301, 31);
            this.guna2txtGmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2txtGmail.TabIndex = 200;
            // 
            // guna2txtDiaChi
            // 
            this.guna2txtDiaChi.BorderColor = System.Drawing.Color.SteelBlue;
            this.guna2txtDiaChi.BorderRadius = 10;
            this.guna2txtDiaChi.BorderThickness = 2;
            this.guna2txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtDiaChi.DefaultText = "";
            this.guna2txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtDiaChi.DisabledState.Parent = this.guna2txtDiaChi;
            this.guna2txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtDiaChi.FocusedState.Parent = this.guna2txtDiaChi;
            this.guna2txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtDiaChi.HoverState.Parent = this.guna2txtDiaChi;
            this.guna2txtDiaChi.Location = new System.Drawing.Point(186, 205);
            this.guna2txtDiaChi.Name = "guna2txtDiaChi";
            this.guna2txtDiaChi.PasswordChar = '\0';
            this.guna2txtDiaChi.PlaceholderText = "";
            this.guna2txtDiaChi.SelectedText = "";
            this.guna2txtDiaChi.ShadowDecoration.Parent = this.guna2txtDiaChi;
            this.guna2txtDiaChi.Size = new System.Drawing.Size(301, 36);
            this.guna2txtDiaChi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2txtDiaChi.TabIndex = 198;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThem.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(491, 275);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 58);
            this.btnThem.TabIndex = 201;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(621, 275);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 58);
            this.btnSua.TabIndex = 202;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(751, 275);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 58);
            this.btnXoa.TabIndex = 203;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCapNhap.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhap.ForeColor = System.Drawing.Color.White;
            this.btnCapNhap.Location = new System.Drawing.Point(881, 275);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(124, 58);
            this.btnCapNhap.TabIndex = 204;
            this.btnCapNhap.Text = "Cập nhập";
            this.btnCapNhap.UseVisualStyleBackColor = false;
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(-19, -19);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.ShadowDecoration.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch1.TabIndex = 205;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.Parent = this.guna2ToggleSwitch1;
            // 
            // guna2ToggleSwitch2
            // 
            this.guna2ToggleSwitch2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch2.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.CheckedState.Parent = this.guna2ToggleSwitch2;
            this.guna2ToggleSwitch2.Location = new System.Drawing.Point(-19, -19);
            this.guna2ToggleSwitch2.Name = "guna2ToggleSwitch2";
            this.guna2ToggleSwitch2.ShadowDecoration.Parent = this.guna2ToggleSwitch2;
            this.guna2ToggleSwitch2.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch2.TabIndex = 206;
            this.guna2ToggleSwitch2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch2.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.UncheckedState.Parent = this.guna2ToggleSwitch2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 207;
            this.label1.Text = "Chức Vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 208;
            this.label3.Text = "Mật Khẩu:";
            // 
            // guna2cmbChucVu
            // 
            this.guna2cmbChucVu.BackColor = System.Drawing.Color.Transparent;
            this.guna2cmbChucVu.BorderColor = System.Drawing.Color.SteelBlue;
            this.guna2cmbChucVu.BorderRadius = 10;
            this.guna2cmbChucVu.BorderThickness = 2;
            this.guna2cmbChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2cmbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2cmbChucVu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2cmbChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2cmbChucVu.FocusedState.Parent = this.guna2cmbChucVu;
            this.guna2cmbChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2cmbChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2cmbChucVu.HoverState.Parent = this.guna2cmbChucVu;
            this.guna2cmbChucVu.ItemHeight = 30;
            this.guna2cmbChucVu.ItemsAppearance.Parent = this.guna2cmbChucVu;
            this.guna2cmbChucVu.Location = new System.Drawing.Point(653, 76);
            this.guna2cmbChucVu.Name = "guna2cmbChucVu";
            this.guna2cmbChucVu.ShadowDecoration.Parent = this.guna2cmbChucVu;
            this.guna2cmbChucVu.Size = new System.Drawing.Size(301, 36);
            this.guna2cmbChucVu.TabIndex = 209;
            // 
            // guna2txtMatKhau
            // 
            this.guna2txtMatKhau.BorderColor = System.Drawing.Color.SteelBlue;
            this.guna2txtMatKhau.BorderRadius = 10;
            this.guna2txtMatKhau.BorderThickness = 2;
            this.guna2txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2txtMatKhau.DefaultText = "";
            this.guna2txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtMatKhau.DisabledState.Parent = this.guna2txtMatKhau;
            this.guna2txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtMatKhau.FocusedState.Parent = this.guna2txtMatKhau;
            this.guna2txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2txtMatKhau.HoverState.Parent = this.guna2txtMatKhau;
            this.guna2txtMatKhau.Location = new System.Drawing.Point(653, 168);
            this.guna2txtMatKhau.Name = "guna2txtMatKhau";
            this.guna2txtMatKhau.PasswordChar = '\0';
            this.guna2txtMatKhau.PlaceholderText = "";
            this.guna2txtMatKhau.SelectedText = "";
            this.guna2txtMatKhau.ShadowDecoration.Parent = this.guna2txtMatKhau;
            this.guna2txtMatKhau.Size = new System.Drawing.Size(301, 31);
            this.guna2txtMatKhau.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2txtMatKhau.TabIndex = 210;
            // 
            // UC_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2txtMatKhau);
            this.Controls.Add(this.guna2cmbChucVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ToggleSwitch2);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.Controls.Add(this.btnCapNhap);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.guna2txtGmail);
            this.Controls.Add(this.guna2txtSDT);
            this.Controls.Add(this.guna2txtDiaChi);
            this.Controls.Add(this.guna2txtTimKiem);
            this.Controls.Add(this.guna2txtTenKhachHang);
            this.Controls.Add(this.guna2txtMaKhachHang);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvThongTinKhachHang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(1069, 791);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKhachHang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvThongTinKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtMaKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtTenKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtGmail;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtDiaChi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhap;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox guna2cmbChucVu;
        private Guna.UI2.WinForms.Guna2TextBox guna2txtMatKhau;
    }
}
