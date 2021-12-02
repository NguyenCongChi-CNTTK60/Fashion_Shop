
namespace WindowsFormsApp
{
    partial class UC_DoiMatKhau
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtxacnhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmatkhaumoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCanhbao = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSđtnv = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnQuaylai = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 27);
            this.label3.TabIndex = 125;
            this.label3.Text = " Xác nhận mật khẩu:";
            // 
            // txtxacnhan
            // 
            this.txtxacnhan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtxacnhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtxacnhan.DefaultText = "";
            this.txtxacnhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtxacnhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtxacnhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtxacnhan.DisabledState.Parent = this.txtxacnhan;
            this.txtxacnhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtxacnhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtxacnhan.FocusedState.Parent = this.txtxacnhan;
            this.txtxacnhan.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtxacnhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtxacnhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtxacnhan.HoverState.Parent = this.txtxacnhan;
            this.txtxacnhan.Location = new System.Drawing.Point(267, 182);
            this.txtxacnhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtxacnhan.Name = "txtxacnhan";
            this.txtxacnhan.PasswordChar = '\0';
            this.txtxacnhan.PlaceholderText = "";
            this.txtxacnhan.SelectedText = "";
            this.txtxacnhan.ShadowDecoration.Parent = this.txtxacnhan;
            this.txtxacnhan.Size = new System.Drawing.Size(317, 46);
            this.txtxacnhan.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtxacnhan.TabIndex = 124;
            this.txtxacnhan.TextChanged += new System.EventHandler(this.txtxacnhan_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label5.Location = new System.Drawing.Point(53, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 27);
            this.label5.TabIndex = 120;
            this.label5.Text = "Mật khẩu mới:";
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmatkhaumoi.BorderThickness = 0;
            this.txtmatkhaumoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmatkhaumoi.DefaultText = "";
            this.txtmatkhaumoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmatkhaumoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmatkhaumoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmatkhaumoi.DisabledState.Parent = this.txtmatkhaumoi;
            this.txtmatkhaumoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmatkhaumoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmatkhaumoi.FocusedState.Parent = this.txtmatkhaumoi;
            this.txtmatkhaumoi.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtmatkhaumoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtmatkhaumoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmatkhaumoi.HoverState.Parent = this.txtmatkhaumoi;
            this.txtmatkhaumoi.Location = new System.Drawing.Point(267, 126);
            this.txtmatkhaumoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.PasswordChar = '\0';
            this.txtmatkhaumoi.PlaceholderText = "";
            this.txtmatkhaumoi.SelectedText = "";
            this.txtmatkhaumoi.ShadowDecoration.Parent = this.txtmatkhaumoi;
            this.txtmatkhaumoi.Size = new System.Drawing.Size(317, 48);
            this.txtmatkhaumoi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtmatkhaumoi.TabIndex = 119;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(186, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 26);
            this.label8.TabIndex = 115;
            this.label8.Text = "ĐĂNG KÝ MẬT KHẨU MỚI";
            // 
            // lblCanhbao
            // 
            this.lblCanhbao.AutoSize = true;
            this.lblCanhbao.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanhbao.ForeColor = System.Drawing.Color.Transparent;
            this.lblCanhbao.Location = new System.Drawing.Point(249, 245);
            this.lblCanhbao.Name = "lblCanhbao";
            this.lblCanhbao.Size = new System.Drawing.Size(299, 21);
            this.lblCanhbao.TabIndex = 126;
            this.lblCanhbao.Text = "Vui lòng kiểm tra tài khoản và mật khẩu của bạn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(202, 103);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 2);
            this.panel2.TabIndex = 131;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(204, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 130;
            this.label4.Text = "+84";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(253, 73);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 32);
            this.panel3.TabIndex = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label1.Location = new System.Drawing.Point(46, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 128;
            this.label1.Text = "Số điện thoại:";
            // 
            // txtSđtnv
            // 
            this.txtSđtnv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSđtnv.BorderThickness = 0;
            this.txtSđtnv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSđtnv.DefaultText = "";
            this.txtSđtnv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSđtnv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSđtnv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSđtnv.DisabledState.Parent = this.txtSđtnv;
            this.txtSđtnv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSđtnv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSđtnv.FocusedState.Parent = this.txtSđtnv;
            this.txtSđtnv.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtSđtnv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtSđtnv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSđtnv.HoverState.Parent = this.txtSđtnv;
            this.txtSđtnv.Location = new System.Drawing.Point(257, 57);
            this.txtSđtnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSđtnv.Name = "txtSđtnv";
            this.txtSđtnv.PasswordChar = '\0';
            this.txtSđtnv.PlaceholderText = "";
            this.txtSđtnv.ReadOnly = true;
            this.txtSđtnv.SelectedText = "";
            this.txtSđtnv.ShadowDecoration.Parent = this.txtSđtnv;
            this.txtSđtnv.Size = new System.Drawing.Size(317, 48);
            this.txtSđtnv.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSđtnv.TabIndex = 127;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this.txtmatkhaumoi;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this.txtxacnhan;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoRoundedCorners = true;
            this.btnLuu.BorderRadius = 26;
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
            this.btnLuu.Location = new System.Drawing.Point(516, 280);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(178, 54);
            this.btnLuu.TabIndex = 132;
            this.btnLuu.Text = "  Xác nhận";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.AutoRoundedCorners = true;
            this.btnQuaylai.BorderRadius = 26;
            this.btnQuaylai.CheckedState.Parent = this.btnQuaylai;
            this.btnQuaylai.CustomImages.Parent = this.btnQuaylai;
            this.btnQuaylai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuaylai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuaylai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuaylai.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuaylai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuaylai.DisabledState.Parent = this.btnQuaylai;
            this.btnQuaylai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnQuaylai.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnQuaylai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuaylai.ForeColor = System.Drawing.Color.White;
            this.btnQuaylai.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.btnQuaylai.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(75)))));
            this.btnQuaylai.HoverState.Parent = this.btnQuaylai;
            this.btnQuaylai.Location = new System.Drawing.Point(28, 280);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.ShadowDecoration.Parent = this.btnQuaylai;
            this.btnQuaylai.Size = new System.Drawing.Size(178, 54);
            this.btnQuaylai.TabIndex = 133;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click_1);
            // 
            // UC_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSđtnv);
            this.Controls.Add(this.lblCanhbao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtxacnhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmatkhaumoi);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_DoiMatKhau";
            this.Size = new System.Drawing.Size(711, 360);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtxacnhan;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtmatkhaumoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCanhbao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSđtnv;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnQuaylai;
    }
}
