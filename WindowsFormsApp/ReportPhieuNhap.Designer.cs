
namespace WindowsFormsApp
{
    partial class ReportPhieuNhap
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new WindowsFormsApp.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbLoaiHH = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPhanTram = new System.Windows.Forms.TextBox();
            this.dpkNgayban = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTennv = new System.Windows.Forms.Label();
            this.lblManv = new System.Windows.Forms.Label();
            this.txtMaHĐ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTenmh = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMakh = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.Label();
            this.lvSanPhamBan = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTienhoantra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTienkhachdua = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbTienBangChu = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lbTienBangSo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.btnThemMatMH = new System.Windows.Forms.Button();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp.Report.ReportPhieuNhap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1535, 1093);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmbLoaiHH
            // 
            this.cmbLoaiHH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbLoaiHH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLoaiHH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbLoaiHH.FormattingEnabled = true;
            this.cmbLoaiHH.Location = new System.Drawing.Point(1281, 71);
            this.cmbLoaiHH.Name = "cmbLoaiHH";
            this.cmbLoaiHH.Size = new System.Drawing.Size(171, 28);
            this.cmbLoaiHH.TabIndex = 233;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(1161, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 29);
            this.label17.TabIndex = 232;
            this.label17.Text = "Loại MH :";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(437, 726);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 29);
            this.label16.TabIndex = 231;
            this.label16.Text = "%";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(219, 726);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 29);
            this.label15.TabIndex = 230;
            this.label15.Text = "Giảm giá:";
            // 
            // txtPhanTram
            // 
            this.txtPhanTram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhanTram.ForeColor = System.Drawing.Color.Black;
            this.txtPhanTram.Location = new System.Drawing.Point(346, 720);
            this.txtPhanTram.Name = "txtPhanTram";
            this.txtPhanTram.ReadOnly = true;
            this.txtPhanTram.Size = new System.Drawing.Size(85, 26);
            this.txtPhanTram.TabIndex = 229;
            // 
            // dpkNgayban
            // 
            this.dpkNgayban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dpkNgayban.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkNgayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkNgayban.Location = new System.Drawing.Point(346, 786);
            this.dpkNgayban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpkNgayban.Name = "dpkNgayban";
            this.dpkNgayban.Size = new System.Drawing.Size(249, 32);
            this.dpkNgayban.TabIndex = 228;
            this.dpkNgayban.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(221, 786);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 35);
            this.label10.TabIndex = 227;
            this.label10.Text = "Ngày bán:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(392, 871);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 35);
            this.label12.TabIndex = 226;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(206, 873);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 35);
            this.label11.TabIndex = 225;
            this.label11.Text = "Người bán:";
            // 
            // lblTennv
            // 
            this.lblTennv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTennv.AutoSize = true;
            this.lblTennv.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennv.ForeColor = System.Drawing.Color.Black;
            this.lblTennv.Location = new System.Drawing.Point(409, 873);
            this.lblTennv.Name = "lblTennv";
            this.lblTennv.Size = new System.Drawing.Size(22, 35);
            this.lblTennv.TabIndex = 224;
            this.lblTennv.Text = "t";
            // 
            // lblManv
            // 
            this.lblManv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblManv.AutoSize = true;
            this.lblManv.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManv.ForeColor = System.Drawing.Color.Black;
            this.lblManv.Location = new System.Drawing.Point(321, 881);
            this.lblManv.Name = "lblManv";
            this.lblManv.Size = new System.Drawing.Size(76, 25);
            this.lblManv.TabIndex = 223;
            this.lblManv.Text = "NV003";
            // 
            // txtMaHĐ
            // 
            this.txtMaHĐ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaHĐ.ForeColor = System.Drawing.Color.Black;
            this.txtMaHĐ.Location = new System.Drawing.Point(162, 128);
            this.txtMaHĐ.Name = "txtMaHĐ";
            this.txtMaHĐ.ReadOnly = true;
            this.txtMaHĐ.Size = new System.Drawing.Size(109, 26);
            this.txtMaHĐ.TabIndex = 222;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(83, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 221;
            this.label3.Text = "Mã HĐ:";
            // 
            // cmbTenmh
            // 
            this.cmbTenmh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTenmh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTenmh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbTenmh.FormattingEnabled = true;
            this.cmbTenmh.Location = new System.Drawing.Point(816, 71);
            this.cmbTenmh.Name = "cmbTenmh";
            this.cmbTenmh.Size = new System.Drawing.Size(284, 28);
            this.cmbTenmh.TabIndex = 220;
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
            this.txtSoLuong.Location = new System.Drawing.Point(866, 149);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ShadowDecoration.Parent = this.txtSoLuong;
            this.txtSoLuong.Size = new System.Drawing.Size(171, 36);
            this.txtSoLuong.TabIndex = 219;
            this.txtSoLuong.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.txtSoLuong.UpDownButtonForeColor = System.Drawing.Color.White;
            this.txtSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMaMH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaMH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(500, 71);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(129, 28);
            this.cmbMaMH.TabIndex = 211;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.lblMakh);
            this.panelRight.Controls.Add(this.lvSanPhamBan);
            this.panelRight.Controls.Add(this.panel4);
            this.panelRight.Location = new System.Drawing.Point(588, 224);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(522, 666);
            this.panelRight.TabIndex = 218;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(1253, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 35);
            this.label9.TabIndex = 195;
            this.label9.Text = ":";
            // 
            // lblMakh
            // 
            this.lblMakh.AutoSize = true;
            this.lblMakh.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakh.ForeColor = System.Drawing.Color.White;
            this.lblMakh.Location = new System.Drawing.Point(168, 74);
            this.lblMakh.Name = "lblMakh";
            this.lblMakh.Size = new System.Drawing.Size(44, 25);
            this.lblMakh.TabIndex = 11;
            this.lblMakh.Text = "UN";
            // 
            // txtSDT
            // 
            this.txtSDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSDT.Location = new System.Drawing.Point(1191, 195);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(273, 26);
            this.txtSDT.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1026, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "NHẬP SĐT:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.AutoSize = true;
            this.txtTenKH.Font = new System.Drawing.Font("Sitka Banner", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.txtTenKH.Location = new System.Drawing.Point(1264, 328);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(188, 38);
            this.txtTenKH.TabIndex = 7;
            this.txtTenKH.Text = "UNKNOW NAME";
            // 
            // lvSanPhamBan
            // 
            this.lvSanPhamBan.CheckBoxes = true;
            this.lvSanPhamBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSanPhamBan.GridLines = true;
            this.lvSanPhamBan.HideSelection = false;
            this.lvSanPhamBan.Location = new System.Drawing.Point(3, 123);
            this.lvSanPhamBan.Name = "lvSanPhamBan";
            this.lvSanPhamBan.Size = new System.Drawing.Size(516, 241);
            this.lvSanPhamBan.TabIndex = 5;
            this.lvSanPhamBan.UseCompatibleStateImageBehavior = false;
            this.lvSanPhamBan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã SP";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên SP";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SL";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thành tiền";
            this.columnHeader5.Width = 150;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtTienhoantra);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtTienkhachdua);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.lbTienBangChu);
            this.panel4.Controls.Add(this.btnThanhToan);
            this.panel4.Controls.Add(this.lbTienBangSo);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnXoaMH);
            this.panel4.Location = new System.Drawing.Point(18, 417);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(516, 224);
            this.panel4.TabIndex = 4;
            // 
            // txtTienhoantra
            // 
            this.txtTienhoantra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTienhoantra.ForeColor = System.Drawing.Color.Black;
            this.txtTienhoantra.Location = new System.Drawing.Point(186, 115);
            this.txtTienhoantra.Name = "txtTienhoantra";
            this.txtTienhoantra.ReadOnly = true;
            this.txtTienhoantra.Size = new System.Drawing.Size(266, 26);
            this.txtTienhoantra.TabIndex = 200;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(3, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 29);
            this.label14.TabIndex = 199;
            this.label14.Text = "Tiền hoàn trả:";
            // 
            // txtTienkhachdua
            // 
            this.txtTienkhachdua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTienkhachdua.ForeColor = System.Drawing.Color.Black;
            this.txtTienkhachdua.Location = new System.Drawing.Point(186, 77);
            this.txtTienkhachdua.Name = "txtTienkhachdua";
            this.txtTienkhachdua.Size = new System.Drawing.Size(266, 26);
            this.txtTienkhachdua.TabIndex = 198;
            this.txtTienkhachdua.Text = "000";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(3, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 29);
            this.label13.TabIndex = 197;
            this.label13.Text = "Tiền khách đưa:";
            // 
            // lbTienBangChu
            // 
            this.lbTienBangChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTienBangChu.AutoSize = true;
            this.lbTienBangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienBangChu.ForeColor = System.Drawing.Color.Black;
            this.lbTienBangChu.Location = new System.Drawing.Point(178, 44);
            this.lbTienBangChu.Name = "lbTienBangChu";
            this.lbTienBangChu.Size = new System.Drawing.Size(159, 30);
            this.lbTienBangChu.TabIndex = 5;
            this.lbTienBangChu.Text = "Không đồng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(288, 159);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(193, 62);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // lbTienBangSo
            // 
            this.lbTienBangSo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTienBangSo.AutoSize = true;
            this.lbTienBangSo.BackColor = System.Drawing.Color.White;
            this.lbTienBangSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienBangSo.ForeColor = System.Drawing.Color.Black;
            this.lbTienBangSo.Location = new System.Drawing.Point(212, 12);
            this.lbTienBangSo.Name = "lbTienBangSo";
            this.lbTienBangSo.Size = new System.Drawing.Size(102, 32);
            this.lbTienBangSo.TabIndex = 0;
            this.lbTienBangSo.Text = "0 VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng tiền :";
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnXoaMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaMH.FlatAppearance.BorderSize = 0;
            this.btnXoaMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMH.ForeColor = System.Drawing.Color.White;
            this.btnXoaMH.Location = new System.Drawing.Point(26, 159);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(191, 62);
            this.btnXoaMH.TabIndex = 2;
            this.btnXoaMH.Text = "Xóa";
            this.btnXoaMH.UseVisualStyleBackColor = false;
            // 
            // btnThemMatMH
            // 
            this.btnThemMatMH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemMatMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnThemMatMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMatMH.FlatAppearance.BorderSize = 0;
            this.btnThemMatMH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThemMatMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMatMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMatMH.ForeColor = System.Drawing.Color.Transparent;
            this.btnThemMatMH.Location = new System.Drawing.Point(493, 852);
            this.btnThemMatMH.Name = "btnThemMatMH";
            this.btnThemMatMH.Size = new System.Drawing.Size(151, 44);
            this.btnThemMatMH.TabIndex = 217;
            this.btnThemMatMH.Text = "Thêm";
            this.btnThemMatMH.UseVisualStyleBackColor = false;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGiaBan.ForeColor = System.Drawing.Color.Black;
            this.txtGiaBan.Location = new System.Drawing.Point(490, 195);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(172, 26);
            this.txtGiaBan.TabIndex = 216;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(382, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 214;
            this.label6.Text = "Giá bán:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(694, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 213;
            this.label5.Text = "Số Lượng :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(694, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 215;
            this.label2.Text = "Tên MH :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(393, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 212;
            this.label1.Text = "Mã MH :";
            // 
            // ReportPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 1093);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbLoaiHH);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPhanTram);
            this.Controls.Add(this.dpkNgayban);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTennv);
            this.Controls.Add(this.lblManv);
            this.Controls.Add(this.txtMaHĐ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTenmh);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cmbMaMH);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.btnThemMatMH);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportPhieuNhap";
            this.Load += new System.EventHandler(this.ReportPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.ComboBox cmbLoaiHH;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPhanTram;
        private System.Windows.Forms.DateTimePicker dpkNgayban;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTennv;
        private System.Windows.Forms.Label lblManv;
        private System.Windows.Forms.TextBox txtMaHĐ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTenmh;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtSoLuong;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMakh;
        public System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtTenKH;
        private System.Windows.Forms.ListView lvSanPhamBan;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTienhoantra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTienkhachdua;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTienBangChu;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lbTienBangSo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.Button btnThemMatMH;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}