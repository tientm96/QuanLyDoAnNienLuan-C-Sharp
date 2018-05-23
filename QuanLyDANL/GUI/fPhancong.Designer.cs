namespace QuanLyDANL
{
    partial class fPhancong
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dGVdsphieupc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxmaGV = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpngayphancong = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbxmaquyendoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbxmachucvu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbxmaphieuphancong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdsphieupc)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btncapnhat);
            this.panel6.Controls.Add(this.btnxoa);
            this.panel6.Controls.Add(this.btnthoat);
            this.panel6.Controls.Add(this.btnthem);
            this.panel6.Location = new System.Drawing.Point(444, 376);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(357, 54);
            this.panel6.TabIndex = 14;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhat.Location = new System.Drawing.Point(190, 8);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(74, 43);
            this.btncapnhat.TabIndex = 3;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Location = new System.Drawing.Point(99, 8);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(74, 43);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Location = new System.Drawing.Point(280, 8);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(74, 43);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Location = new System.Drawing.Point(3, 8);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(76, 43);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Danh sách phiếu phân công";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dGVdsphieupc);
            this.panel4.Location = new System.Drawing.Point(12, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 375);
            this.panel4.TabIndex = 11;
            // 
            // dGVdsphieupc
            // 
            this.dGVdsphieupc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVdsphieupc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dGVdsphieupc.Location = new System.Drawing.Point(0, 3);
            this.dGVdsphieupc.Name = "dGVdsphieupc";
            this.dGVdsphieupc.Size = new System.Drawing.Size(388, 369);
            this.dGVdsphieupc.TabIndex = 0;
            this.dGVdsphieupc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVdsQDA_CellContentClick);
            this.dGVdsphieupc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVdsphieupc_RowEnter);
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
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbxmaGV);
            this.panel2.Location = new System.Drawing.Point(21, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 45);
            this.panel2.TabIndex = 10;
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
            this.tbxmaGV.Location = new System.Drawing.Point(125, 11);
            this.tbxmaGV.Name = "tbxmaGV";
            this.tbxmaGV.Size = new System.Drawing.Size(177, 20);
            this.tbxmaGV.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpngayphancong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 41);
            this.panel1.TabIndex = 8;
            // 
            // dtpngayphancong
            // 
            this.dtpngayphancong.Location = new System.Drawing.Point(125, 14);
            this.dtpngayphancong.Name = "dtpngayphancong";
            this.dtpngayphancong.Size = new System.Drawing.Size(177, 20);
            this.dtpngayphancong.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày phân công";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(406, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 255);
            this.panel3.TabIndex = 17;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbxmaquyendoan);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(21, 195);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(337, 41);
            this.panel8.TabIndex = 13;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // tbxmaquyendoan
            // 
            this.tbxmaquyendoan.Location = new System.Drawing.Point(125, 11);
            this.tbxmaquyendoan.Name = "tbxmaquyendoan";
            this.tbxmaquyendoan.Size = new System.Drawing.Size(177, 20);
            this.tbxmaquyendoan.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã quyển đồ án";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbxmachucvu);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(21, 148);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(337, 41);
            this.panel7.TabIndex = 12;
            // 
            // tbxmachucvu
            // 
            this.tbxmachucvu.Location = new System.Drawing.Point(125, 11);
            this.tbxmachucvu.Name = "tbxmachucvu";
            this.tbxmachucvu.Size = new System.Drawing.Size(177, 20);
            this.tbxmachucvu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã chức vụ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbxmaphieuphancong);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(21, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(337, 41);
            this.panel5.TabIndex = 11;
            // 
            // tbxmaphieuphancong
            // 
            this.tbxmaphieuphancong.Location = new System.Drawing.Point(125, 11);
            this.tbxmaphieuphancong.Name = "tbxmaphieuphancong";
            this.tbxmaphieuphancong.Size = new System.Drawing.Size(177, 20);
            this.tbxmaphieuphancong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu phân công";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fPhancong
            // 
            this.AcceptButton = this.btnthem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Name = "fPhancong";
            this.Text = "Phân công chấm quyển đồ án";
            this.Load += new System.EventHandler(this.fPhancong_Load);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVdsphieupc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dGVdsphieupc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxmaGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbxmaphieuphancong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbxmaquyendoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbxmachucvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DateTimePicker dtpngayphancong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}