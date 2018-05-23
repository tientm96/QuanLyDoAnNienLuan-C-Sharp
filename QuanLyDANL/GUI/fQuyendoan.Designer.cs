namespace QuanLyDANL
{
    partial class fQuyendoan
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
            this.dGVdsQDA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbxmaQDA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dTPngaynop = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxmaPDK = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnnop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxnhanxet = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxdiemda = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdsQDA)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dGVdsQDA);
            this.panel1.Location = new System.Drawing.Point(4, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 369);
            this.panel1.TabIndex = 0;
            // 
            // dGVdsQDA
            // 
            this.dGVdsQDA.AllowUserToAddRows = false;
            this.dGVdsQDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVdsQDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dGVdsQDA.Location = new System.Drawing.Point(0, 5);
            this.dGVdsQDA.Name = "dGVdsQDA";
            this.dGVdsQDA.Size = new System.Drawing.Size(392, 358);
            this.dGVdsQDA.TabIndex = 0;
            this.dGVdsQDA.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVdsQDA_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaQuyenDA";
            this.Column1.HeaderText = "Mã quyển đồ án";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayNop";
            this.Column2.HeaderText = "Ngày nộp";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiemDA";
            this.Column3.HeaderText = "Điểm DA";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NhanXet";
            this.Column4.HeaderText = "Nhận xét";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "FK_MaPhieuDK";
            this.Column5.HeaderText = "Mã phiếu đăng ký";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách quyển đồ án";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbxmaQDA);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(9, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 41);
            this.panel4.TabIndex = 8;
            // 
            // tbxmaQDA
            // 
            this.tbxmaQDA.Location = new System.Drawing.Point(105, 11);
            this.tbxmaQDA.Name = "tbxmaQDA";
            this.tbxmaQDA.Size = new System.Drawing.Size(147, 20);
            this.tbxmaQDA.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã quyển đồ án";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Location = new System.Drawing.Point(413, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(383, 280);
            this.panel6.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dTPngaynop);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(9, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 45);
            this.panel5.TabIndex = 12;
            // 
            // dTPngaynop
            // 
            this.dTPngaynop.Location = new System.Drawing.Point(105, 14);
            this.dTPngaynop.Name = "dTPngaynop";
            this.dTPngaynop.Size = new System.Drawing.Size(147, 20);
            this.dTPngaynop.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày nộp ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbxmaPDK);
            this.panel3.Location = new System.Drawing.Point(9, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 45);
            this.panel3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu đăng ký";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxmaPDK
            // 
            this.tbxmaPDK.Location = new System.Drawing.Point(105, 11);
            this.tbxmaPDK.Name = "tbxmaPDK";
            this.tbxmaPDK.Size = new System.Drawing.Size(147, 20);
            this.tbxmaPDK.TabIndex = 1;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Location = new System.Drawing.Point(726, 367);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(70, 41);
            this.btnthoat.TabIndex = 14;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Location = new System.Drawing.Point(641, 367);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(70, 41);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhat.Location = new System.Drawing.Point(542, 367);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(74, 41);
            this.btncapnhat.TabIndex = 12;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnnop
            // 
            this.btnnop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnnop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnop.Location = new System.Drawing.Point(444, 367);
            this.btnnop.Name = "btnnop";
            this.btnnop.Size = new System.Drawing.Size(72, 41);
            this.btnnop.TabIndex = 11;
            this.btnnop.Text = "Nộp";
            this.btnnop.UseVisualStyleBackColor = false;
            this.btnnop.Click += new System.EventHandler(this.btnnop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Thông tin quyển đồ án";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbxnhanxet);
            this.panel2.Location = new System.Drawing.Point(9, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 45);
            this.panel2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhận xét";
            // 
            // tbxnhanxet
            // 
            this.tbxnhanxet.Location = new System.Drawing.Point(105, 11);
            this.tbxnhanxet.Name = "tbxnhanxet";
            this.tbxnhanxet.ReadOnly = true;
            this.tbxnhanxet.Size = new System.Drawing.Size(147, 20);
            this.tbxnhanxet.TabIndex = 1;
            this.tbxnhanxet.Text = "không";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.tbxdiemda);
            this.panel7.Location = new System.Drawing.Point(9, 166);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(266, 45);
            this.panel7.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Điểm đồ án";
            // 
            // tbxdiemda
            // 
            this.tbxdiemda.Location = new System.Drawing.Point(105, 11);
            this.tbxdiemda.Name = "tbxdiemda";
            this.tbxdiemda.ReadOnly = true;
            this.tbxdiemda.Size = new System.Drawing.Size(147, 20);
            this.tbxdiemda.TabIndex = 1;
            this.tbxdiemda.Text = "0";
            // 
            // fQuyendoan
            // 
            this.AcceptButton = this.btnnop;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(808, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnnop);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.panel1);
            this.Name = "fQuyendoan";
            this.Text = "Quyển đồ án";
            this.Load += new System.EventHandler(this.fQuyendoan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVdsQDA)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVdsQDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxmaPDK;
        private System.Windows.Forms.Button btnnop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dTPngaynop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxmaQDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxdiemda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxnhanxet;
    }
}