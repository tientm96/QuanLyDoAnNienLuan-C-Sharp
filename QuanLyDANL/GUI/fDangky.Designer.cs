namespace QuanLyDANL
{
    partial class fDangky
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
            this.dGVdsphieudangky = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.tbxmadt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btndangky = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbxmssv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxmapdk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpngaydkdt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdsphieudangky)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dGVdsphieudangky);
            this.panel1.Location = new System.Drawing.Point(5, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 335);
            this.panel1.TabIndex = 0;
            // 
            // dGVdsphieudangky
            // 
            this.dGVdsphieudangky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVdsphieudangky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGVdsphieudangky.Location = new System.Drawing.Point(0, 3);
            this.dGVdsphieudangky.Name = "dGVdsphieudangky";
            this.dGVdsphieudangky.Size = new System.Drawing.Size(401, 327);
            this.dGVdsphieudangky.TabIndex = 0;
            this.dGVdsphieudangky.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVdsdetai_CellContentClick);
            this.dGVdsphieudangky.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVdsphieudangky_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách phiếu đăng ký";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(556, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Sinh viên đăng ký";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.tbxmadt);
            this.panel17.Controls.Add(this.label18);
            this.panel17.Location = new System.Drawing.Point(5, 133);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(338, 37);
            this.panel17.TabIndex = 7;
            // 
            // tbxmadt
            // 
            this.tbxmadt.Location = new System.Drawing.Point(103, 8);
            this.tbxmadt.Name = "tbxmadt";
            this.tbxmadt.Size = new System.Drawing.Size(219, 20);
            this.tbxmadt.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Mã đề tài";
            // 
            // btndangky
            // 
            this.btndangky.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btndangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangky.Location = new System.Drawing.Point(456, 334);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(75, 40);
            this.btndangky.TabIndex = 9;
            this.btndangky.Text = "Đăng ký";
            this.btndangky.UseVisualStyleBackColor = false;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Location = new System.Drawing.Point(736, 334);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 40);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel17);
            this.panel5.Location = new System.Drawing.Point(451, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 286);
            this.panel5.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbxmssv);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(5, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(332, 31);
            this.panel8.TabIndex = 3;
            // 
            // tbxmssv
            // 
            this.tbxmssv.Location = new System.Drawing.Point(103, 2);
            this.tbxmssv.Name = "tbxmssv";
            this.tbxmssv.Size = new System.Drawing.Size(219, 20);
            this.tbxmssv.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "MSSV";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbxmapdk);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(5, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 37);
            this.panel3.TabIndex = 9;
            // 
            // tbxmapdk
            // 
            this.tbxmapdk.Location = new System.Drawing.Point(103, 8);
            this.tbxmapdk.Name = "tbxmapdk";
            this.tbxmapdk.Size = new System.Drawing.Size(219, 20);
            this.tbxmapdk.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã phiếu đăng ký";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.dtpngaydkdt);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(7, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 31);
            this.panel4.TabIndex = 3;
            // 
            // dtpngaydkdt
            // 
            this.dtpngaydkdt.Location = new System.Drawing.Point(101, 3);
            this.dtpngaydkdt.Name = "dtpngaydkdt";
            this.dtpngaydkdt.Size = new System.Drawing.Size(219, 20);
            this.dtpngaydkdt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày đăng ký";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhat.Location = new System.Drawing.Point(645, 334);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 40);
            this.btncapnhat.TabIndex = 12;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Location = new System.Drawing.Point(551, 334);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 40);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FK_MSSV";
            this.Column1.HeaderText = "MSSV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaPhieuDK";
            this.Column2.HeaderText = "Mã phiếu đăng ký";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FK_MaDeTai";
            this.Column3.HeaderText = "Mã đề tài";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayDK";
            this.Column4.HeaderText = "Ngày đăng ký";
            this.Column4.Name = "Column4";
            // 
            // fDangky
            // 
            this.AcceptButton = this.btndangky;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(830, 386);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "fDangky";
            this.Text = "Đăng ký đề tài";
            this.Load += new System.EventHandler(this.fDangky_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVdsphieudangky)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVdsphieudangky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox tbxmadt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbxmssv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpngaydkdt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbxmapdk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}