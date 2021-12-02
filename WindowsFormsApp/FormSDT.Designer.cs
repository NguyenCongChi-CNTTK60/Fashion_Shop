
namespace WindowsFormsApp
{
    partial class FormSDT
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlma = new System.Windows.Forms.Panel();
            this.lblCanhbao = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSđtnv = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnLuu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnQuaylai = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnlma
            // 
            this.pnlma.Controls.Add(this.btnQuaylai);
            this.pnlma.Controls.Add(this.btnLuu);
            this.pnlma.Controls.Add(this.lblCanhbao);
            this.pnlma.Controls.Add(this.panel2);
            this.pnlma.Controls.Add(this.label1);
            this.pnlma.Controls.Add(this.panel3);
            this.pnlma.Controls.Add(this.label8);
            this.pnlma.Controls.Add(this.label5);
            this.pnlma.Controls.Add(this.txtSđtnv);
            this.pnlma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlma.Location = new System.Drawing.Point(0, 0);
            this.pnlma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlma.Name = "pnlma";
            this.pnlma.Size = new System.Drawing.Size(711, 360);
            this.pnlma.TabIndex = 0;
            // 
            // lblCanhbao
            // 
            this.lblCanhbao.AutoSize = true;
            this.lblCanhbao.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanhbao.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCanhbao.Location = new System.Drawing.Point(206, 170);
            this.lblCanhbao.Name = "lblCanhbao";
            this.lblCanhbao.Size = new System.Drawing.Size(299, 21);
            this.lblCanhbao.TabIndex = 90;
            this.lblCanhbao.Text = "Vui lòng kiểm tra tài khoản và mật khẩu của bạn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(210, 142);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 2);
            this.panel2.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(212, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 86;
            this.label1.Text = "+84";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(261, 112);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 32);
            this.panel3.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(171, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 29);
            this.label8.TabIndex = 84;
            this.label8.Text = "XÁC NHẬN SỐ ĐIỆN THOẠI CỦA BẠN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 83;
            this.label5.Text = "Số điện thoại:";
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
            this.txtSđtnv.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtSđtnv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSđtnv.FocusedState.Parent = this.txtSđtnv;
            this.txtSđtnv.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.txtSđtnv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtSđtnv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSđtnv.HoverState.Parent = this.txtSđtnv;
            this.txtSđtnv.Location = new System.Drawing.Point(261, 98);
            this.txtSđtnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSđtnv.Name = "txtSđtnv";
            this.txtSđtnv.PasswordChar = '\0';
            this.txtSđtnv.PlaceholderText = "";
            this.txtSđtnv.SelectedText = "";
            this.txtSđtnv.ShadowDecoration.Parent = this.txtSđtnv;
            this.txtSđtnv.Size = new System.Drawing.Size(296, 46);
            this.txtSđtnv.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSđtnv.TabIndex = 82;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this.txtSđtnv;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 15;
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
            this.btnLuu.Location = new System.Drawing.Point(493, 222);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShadowDecoration.Parent = this.btnLuu;
            this.btnLuu.Size = new System.Drawing.Size(178, 54);
            this.btnLuu.TabIndex = 133;
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
            this.btnQuaylai.Location = new System.Drawing.Point(42, 222);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.ShadowDecoration.Parent = this.btnQuaylai;
            this.btnQuaylai.Size = new System.Drawing.Size(178, 54);
            this.btnQuaylai.TabIndex = 134;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click_1);
            // 
            // FormSDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.pnlma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSodienthoai";
            this.pnlma.ResumeLayout(false);
            this.pnlma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel pnlma;
        private System.Windows.Forms.Label lblCanhbao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSđtnv;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuu;
        private Guna.UI2.WinForms.Guna2GradientButton btnQuaylai;
    }
}