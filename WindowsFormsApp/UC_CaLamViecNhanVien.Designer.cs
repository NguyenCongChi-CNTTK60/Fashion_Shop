
namespace WindowsFormsApp
{
    partial class UC_CaLamViecNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTk = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgaykt = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaybd = new System.Windows.Forms.DateTimePicker();
            this.cmbCalamviec = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTennv = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.dgvGC = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblMNV = new System.Windows.Forms.Label();
            this.txtTimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1411, 68);
            this.panel2.TabIndex = 219;
            // 
            // lblTk
            // 
            this.lblTk.AutoSize = true;
            this.lblTk.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTk.Location = new System.Drawing.Point(15, 12);
            this.lblTk.Name = "lblTk";
            this.lblTk.Size = new System.Drawing.Size(188, 35);
            this.lblTk.TabIndex = 14;
            this.lblTk.Text = "Giao ca nhân viên\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTimkiem);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblMNV);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpNgaykt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpNgaybd);
            this.panel1.Controls.Add(this.cmbCalamviec);
            this.panel1.Controls.Add(this.cmbTennv);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(21, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 303);
            this.panel1.TabIndex = 221;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(10, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1355, 49);
            this.panel4.TabIndex = 231;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thông tin chung";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(655, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 35);
            this.label7.TabIndex = 233;
            this.label7.Text = "*";
            // 
            // dtpNgaykt
            // 
            this.dtpNgaykt.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaykt.Location = new System.Drawing.Point(528, 230);
            this.dtpNgaykt.Name = "dtpNgaykt";
            this.dtpNgaykt.Size = new System.Drawing.Size(322, 33);
            this.dtpNgaykt.TabIndex = 235;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(522, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 35);
            this.label8.TabIndex = 234;
            this.label8.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(119, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 35);
            this.label5.TabIndex = 222;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(637, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 35);
            this.label4.TabIndex = 222;
            this.label4.Text = "*";
            // 
            // dtpNgaybd
            // 
            this.dtpNgaybd.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaybd.Location = new System.Drawing.Point(29, 230);
            this.dtpNgaybd.Name = "dtpNgaybd";
            this.dtpNgaybd.Size = new System.Drawing.Size(322, 33);
            this.dtpNgaybd.TabIndex = 232;
            // 
            // cmbCalamviec
            // 
            this.cmbCalamviec.BackColor = System.Drawing.Color.Transparent;
            this.cmbCalamviec.BorderColor = System.Drawing.Color.Black;
            this.cmbCalamviec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCalamviec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalamviec.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCalamviec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCalamviec.FocusedState.Parent = this.cmbCalamviec;
            this.cmbCalamviec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalamviec.ForeColor = System.Drawing.Color.Black;
            this.cmbCalamviec.HoverState.Parent = this.cmbCalamviec;
            this.cmbCalamviec.ItemHeight = 30;
            this.cmbCalamviec.Items.AddRange(new object[] {
            "----- Chọn ca làm việc -----"});
            this.cmbCalamviec.ItemsAppearance.Parent = this.cmbCalamviec;
            this.cmbCalamviec.Location = new System.Drawing.Point(528, 121);
            this.cmbCalamviec.Name = "cmbCalamviec";
            this.cmbCalamviec.ShadowDecoration.Parent = this.cmbCalamviec;
            this.cmbCalamviec.Size = new System.Drawing.Size(368, 36);
            this.cmbCalamviec.TabIndex = 231;
            this.cmbCalamviec.Click += new System.EventHandler(this.cmbCLV_Click);
            // 
            // cmbTennv
            // 
            this.cmbTennv.BackColor = System.Drawing.Color.Transparent;
            this.cmbTennv.BorderColor = System.Drawing.Color.Black;
            this.cmbTennv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTennv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTennv.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTennv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTennv.FocusedState.Parent = this.cmbTennv;
            this.cmbTennv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTennv.ForeColor = System.Drawing.Color.Black;
            this.cmbTennv.HoverState.Parent = this.cmbTennv;
            this.cmbTennv.ItemHeight = 30;
            this.cmbTennv.Items.AddRange(new object[] {
            "---- Chọn tên nhân viên ----"});
            this.cmbTennv.ItemsAppearance.Parent = this.cmbTennv;
            this.cmbTennv.Location = new System.Drawing.Point(29, 121);
            this.cmbTennv.Name = "cmbTennv";
            this.cmbTennv.ShadowDecoration.Parent = this.cmbTennv;
            this.cmbTennv.Size = new System.Drawing.Size(368, 36);
            this.cmbTennv.TabIndex = 230;
            this.cmbTennv.Click += new System.EventHandler(this.cmbTenNV_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(522, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 35);
            this.label11.TabIndex = 225;
            this.label11.Text = "Ca làm việc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 35);
            this.label10.TabIndex = 223;
            this.label10.Text = "Ngày làm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(166, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 35);
            this.label3.TabIndex = 19;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên nhân viên";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(10, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1355, 1);
            this.panel3.TabIndex = 16;
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnSua.FlatAppearance.BorderSize = 2;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1220, 1086);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSua.Size = new System.Drawing.Size(167, 45);
            this.btnSua.TabIndex = 230;
            this.btnSua.Text = "         Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnXoa.FlatAppearance.BorderSize = 2;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 30;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1013, 1086);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXoa.Size = new System.Drawing.Size(167, 45);
            this.btnXoa.TabIndex = 229;
            this.btnXoa.Text = "         Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnThem.FlatAppearance.BorderSize = 2;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 30;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(794, 1086);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThem.Size = new System.Drawing.Size(167, 45);
            this.btnThem.TabIndex = 228;
            this.btnThem.Text = "        Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvGC
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgvGC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvGC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGC.BackgroundColor = System.Drawing.Color.White;
            this.dgvGC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvGC.ColumnHeadersHeight = 45;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGC.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvGC.EnableHeadersVisualStyles = false;
            this.dgvGC.GridColor = System.Drawing.Color.Gray;
            this.dgvGC.Location = new System.Drawing.Point(18, 394);
            this.dgvGC.Name = "dgvGC";
            this.dgvGC.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGC.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvGC.RowHeadersVisible = false;
            this.dgvGC.RowHeadersWidth = 62;
            this.dgvGC.RowTemplate.Height = 45;
            this.dgvGC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGC.Size = new System.Drawing.Size(1368, 673);
            this.dgvGC.TabIndex = 222;
            this.dgvGC.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGC.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGC.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGC.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGC.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGC.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGC.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvGC.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.dgvGC.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGC.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvGC.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGC.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvGC.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvGC.ThemeStyle.ReadOnly = true;
            this.dgvGC.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvGC.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGC.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvGC.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGC.ThemeStyle.RowsStyle.Height = 45;
            this.dgvGC.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvGC.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvGC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGC_CellContentClick);
            // 
            // lblMNV
            // 
            this.lblMNV.AutoSize = true;
            this.lblMNV.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMNV.ForeColor = System.Drawing.Color.White;
            this.lblMNV.Location = new System.Drawing.Point(830, 180);
            this.lblMNV.Name = "lblMNV";
            this.lblMNV.Size = new System.Drawing.Size(143, 35);
            this.lblMNV.TabIndex = 237;
            this.lblMNV.Text = "Tên nhân viên";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BorderColor = System.Drawing.Color.Silver;
            this.txtTimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiem.DefaultText = "Tìm kiếm theo mã, tên nhân viên";
            this.txtTimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.DisabledState.Parent = this.txtTimkiem;
            this.txtTimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.FocusedState.Parent = this.txtTimkiem;
            this.txtTimkiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.HoverState.Parent = this.txtTimkiem;
            this.txtTimkiem.Location = new System.Drawing.Point(960, 222);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(7);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.PasswordChar = '\0';
            this.txtTimkiem.PlaceholderText = "";
            this.txtTimkiem.SelectedText = "";
            this.txtTimkiem.SelectionStart = 31;
            this.txtTimkiem.ShadowDecoration.Parent = this.txtTimkiem;
            this.txtTimkiem.Size = new System.Drawing.Size(396, 41);
            this.txtTimkiem.TabIndex = 239;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            this.txtTimkiem.Leave += new System.EventHandler(this.txtTimkiem_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(963, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 35);
            this.label9.TabIndex = 238;
            this.label9.Text = "Tìm kiếm";
            // 
            // UC_CaLamViecNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvGC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UC_CaLamViecNhanVien";
            this.Size = new System.Drawing.Size(1411, 1150);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaybd;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCalamviec;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTennv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgaykt;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMNV;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiem;
        private System.Windows.Forms.Label label9;
    }
}
