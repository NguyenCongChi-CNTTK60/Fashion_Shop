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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.khachHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiemKhachHang = new System.Windows.Forms.TextBox();
            this.txtDienThoaiKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDiaChiKhachHang = new System.Windows.Forms.RichTextBox();
            this.txtEmailKH = new System.Windows.Forms.TextBox();
            this.btnLamMoiKhachHang = new System.Windows.Forms.Button();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.btnXoaKhachHang = new System.Windows.Forms.Button();
            this.btnSuaKhachHang = new System.Windows.Forms.Button();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvKhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbHang = new System.Windows.Forms.ComboBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // khachHangBindingSource1
            // 
            this.khachHangBindingSource1.DataMember = "KhachHang";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label9.Location = new System.Drawing.Point(241, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(605, 58);
            this.label9.TabIndex = 71;
            this.label9.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // txtTimKiemKhachHang
            // 
            this.txtTimKiemKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiemKhachHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemKhachHang.Location = new System.Drawing.Point(149, 268);
            this.txtTimKiemKhachHang.Name = "txtTimKiemKhachHang";
            this.txtTimKiemKhachHang.Size = new System.Drawing.Size(340, 32);
            this.txtTimKiemKhachHang.TabIndex = 66;

            // 
            // txtDienThoaiKH
            // 
            this.txtDienThoaiKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDienThoaiKH.Enabled = false;
            this.txtDienThoaiKH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoaiKH.Location = new System.Drawing.Point(149, 152);
            this.txtDienThoaiKH.MaxLength = 10;
            this.txtDienThoaiKH.Name = "txtDienThoaiKH";
            this.txtDienThoaiKH.Size = new System.Drawing.Size(340, 32);
            this.txtDienThoaiKH.TabIndex = 2;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaKH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(149, 104);
            this.txtMaKH.MaxLength = 10;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(340, 32);
            this.txtMaKH.TabIndex = 10;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(627, 104);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(340, 32);
            this.txtTenKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "Tìm Kiếm :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 62;
            this.label7.Text = "Điện Thoại :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 60;
            this.label6.Text = "Mã KH :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(544, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 59;
            this.label8.Text = "Email:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "Tên KH :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 62;
            this.label3.Text = "Địa Chỉ :";
            // 
            // rtbDiaChiKhachHang
            // 
            this.rtbDiaChiKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbDiaChiKhachHang.Enabled = false;
            this.rtbDiaChiKhachHang.Location = new System.Drawing.Point(149, 204);
            this.rtbDiaChiKhachHang.Name = "rtbDiaChiKhachHang";
            this.rtbDiaChiKhachHang.Size = new System.Drawing.Size(340, 49);
            this.rtbDiaChiKhachHang.TabIndex = 4;
            this.rtbDiaChiKhachHang.Text = "";
            // 
            // txtEmailKH
            // 
            this.txtEmailKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailKH.Enabled = false;
            this.txtEmailKH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailKH.Location = new System.Drawing.Point(627, 152);
            this.txtEmailKH.Name = "txtEmailKH";
            this.txtEmailKH.Size = new System.Drawing.Size(340, 32);
            this.txtEmailKH.TabIndex = 3;
            // 
            // btnLamMoiKhachHang
            // 
            this.btnLamMoiKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLamMoiKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLamMoiKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiKhachHang.FlatAppearance.BorderSize = 0;
            this.btnLamMoiKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLamMoiKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoiKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoiKhachHang.Image")));
            this.btnLamMoiKhachHang.Location = new System.Drawing.Point(690, 629);
            this.btnLamMoiKhachHang.Name = "btnLamMoiKhachHang";
            this.btnLamMoiKhachHang.Size = new System.Drawing.Size(177, 38);
            this.btnLamMoiKhachHang.TabIndex = 73;
            this.btnLamMoiKhachHang.Text = "Làm Mới";
            this.btnLamMoiKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoiKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoiKhachHang.UseVisualStyleBackColor = false;

            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnThemKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemKhachHang.FlatAppearance.BorderSize = 0;
            this.btnThemKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThemKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnThemKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKhachHang.Image")));
            this.btnThemKhachHang.Location = new System.Drawing.Point(48, 629);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(182, 38);
            this.btnThemKhachHang.TabIndex = 6;
            this.btnThemKhachHang.Text = "Thêm Mới";
            this.btnThemKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemKhachHang.UseVisualStyleBackColor = false;
   
            // 
            // btnXoaKhachHang
            // 
            this.btnXoaKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnXoaKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKhachHang.FlatAppearance.BorderSize = 0;
            this.btnXoaKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnXoaKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKhachHang.Image")));
            this.btnXoaKhachHang.Location = new System.Drawing.Point(477, 629);
            this.btnXoaKhachHang.Name = "btnXoaKhachHang";
            this.btnXoaKhachHang.Size = new System.Drawing.Size(177, 38);
            this.btnXoaKhachHang.TabIndex = 68;
            this.btnXoaKhachHang.Text = "Xóa";
            this.btnXoaKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaKhachHang.UseVisualStyleBackColor = false;

            // 
            // btnSuaKhachHang
            // 
            this.btnSuaKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSuaKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaKhachHang.FlatAppearance.BorderSize = 0;
            this.btnSuaKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSuaKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaKhachHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnSuaKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKhachHang.Image")));
            this.btnSuaKhachHang.Location = new System.Drawing.Point(266, 629);
            this.btnSuaKhachHang.Name = "btnSuaKhachHang";
            this.btnSuaKhachHang.Size = new System.Drawing.Size(182, 38);
            this.btnSuaKhachHang.TabIndex = 69;
            this.btnSuaKhachHang.Text = "Sửa";
            this.btnSuaKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaKhachHang.UseVisualStyleBackColor = false;
   
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.Location = new System.Drawing.Point(48, 324);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 30;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(919, 272);
            this.dgvKhachHang.TabIndex = 74;
            this.dgvKhachHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvKhachHang.ThemeStyle.ReadOnly = true;
            this.dgvKhachHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhachHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhachHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvKhachHang.ThemeStyle.RowsStyle.Height = 30;
            this.dgvKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dgvKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
    
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 75;
            this.label4.Text = "Hạng:";
            // 
            // cbbHang
            // 
            this.cbbHang.Enabled = false;
            this.cbbHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHang.FormattingEnabled = true;
            this.cbbHang.Location = new System.Drawing.Point(627, 204);
            this.cbbHang.Name = "cbbHang";
            this.cbbHang.Size = new System.Drawing.Size(340, 32);
            this.cbbHang.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.Location = new System.Drawing.Point(627, 262);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(340, 32);
            this.txtMatKhau.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 78;
            this.label5.Text = "Mật Khẩu:";
            // 
            // UC_KhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.cbbHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.rtbDiaChiKhachHang);
            this.Controls.Add(this.btnLamMoiKhachHang);
            this.Controls.Add(this.btnThemKhachHang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnXoaKhachHang);
            this.Controls.Add(this.btnSuaKhachHang);
            this.Controls.Add(this.txtTimKiemKhachHang);
            this.Controls.Add(this.txtDienThoaiKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtEmailKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_KhachHang";
            this.Size = new System.Drawing.Size(994, 694);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoiKhachHang;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoaKhachHang;
        private System.Windows.Forms.Button btnSuaKhachHang;
        private System.Windows.Forms.TextBox txtTimKiemKhachHang;
        private System.Windows.Forms.TextBox txtDienThoaiKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDiaChiKhachHang;
        private System.Windows.Forms.TextBox txtEmailKH;
        private System.Windows.Forms.BindingSource khachHangBindingSource;

        private System.Windows.Forms.BindingSource khachHangBindingSource1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbHang;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label5;
    }
}
