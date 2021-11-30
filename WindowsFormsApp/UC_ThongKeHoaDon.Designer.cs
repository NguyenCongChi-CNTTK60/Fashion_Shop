
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
            this.btnXem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongtienhoadon = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongkehd)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpkNgaybd
            // 
            this.dpkNgaybd.BorderColor = System.Drawing.Color.Maroon;
            this.dpkNgaybd.BorderRadius = 3;
            this.dpkNgaybd.BorderThickness = 2;
            this.dpkNgaybd.Checked = true;
            this.dpkNgaybd.CheckedState.Parent = this.dpkNgaybd;
            this.dpkNgaybd.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.dpkNgaykt.BorderColor = System.Drawing.Color.Maroon;
            this.dpkNgaykt.BorderRadius = 3;
            this.dpkNgaykt.BorderThickness = 2;
            this.dpkNgaykt.Checked = true;
            this.dpkNgaykt.CheckedState.Parent = this.dpkNgaykt;
            this.dpkNgaykt.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.dgvThongkehd.Size = new System.Drawing.Size(979, 414);
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
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.Black;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(747, 84);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Padding = new System.Windows.Forms.Padding(1);
            this.btnXem.Size = new System.Drawing.Size(126, 43);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = " Xem";
            this.btnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 602);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tổng tiền hóa đơn:";
            // 
            // txtTongtienhoadon
            // 
            this.txtTongtienhoadon.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtTongtienhoadon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTongtienhoadon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongtienhoadon.DefaultText = "";
            this.txtTongtienhoadon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongtienhoadon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongtienhoadon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongtienhoadon.DisabledState.Parent = this.txtTongtienhoadon;
            this.txtTongtienhoadon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongtienhoadon.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTongtienhoadon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTongtienhoadon.FocusedState.Parent = this.txtTongtienhoadon;
            this.txtTongtienhoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtTongtienhoadon.ForeColor = System.Drawing.Color.Maroon;
            this.txtTongtienhoadon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongtienhoadon.HoverState.Parent = this.txtTongtienhoadon;
            this.txtTongtienhoadon.Location = new System.Drawing.Point(176, 591);
            this.txtTongtienhoadon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTongtienhoadon.Name = "txtTongtienhoadon";
            this.txtTongtienhoadon.PasswordChar = '\0';
            this.txtTongtienhoadon.PlaceholderText = "";
            this.txtTongtienhoadon.ReadOnly = true;
            this.txtTongtienhoadon.SelectedText = "";
            this.txtTongtienhoadon.ShadowDecoration.Parent = this.txtTongtienhoadon;
            this.txtTongtienhoadon.Size = new System.Drawing.Size(280, 40);
            this.txtTongtienhoadon.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTongtienhoadon.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
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
            // UC_ThongKeHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTongtienhoadon);
            this.Controls.Add(this.btnTangngay);
            this.Controls.Add(this.dgvThongkehd);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpkNgaykt);
            this.Controls.Add(this.dpkNgaybd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ThongKeHoaDon";
            this.Size = new System.Drawing.Size(1010, 593);
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
        private System.Windows.Forms.Button btnXem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongkehd;
        private System.Windows.Forms.Button btnTangngay;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtTongtienhoadon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}
