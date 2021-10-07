
namespace WindowsFormsApp
{
    partial class UC_StatisticCommodity
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
            this.dtThongKe = new System.Windows.Forms.DataGridView();
            this.txtThongKe = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Th = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtThongKe
            // 
            this.dtThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtThongKe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtThongKe.Location = new System.Drawing.Point(20, 155);
            this.dtThongKe.Name = "dtThongKe";
            this.dtThongKe.ReadOnly = true;
            this.dtThongKe.RowHeadersWidth = 51;
            this.dtThongKe.RowTemplate.Height = 24;
            this.dtThongKe.Size = new System.Drawing.Size(929, 416);
            this.dtThongKe.TabIndex = 0;
        
            // 
            // txtThongKe
            // 
            this.txtThongKe.AutoSize = true;
            this.txtThongKe.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongKe.Location = new System.Drawing.Point(403, 34);
            this.txtThongKe.Name = "txtThongKe";
            this.txtThongKe.Size = new System.Drawing.Size(0, 36);
            this.txtThongKe.TabIndex = 1;
            this.txtThongKe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(301, 59);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // Th
            // 
            this.Th.Location = new System.Drawing.Point(522, 59);
            this.Th.Name = "Th";
            this.Th.Size = new System.Drawing.Size(108, 32);
            this.Th.TabIndex = 4;
            this.Th.Text = "Thống Kê";
            this.Th.UseVisualStyleBackColor = true;

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xuất Excel";
            this.button1.UseVisualStyleBackColor = true;
    
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 32);
            this.textBox1.TabIndex = 6;
      
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("FS Harabara", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(262, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 48);
            this.label3.TabIndex = 9;
            this.label3.Text = "THỐNG KÊ DOANH THU";
            // 
            // UC_ThongKeHangHoa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Th);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtThongKe);
            this.Controls.Add(this.dtThongKe);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_ThongKeHangHoa";
            this.Size = new System.Drawing.Size(974, 596);
            ((System.ComponentModel.ISupportInitialize)(this.dtThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtThongKe;
        private System.Windows.Forms.Label txtThongKe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button Th;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
