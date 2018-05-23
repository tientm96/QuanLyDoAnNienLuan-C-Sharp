namespace QuanLyDANL
{
    partial class fThongke
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
            this.dGVdsDeTai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnradt = new System.Windows.Forms.Button();
            this.btnduocpc = new System.Windows.Forms.Button();
            this.btnduocdk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdsDeTai)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVdsDeTai
            // 
            this.dGVdsDeTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVdsDeTai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dGVdsDeTai.Location = new System.Drawing.Point(12, 8);
            this.dGVdsDeTai.Name = "dGVdsDeTai";
            this.dGVdsDeTai.Size = new System.Drawing.Size(523, 343);
            this.dGVdsDeTai.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã đề tài";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên đề tài";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Loại đề tài";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày ra đề tài";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mã giảng viên";
            this.Column5.Name = "Column5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnradt);
            this.panel1.Controls.Add(this.btnduocpc);
            this.panel1.Controls.Add(this.btnduocdk);
            this.panel1.Location = new System.Drawing.Point(561, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 339);
            this.panel1.TabIndex = 1;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Location = new System.Drawing.Point(48, 297);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(89, 39);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnradt
            // 
            this.btnradt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnradt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnradt.Location = new System.Drawing.Point(0, 133);
            this.btnradt.Name = "btnradt";
            this.btnradt.Size = new System.Drawing.Size(137, 65);
            this.btnradt.TabIndex = 2;
            this.btnradt.Text = "Số lượng đề tài giáo viên đã ra";
            this.btnradt.UseVisualStyleBackColor = false;
            // 
            // btnduocpc
            // 
            this.btnduocpc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnduocpc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnduocpc.Location = new System.Drawing.Point(0, 64);
            this.btnduocpc.Name = "btnduocpc";
            this.btnduocpc.Size = new System.Drawing.Size(137, 63);
            this.btnduocpc.TabIndex = 1;
            this.btnduocpc.Text = "Số  lượng đề tài giáo viên đươc phân công";
            this.btnduocpc.UseVisualStyleBackColor = false;
            // 
            // btnduocdk
            // 
            this.btnduocdk.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnduocdk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnduocdk.Location = new System.Drawing.Point(0, 3);
            this.btnduocdk.Name = "btnduocdk";
            this.btnduocdk.Size = new System.Drawing.Size(137, 55);
            this.btnduocdk.TabIndex = 0;
            this.btnduocdk.Text = "Số lượng đề tài được đăng ký";
            this.btnduocdk.UseVisualStyleBackColor = false;
            // 
            // fThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(710, 363);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dGVdsDeTai);
            this.Name = "fThongke";
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dGVdsDeTai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVdsDeTai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnradt;
        private System.Windows.Forms.Button btnduocpc;
        private System.Windows.Forms.Button btnduocdk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}