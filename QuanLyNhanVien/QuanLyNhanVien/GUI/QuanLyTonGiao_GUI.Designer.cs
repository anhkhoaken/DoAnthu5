namespace QuanLyNhanVien
{
    partial class QuanLyTonGiao_GUI
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
            this.dgvTonGiao = new System.Windows.Forms.DataGridView();
            this.txtMaTonGiao = new JMetroTextBox.JMetroTextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btxoa = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btthem = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGhiChu = new JMetroTextBox.JMetroTextBox();
            this.txtTenTonGiao = new JMetroTextBox.JMetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonGiao)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTonGiao
            // 
            this.dgvTonGiao.BackgroundColor = System.Drawing.Color.White;
            this.dgvTonGiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonGiao.Location = new System.Drawing.Point(1, 141);
            this.dgvTonGiao.Name = "dgvTonGiao";
            this.dgvTonGiao.Size = new System.Drawing.Size(673, 191);
            this.dgvTonGiao.TabIndex = 0;
            this.dgvTonGiao.SelectionChanged += new System.EventHandler(this.DgvTonGiao_SelectionChanged);
            // 
            // txtMaTonGiao
            // 
            this.txtMaTonGiao.BackColor = System.Drawing.Color.Transparent;
            this.txtMaTonGiao.BorderColor = System.Drawing.Color.Empty;
            this.txtMaTonGiao.BorderRadius = 1;
            this.txtMaTonGiao.FillColor = System.Drawing.SystemColors.Window;
            this.txtMaTonGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMaTonGiao.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMaTonGiao.ForeColors = System.Drawing.Color.Gray;
            this.txtMaTonGiao.IsPassword = false;
            this.txtMaTonGiao.LineThickness = 2;
            this.txtMaTonGiao.Location = new System.Drawing.Point(13, 390);
            this.txtMaTonGiao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTonGiao.MaxLength = 32767;
            this.txtMaTonGiao.MouseOnHover = System.Drawing.Color.Empty;
            this.txtMaTonGiao.Name = "txtMaTonGiao";
            this.txtMaTonGiao.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTonGiao.OnFocusColor = System.Drawing.Color.Empty;
            this.txtMaTonGiao.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtMaTonGiao.ReadOnly = false;
            this.txtMaTonGiao.Size = new System.Drawing.Size(202, 32);
            this.txtMaTonGiao.TabIndex = 1;
            this.txtMaTonGiao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaTonGiao.TextName = "";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btxoa,
            this.btthem});
            this.shapeContainer1.Size = new System.Drawing.Size(675, 495);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // btxoa
            // 
            this.btxoa.BorderWidth = 2;
            this.btxoa.CornerRadius = 17;
            this.btxoa.Location = new System.Drawing.Point(375, 437);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(106, 45);
            this.btxoa.Click += new System.EventHandler(this.Btxoa_Click);
            // 
            // btthem
            // 
            this.btthem.BorderWidth = 2;
            this.btthem.CornerRadius = 17;
            this.btthem.Location = new System.Drawing.Point(169, 437);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(104, 44);
            this.btthem.Click += new System.EventHandler(this.Btthem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(73, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Tôn Giáo";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.Transparent;
            this.txtGhiChu.BorderColor = System.Drawing.Color.Empty;
            this.txtGhiChu.BorderRadius = 1;
            this.txtGhiChu.FillColor = System.Drawing.SystemColors.Window;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtGhiChu.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtGhiChu.ForeColors = System.Drawing.Color.Gray;
            this.txtGhiChu.IsPassword = false;
            this.txtGhiChu.LineThickness = 2;
            this.txtGhiChu.Location = new System.Drawing.Point(459, 390);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGhiChu.MaxLength = 32767;
            this.txtGhiChu.MouseOnHover = System.Drawing.Color.Empty;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.OnFocusColor = System.Drawing.Color.Empty;
            this.txtGhiChu.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtGhiChu.ReadOnly = false;
            this.txtGhiChu.Size = new System.Drawing.Size(202, 32);
            this.txtGhiChu.TabIndex = 4;
            this.txtGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGhiChu.TextName = "";
            // 
            // txtTenTonGiao
            // 
            this.txtTenTonGiao.BackColor = System.Drawing.Color.Transparent;
            this.txtTenTonGiao.BorderColor = System.Drawing.Color.Empty;
            this.txtTenTonGiao.BorderRadius = 1;
            this.txtTenTonGiao.FillColor = System.Drawing.SystemColors.Window;
            this.txtTenTonGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTenTonGiao.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTenTonGiao.ForeColors = System.Drawing.Color.Gray;
            this.txtTenTonGiao.IsPassword = false;
            this.txtTenTonGiao.LineThickness = 2;
            this.txtTenTonGiao.Location = new System.Drawing.Point(236, 390);
            this.txtTenTonGiao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenTonGiao.MaxLength = 32767;
            this.txtTenTonGiao.MouseOnHover = System.Drawing.Color.Empty;
            this.txtTenTonGiao.Name = "txtTenTonGiao";
            this.txtTenTonGiao.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTonGiao.OnFocusColor = System.Drawing.Color.Empty;
            this.txtTenTonGiao.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtTenTonGiao.ReadOnly = false;
            this.txtTenTonGiao.Size = new System.Drawing.Size(202, 32);
            this.txtTenTonGiao.TabIndex = 5;
            this.txtTenTonGiao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenTonGiao.TextName = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(298, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Tôn Giáo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(549, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ghi Chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(188, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quản Lý Tôn Giáo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(414, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Xóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(192, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cập Nhật";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 131);
            this.panel1.TabIndex = 11;
            // 
            // QuanLyTonGiao_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenTonGiao);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaTonGiao);
            this.Controls.Add(this.dgvTonGiao);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "QuanLyTonGiao_GUI";
            this.Text = "QuanLyTonGiao_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonGiao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTonGiao;
        private JMetroTextBox.JMetroTextBox txtMaTonGiao;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btthem;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btxoa;
        private JMetroTextBox.JMetroTextBox txtGhiChu;
        private JMetroTextBox.JMetroTextBox txtTenTonGiao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}