
namespace WindowsFormsApp
{
    partial class UC_XacNhanSDT
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnQuaylai = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblgiay = new System.Windows.Forms.Label();
            this.lblDem = new System.Windows.Forms.Label();
            this.lblmaxn = new System.Windows.Forms.Label();
            this.lblCanhbao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSđtnv = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnQuaylai);
            this.panel1.Controls.Add(this.lblgiay);
            this.panel1.Controls.Add(this.lblDem);
            this.panel1.Controls.Add(this.lblmaxn);
            this.panel1.Controls.Add(this.lblCanhbao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMa);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSđtnv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 360);
            this.panel1.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoRoundedCorners = true;
            this.btnLuu.BorderRadius = 23;
            this.btnLuu.CheckedState.Parent = this.btnLuu;
            this.btnLuu.CustomImages.Parent = this.btnLuu;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.DisabledState.Parent = this.btnLuu;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnLuu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.btnLuu.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnLuu.HoverState.Parent = this.btnLuu;
            this.btnLuu.Location = new System.Drawing.Point(546, 271);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(124, 48);
            this.btnLuu.TabIndex = 247;
            this.btnLuu.Text = "Xác nhận";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.AutoRoundedCorners = true;
            this.btnQuaylai.BorderRadius = 23;
            this.btnQuaylai.CheckedState.Parent = this.btnQuaylai;
            this.btnQuaylai.CustomImages.Parent = this.btnQuaylai;
            this.btnQuaylai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuaylai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuaylai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuaylai.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuaylai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuaylai.DisabledState.Parent = this.btnQuaylai;
            this.btnQuaylai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnQuaylai.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnQuaylai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuaylai.ForeColor = System.Drawing.Color.White;
            this.btnQuaylai.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.btnQuaylai.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.btnQuaylai.HoverState.Parent = this.btnQuaylai;
            this.btnQuaylai.Location = new System.Drawing.Point(45, 271);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.ShadowDecoration.Parent = this.btnQuaylai;
            this.btnQuaylai.Size = new System.Drawing.Size(124, 48);
            this.btnQuaylai.TabIndex = 244;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click_1);
            // 
            // lblgiay
            // 
            this.lblgiay.AutoSize = true;
            this.lblgiay.Font = new System.Drawing.Font("Sitka Banner", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgiay.ForeColor = System.Drawing.Color.Green;
            this.lblgiay.Location = new System.Drawing.Point(413, 217);
            this.lblgiay.Name = "lblgiay";
            this.lblgiay.Size = new System.Drawing.Size(39, 24);
            this.lblgiay.TabIndex = 129;
            this.lblgiay.Text = "giây\r\n";
            // 
            // lblDem
            // 
            this.lblDem.AutoSize = true;
            this.lblDem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDem.ForeColor = System.Drawing.Color.Green;
            this.lblDem.Location = new System.Drawing.Point(383, 222);
            this.lblDem.Name = "lblDem";
            this.lblDem.Size = new System.Drawing.Size(24, 17);
            this.lblDem.TabIndex = 128;
            this.lblDem.Text = "60";
            // 
            // lblmaxn
            // 
            this.lblmaxn.AutoSize = true;
            this.lblmaxn.Font = new System.Drawing.Font("Sitka Banner", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaxn.ForeColor = System.Drawing.Color.Green;
            this.lblmaxn.Location = new System.Drawing.Point(190, 217);
            this.lblmaxn.Name = "lblmaxn";
            this.lblmaxn.Size = new System.Drawing.Size(187, 24);
            this.lblmaxn.TabIndex = 127;
            this.lblmaxn.Text = "Mã xác nhận sẽ gửi trong";
            // 
            // lblCanhbao
            // 
            this.lblCanhbao.AutoSize = true;
            this.lblCanhbao.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanhbao.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCanhbao.Location = new System.Drawing.Point(224, 57);
            this.lblCanhbao.Name = "lblCanhbao";
            this.lblCanhbao.Size = new System.Drawing.Size(299, 21);
            this.lblCanhbao.TabIndex = 126;
            this.lblCanhbao.Text = "Vui lòng kiểm tra tài khoản và mật khẩu của bạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 125;
            this.label3.Text = " Mã xác nhận:";
            // 
            // txtMa
            // 
            this.txtMa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa.DefaultText = "";
            this.txtMa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMa.DisabledState.Parent = this.txtMa;
            this.txtMa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMa.FocusedState.Parent = this.txtMa;
            this.txtMa.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtMa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMa.HoverState.Parent = this.txtMa;
            this.txtMa.Location = new System.Drawing.Point(193, 166);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMa.Name = "txtMa";
            this.txtMa.PasswordChar = '\0';
            this.txtMa.PlaceholderText = "";
            this.txtMa.SelectedText = "";
            this.txtMa.ShadowDecoration.Parent = this.txtMa;
            this.txtMa.Size = new System.Drawing.Size(296, 46);
            this.txtMa.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMa.TabIndex = 124;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(193, 129);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 2);
            this.panel2.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(195, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 122;
            this.label4.Text = "+84";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(244, 98);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 32);
            this.panel3.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 120;
            this.label5.Text = "Số điện thoại:";
            // 
            // txtSđtnv
            // 
            this.txtSđtnv.BackColor = System.Drawing.Color.White;
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
            this.txtSđtnv.Location = new System.Drawing.Point(248, 82);
            this.txtSđtnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSđtnv.Name = "txtSđtnv";
            this.txtSđtnv.PasswordChar = '\0';
            this.txtSđtnv.PlaceholderText = "";
            this.txtSđtnv.ReadOnly = true;
            this.txtSđtnv.SelectedText = "";
            this.txtSđtnv.ShadowDecoration.Parent = this.txtSđtnv;
            this.txtSđtnv.Size = new System.Drawing.Size(317, 48);
            this.txtSđtnv.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSđtnv.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(239, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 29);
            this.label1.TabIndex = 116;
            this.label1.Text = "MÃ\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(135, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(364, 29);
            this.label8.TabIndex = 115;
            this.label8.Text = "XÁC NHẬN          SỐ ĐIỆN THOẠI CỦA BẠN";
            // 
            // UC_XacNhanSDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_XacNhanSDT";
            this.Size = new System.Drawing.Size(711, 360);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblgiay;
        private System.Windows.Forms.Label lblDem;
        private System.Windows.Forms.Label lblmaxn;
        private System.Windows.Forms.Label lblCanhbao;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSđtnv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnQuaylai;
    }
}
