namespace QuanLyNhanVien
{
    partial class QuanLyNhanVien_GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cbBac = new System.Windows.Forms.ComboBox();
            this.cbBoPhan = new System.Windows.Forms.ComboBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.cbHeSoLuong = new System.Windows.Forms.ComboBox();
            this.cbDanToc = new System.Windows.Forms.ComboBox();
            this.cbHonNhan = new System.Windows.Forms.ComboBox();
            this.cbNgach = new System.Windows.Forms.ComboBox();
            this.cbPhongBan = new System.Windows.Forms.ComboBox();
            this.cbQuocTich = new System.Windows.Forms.ComboBox();
            this.cbTonGiao = new System.Windows.Forms.ComboBox();
            this.cbTrinhDoHocVan = new System.Windows.Forms.ComboBox();
            this.cbTrinhDoNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.cbTrinhDoTinHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btxuatbc = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.cttimkiem = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btxoa = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btcapnhat = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.cbchin = new System.Windows.Forms.ComboBox();
            this.txttimkiem = new JTextBox.JTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 127);
            this.dgvNhanVien.Name = "dgvNhanVien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.Size = new System.Drawing.Size(965, 356);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.SelectionChanged += new System.EventHandler(this.DgvNhanVien_SelectionChanged);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(164, 504);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(185, 20);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(164, 546);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(185, 20);
            this.txtTenNhanVien.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(654, 768);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(185, 20);
            this.txtGhiChu.TabIndex = 3;
            // 
            // cbBac
            // 
            this.cbBac.FormattingEnabled = true;
            this.cbBac.Location = new System.Drawing.Point(164, 582);
            this.cbBac.Name = "cbBac";
            this.cbBac.Size = new System.Drawing.Size(185, 21);
            this.cbBac.TabIndex = 4;
            // 
            // cbBoPhan
            // 
            this.cbBoPhan.FormattingEnabled = true;
            this.cbBoPhan.Location = new System.Drawing.Point(164, 622);
            this.cbBoPhan.Name = "cbBoPhan";
            this.cbBoPhan.Size = new System.Drawing.Size(185, 21);
            this.cbBoPhan.TabIndex = 5;
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(166, 659);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(185, 21);
            this.cbChucVu.TabIndex = 6;
            // 
            // cbHeSoLuong
            // 
            this.cbHeSoLuong.FormattingEnabled = true;
            this.cbHeSoLuong.Location = new System.Drawing.Point(164, 692);
            this.cbHeSoLuong.Name = "cbHeSoLuong";
            this.cbHeSoLuong.Size = new System.Drawing.Size(185, 21);
            this.cbHeSoLuong.TabIndex = 7;
            // 
            // cbDanToc
            // 
            this.cbDanToc.FormattingEnabled = true;
            this.cbDanToc.Location = new System.Drawing.Point(166, 729);
            this.cbDanToc.Name = "cbDanToc";
            this.cbDanToc.Size = new System.Drawing.Size(185, 21);
            this.cbDanToc.TabIndex = 8;
            // 
            // cbHonNhan
            // 
            this.cbHonNhan.FormattingEnabled = true;
            this.cbHonNhan.Location = new System.Drawing.Point(166, 766);
            this.cbHonNhan.Name = "cbHonNhan";
            this.cbHonNhan.Size = new System.Drawing.Size(185, 21);
            this.cbHonNhan.TabIndex = 9;
            // 
            // cbNgach
            // 
            this.cbNgach.FormattingEnabled = true;
            this.cbNgach.Location = new System.Drawing.Point(654, 499);
            this.cbNgach.Name = "cbNgach";
            this.cbNgach.Size = new System.Drawing.Size(185, 21);
            this.cbNgach.TabIndex = 10;
            // 
            // cbPhongBan
            // 
            this.cbPhongBan.FormattingEnabled = true;
            this.cbPhongBan.Location = new System.Drawing.Point(654, 541);
            this.cbPhongBan.Name = "cbPhongBan";
            this.cbPhongBan.Size = new System.Drawing.Size(185, 21);
            this.cbPhongBan.TabIndex = 11;
            // 
            // cbQuocTich
            // 
            this.cbQuocTich.FormattingEnabled = true;
            this.cbQuocTich.Location = new System.Drawing.Point(654, 577);
            this.cbQuocTich.Name = "cbQuocTich";
            this.cbQuocTich.Size = new System.Drawing.Size(185, 21);
            this.cbQuocTich.TabIndex = 12;
            // 
            // cbTonGiao
            // 
            this.cbTonGiao.FormattingEnabled = true;
            this.cbTonGiao.Location = new System.Drawing.Point(654, 617);
            this.cbTonGiao.Name = "cbTonGiao";
            this.cbTonGiao.Size = new System.Drawing.Size(185, 21);
            this.cbTonGiao.TabIndex = 13;
            // 
            // cbTrinhDoHocVan
            // 
            this.cbTrinhDoHocVan.FormattingEnabled = true;
            this.cbTrinhDoHocVan.Location = new System.Drawing.Point(654, 651);
            this.cbTrinhDoHocVan.Name = "cbTrinhDoHocVan";
            this.cbTrinhDoHocVan.Size = new System.Drawing.Size(185, 21);
            this.cbTrinhDoHocVan.TabIndex = 14;
            // 
            // cbTrinhDoNgoaiNgu
            // 
            this.cbTrinhDoNgoaiNgu.FormattingEnabled = true;
            this.cbTrinhDoNgoaiNgu.Location = new System.Drawing.Point(654, 692);
            this.cbTrinhDoNgoaiNgu.Name = "cbTrinhDoNgoaiNgu";
            this.cbTrinhDoNgoaiNgu.Size = new System.Drawing.Size(185, 21);
            this.cbTrinhDoNgoaiNgu.TabIndex = 15;
            // 
            // cbTrinhDoTinHoc
            // 
            this.cbTrinhDoTinHoc.FormattingEnabled = true;
            this.cbTrinhDoTinHoc.Location = new System.Drawing.Point(654, 729);
            this.cbTrinhDoTinHoc.Name = "cbTrinhDoTinHoc";
            this.cbTrinhDoTinHoc.Size = new System.Drawing.Size(185, 21);
            this.cbTrinhDoTinHoc.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bậc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Bộ Phận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 667);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Chức Vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 700);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Hệ Số Lương Nhân Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 737);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Dân Tộc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 771);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Hôn Nhân";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ngạch";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(541, 549);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Phòng Ban";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(539, 585);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Quốc Tịch";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(539, 625);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Tôn Giáo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(539, 659);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Trình Độ Học Vấn";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(539, 700);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Trình Độ Ngoại Ngữ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(539, 737);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Trình Độ Tin Học";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(539, 769);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Ghi Chú";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btxuatbc,
            this.cttimkiem,
            this.btxoa,
            this.btcapnhat});
            this.shapeContainer1.Size = new System.Drawing.Size(968, 861);
            this.shapeContainer1.TabIndex = 33;
            this.shapeContainer1.TabStop = false;
            // 
            // btxuatbc
            // 
            this.btxuatbc.CornerRadius = 10;
            this.btxuatbc.Location = new System.Drawing.Point(579, 819);
            this.btxuatbc.Name = "btxuatbc";
            this.btxuatbc.Size = new System.Drawing.Size(85, 37);
            this.btxuatbc.Click += new System.EventHandler(this.Btuatbc_Click);
            // 
            // cttimkiem
            // 
            this.cttimkiem.CornerRadius = 10;
            this.cttimkiem.Location = new System.Drawing.Point(684, 62);
            this.cttimkiem.Name = "cttimkiem";
            this.cttimkiem.Size = new System.Drawing.Size(75, 33);
            this.cttimkiem.Click += new System.EventHandler(this.Cttimkiem_Click);
            // 
            // btxoa
            // 
            this.btxoa.CornerRadius = 10;
            this.btxoa.Location = new System.Drawing.Point(463, 818);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(85, 37);
            this.btxoa.Click += new System.EventHandler(this.Btxoa_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.CornerRadius = 10;
            this.btcapnhat.Location = new System.Drawing.Point(347, 818);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(85, 37);
            this.btcapnhat.Click += new System.EventHandler(this.Btcapnhat_Click);
            // 
            // cbchin
            // 
            this.cbchin.FormattingEnabled = true;
            this.cbchin.Location = new System.Drawing.Point(164, 75);
            this.cbchin.Name = "cbchin";
            this.cbchin.Size = new System.Drawing.Size(187, 21);
            this.cbchin.TabIndex = 34;
            // 
            // txttimkiem
            // 
            this.txttimkiem.AutoSize = true;
            this.txttimkiem.BorderColor = System.Drawing.Color.Black;
            this.txttimkiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txttimkiem.Hint = "";
            this.txttimkiem.IsPassword = false;
            this.txttimkiem.Length = 0;
            this.txttimkiem.Location = new System.Drawing.Point(380, 59);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.OnFocus = System.Drawing.Color.DarkGray;
            this.txttimkiem.OnlyChar = false;
            this.txttimkiem.OnlyNumber = false;
            this.txttimkiem.Size = new System.Drawing.Size(252, 37);
            this.txttimkiem.TabIndex = 35;
            this.txttimkiem.TextValue = "";
            // 
            // QuanLyNhanVien_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 861);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.cbchin);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTrinhDoTinHoc);
            this.Controls.Add(this.cbTrinhDoNgoaiNgu);
            this.Controls.Add(this.cbTrinhDoHocVan);
            this.Controls.Add(this.cbTonGiao);
            this.Controls.Add(this.cbQuocTich);
            this.Controls.Add(this.cbPhongBan);
            this.Controls.Add(this.cbNgach);
            this.Controls.Add(this.cbHonNhan);
            this.Controls.Add(this.cbDanToc);
            this.Controls.Add(this.cbHeSoLuong);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.cbBoPhan);
            this.Controls.Add(this.cbBac);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "QuanLyNhanVien_GUI";
            this.Text = "QuanLyNhanVien_GUI";
            //this.Load += new System.EventHandler(this.QuanLyNhanVien_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cbBac;
        private System.Windows.Forms.ComboBox cbBoPhan;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.ComboBox cbHeSoLuong;
        private System.Windows.Forms.ComboBox cbDanToc;
        private System.Windows.Forms.ComboBox cbHonNhan;
        private System.Windows.Forms.ComboBox cbNgach;
        private System.Windows.Forms.ComboBox cbPhongBan;
        private System.Windows.Forms.ComboBox cbQuocTich;
        private System.Windows.Forms.ComboBox cbTonGiao;
        private System.Windows.Forms.ComboBox cbTrinhDoHocVan;
        private System.Windows.Forms.ComboBox cbTrinhDoNgoaiNgu;
        private System.Windows.Forms.ComboBox cbTrinhDoTinHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btxoa;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btcapnhat;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape cttimkiem;
        private System.Windows.Forms.ComboBox cbchin;
        private JTextBox.JTextBox txttimkiem;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btxuatbc;
    }
}