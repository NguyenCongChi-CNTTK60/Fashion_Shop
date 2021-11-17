
namespace WindowsFormsApp
{
    partial class FormChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMoi2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito", 10.8F);
            this.label1.Location = new System.Drawing.Point(44, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu Cũ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito", 10.8F);
            this.label2.Location = new System.Drawing.Point(44, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu Mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito", 10.8F);
            this.label3.Location = new System.Drawing.Point(27, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác Nhận Mật Khẩu:";
            // 
            // txtCu
            // 
            this.txtCu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCu.DefaultText = "";
            this.txtCu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCu.DisabledState.Parent = this.txtCu;
            this.txtCu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCu.FocusedState.Parent = this.txtCu;
            this.txtCu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCu.HoverState.Parent = this.txtCu;
            this.txtCu.Location = new System.Drawing.Point(227, 47);
            this.txtCu.Name = "txtCu";
            this.txtCu.PasswordChar = '\0';
            this.txtCu.PlaceholderText = "";
            this.txtCu.SelectedText = "";
            this.txtCu.ShadowDecoration.Parent = this.txtCu;
            this.txtCu.Size = new System.Drawing.Size(213, 36);
            this.txtCu.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCu.TabIndex = 3;
            // 
            // txtMoi
            // 
            this.txtMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoi.DefaultText = "";
            this.txtMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoi.DisabledState.Parent = this.txtMoi;
            this.txtMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoi.FocusedState.Parent = this.txtMoi;
            this.txtMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoi.HoverState.Parent = this.txtMoi;
            this.txtMoi.Location = new System.Drawing.Point(227, 103);
            this.txtMoi.Name = "txtMoi";
            this.txtMoi.PasswordChar = '\0';
            this.txtMoi.PlaceholderText = "";
            this.txtMoi.SelectedText = "";
            this.txtMoi.ShadowDecoration.Parent = this.txtMoi;
            this.txtMoi.Size = new System.Drawing.Size(213, 36);
            this.txtMoi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMoi.TabIndex = 4;
            // 
            // txtMoi2
            // 
            this.txtMoi2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoi2.DefaultText = "";
            this.txtMoi2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoi2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoi2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoi2.DisabledState.Parent = this.txtMoi2;
            this.txtMoi2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoi2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoi2.FocusedState.Parent = this.txtMoi2;
            this.txtMoi2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoi2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoi2.HoverState.Parent = this.txtMoi2;
            this.txtMoi2.Location = new System.Drawing.Point(227, 163);
            this.txtMoi2.Name = "txtMoi2";
            this.txtMoi2.PasswordChar = '\0';
            this.txtMoi2.PlaceholderText = "";
            this.txtMoi2.SelectedText = "";
            this.txtMoi2.ShadowDecoration.Parent = this.txtMoi2;
            this.txtMoi2.Size = new System.Drawing.Size(213, 36);
            this.txtMoi2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMoi2.TabIndex = 5;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Nunito", 10.8F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(302, 264);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(138, 45);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Xác Nhận";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 352);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtMoi2);
            this.Controls.Add(this.txtMoi);
            this.Controls.Add(this.txtCu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCu;
        private Guna.UI2.WinForms.Guna2TextBox txtMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtMoi2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}