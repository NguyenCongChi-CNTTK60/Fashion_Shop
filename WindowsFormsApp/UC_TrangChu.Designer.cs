
namespace WindowsFormsApp
{
    partial class UC_TrangChu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTTTaiKhoan = new System.Windows.Forms.Panel();
            this.btnTK = new FontAwesome.Sharp.IconButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDoanhthu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNhanvien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblHoadon = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.pcbAlign = new FontAwesome.Sharp.IconPictureBox();
            this.pcbBell = new FontAwesome.Sharp.IconPictureBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblKhachhang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlTTTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlTTTaiKhoan);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 1150);
            this.panel1.TabIndex = 0;
            // 
            // pnlTTTaiKhoan
            // 
            this.pnlTTTaiKhoan.BackColor = System.Drawing.Color.White;
            this.pnlTTTaiKhoan.Controls.Add(this.btnTK);
            this.pnlTTTaiKhoan.Location = new System.Drawing.Point(987, 70);
            this.pnlTTTaiKhoan.Name = "pnlTTTaiKhoan";
            this.pnlTTTaiKhoan.Size = new System.Drawing.Size(295, 95);
            this.pnlTTTaiKhoan.TabIndex = 29;
            // 
            // btnTK
            // 
            this.btnTK.FlatAppearance.BorderSize = 0;
            this.btnTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTK.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.Black;
            this.btnTK.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnTK.IconColor = System.Drawing.Color.Black;
            this.btnTK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTK.IconSize = 35;
            this.btnTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTK.Location = new System.Drawing.Point(10, 13);
            this.btnTK.Name = "btnTK";
            this.btnTK.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTK.Size = new System.Drawing.Size(271, 55);
            this.btnTK.TabIndex = 7;
            this.btnTK.Text = "            Tài khoản của tôi\r\n";
            this.btnTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(21, 429);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelBorderWidth = 3;
            series2.Legend = "Legend1";
            series2.Name = "Doanh Thu";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1374, 696);
            this.chart1.TabIndex = 28;
            this.chart1.Text = "chart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 29);
            this.label10.TabIndex = 27;
            this.label10.Text = "DOANH THU TỔNG HỢP\r\n";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblDoanhthu);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Location = new System.Drawing.Point(1079, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 100);
            this.panel4.TabIndex = 26;
            // 
            // lblDoanhthu
            // 
            this.lblDoanhthu.AutoSize = true;
            this.lblDoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhthu.Location = new System.Drawing.Point(27, 57);
            this.lblDoanhthu.Name = "lblDoanhthu";
            this.lblDoanhthu.Size = new System.Drawing.Size(24, 25);
            this.lblDoanhthu.TabIndex = 7;
            this.lblDoanhthu.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(26, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Doanh thu/Hóa đơn";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Olive;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(7, 100);
            this.panel8.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblNhanvien);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(725, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 100);
            this.panel3.TabIndex = 25;
            // 
            // lblNhanvien
            // 
            this.lblNhanvien.AutoSize = true;
            this.lblNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanvien.Location = new System.Drawing.Point(30, 57);
            this.lblNhanvien.Name = "lblNhanvien";
            this.lblNhanvien.Size = new System.Drawing.Size(24, 25);
            this.lblNhanvien.TabIndex = 7;
            this.lblNhanvien.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(29, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số nhân viên";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(7, 100);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblHoadon);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Location = new System.Drawing.Point(367, 196);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 100);
            this.panel6.TabIndex = 24;
            // 
            // lblHoadon
            // 
            this.lblHoadon.AutoSize = true;
            this.lblHoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoadon.Location = new System.Drawing.Point(29, 57);
            this.lblHoadon.Name = "lblHoadon";
            this.lblHoadon.Size = new System.Drawing.Size(24, 25);
            this.lblHoadon.TabIndex = 7;
            this.lblHoadon.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(28, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số hóa đơn";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(7, 100);
            this.panel9.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnX);
            this.panel2.Controls.Add(this.pcbAlign);
            this.panel2.Controls.Add(this.pcbBell);
            this.panel2.Controls.Add(this.lblTenNhanVien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1411, 68);
            this.panel2.TabIndex = 23;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(82)))), ((int)(((byte)(132)))));
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnX.Location = new System.Drawing.Point(1364, 17);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(31, 31);
            this.btnX.TabIndex = 21;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            // 
            // pcbAlign
            // 
            this.pcbAlign.BackColor = System.Drawing.Color.White;
            this.pcbAlign.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pcbAlign.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.pcbAlign.IconColor = System.Drawing.SystemColors.HotTrack;
            this.pcbAlign.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pcbAlign.IconSize = 37;
            this.pcbAlign.Location = new System.Drawing.Point(1258, 18);
            this.pcbAlign.Name = "pcbAlign";
            this.pcbAlign.Size = new System.Drawing.Size(43, 37);
            this.pcbAlign.TabIndex = 21;
            this.pcbAlign.TabStop = false;
            // 
            // pcbBell
            // 
            this.pcbBell.BackColor = System.Drawing.Color.White;
            this.pcbBell.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pcbBell.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.pcbBell.IconColor = System.Drawing.SystemColors.HotTrack;
            this.pcbBell.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pcbBell.IconSize = 37;
            this.pcbBell.Location = new System.Drawing.Point(1198, 18);
            this.pcbBell.Name = "pcbBell";
            this.pcbBell.Size = new System.Drawing.Size(43, 37);
            this.pcbBell.TabIndex = 19;
            this.pcbBell.TabStop = false;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Sitka Banner", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.Location = new System.Drawing.Point(1032, 17);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(147, 29);
            this.lblTenNhanVien.TabIndex = 16;
            this.lblTenNhanVien.Text = "Nguyễn Công Chí";
            this.lblTenNhanVien.Click += new System.EventHandler(this.lblTenNhanVien_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tổng quan";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Gray;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Gray;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 39;
            this.iconPictureBox2.Location = new System.Drawing.Point(987, 14);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(39, 50);
            this.iconPictureBox2.TabIndex = 16;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblKhachhang);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Location = new System.Drawing.Point(21, 196);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 100);
            this.panel5.TabIndex = 22;
            // 
            // lblKhachhang
            // 
            this.lblKhachhang.AutoSize = true;
            this.lblKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachhang.Location = new System.Drawing.Point(25, 57);
            this.lblKhachhang.Name = "lblKhachhang";
            this.lblKhachhang.Size = new System.Drawing.Size(24, 25);
            this.lblKhachhang.TabIndex = 2;
            this.lblKhachhang.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số khách hàng";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SteelBlue;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(7, 100);
            this.panel10.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "TỔNG QUAN KINH DOANH";
            // 
            // UC_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel1);
            this.Name = "UC_TrangChu";
            this.Size = new System.Drawing.Size(1411, 1150);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTTTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDoanhthu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblHoadon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnX;
        private FontAwesome.Sharp.IconPictureBox pcbAlign;
        private FontAwesome.Sharp.IconPictureBox pcbBell;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblKhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTTTaiKhoan;
        private FontAwesome.Sharp.IconButton btnTK;
    }
}
