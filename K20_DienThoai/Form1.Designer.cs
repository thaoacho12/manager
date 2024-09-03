namespace K20_DienThoai
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnNhapDL = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHangSX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtHangSX = new System.Windows.Forms.RadioButton();
            this.rbtTenDT = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaDL = new System.Windows.Forms.Button();
            this.btnSuaDL = new System.Windows.Forms.Button();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 52);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnNhapDL);
            this.panel2.Controls.Add(this.txtGia);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtThongTin);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtHangSX);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTenDT);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMaDT);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 287);
            this.panel2.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(92, 219);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnNhapDL
            // 
            this.btnNhapDL.Location = new System.Drawing.Point(6, 219);
            this.btnNhapDL.Name = "btnNhapDL";
            this.btnNhapDL.Size = new System.Drawing.Size(75, 23);
            this.btnNhapDL.TabIndex = 12;
            this.btnNhapDL.Text = "Thêm DL";
            this.btnNhapDL.UseVisualStyleBackColor = true;
            this.btnNhapDL.Click += new System.EventHandler(this.btnNhapDL_Click);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(67, 171);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá:";
            // 
            // txtThongTin
            // 
            this.txtThongTin.Location = new System.Drawing.Point(67, 132);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(100, 20);
            this.txtThongTin.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thông Tin:";
            // 
            // txtHangSX
            // 
            this.txtHangSX.Location = new System.Drawing.Point(67, 95);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Size = new System.Drawing.Size(100, 20);
            this.txtHangSX.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hãng SX:";
            // 
            // txtTenDT
            // 
            this.txtTenDT.Location = new System.Drawing.Point(67, 55);
            this.txtTenDT.Name = "txtTenDT";
            this.txtTenDT.Size = new System.Drawing.Size(100, 20);
            this.txtTenDT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên ĐT:";
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(67, 18);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.Size = new System.Drawing.Size(100, 20);
            this.txtMaDT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ĐT: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtHangSX);
            this.panel3.Controls.Add(this.rbtTenDT);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.btnXoaDL);
            this.panel3.Controls.Add(this.btnSuaDL);
            this.panel3.Controls.Add(this.dgvHienThi);
            this.panel3.Controls.Add(this.txtTimKiem);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(176, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 287);
            this.panel3.TabIndex = 2;
            // 
            // rbtHangSX
            // 
            this.rbtHangSX.AutoSize = true;
            this.rbtHangSX.Location = new System.Drawing.Point(269, 202);
            this.rbtHangSX.Name = "rbtHangSX";
            this.rbtHangSX.Size = new System.Drawing.Size(68, 17);
            this.rbtHangSX.TabIndex = 17;
            this.rbtHangSX.Text = "Hãng SX";
            this.rbtHangSX.UseVisualStyleBackColor = true;
            // 
            // rbtTenDT
            // 
            this.rbtTenDT.AutoSize = true;
            this.rbtTenDT.Checked = true;
            this.rbtTenDT.Location = new System.Drawing.Point(188, 202);
            this.rbtTenDT.Name = "rbtTenDT";
            this.rbtTenDT.Size = new System.Drawing.Size(62, 17);
            this.rbtTenDT.TabIndex = 16;
            this.rbtTenDT.TabStop = true;
            this.rbtTenDT.Text = "Tên ĐT";
            this.rbtTenDT.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(364, 240);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaDL
            // 
            this.btnXoaDL.Location = new System.Drawing.Point(188, 240);
            this.btnXoaDL.Name = "btnXoaDL";
            this.btnXoaDL.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDL.TabIndex = 14;
            this.btnXoaDL.Text = "Xoá DL";
            this.btnXoaDL.UseVisualStyleBackColor = true;
            this.btnXoaDL.Click += new System.EventHandler(this.btnXoaDL_Click);
            // 
            // btnSuaDL
            // 
            this.btnSuaDL.Location = new System.Drawing.Point(15, 240);
            this.btnSuaDL.Name = "btnSuaDL";
            this.btnSuaDL.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDL.TabIndex = 13;
            this.btnSuaDL.Text = "Sửa DL";
            this.btnSuaDL.UseVisualStyleBackColor = true;
            this.btnSuaDL.Click += new System.EventHandler(this.btnSuaDL_Click);
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.AllowUserToAddRows = false;
            this.dgvHienThi.AllowUserToDeleteRows = false;
            this.dgvHienThi.AllowUserToResizeRows = false;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHienThi.Location = new System.Drawing.Point(0, 0);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.ReadOnly = true;
            this.dgvHienThi.RowHeadersVisible = false;
            this.dgvHienThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHienThi.Size = new System.Drawing.Size(500, 187);
            this.dgvHienThi.TabIndex = 11;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(73, 199);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 20);
            this.txtTimKiem.TabIndex = 9;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tim kiếm: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 339);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNhapDL;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHangSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaDL;
        private System.Windows.Forms.Button btnSuaDL;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtHangSX;
        private System.Windows.Forms.RadioButton rbtTenDT;
        private System.Windows.Forms.Button btnHuy;
    }
}

