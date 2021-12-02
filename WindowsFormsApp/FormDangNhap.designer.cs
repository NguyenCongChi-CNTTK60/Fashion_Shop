
namespace WindowsFormsApp
{
    partial class FormDangNhap
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
            this.panelTrangChu = new System.Windows.Forms.Panel();
            this.btnDangKy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCanhbao = new System.Windows.Forms.Label();
            this.lbQuenMK = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.chkHienThiMK = new System.Windows.Forms.CheckBox();
            this.BoFormDangnhap = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Bopanelchinh = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.errtxtTaikhoan = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMatkhau = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTrangChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errtxtTaikhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMatkhau)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTrangChu
            // 
            this.panelTrangChu.BackColor = System.Drawing.Color.White;
            this.panelTrangChu.Controls.Add(this.pictureBox3);
            this.panelTrangChu.Controls.Add(this.pictureBox2);
            this.panelTrangChu.Controls.Add(this.pictureBox1);
            this.panelTrangChu.Controls.Add(this.btnDangNhap);
            this.panelTrangChu.Controls.Add(this.txtMatKhau);
            this.panelTrangChu.Controls.Add(this.txtTenDangNhap);
            this.panelTrangChu.Controls.Add(this.btnDangKy);
            this.panelTrangChu.Controls.Add(this.label5);
            this.panelTrangChu.Controls.Add(this.lblCanhbao);
            this.panelTrangChu.Controls.Add(this.lbQuenMK);
            this.panelTrangChu.Controls.Add(this.chkHienThiMK);
            this.panelTrangChu.Location = new System.Drawing.Point(578, 88);
            this.panelTrangChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTrangChu.Name = "panelTrangChu";
            this.panelTrangChu.Size = new System.Drawing.Size(394, 517);
            this.panelTrangChu.TabIndex = 7;
            // 
            // btnDangKy
            // 
            this.btnDangKy.AutoSize = true;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDangKy.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDangKy.Location = new System.Drawing.Point(270, 431);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(84, 28);
            this.btnDangKy.TabIndex = 34;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(28, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 28);
            this.label5.TabIndex = 33;
            this.label5.Text = "Bạn chưa có tài khoản?\r\n";
            // 
            // lblCanhbao
            // 
            this.lblCanhbao.AutoSize = true;
            this.lblCanhbao.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanhbao.ForeColor = System.Drawing.Color.Transparent;
            this.lblCanhbao.Location = new System.Drawing.Point(64, 87);
            this.lblCanhbao.Name = "lblCanhbao";
            this.lblCanhbao.Size = new System.Drawing.Size(299, 21);
            this.lblCanhbao.TabIndex = 26;
            this.lblCanhbao.Text = "Vui lòng kiểm tra tài khoản và mật khẩu của bạn";
            this.lblCanhbao.Click += new System.EventHandler(this.lblCanhbao_Click);
            // 
            // lbQuenMK
            // 
            this.lbQuenMK.AutoSize = true;
            this.lbQuenMK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbQuenMK.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbQuenMK.Location = new System.Drawing.Point(30, 470);
            this.lbQuenMK.Name = "lbQuenMK";
            this.lbQuenMK.Size = new System.Drawing.Size(188, 28);
            this.lbQuenMK.TabIndex = 20;
            this.lbQuenMK.Text = "Bạn quên mật khẩu?";
            this.lbQuenMK.Click += new System.EventHandler(this.lbQuenMK_Click);
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Sitka Banner", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.Location = new System.Drawing.Point(931, 0);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnX.Name = "btnX";
            this.btnX.Padding = new System.Windows.Forms.Padding(1);
            this.btnX.Size = new System.Drawing.Size(62, 65);
            this.btnX.TabIndex = 20;
            this.btnX.Text = "X";
            this.btnX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // chkHienThiMK
            // 
            this.chkHienThiMK.AutoSize = true;
            this.chkHienThiMK.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienThiMK.Location = new System.Drawing.Point(52, 260);
            this.chkHienThiMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkHienThiMK.Name = "chkHienThiMK";
            this.chkHienThiMK.Size = new System.Drawing.Size(175, 33);
            this.chkHienThiMK.TabIndex = 15;
            this.chkHienThiMK.Text = "Hiển thị mật khẩu";
            this.chkHienThiMK.UseVisualStyleBackColor = true;
            this.chkHienThiMK.CheckedChanged += new System.EventHandler(this.chkHienThiMK_CheckedChanged);
            // 
            // BoFormDangnhap
            // 
            this.BoFormDangnhap.BorderRadius = 20;
            this.BoFormDangnhap.TargetControl = this;
            // 
            // Bopanelchinh
            // 
            this.Bopanelchinh.BorderRadius = 20;
            this.Bopanelchinh.TargetControl = this.panelTrangChu;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnX);
            this.guna2GradientPanel1.Controls.Add(this.pictureBox4);
            this.guna2GradientPanel1.Controls.Add(this.panelTrangChu);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1007, 605);
            this.guna2GradientPanel1.TabIndex = 8;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoRoundedCorners = true;
            this.btnDangNhap.BorderRadius = 30;
            this.btnDangNhap.CheckedState.Parent = this.btnDangNhap;
            this.btnDangNhap.CustomImages.Parent = this.btnDangNhap;
            this.btnDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangNhap.DisabledState.Parent = this.btnDangNhap;
            this.btnDangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.HoverState.Parent = this.btnDangNhap;
            this.btnDangNhap.Location = new System.Drawing.Point(86, 298);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ShadowDecoration.Parent = this.btnDangNhap;
            this.btnDangNhap.Size = new System.Drawing.Size(237, 62);
            this.btnDangNhap.TabIndex = 41;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp.Properties.Resources.Login2;
            this.pictureBox4.Location = new System.Drawing.Point(-12, 47);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(475, 591);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp.Properties.Resources.icons8_instagram_48;
            this.pictureBox3.Location = new System.Drawing.Point(232, 378);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp.Properties.Resources.icons8_google_48;
            this.pictureBox2.Location = new System.Drawing.Point(191, 378);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources.icons8_facebook_48;
            this.pictureBox1.Location = new System.Drawing.Point(150, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderRadius = 9;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "123";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.Parent = this.txtMatKhau;
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.FocusedState.Parent = this.txtMatKhau;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.HoverState.Parent = this.txtMatKhau;
            this.txtMatKhau.IconLeft = global::WindowsFormsApp.Properties.Resources.icons8_password_30;
            this.txtMatKhau.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtMatKhau.Location = new System.Drawing.Point(52, 196);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMatKhau.PlaceholderText = "Mật khẩu";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionStart = 3;
            this.txtMatKhau.ShadowDecoration.Parent = this.txtMatKhau;
            this.txtMatKhau.Size = new System.Drawing.Size(302, 49);
            this.txtMatKhau.TabIndex = 9;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderRadius = 9;
            this.txtTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDangNhap.DefaultText = "tan";
            this.txtTenDangNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.DisabledState.Parent = this.txtTenDangNhap;
            this.txtTenDangNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(230)))));
            this.txtTenDangNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.FocusedState.Parent = this.txtTenDangNhap;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDangNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.HoverState.Parent = this.txtTenDangNhap;
            this.txtTenDangNhap.IconLeft = global::WindowsFormsApp.Properties.Resources.icons8_user_30;
            this.txtTenDangNhap.IconLeftSize = new System.Drawing.Size(24, 24);
            this.txtTenDangNhap.Location = new System.Drawing.Point(52, 123);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenDangNhap.PlaceholderText = "Tên đăng nhập";
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.SelectionStart = 3;
            this.txtTenDangNhap.ShadowDecoration.Parent = this.txtTenDangNhap;
            this.txtTenDangNhap.Size = new System.Drawing.Size(302, 51);
            this.txtTenDangNhap.TabIndex = 8;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged_1);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 604);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTrangChu.ResumeLayout(false);
            this.panelTrangChu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errtxtTaikhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMatkhau)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTrangChu;
        private System.Windows.Forms.Label lblCanhbao;
        private System.Windows.Forms.Label lbQuenMK;
        private System.Windows.Forms.CheckBox chkHienThiMK;
        private Guna.UI2.WinForms.Guna2Elipse BoFormDangnhap;
        private Guna.UI2.WinForms.Guna2Elipse Bopanelchinh;
        private System.Windows.Forms.ErrorProvider errtxtTaikhoan;
        private System.Windows.Forms.ErrorProvider errMatkhau;
        private System.Windows.Forms.Label btnDangKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnX;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
        private Guna.UI2.WinForms.Guna2GradientButton btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

