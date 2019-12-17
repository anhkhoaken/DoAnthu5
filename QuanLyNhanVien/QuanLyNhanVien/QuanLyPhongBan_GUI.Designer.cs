namespace QuanLyNhanVien
{
    partial class QuanLyPhongBan_GUI
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
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.txtMaPB = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.Label();
            this.txtslnv = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btcapnhat = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.maPB = new JMetroTextBox.JMetroTextBox();
            this.TenPB = new JMetroTextBox.JMetroTextBox();
            this.ghichu = new JMetroTextBox.JMetroTextBox();
            this.slnv = new JMetroTextBox.JMetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jGradientPanel1 = new JGradient_Panel.JGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.jGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhongBan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhongBan.Location = new System.Drawing.Point(0, 180);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.Size = new System.Drawing.Size(963, 261);
            this.dgvPhongBan.TabIndex = 0;
            this.dgvPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPhongBan_CellContentClick);
            this.dgvPhongBan.SelectionChanged += new System.EventHandler(this.DgvPhongBan_SelectionChanged);
            // 
            // txtMaPB
            // 
            this.txtMaPB.AutoSize = true;
            this.txtMaPB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPB.Location = new System.Drawing.Point(17, 473);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(121, 19);
            this.txtMaPB.TabIndex = 3;
            this.txtMaPB.Text = "Mã Phòng Ban";
            // 
            // txtTenPB
            // 
            this.txtTenPB.AutoSize = true;
            this.txtTenPB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPB.Location = new System.Drawing.Point(18, 561);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(128, 19);
            this.txtTenPB.TabIndex = 7;
            this.txtTenPB.Text = "Tên Phòng Ban";
            // 
            // txtslnv
            // 
            this.txtslnv.AutoSize = true;
            this.txtslnv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtslnv.Location = new System.Drawing.Point(494, 473);
            this.txtslnv.Name = "txtslnv";
            this.txtslnv.Size = new System.Drawing.Size(170, 19);
            this.txtslnv.TabIndex = 8;
            this.txtslnv.Text = "Số Lượng Nhân Viên";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.AutoSize = true;
            this.txtGhiChu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(520, 561);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(71, 19);
            this.txtGhiChu.TabIndex = 9;
            this.txtGhiChu.Text = "Ghi Chú";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.btcapnhat});
            this.shapeContainer1.Size = new System.Drawing.Size(963, 754);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.White;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.Black;
            this.rectangleShape1.CornerRadius = 20;
            this.rectangleShape1.FillColor = System.Drawing.Color.White;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.White;
            this.rectangleShape1.Location = new System.Drawing.Point(547, 607);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rectangleShape1.Size = new System.Drawing.Size(161, 51);
            this.rectangleShape1.Click += new System.EventHandler(this.Btcapnhat_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.BackColor = System.Drawing.Color.White;
            this.btcapnhat.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btcapnhat.BorderColor = System.Drawing.Color.Black;
            this.btcapnhat.CornerRadius = 20;
            this.btcapnhat.FillColor = System.Drawing.Color.White;
            this.btcapnhat.FillGradientColor = System.Drawing.Color.White;
            this.btcapnhat.Location = new System.Drawing.Point(219, 609);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btcapnhat.Size = new System.Drawing.Size(161, 51);
            this.btcapnhat.Click += new System.EventHandler(this.Btcapnhat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(233, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cập Nhật";
            // 
            // maPB
            // 
            this.maPB.BackColor = System.Drawing.Color.Transparent;
            this.maPB.BorderColor = System.Drawing.Color.Black;
            this.maPB.BorderRadius = 15;
            this.maPB.FillColor = System.Drawing.SystemColors.Window;
            this.maPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.maPB.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.maPB.ForeColors = System.Drawing.Color.Black;
            this.maPB.IsPassword = false;
            this.maPB.LineThickness = 2;
            this.maPB.Location = new System.Drawing.Point(153, 461);
            this.maPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maPB.MaxLength = 32767;
            this.maPB.MouseOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.maPB.Name = "maPB";
            this.maPB.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.maPB.OnFocusColor = System.Drawing.Color.Teal;
            this.maPB.OnFocusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.maPB.ReadOnly = false;
            this.maPB.Size = new System.Drawing.Size(262, 38);
            this.maPB.TabIndex = 12;
            this.maPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.maPB.TextName = "";
            this.maPB.Load += new System.EventHandler(this.JMetroTextBox1_Load);
            // 
            // TenPB
            // 
            this.TenPB.BackColor = System.Drawing.Color.Transparent;
            this.TenPB.BorderColor = System.Drawing.Color.Black;
            this.TenPB.BorderRadius = 15;
            this.TenPB.FillColor = System.Drawing.SystemColors.Window;
            this.TenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TenPB.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TenPB.ForeColors = System.Drawing.Color.Black;
            this.TenPB.IsPassword = false;
            this.TenPB.LineThickness = 2;
            this.TenPB.Location = new System.Drawing.Point(153, 550);
            this.TenPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TenPB.MaxLength = 32767;
            this.TenPB.MouseOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TenPB.Name = "TenPB";
            this.TenPB.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.TenPB.OnFocusColor = System.Drawing.Color.Teal;
            this.TenPB.OnFocusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TenPB.ReadOnly = false;
            this.TenPB.Size = new System.Drawing.Size(262, 38);
            this.TenPB.TabIndex = 13;
            this.TenPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TenPB.TextName = "";
            this.TenPB.Load += new System.EventHandler(this.JMetroTextBox2_Load);
            // 
            // ghichu
            // 
            this.ghichu.BackColor = System.Drawing.Color.Transparent;
            this.ghichu.BorderColor = System.Drawing.Color.Black;
            this.ghichu.BorderRadius = 15;
            this.ghichu.FillColor = System.Drawing.SystemColors.Window;
            this.ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ghichu.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ghichu.ForeColors = System.Drawing.Color.Black;
            this.ghichu.IsPassword = false;
            this.ghichu.LineThickness = 2;
            this.ghichu.Location = new System.Drawing.Point(670, 550);
            this.ghichu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ghichu.MaxLength = 32767;
            this.ghichu.MouseOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ghichu.Name = "ghichu";
            this.ghichu.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.ghichu.OnFocusColor = System.Drawing.Color.Teal;
            this.ghichu.OnFocusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ghichu.ReadOnly = false;
            this.ghichu.Size = new System.Drawing.Size(262, 38);
            this.ghichu.TabIndex = 14;
            this.ghichu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ghichu.TextName = "";
            this.ghichu.Load += new System.EventHandler(this.JMetroTextBox3_Load);
            // 
            // slnv
            // 
            this.slnv.BackColor = System.Drawing.Color.Transparent;
            this.slnv.BorderColor = System.Drawing.Color.Black;
            this.slnv.BorderRadius = 15;
            this.slnv.FillColor = System.Drawing.SystemColors.Window;
            this.slnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.slnv.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.slnv.ForeColors = System.Drawing.Color.Black;
            this.slnv.IsPassword = false;
            this.slnv.LineThickness = 2;
            this.slnv.Location = new System.Drawing.Point(670, 461);
            this.slnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slnv.MaxLength = 32767;
            this.slnv.MouseOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.slnv.Name = "slnv";
            this.slnv.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.slnv.OnFocusColor = System.Drawing.Color.Teal;
            this.slnv.OnFocusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.slnv.ReadOnly = false;
            this.slnv.Size = new System.Drawing.Size(262, 38);
            this.slnv.TabIndex = 15;
            this.slnv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.slnv.TextName = "";
            this.slnv.Load += new System.EventHandler(this.JMetroTextBox4_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(600, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Xóa";
            // 
            // jGradientPanel1
            // 
            this.jGradientPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.jGradientPanel1.ColorBottom = System.Drawing.Color.Empty;
            this.jGradientPanel1.ColorTop = System.Drawing.Color.Empty;
            this.jGradientPanel1.Controls.Add(this.label3);
            this.jGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.jGradientPanel1.Name = "jGradientPanel1";
            this.jGradientPanel1.Size = new System.Drawing.Size(963, 174);
            this.jGradientPanel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(304, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quản Lý Phòng Ban";
            // 
            // QuanLyPhongBan_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 754);
            this.Controls.Add(this.jGradientPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.slnv);
            this.Controls.Add(this.ghichu);
            this.Controls.Add(this.TenPB);
            this.Controls.Add(this.maPB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtslnv);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.txtMaPB);
            this.Controls.Add(this.dgvPhongBan);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyPhongBan_GUI";
            this.Text = "QuanLyPhongBan_GUI";
            this.Load += new System.EventHandler(this.QuanLyPhongBan_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.jGradientPanel1.ResumeLayout(false);
            this.jGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.Label txtMaPB;
        private System.Windows.Forms.Label txtTenPB;
        private System.Windows.Forms.Label txtslnv;
        private System.Windows.Forms.Label txtGhiChu;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btcapnhat;
        private System.Windows.Forms.Label label1;
        private JMetroTextBox.JMetroTextBox maPB;
        private JMetroTextBox.JMetroTextBox TenPB;
        private JMetroTextBox.JMetroTextBox ghichu;
        private JMetroTextBox.JMetroTextBox slnv;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label2;
        private JGradient_Panel.JGradientPanel jGradientPanel1;
        private System.Windows.Forms.Label label3;
    }
}