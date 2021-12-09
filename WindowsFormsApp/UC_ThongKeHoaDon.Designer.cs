
namespace WindowsFormsApp
{
    partial class UC_ThongKeHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dpkNgaybd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dpkNgaykt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvThongkehd = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnTangngay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnXem = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongkehd)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpkNgaybd
            // 
            this.dpkNgaybd.BorderColor = System.Drawing.Color.White;
            this.dpkNgaybd.BorderRadius = 3;
            this.dpkNgaybd.BorderThickness = 2;
            this.dpkNgaybd.Checked = true;
            this.dpkNgaybd.CheckedState.Parent = this.dpkNgaybd;
            this.dpkNgaybd.FillColor = System.Drawing.Color.White;
            this.dpkNgaybd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dpkNgaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkNgaybd.HoverState.Parent = this.dpkNgaybd;
            this.dpkNgaybd.Location = new System.Drawing.Point(186, 85);
            this.dpkNgaybd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpkNgaybd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpkNgaybd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpkNgaybd.Name = "dpkNgaybd";
            this.dpkNgaybd.ShadowDecoration.Parent = this.dpkNgaybd;
            this.dpkNgaybd.Size = new System.Drawing.Size(187, 37);
            this.dpkNgaybd.TabIndex = 3;
            this.dpkNgaybd.Value = new System.DateTime(2021, 10, 25, 21, 55, 52, 140);
            // 
            // dpkNgaykt
            // 
            this.dpkNgaykt.BorderColor = System.Drawing.Color.White;
            this.dpkNgaykt.BorderRadius = 3;
            this.dpkNgaykt.BorderThickness = 2;
            this.dpkNgaykt.Checked = true;
            this.dpkNgaykt.CheckedState.Parent = this.dpkNgaykt;
            this.dpkNgaykt.FillColor = System.Drawing.Color.White;
            this.dpkNgaykt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dpkNgaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkNgaykt.HoverState.Parent = this.dpkNgaykt;
            this.dpkNgaykt.Location = new System.Drawing.Point(523, 84);
            this.dpkNgaykt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpkNgaykt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpkNgaykt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpkNgaykt.Name = "dpkNgaykt";
            this.dpkNgaykt.ShadowDecoration.Parent = this.dpkNgaykt;
            this.dpkNgaykt.Size = new System.Drawing.Size(172, 37);
            this.dpkNgaykt.TabIndex = 4;
            this.dpkNgaykt.Value = new System.DateTime(2021, 10, 25, 21, 55, 52, 140);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 128);
            this.label2.TabIndex = 5;
            this.label2.Text = "Từ ngày:\r\n\r\n\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đến ngày:";
            // 
            // dgvThongkehd
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvThongkehd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongkehd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongkehd.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongkehd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongkehd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongkehd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongkehd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongkehd.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongkehd.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongkehd.EnableHeadersVisualStyles = false;
            this.dgvThongkehd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongkehd.Location = new System.Drawing.Point(15, 144);
            this.dgvThongkehd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThongkehd.Name = "dgvThongkehd";
            this.dgvThongkehd.ReadOnly = true;
            this.dgvThongkehd.RowHeadersVisible = false;
            this.dgvThongkehd.RowHeadersWidth = 62;
            this.dgvThongkehd.RowTemplate.Height = 28;
            this.dgvThongkehd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongkehd.Size = new System.Drawing.Size(979, 405);
            this.dgvThongkehd.TabIndex = 8;
            this.dgvThongkehd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongkehd.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongkehd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongkehd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongkehd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongkehd.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongkehd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongkehd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.dgvThongkehd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongkehd.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongkehd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongkehd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongkehd.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvThongkehd.ThemeStyle.ReadOnly = true;
            this.dgvThongkehd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongkehd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongkehd.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongkehd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongkehd.ThemeStyle.RowsStyle.Height = 28;
            this.dgvThongkehd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongkehd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnTangngay
            // 
            this.btnTangngay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTangngay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTangngay.FlatAppearance.BorderSize = 0;
            this.btnTangngay.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnTangngay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTangngay.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangngay.ForeColor = System.Drawing.Color.Black;
            this.btnTangngay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTangngay.Location = new System.Drawing.Point(15, 78);
            this.btnTangngay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTangngay.Name = "btnTangngay";
            this.btnTangngay.Padding = new System.Windows.Forms.Padding(1);
            this.btnTangngay.Size = new System.Drawing.Size(45, 43);
            this.btnTangngay.TabIndex = 9;
            this.btnTangngay.Text = "  ";
            this.btnTangngay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTangngay.UseVisualStyleBackColor = false;
            this.btnTangngay.Click += new System.EventHandler(this.btnTangngay_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tổng tiền hóa đơn:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 62);
            this.panel2.TabIndex = 185;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(333, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 40);
            this.label4.TabIndex = 226;
            this.label4.Text = "THỐNG KÊ HÓA ĐƠN";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Maroon;
            this.lblTongTien.Location = new System.Drawing.Point(212, 556);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(169, 23);
            this.lblTongTien.TabIndex = 186;
            this.lblTongTien.Text = "Tổng tiền hóa đơn:";
            // 
            // btnXem
            // 
            this.btnXem.AutoRoundedCorners = true;
            this.btnXem.BorderRadius = 23;
            this.btnXem.CheckedState.Parent = this.btnXem;
            this.btnXem.CustomImages.Parent = this.btnXem;
            this.btnXem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXem.DisabledState.Parent = this.btnXem;
            this.btnXem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnXem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.btnXem.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnXem.HoverState.Parent = this.btnXem;
            this.btnXem.Location = new System.Drawing.Point(729, 74);
            this.btnXem.Name = "btnXem";
            this.btnXem.ShadowDecoration.Parent = this.btnXem;
            this.btnXem.Size = new System.Drawing.Size(140, 48);
            this.btnXem.TabIndex = 248;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click_1);
            // 
            // UC_ThongKeHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTangngay);
            this.Controls.Add(this.dgvThongkehd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpkNgaykt);
            this.Controls.Add(this.dpkNgaybd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ThongKeHoaDon";
            this.Size = new System.Drawing.Size(1010, 595);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongkehd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker dpkNgaybd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpkNgaykt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongkehd;
        private System.Windows.Forms.Button btnTangngay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTongTien;
        private Guna.UI2.WinForms.Guna2GradientButton btnXem;
    }
}
