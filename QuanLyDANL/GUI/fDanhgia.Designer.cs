namespace QuanLyDANL
{
    partial class fDanhgia
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
            this.dGVdsPPC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxnhanxet = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbxdiemDA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxmaGV = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbxmaQDA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnchamdiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdsPPC)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dGVdsPPC);
            this.panel1.Location = new System.Drawing.Point(5, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 383);
            this.panel1.TabIndex = 0;
            // 
            // dGVdsPPC
            // 
            this.dGVdsPPC.AllowUserToAddRows = false;
            this.dGVdsPPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVdsPPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dGVdsPPC.Location = new System.Drawing.Point(3, 0);
            this.dGVdsPPC.Name = "dGVdsPPC";
            this.dGVdsPPC.Size = new System.Drawing.Size(379, 367);
            this.dGVdsPPC.TabIndex = 0;
            this.dGVdsPPC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVdsPPC_CellContentClick);
            this.dGVdsPPC.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVdsQDA_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhieuPC";
            this.Column1.HeaderText = "Mã phiếu phân công";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayPC";
            this.Column2.HeaderText = "Ngày phân công";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FK_MaGV";
            this.Column3.HeaderText = "Mã giảng viên";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FK_MaChucVu";
            this.Column4.HeaderText = "Mã chức vụ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "FK_MaQuyenDA";
            this.Column5.HeaderText = "Mã quyển đồ án";
            this.Column5.Name = "Column5";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(400, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 316);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Vui lòng chọn mã quyển đồ án hoặc mã giáo viên   ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.tbxnhanxet);
            this.panel5.Location = new System.Drawing.Point(8, 214);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(337, 90);
            this.panel5.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhận xét";
            // 
            // tbxnhanxet
            // 
            this.tbxnhanxet.Location = new System.Drawing.Point(105, 11);
            this.tbxnhanxet.Multiline = true;
            this.tbxnhanxet.Name = "tbxnhanxet";
            this.tbxnhanxet.Size = new System.Drawing.Size(197, 73);
            this.tbxnhanxet.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbxdiemDA);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(8, 167);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(337, 41);
            this.panel6.TabIndex = 14;
            // 
            // tbxdiemDA
            // 
            this.tbxdiemDA.Location = new System.Drawing.Point(105, 11);
            this.tbxdiemDA.Name = "tbxdiemDA";
            this.tbxdiemDA.Size = new System.Drawing.Size(197, 20);
            this.tbxdiemDA.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm quyển đồ án";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbxmaGV);
            this.panel3.Location = new System.Drawing.Point(8, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 45);
            this.panel3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã giảng viên";
            // 
            // tbxmaGV
            // 
            this.tbxmaGV.Location = new System.Drawing.Point(105, 11);
            this.tbxmaGV.Name = "tbxmaGV";
            this.tbxmaGV.ReadOnly = true;
            this.tbxmaGV.Size = new System.Drawing.Size(197, 20);
            this.tbxmaGV.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbxmaQDA);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(8, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 41);
            this.panel4.TabIndex = 11;
            // 
            // tbxmaQDA
            // 
            this.tbxmaQDA.Location = new System.Drawing.Point(105, 11);
            this.tbxmaQDA.Name = "tbxmaQDA";
            this.tbxmaQDA.ReadOnly = true;
            this.tbxmaQDA.Size = new System.Drawing.Size(197, 20);
            this.tbxmaQDA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã quyển đồ án";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Location = new System.Drawing.Point(669, 365);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 45);
            this.btnthoat.TabIndex = 17;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnchamdiem
            // 
            this.btnchamdiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnchamdiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchamdiem.Location = new System.Drawing.Point(476, 365);
            this.btnchamdiem.Name = "btnchamdiem";
            this.btnchamdiem.Size = new System.Drawing.Size(75, 45);
            this.btnchamdiem.TabIndex = 16;
            this.btnchamdiem.Text = "Chấm điểm";
            this.btnchamdiem.UseVisualStyleBackColor = false;
            this.btnchamdiem.Click += new System.EventHandler(this.btnchamdiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách phiếu phân công";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhat.Location = new System.Drawing.Point(572, 365);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 45);
            this.btncapnhat.TabIndex = 18;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // fDanhgia
            // 
            this.AcceptButton = this.btnchamdiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(783, 422);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnchamdiem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fDanhgia";
            this.Text = "Đánh giá quyển đồ án";
            this.Load += new System.EventHandler(this.fDanhgia_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVdsPPC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVdsPPC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnchamdiem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxnhanxet;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbxdiemDA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxmaGV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbxmaQDA;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}