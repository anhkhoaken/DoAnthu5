namespace QuanLyNhanVien
{
    partial class ThemCHUCVU_GUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaChucVu = new System.Windows.Forms.TextBox();
            this.txbTenChucVu = new System.Windows.Forms.TextBox();
            this.txbGhiChu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbHeSoCV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Chức Vụ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Chức Vụ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ số Chức Vụ :";
            // 
            // txbMaChucVu
            // 
            this.txbMaChucVu.Location = new System.Drawing.Point(2, 130);
            this.txbMaChucVu.Name = "txbMaChucVu";
            this.txbMaChucVu.Size = new System.Drawing.Size(202, 20);
            this.txbMaChucVu.TabIndex = 3;
            // 
            // txbTenChucVu
            // 
            this.txbTenChucVu.Location = new System.Drawing.Point(255, 130);
            this.txbTenChucVu.Name = "txbTenChucVu";
            this.txbTenChucVu.Size = new System.Drawing.Size(198, 20);
            this.txbTenChucVu.TabIndex = 4;
            // 
            // txbGhiChu
            // 
            this.txbGhiChu.Location = new System.Drawing.Point(6, 191);
            this.txbGhiChu.Name = "txbGhiChu";
            this.txbGhiChu.Size = new System.Drawing.Size(198, 20);
            this.txbGhiChu.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(167, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbHeSoCV
            // 
            this.txbHeSoCV.Location = new System.Drawing.Point(255, 191);
            this.txbHeSoCV.Name = "txbHeSoCV";
            this.txbHeSoCV.Size = new System.Drawing.Size(198, 20);
            this.txbHeSoCV.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ghi Chú :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 100);
            this.panel1.TabIndex = 9;
            // 
            // ThemCHUCVU_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 285);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbHeSoCV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbGhiChu);
            this.Controls.Add(this.txbTenChucVu);
            this.Controls.Add(this.txbMaChucVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemCHUCVU_GUI";
            this.Text = "ThemCHUCVU_GUI";
            this.Load += new System.EventHandler(this.ThemCHUCVU_GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaChucVu;
        private System.Windows.Forms.TextBox txbTenChucVu;
        private System.Windows.Forms.TextBox txbGhiChu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbHeSoCV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}