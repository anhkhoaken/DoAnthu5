namespace QuanLyNhanVien.GUI
{
    partial class QuanLyCong_HUI
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
            this.dgvcong = new System.Windows.Forms.DataGridView();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtNgayCong = new System.Windows.Forms.TextBox();
            this.txtHSPC = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aaaaaaaa = new System.Windows.Forms.Label();
            this.txtThangaaa = new System.Windows.Forms.Label();
            this.aaa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.dtpthoigian = new System.Windows.Forms.DateTimePicker();
            this.btxem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcong
            // 
            this.dgvcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcong.Location = new System.Drawing.Point(1, 54);
            this.dgvcong.Name = "dgvcong";
            this.dgvcong.Size = new System.Drawing.Size(798, 278);
            this.dgvcong.TabIndex = 0;
            this.dgvcong.SelectionChanged += new System.EventHandler(this.Dgvcong_SelectionChanged);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(113, 363);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(178, 20);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(113, 426);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(178, 20);
            this.txtTenNhanVien.TabIndex = 2;
            // 
            // txtNgayCong
            // 
            this.txtNgayCong.Location = new System.Drawing.Point(113, 490);
            this.txtNgayCong.Name = "txtNgayCong";
            this.txtNgayCong.Size = new System.Drawing.Size(178, 20);
            this.txtNgayCong.TabIndex = 3;
            // 
            // txtHSPC
            // 
            this.txtHSPC.Location = new System.Drawing.Point(520, 363);
            this.txtHSPC.Name = "txtHSPC";
            this.txtHSPC.Size = new System.Drawing.Size(178, 20);
            this.txtHSPC.TabIndex = 4;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(520, 426);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(178, 20);
            this.txtThang.TabIndex = 5;
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(520, 490);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(178, 20);
            this.txtnam.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // aaaaaaaa
            // 
            this.aaaaaaaa.AutoSize = true;
            this.aaaaaaaa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.aaaaaaaa.Location = new System.Drawing.Point(401, 494);
            this.aaaaaaaa.Name = "aaaaaaaa";
            this.aaaaaaaa.Size = new System.Drawing.Size(37, 16);
            this.aaaaaaaa.TabIndex = 8;
            this.aaaaaaaa.Text = "Năm";
            // 
            // txtThangaaa
            // 
            this.txtThangaaa.AutoSize = true;
            this.txtThangaaa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThangaaa.Location = new System.Drawing.Point(401, 430);
            this.txtThangaaa.Name = "txtThangaaa";
            this.txtThangaaa.Size = new System.Drawing.Size(47, 16);
            this.txtThangaaa.TabIndex = 9;
            this.txtThangaaa.Text = "Tháng";
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.aaa.Location = new System.Drawing.Point(401, 363);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(104, 16);
            this.aaa.TabIndex = 10;
            this.aaa.Text = "Hệ Số Phụ Cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(12, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày Công";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(12, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên Nhân Viên";
            // 
            // btCapNhat
            // 
            this.btCapNhat.Location = new System.Drawing.Point(291, 556);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(83, 34);
            this.btCapNhat.TabIndex = 13;
            this.btCapNhat.Text = "button1";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.BtCapNhat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(430, 556);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(83, 34);
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "button2";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.BtXoa_Click);
            // 
            // dtpthoigian
            // 
            this.dtpthoigian.Location = new System.Drawing.Point(205, 28);
            this.dtpthoigian.Name = "dtpthoigian";
            this.dtpthoigian.Size = new System.Drawing.Size(340, 20);
            this.dtpthoigian.TabIndex = 15;
            // 
            // btxem
            // 
            this.btxem.Location = new System.Drawing.Point(563, 28);
            this.btxem.Name = "btxem";
            this.btxem.Size = new System.Drawing.Size(99, 23);
            this.btxem.TabIndex = 16;
            this.btxem.Text = "button1";
            this.btxem.UseVisualStyleBackColor = true;
            this.btxem.Click += new System.EventHandler(this.Btxem_Click);
            // 
            // QuanLyCong_HUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.btxem);
            this.Controls.Add(this.dtpthoigian);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.txtThangaaa);
            this.Controls.Add(this.aaaaaaaa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtHSPC);
            this.Controls.Add(this.txtNgayCong);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.dgvcong);
            this.Name = "QuanLyCong_HUI";
            this.Text = "QuanLyCong_HUI";
            //this.Load += new System.EventHandler(this.QuanLyCong_HUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcong;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtNgayCong;
        private System.Windows.Forms.TextBox txtHSPC;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aaaaaaaa;
        private System.Windows.Forms.Label txtThangaaa;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DateTimePicker dtpthoigian;
        private System.Windows.Forms.Button btxem;
    }
}