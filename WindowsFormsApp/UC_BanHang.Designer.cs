namespace WindowsFormsApp
{
    partial class UC_BanHang
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnThemMatHang = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnThemMoiKH = new System.Windows.Forms.Button();
            this.txtInPutNumberPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.Label();
            this.btnXoaMatHang = new System.Windows.Forms.Button();
            this.lvSanPhamBan = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbTienBangChu = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lbTienBangSo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelRight.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã MH :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên MH:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(43, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn Vị :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito", 10.8F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số Lượng :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nunito", 10.8F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(76, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giá :";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenMH.ForeColor = System.Drawing.Color.Black;
            this.txtTenMH.Location = new System.Drawing.Point(138, 155);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(278, 32);
            this.txtTenMH.TabIndex = 3;
            // 
            // txtGia
            // 
            this.txtGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGia.ForeColor = System.Drawing.Color.Black;
            this.txtGia.Location = new System.Drawing.Point(138, 350);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(278, 32);
            this.txtGia.TabIndex = 3;
            // 
            // btnThemMatHang
            // 
            this.btnThemMatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemMatHang.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThemMatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMatHang.FlatAppearance.BorderSize = 0;
            this.btnThemMatHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThemMatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMatHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMatHang.ForeColor = System.Drawing.Color.Transparent;
            this.btnThemMatHang.Location = new System.Drawing.Point(265, 398);
            this.btnThemMatHang.Name = "btnThemMatHang";
            this.btnThemMatHang.Size = new System.Drawing.Size(151, 44);
            this.btnThemMatHang.TabIndex = 7;
            this.btnThemMatHang.Text = "Thêm";
            this.btnThemMatHang.UseVisualStyleBackColor = false;
            this.btnThemMatHang.Click += new System.EventHandler(this.btnThemMatHang_Click_1);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Silver;
            this.panelRight.Controls.Add(this.lvSanPhamBan);
            this.panelRight.Controls.Add(this.btnThemMoiKH);
            this.panelRight.Controls.Add(this.txtInPutNumberPhone);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.txtTenKH);
            this.panelRight.Controls.Add(this.panel4);
            this.panelRight.Controls.Add(this.flowLayoutPanel1);
            this.panelRight.Controls.Add(this.panel3);
            this.panelRight.Location = new System.Drawing.Point(483, 65);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(491, 540);
            this.panelRight.TabIndex = 8;
            // 
            // btnThemMoiKH
            // 
            this.btnThemMoiKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemMoiKH.AutoSize = true;
            this.btnThemMoiKH.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThemMoiKH.ForeColor = System.Drawing.Color.White;
            this.btnThemMoiKH.Location = new System.Drawing.Point(408, 18);
            this.btnThemMoiKH.Name = "btnThemMoiKH";
            this.btnThemMoiKH.Size = new System.Drawing.Size(35, 33);
            this.btnThemMoiKH.TabIndex = 10;
            this.btnThemMoiKH.Text = "+";
            this.btnThemMoiKH.UseVisualStyleBackColor = false;
            this.btnThemMoiKH.Click += new System.EventHandler(this.btnThemMoiKH_Click_1);
            // 
            // txtInPutNumberPhone
            // 
            this.txtInPutNumberPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtInPutNumberPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtInPutNumberPhone.Location = new System.Drawing.Point(144, 13);
            this.txtInPutNumberPhone.MaxLength = 10;
            this.txtInPutNumberPhone.Name = "txtInPutNumberPhone";
            this.txtInPutNumberPhone.Size = new System.Drawing.Size(225, 32);
            this.txtInPutNumberPhone.TabIndex = 9;
            this.txtInPutNumberPhone.TextChanged += new System.EventHandler(this.txtInPutNumberPhone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(22, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "NHẬP SĐT:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.AutoSize = true;
            this.txtTenKH.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtTenKH.Location = new System.Drawing.Point(139, 48);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(179, 26);
            this.txtTenKH.TabIndex = 7;
            this.txtTenKH.Text = "UNKNOW NAME";
            // 
            // btnXoaMatHang
            // 
            this.btnXoaMatHang.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoaMatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaMatHang.FlatAppearance.BorderSize = 0;
            this.btnXoaMatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMatHang.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMatHang.ForeColor = System.Drawing.Color.White;
            this.btnXoaMatHang.Location = new System.Drawing.Point(16, 102);
            this.btnXoaMatHang.Name = "btnXoaMatHang";
            this.btnXoaMatHang.Size = new System.Drawing.Size(162, 49);
            this.btnXoaMatHang.TabIndex = 2;
            this.btnXoaMatHang.Text = "Xóa";
            this.btnXoaMatHang.UseVisualStyleBackColor = false;
            this.btnXoaMatHang.Click += new System.EventHandler(this.btnXoaMatHang_Click_1);
            // 
            // lvSanPhamBan
            // 
            this.lvSanPhamBan.CheckBoxes = true;
            this.lvSanPhamBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvSanPhamBan.Font = new System.Drawing.Font("Nunito", 10.8F);
            this.lvSanPhamBan.GridLines = true;
            this.lvSanPhamBan.HideSelection = false;
            this.lvSanPhamBan.Location = new System.Drawing.Point(16, 92);
            this.lvSanPhamBan.Name = "lvSanPhamBan";
            this.lvSanPhamBan.Size = new System.Drawing.Size(459, 265);
            this.lvSanPhamBan.TabIndex = 5;
            this.lvSanPhamBan.UseCompatibleStateImageBehavior = false;
            this.lvSanPhamBan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã SP";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên SP";
            this.columnHeader6.Width = 160;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SL";
            this.columnHeader7.Width = 35;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Thành Tiền";
            this.columnHeader8.Width = 140;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.lbTienBangChu);
            this.panel4.Controls.Add(this.btnThanhToan);
            this.panel4.Controls.Add(this.lbTienBangSo);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnXoaMatHang);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 373);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(471, 167);
            this.panel4.TabIndex = 4;
            // 
            // lbTienBangChu
            // 
            this.lbTienBangChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTienBangChu.AutoSize = true;
            this.lbTienBangChu.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienBangChu.ForeColor = System.Drawing.Color.White;
            this.lbTienBangChu.Location = new System.Drawing.Point(273, 58);
            this.lbTienBangChu.Name = "lbTienBangChu";
            this.lbTienBangChu.Size = new System.Drawing.Size(143, 26);
            this.lbTienBangChu.TabIndex = 5;
            this.lbTienBangChu.Text = "Không đồng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(246, 102);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(143, 49);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click_1);
            // 
            // lbTienBangSo
            // 
            this.lbTienBangSo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTienBangSo.AutoSize = true;
            this.lbTienBangSo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienBangSo.ForeColor = System.Drawing.Color.White;
            this.lbTienBangSo.Location = new System.Drawing.Point(306, 7);
            this.lbTienBangSo.Name = "lbTienBangSo";
            this.lbTienBangSo.Size = new System.Drawing.Size(85, 28);
            this.lbTienBangSo.TabIndex = 0;
            this.lbTienBangSo.Text = "0 VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng tiền :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.panel5.Location = new System.Drawing.Point(0, 157);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(471, 10);
            this.panel5.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(481, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 540);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 540);
            this.panel3.TabIndex = 4;
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMaMH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaMH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(138, 91);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(278, 31);
            this.cmbMaMH.TabIndex = 1;
            this.cmbMaMH.SelectedIndexChanged += new System.EventHandler(this.cmbMaMH_SelectedIndexChanged);
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.txtDonViTinh.Location = new System.Drawing.Point(138, 221);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(278, 32);
            this.txtDonViTinh.TabIndex = 92;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.DisabledState.Parent = this.txtSoLuong;
            this.txtSoLuong.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txtSoLuong.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txtSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.FocusedState.Parent = this.txtSoLuong;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtSoLuong.Location = new System.Drawing.Point(138, 285);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ShadowDecoration.Parent = this.txtSoLuong;
            this.txtSoLuong.Size = new System.Drawing.Size(278, 36);
            this.txtSoLuong.TabIndex = 93;
            this.txtSoLuong.UpDownButtonFillColor = System.Drawing.Color.SteelBlue;
            this.txtSoLuong.UpDownButtonForeColor = System.Drawing.Color.White;
            this.txtSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 462);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 127);
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 59);
            this.panel1.TabIndex = 186;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nunito", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(341, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 32);
            this.label7.TabIndex = 183;
            this.label7.Text = "Thông tin khách hàng";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(422, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 43);
            this.button2.TabIndex = 187;
            this.button2.Text = "QR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UC_Sell
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.cmbMaMH);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.btnThemMatHang);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Sell";
            this.Size = new System.Drawing.Size(977, 608);
            this.Load += new System.EventHandler(this.UC_Sell_Load);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnThemMatHang;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnXoaMatHang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lbTienBangSo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;

        private System.Windows.Forms.TextBox txtDonViTinh;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtSoLuong;
        private System.Windows.Forms.ListView lvSanPhamBan;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lbTienBangChu;
        private System.Windows.Forms.Label txtTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemMoiKH;
        public System.Windows.Forms.TextBox txtInPutNumberPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}
