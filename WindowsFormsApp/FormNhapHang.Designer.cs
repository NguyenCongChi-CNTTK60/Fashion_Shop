
namespace WindowsFormsApp
{
    partial class FormNhapHang
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
            this.label12 = new System.Windows.Forms.Label();
            this.lblMapn = new System.Windows.Forms.Label();
            this.lsvNhaphang = new System.Windows.Forms.ListView();
            this.lbltong = new System.Windows.Forms.Label();
            this.lbltensp = new System.Windows.Forms.Label();
            this.lblmasp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTensp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpkNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.lblMancc = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTenncc = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbTenncc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSĐT = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblManv = new System.Windows.Forms.Label();
            this.lblTennv = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLammoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(886, 626);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 35);
            this.label12.TabIndex = 64;
            this.label12.Text = "Tổng:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblMapn
            // 
            this.lblMapn.AutoSize = true;
            this.lblMapn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMapn.Location = new System.Drawing.Point(178, 65);
            this.lblMapn.Name = "lblMapn";
            this.lblMapn.Size = new System.Drawing.Size(67, 22);
            this.lblMapn.TabIndex = 62;
            this.lblMapn.Text = "MaPN:";
            // 
            // lsvNhaphang
            // 
            this.lsvNhaphang.CheckBoxes = true;
            this.lsvNhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvNhaphang.HideSelection = false;
            this.lsvNhaphang.Location = new System.Drawing.Point(38, 396);
            this.lsvNhaphang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvNhaphang.Name = "lsvNhaphang";
            this.lsvNhaphang.Size = new System.Drawing.Size(965, 214);
            this.lsvNhaphang.TabIndex = 59;
            this.lsvNhaphang.UseCompatibleStateImageBehavior = false;
            // 
            // lbltong
            // 
            this.lbltong.AutoSize = true;
            this.lbltong.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbltong.Location = new System.Drawing.Point(967, 636);
            this.lbltong.Name = "lbltong";
            this.lbltong.Size = new System.Drawing.Size(15, 21);
            this.lbltong.TabIndex = 58;
            this.lbltong.Text = ".";
            // 
            // lbltensp
            // 
            this.lbltensp.AutoSize = true;
            this.lbltensp.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltensp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbltensp.Location = new System.Drawing.Point(939, 221);
            this.lbltensp.Name = "lbltensp";
            this.lbltensp.Size = new System.Drawing.Size(64, 21);
            this.lbltensp.TabIndex = 56;
            this.lbltensp.Text = "TenSP:";
            // 
            // lblmasp
            // 
            this.lblmasp.AutoSize = true;
            this.lblmasp.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmasp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblmasp.Location = new System.Drawing.Point(185, 107);
            this.lblmasp.Name = "lblmasp";
            this.lblmasp.Size = new System.Drawing.Size(60, 21);
            this.lblmasp.TabIndex = 55;
            this.lblmasp.Text = "MaSP:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 35);
            this.label11.TabIndex = 53;
            this.label11.Text = "Giá nhập:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 35);
            this.label10.TabIndex = 52;
            this.label10.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(760, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 35);
            this.label8.TabIndex = 50;
            this.label8.Text = "Tên sản phẩm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 35);
            this.label7.TabIndex = 49;
            this.label7.Text = "Mã sản phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 35);
            this.label6.TabIndex = 47;
            this.label6.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(797, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 35);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ngày nhập hàng:";
            // 
            // cmbTensp
            // 
            this.cmbTensp.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTensp.ForeColor = System.Drawing.Color.Maroon;
            this.cmbTensp.FormattingEnabled = true;
            this.cmbTensp.Location = new System.Drawing.Point(155, 143);
            this.cmbTensp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTensp.Name = "cmbTensp";
            this.cmbTensp.Size = new System.Drawing.Size(200, 34);
            this.cmbTensp.TabIndex = 40;
            this.cmbTensp.SelectedIndexChanged += new System.EventHandler(this.cmbTensp_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 35);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mã phiếu nhập:";
            // 
            // dtpkNgaynhap
            // 
            this.dtpkNgaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgaynhap.Location = new System.Drawing.Point(760, 339);
            this.dtpkNgaynhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkNgaynhap.Name = "dtpkNgaynhap";
            this.dtpkNgaynhap.Size = new System.Drawing.Size(222, 28);
            this.dtpkNgaynhap.TabIndex = 66;
            // 
            // lblMancc
            // 
            this.lblMancc.AutoSize = true;
            this.lblMancc.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMancc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMancc.Location = new System.Drawing.Point(560, 75);
            this.lblMancc.Name = "lblMancc";
            this.lblMancc.Size = new System.Drawing.Size(77, 21);
            this.lblMancc.TabIndex = 71;
            this.lblMancc.Text = "MaNCC:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(458, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 35);
            this.label14.TabIndex = 70;
            this.label14.Text = "Mã NCC:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(760, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 35);
            this.label15.TabIndex = 72;
            this.label15.Text = "Tên NCC:";
            // 
            // lblTenncc
            // 
            this.lblTenncc.AutoSize = true;
            this.lblTenncc.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenncc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTenncc.Location = new System.Drawing.Point(901, 263);
            this.lblTenncc.Name = "lblTenncc";
            this.lblTenncc.Size = new System.Drawing.Size(81, 21);
            this.lblTenncc.TabIndex = 73;
            this.lblTenncc.Text = "TenNCC:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(439, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 35);
            this.label17.TabIndex = 75;
            this.label17.Text = "Tên NCC:";
            // 
            // cmbTenncc
            // 
            this.cmbTenncc.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenncc.ForeColor = System.Drawing.Color.Maroon;
            this.cmbTenncc.FormattingEnabled = true;
            this.cmbTenncc.Location = new System.Drawing.Point(563, 107);
            this.cmbTenncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTenncc.Name = "cmbTenncc";
            this.cmbTenncc.Size = new System.Drawing.Size(197, 34);
            this.cmbTenncc.TabIndex = 74;
            this.cmbTenncc.SelectedIndexChanged += new System.EventHandler(this.cmbTenncc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 35);
            this.label4.TabIndex = 76;
            this.label4.Text = "Địa chỉ:";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDiachi.Location = new System.Drawing.Point(560, 170);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(65, 21);
            this.lblDiachi.TabIndex = 77;
            this.lblDiachi.Text = "DiaChi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(458, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 35);
            this.label9.TabIndex = 78;
            this.label9.Text = "SĐT:";
            // 
            // lblSĐT
            // 
            this.lblSĐT.AutoSize = true;
            this.lblSĐT.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSĐT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSĐT.Location = new System.Drawing.Point(547, 211);
            this.lblSĐT.Name = "lblSĐT";
            this.lblSĐT.Size = new System.Drawing.Size(49, 21);
            this.lblSĐT.TabIndex = 79;
            this.lblSĐT.Text = "SDT:";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(155, 197);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(251, 30);
            this.txtGia.TabIndex = 80;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(155, 280);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(251, 30);
            this.txtSoLuong.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 35);
            this.label5.TabIndex = 82;
            this.label5.Text = "Nhân viên nhập:";
            // 
            // lblManv
            // 
            this.lblManv.AutoSize = true;
            this.lblManv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblManv.Location = new System.Drawing.Point(328, 368);
            this.lblManv.Name = "lblManv";
            this.lblManv.Size = new System.Drawing.Size(42, 22);
            this.lblManv.TabIndex = 83;
            this.lblManv.Text = "Mã:";
            // 
            // lblTennv
            // 
            this.lblTennv.AutoSize = true;
            this.lblTennv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTennv.Location = new System.Drawing.Point(203, 368);
            this.lblTennv.Name = "lblTennv";
            this.lblTennv.Size = new System.Drawing.Size(71, 22);
            this.lblTennv.TabIndex = 84;
            this.lblTennv.Text = "TenNV:";
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(361, 144);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(45, 34);
            this.btnThemSP.TabIndex = 85;
            this.btnThemSP.Text = "+";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtGiaban
            // 
            this.txtGiaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaban.Location = new System.Drawing.Point(155, 239);
            this.txtGiaban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaban.Multiline = true;
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(251, 30);
            this.txtGiaban.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 35);
            this.label13.TabIndex = 86;
            this.label13.Text = "Giá bán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 35);
            this.label1.TabIndex = 88;
            this.label1.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(547, 263);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 21);
            this.lblEmail.TabIndex = 89;
            this.lblEmail.Text = "Email:";
            // 
            // btnThem
            // 
            this.btnThem.AutoRoundedCorners = true;
            this.btnThem.BorderRadius = 22;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.DisabledState.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnThem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.btnThem.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(53, 615);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(148, 46);
            this.btnThem.TabIndex = 133;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoRoundedCorners = true;
            this.btnLuu.BorderRadius = 22;
            this.btnLuu.CheckedState.Parent = this.btnLuu;
            this.btnLuu.CustomImages.Parent = this.btnLuu;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.DisabledState.Parent = this.btnLuu;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnLuu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.btnLuu.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnLuu.HoverState.Parent = this.btnLuu;
            this.btnLuu.Location = new System.Drawing.Point(222, 615);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(148, 46);
            this.btnLuu.TabIndex = 134;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnLammoi
            // 
            this.btnLammoi.AutoRoundedCorners = true;
            this.btnLammoi.BorderRadius = 22;
            this.btnLammoi.CheckedState.Parent = this.btnLammoi;
            this.btnLammoi.CustomImages.Parent = this.btnLammoi;
            this.btnLammoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLammoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLammoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLammoi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLammoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLammoi.DisabledState.Parent = this.btnLammoi;
            this.btnLammoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnLammoi.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnLammoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLammoi.ForeColor = System.Drawing.Color.White;
            this.btnLammoi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.btnLammoi.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnLammoi.HoverState.Parent = this.btnLammoi;
            this.btnLammoi.Location = new System.Drawing.Point(391, 615);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.ShadowDecoration.Parent = this.btnLammoi;
            this.btnLammoi.Size = new System.Drawing.Size(148, 46);
            this.btnLammoi.TabIndex = 135;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BorderRadius = 22;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.DisabledState.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnXoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.btnXoa.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(564, 615);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(148, 46);
            this.btnXoa.TabIndex = 136;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 684);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGiaban);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.lblTennv);
            this.Controls.Add(this.lblManv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lblSĐT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbTenncc);
            this.Controls.Add(this.lblTenncc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblMancc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpkNgaynhap);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblMapn);
            this.Controls.Add(this.lsvNhaphang);
            this.Controls.Add(this.lbltong);
            this.Controls.Add(this.lbltensp);
            this.Controls.Add(this.lblmasp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTensp);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhaphang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMapn;
        private System.Windows.Forms.ListView lsvNhaphang;
        private System.Windows.Forms.Label lbltong;
        private System.Windows.Forms.Label lbltensp;
        private System.Windows.Forms.Label lblmasp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTensp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpkNgaynhap;
        private System.Windows.Forms.Label lblMancc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTenncc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbTenncc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSĐT;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblManv;
        private System.Windows.Forms.Label lblTennv;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnLammoi;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
    }
}