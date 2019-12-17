namespace QuanLyNhanVien
{
    partial class QuanLyBOPHAN_GUI
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
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.txbGhiChu = new System.Windows.Forms.TextBox();
            this.txbPhongBan = new System.Windows.Forms.TextBox();
            this.txbTenBoPhan = new System.Windows.Forms.TextBox();
            this.txbMaBoPhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtgdsBoPhan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdsBoPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(136, 509);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(137, 48);
            this.btnCapNhap.TabIndex = 17;
            this.btnCapNhap.Text = "Cập nhập";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // txbGhiChu
            // 
            this.txbGhiChu.Location = new System.Drawing.Point(302, 156);
            this.txbGhiChu.Name = "txbGhiChu";
            this.txbGhiChu.Size = new System.Drawing.Size(307, 20);
            this.txbGhiChu.TabIndex = 16;
            // 
            // txbPhongBan
            // 
            this.txbPhongBan.Location = new System.Drawing.Point(302, 109);
            this.txbPhongBan.Name = "txbPhongBan";
            this.txbPhongBan.Size = new System.Drawing.Size(307, 20);
            this.txbPhongBan.TabIndex = 15;
            // 
            // txbTenBoPhan
            // 
            this.txbTenBoPhan.Location = new System.Drawing.Point(302, 72);
            this.txbTenBoPhan.Name = "txbTenBoPhan";
            this.txbTenBoPhan.Size = new System.Drawing.Size(307, 20);
            this.txbTenBoPhan.TabIndex = 14;
            // 
            // txbMaBoPhan
            // 
            this.txbMaBoPhan.Location = new System.Drawing.Point(302, 28);
            this.txbMaBoPhan.Name = "txbMaBoPhan";
            this.txbMaBoPhan.Size = new System.Drawing.Size(307, 20);
            this.txbMaBoPhan.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ghi Chú :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phòng Ban :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Bộ Phận :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Bộ Phận :";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(472, 509);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 48);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtgdsBoPhan
            // 
            this.dtgdsBoPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdsBoPhan.Location = new System.Drawing.Point(136, 226);
            this.dtgdsBoPhan.Name = "dtgdsBoPhan";
            this.dtgdsBoPhan.Size = new System.Drawing.Size(473, 244);
            this.dtgdsBoPhan.TabIndex = 19;
            this.dtgdsBoPhan.SelectionChanged += new System.EventHandler(this.dtgdsBoPhan_SelectionChanged);
            // 
            // QuanLyBOPHAN_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.dtgdsBoPhan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhap);
            this.Controls.Add(this.txbGhiChu);
            this.Controls.Add(this.txbPhongBan);
            this.Controls.Add(this.txbTenBoPhan);
            this.Controls.Add(this.txbMaBoPhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyBOPHAN_GUI";
            this.Text = "QuanLyBOPHAN_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dtgdsBoPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.TextBox txbGhiChu;
        private System.Windows.Forms.TextBox txbPhongBan;
        private System.Windows.Forms.TextBox txbTenBoPhan;
        private System.Windows.Forms.TextBox txbMaBoPhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dtgdsBoPhan;
    }
}