namespace QuanLyDANL
{
    partial class fTaikhoan
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
            this.tbxtkid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbxPWnew = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btxthaydoi = new System.Windows.Forms.Button();
            this.btxthoat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbxghichu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btxthem = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbxpassold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxtkid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 34);
            this.panel1.TabIndex = 0;
            // 
            // tbxtkid
            // 
            this.tbxtkid.Location = new System.Drawing.Point(73, 8);
            this.tbxtkid.Name = "tbxtkid";
            this.tbxtkid.Size = new System.Drawing.Size(185, 20);
            this.tbxtkid.TabIndex = 1;
            this.tbxtkid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TaiKhoanID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(291, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 104);
            this.panel2.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tbxPWnew);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(5, 39);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(243, 34);
            this.panel9.TabIndex = 3;
            // 
            // tbxPWnew
            // 
            this.tbxPWnew.Location = new System.Drawing.Point(76, 8);
            this.tbxPWnew.Name = "tbxPWnew";
            this.tbxPWnew.Size = new System.Drawing.Size(164, 20);
            this.tbxPWnew.TabIndex = 4;
            this.tbxPWnew.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thay đổi mật khẩu";
            // 
            // btxthaydoi
            // 
            this.btxthaydoi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btxthaydoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btxthaydoi.Location = new System.Drawing.Point(349, 238);
            this.btxthaydoi.Name = "btxthaydoi";
            this.btxthaydoi.Size = new System.Drawing.Size(75, 39);
            this.btxthaydoi.TabIndex = 6;
            this.btxthaydoi.Text = "Thay đổi mật khẩu";
            this.btxthaydoi.UseVisualStyleBackColor = false;
            this.btxthaydoi.Click += new System.EventHandler(this.btxthaydoi_Click);
            // 
            // btxthoat
            // 
            this.btxthoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btxthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btxthoat.Location = new System.Drawing.Point(459, 238);
            this.btxthoat.Name = "btxthoat";
            this.btxthoat.Size = new System.Drawing.Size(75, 39);
            this.btxthoat.TabIndex = 6;
            this.btxthoat.Text = "Thoát";
            this.btxthoat.UseVisualStyleBackColor = false;
            this.btxthoat.Click += new System.EventHandler(this.btxthoat_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(6, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 202);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbxghichu);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(6, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 108);
            this.panel4.TabIndex = 6;
            // 
            // tbxghichu
            // 
            this.tbxghichu.Location = new System.Drawing.Point(73, 11);
            this.tbxghichu.Multiline = true;
            this.tbxghichu.Name = "tbxghichu";
            this.tbxghichu.Size = new System.Drawing.Size(188, 94);
            this.tbxghichu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ghi chú";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btxthem
            // 
            this.btxthem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btxthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btxthem.Location = new System.Drawing.Point(210, 238);
            this.btxthem.Name = "btxthem";
            this.btxthem.Size = new System.Drawing.Size(75, 39);
            this.btxthem.TabIndex = 6;
            this.btxthem.Text = "Thêm tài khoản";
            this.btxthem.UseVisualStyleBackColor = false;
            this.btxthem.Click += new System.EventHandler(this.btxthem_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbxpassold);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(6, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 34);
            this.panel5.TabIndex = 7;
            // 
            // tbxpassold
            // 
            this.tbxpassold.Location = new System.Drawing.Point(73, 8);
            this.tbxpassold.Name = "tbxpassold";
            this.tbxpassold.Size = new System.Drawing.Size(185, 20);
            this.tbxpassold.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu";
            // 
            // fTaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(546, 286);
            this.Controls.Add(this.btxthaydoi);
            this.Controls.Add(this.btxthoat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btxthem);
            this.Controls.Add(this.panel2);
            this.Name = "fTaikhoan";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.fTaikhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxtkid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbxPWnew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btxthaydoi;
        private System.Windows.Forms.Button btxthoat;
        private System.Windows.Forms.Button btxthem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbxghichu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbxpassold;
        private System.Windows.Forms.Label label4;
    }
}