﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTk = new System.Windows.Forms.Label();
            this.btnXem = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpkNgaykt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dpkNgaybd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvHd = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmbLuaChon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHd)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 1095);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 32);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tổng tiền hóa đơn:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Maroon;
            this.lblTongTien.Location = new System.Drawing.Point(215, 1099);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(187, 26);
            this.lblTongTien.TabIndex = 186;
            this.lblTongTien.Text = "Tổng tiền hóa đơn:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1411, 68);
            this.panel2.TabIndex = 188;
            // 
            // lblTk
            // 
            this.lblTk.AutoSize = true;
            this.lblTk.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTk.Location = new System.Drawing.Point(15, 12);
            this.lblTk.Name = "lblTk";
            this.lblTk.Size = new System.Drawing.Size(193, 35);
            this.lblTk.TabIndex = 14;
            this.lblTk.Text = "Thống kê hóa đơn\r\n";
            // 
            // btnXem
            // 
            this.btnXem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnXem.BorderRadius = 1;
            this.btnXem.BorderThickness = 2;
            this.btnXem.CheckedState.Parent = this.btnXem;
            this.btnXem.CustomImages.Parent = this.btnXem;
            this.btnXem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXem.DisabledState.Parent = this.btnXem;
            this.btnXem.FillColor = System.Drawing.SystemColors.Control;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.Black;
            this.btnXem.HoverState.Parent = this.btnXem;
            this.btnXem.Location = new System.Drawing.Point(829, 97);
            this.btnXem.Name = "btnXem";
            this.btnXem.ShadowDecoration.Parent = this.btnXem;
            this.btnXem.Size = new System.Drawing.Size(124, 36);
            this.btnXem.TabIndex = 193;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 191;
            this.label4.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 190;
            this.label2.Text = "Từ ngày";
            // 
            // dpkNgaykt
            // 
            this.dpkNgaykt.AllowDrop = true;
            this.dpkNgaykt.Animated = true;
            this.dpkNgaykt.CheckedState.Parent = this.dpkNgaykt;
            this.dpkNgaykt.FillColor = System.Drawing.Color.White;
            this.dpkNgaykt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkNgaykt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkNgaykt.HoverState.Parent = this.dpkNgaykt;
            this.dpkNgaykt.Location = new System.Drawing.Point(531, 97);
            this.dpkNgaykt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpkNgaykt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpkNgaykt.Name = "dpkNgaykt";
            this.dpkNgaykt.ShadowDecoration.Parent = this.dpkNgaykt;
            this.dpkNgaykt.Size = new System.Drawing.Size(240, 36);
            this.dpkNgaykt.TabIndex = 194;
            this.dpkNgaykt.Value = new System.DateTime(2021, 12, 9, 19, 36, 10, 687);
            // 
            // dpkNgaybd
            // 
            this.dpkNgaybd.CheckedState.Parent = this.dpkNgaybd;
            this.dpkNgaybd.FillColor = System.Drawing.Color.White;
            this.dpkNgaybd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkNgaybd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkNgaybd.HoverState.Parent = this.dpkNgaybd;
            this.dpkNgaybd.Location = new System.Drawing.Point(130, 97);
            this.dpkNgaybd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpkNgaybd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpkNgaybd.Name = "dpkNgaybd";
            this.dpkNgaybd.ShadowDecoration.Parent = this.dpkNgaybd;
            this.dpkNgaybd.Size = new System.Drawing.Size(238, 36);
            this.dpkNgaybd.TabIndex = 195;
            this.dpkNgaybd.Value = new System.DateTime(2021, 12, 9, 19, 36, 10, 687);
            // 
            // dgvHd
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHd.BackgroundColor = System.Drawing.Color.White;
            this.dgvHd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHd.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHd.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHd.EnableHeadersVisualStyles = false;
            this.dgvHd.GridColor = System.Drawing.Color.Black;
            this.dgvHd.Location = new System.Drawing.Point(29, 152);
            this.dgvHd.Name = "dgvHd";
            this.dgvHd.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHd.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHd.RowHeadersVisible = false;
            this.dgvHd.RowHeadersWidth = 62;
            this.dgvHd.RowTemplate.Height = 45;
            this.dgvHd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHd.Size = new System.Drawing.Size(1359, 925);
            this.dgvHd.TabIndex = 196;
            this.dgvHd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHd.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHd.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHd.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvHd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.dgvHd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHd.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHd.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvHd.ThemeStyle.ReadOnly = true;
            this.dgvHd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHd.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHd.ThemeStyle.RowsStyle.Height = 45;
            this.dgvHd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cmbLuaChon
            // 
            this.cmbLuaChon.BackColor = System.Drawing.Color.Transparent;
            this.cmbLuaChon.BorderColor = System.Drawing.Color.Black;
            this.cmbLuaChon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLuaChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLuaChon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLuaChon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLuaChon.FocusedState.Parent = this.cmbLuaChon;
            this.cmbLuaChon.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLuaChon.ForeColor = System.Drawing.Color.Black;
            this.cmbLuaChon.HoverState.Parent = this.cmbLuaChon;
            this.cmbLuaChon.ItemHeight = 30;
            this.cmbLuaChon.Items.AddRange(new object[] {
            "--- Lựa chọn xem ---",
            "Hôm qua",
            "Hôm nay",
            "Tuần này",
            "Tháng này",
            "Năm nay"});
            this.cmbLuaChon.ItemsAppearance.Parent = this.cmbLuaChon;
            this.cmbLuaChon.Location = new System.Drawing.Point(1155, 97);
            this.cmbLuaChon.Name = "cmbLuaChon";
            this.cmbLuaChon.ShadowDecoration.Parent = this.cmbLuaChon;
            this.cmbLuaChon.Size = new System.Drawing.Size(233, 36);
            this.cmbLuaChon.TabIndex = 238;
            this.cmbLuaChon.SelectedIndexChanged += new System.EventHandler(this.cmbLuaChon_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1009, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 32);
            this.label6.TabIndex = 237;
            this.label6.Text = "Lựa chọn xem:";
            // 
            // UC_ThongKeHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.cmbLuaChon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvHd);
            this.Controls.Add(this.dpkNgaybd);
            this.Controls.Add(this.dpkNgaykt);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ThongKeHoaDon";
            this.Size = new System.Drawing.Size(1411, 1150);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTk;
        private Guna.UI2.WinForms.Guna2Button btnXem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpkNgaykt;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpkNgaybd;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHd;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLuaChon;
        private System.Windows.Forms.Label label6;
    }
}
