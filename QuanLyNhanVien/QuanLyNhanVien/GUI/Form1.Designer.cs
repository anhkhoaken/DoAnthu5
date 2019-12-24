namespace QuanLyNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbTaiKhoan = new System.Windows.Forms.TextBox();
            this.TxbMatKhau = new System.Windows.Forms.TextBox();
            this.BtnDangNhap = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu :";
            // 
            // TxbTaiKhoan
            // 
            this.TxbTaiKhoan.Location = new System.Drawing.Point(133, 76);
            this.TxbTaiKhoan.Name = "TxbTaiKhoan";
            this.TxbTaiKhoan.Size = new System.Drawing.Size(169, 20);
            this.TxbTaiKhoan.TabIndex = 2;
            // 
            // TxbMatKhau
            // 
            this.TxbMatKhau.Location = new System.Drawing.Point(133, 133);
            this.TxbMatKhau.Name = "TxbMatKhau";
            this.TxbMatKhau.Size = new System.Drawing.Size(169, 20);
            this.TxbMatKhau.TabIndex = 3;
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.Location = new System.Drawing.Point(84, 198);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.Size = new System.Drawing.Size(99, 32);
            this.BtnDangNhap.TabIndex = 4;
            this.BtnDangNhap.Text = "Đăng Nhập";
            this.BtnDangNhap.UseVisualStyleBackColor = true;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(214, 198);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(99, 32);
            this.BtnThoat.TabIndex = 5;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 304);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnDangNhap);
            this.Controls.Add(this.TxbMatKhau);
            this.Controls.Add(this.TxbTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbTaiKhoan;
        private System.Windows.Forms.TextBox TxbMatKhau;
        private System.Windows.Forms.Button BtnDangNhap;
        private System.Windows.Forms.Button BtnThoat;
    }
}

