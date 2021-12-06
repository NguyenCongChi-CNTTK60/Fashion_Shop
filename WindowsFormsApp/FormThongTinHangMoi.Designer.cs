
namespace WindowsFormsApp
{
    partial class FormThongTinHangMoi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMaLoaiHang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLoaiHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenmh = new System.Windows.Forms.TextBox();
            this.cmbDonvitinh = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.btnThemLoaiHang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemLoaiHang);
            this.panel1.Controls.Add(this.cmbMaLoaiHang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbLoaiHang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTenmh);
            this.panel1.Controls.Add(this.cmbDonvitinh);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 471);
            this.panel1.TabIndex = 0;
            // 
            // cmbMaLoaiHang
            // 
            this.cmbMaLoaiHang.Enabled = false;
            this.cmbMaLoaiHang.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaLoaiHang.ForeColor = System.Drawing.Color.Maroon;
            this.cmbMaLoaiHang.FormattingEnabled = true;
            this.cmbMaLoaiHang.Items.AddRange(new object[] {
            "Chiếc ",
            "Bộ"});
            this.cmbMaLoaiHang.Location = new System.Drawing.Point(407, 331);
            this.cmbMaLoaiHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaLoaiHang.Name = "cmbMaLoaiHang";
            this.cmbMaLoaiHang.Size = new System.Drawing.Size(141, 40);
            this.cmbMaLoaiHang.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 40);
            this.label3.TabIndex = 103;
            this.label3.Text = "Loại hàng:";
            // 
            // cmbLoaiHang
            // 
            this.cmbLoaiHang.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiHang.ForeColor = System.Drawing.Color.Maroon;
            this.cmbLoaiHang.FormattingEnabled = true;
            this.cmbLoaiHang.Items.AddRange(new object[] {
            "Chiếc ",
            "Bộ"});
            this.cmbLoaiHang.Location = new System.Drawing.Point(249, 331);
            this.cmbLoaiHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLoaiHang.Name = "cmbLoaiHang";
            this.cmbLoaiHang.Size = new System.Drawing.Size(152, 40);
            this.cmbLoaiHang.TabIndex = 102;
            this.cmbLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiHang_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(218, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 47);
            this.label6.TabIndex = 101;
            this.label6.Text = "NHẬP MỚI HÀNG HÓA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 40);
            this.label4.TabIndex = 100;
            this.label4.Text = "Tên đơn vị tính:";
            // 
            // txtTenmh
            // 
            this.txtTenmh.Font = new System.Drawing.Font("Sitka Banner", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenmh.Location = new System.Drawing.Point(249, 183);
            this.txtTenmh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenmh.Multiline = true;
            this.txtTenmh.Name = "txtTenmh";
            this.txtTenmh.Size = new System.Drawing.Size(299, 38);
            this.txtTenmh.TabIndex = 99;
            // 
            // cmbDonvitinh
            // 
            this.cmbDonvitinh.Font = new System.Drawing.Font("Sitka Banner", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDonvitinh.ForeColor = System.Drawing.Color.Maroon;
            this.cmbDonvitinh.FormattingEnabled = true;
            this.cmbDonvitinh.Items.AddRange(new object[] {
            "Chiếc ",
            "Bộ"});
            this.cmbDonvitinh.Location = new System.Drawing.Point(283, 259);
            this.cmbDonvitinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDonvitinh.Name = "cmbDonvitinh";
            this.cmbDonvitinh.Size = new System.Drawing.Size(169, 40);
            this.cmbDonvitinh.TabIndex = 98;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(508, 390);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(189, 58);
            this.btnLuu.TabIndex = 97;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 40);
            this.label1.TabIndex = 96;
            this.label1.Text = "Tên mặt hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 40);
            this.label2.TabIndex = 95;
            this.label2.Text = "Mã mặt hàng:";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Enabled = false;
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHang.Location = new System.Drawing.Point(249, 110);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHang.Multiline = true;
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.ReadOnly = true;
            this.txtMaHang.Size = new System.Drawing.Size(298, 35);
            this.txtMaHang.TabIndex = 94;
            // 
            // btnThemLoaiHang
            // 
            this.btnThemLoaiHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnThemLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiHang.ForeColor = System.Drawing.Color.White;
            this.btnThemLoaiHang.Location = new System.Drawing.Point(574, 331);
            this.btnThemLoaiHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemLoaiHang.Name = "btnThemLoaiHang";
            this.btnThemLoaiHang.Size = new System.Drawing.Size(39, 41);
            this.btnThemLoaiHang.TabIndex = 127;
            this.btnThemLoaiHang.Text = "+";
            this.btnThemLoaiHang.UseVisualStyleBackColor = false;
            this.btnThemLoaiHang.Click += new System.EventHandler(this.btnThemLoaiHang_Click);
            // 
            // FormThongTinHangMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 471);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormThongTinHangMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongtinhangmoi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMaLoaiHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLoaiHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenmh;
        private System.Windows.Forms.ComboBox cmbDonvitinh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Button btnThemLoaiHang;
    }
}