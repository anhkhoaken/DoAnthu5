namespace QuanLyNhanVien
{
    partial class QuanLyTDHV_GUI
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
            this.txtMaTrinhDoHocVan = new JMetroTextBox.JMetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btxoa = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btcapnhat = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.dgvTrinhDoHocVan = new System.Windows.Forms.DataGridView();
            this.txtGhiChu = new JMetroTextBox.JMetroTextBox();
            this.txtTenTrinhDoHocVan = new JMetroTextBox.JMetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDoHocVan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaTrinhDoHocVan
            // 
            this.txtMaTrinhDoHocVan.BackColor = System.Drawing.Color.Transparent;
            this.txtMaTrinhDoHocVan.BorderColor = System.Drawing.Color.Empty;
            this.txtMaTrinhDoHocVan.BorderRadius = 1;
            this.txtMaTrinhDoHocVan.FillColor = System.Drawing.SystemColors.Window;
            this.txtMaTrinhDoHocVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMaTrinhDoHocVan.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMaTrinhDoHocVan.ForeColors = System.Drawing.Color.Gray;
            this.txtMaTrinhDoHocVan.IsPassword = false;
            this.txtMaTrinhDoHocVan.LineThickness = 2;
            this.txtMaTrinhDoHocVan.Location = new System.Drawing.Point(34, 380);
            this.txtMaTrinhDoHocVan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTrinhDoHocVan.MaxLength = 32767;
            this.txtMaTrinhDoHocVan.MouseOnHover = System.Drawing.Color.Empty;
            this.txtMaTrinhDoHocVan.Name = "txtMaTrinhDoHocVan";
            this.txtMaTrinhDoHocVan.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTrinhDoHocVan.OnFocusColor = System.Drawing.Color.Empty;
            this.txtMaTrinhDoHocVan.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtMaTrinhDoHocVan.ReadOnly = false;
            this.txtMaTrinhDoHocVan.Size = new System.Drawing.Size(195, 28);
            this.txtMaTrinhDoHocVan.TabIndex = 0;
            this.txtMaTrinhDoHocVan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaTrinhDoHocVan.TextName = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(60, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Trình Độ Học Vấn";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btxoa,
            this.btcapnhat});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 508);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // btxoa
            // 
            this.btxoa.BorderWidth = 2;
            this.btxoa.CornerRadius = 17;
            this.btxoa.Location = new System.Drawing.Point(470, 446);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(124, 41);
            this.btxoa.Click += new System.EventHandler(this.Btxoa_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.BorderWidth = 2;
            this.btcapnhat.CornerRadius = 17;
            this.btcapnhat.Location = new System.Drawing.Point(182, 448);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(124, 38);
            this.btcapnhat.Click += new System.EventHandler(this.Btcapnhat_Click);
            // 
            // dgvTrinhDoHocVan
            // 
            this.dgvTrinhDoHocVan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrinhDoHocVan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrinhDoHocVan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrinhDoHocVan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrinhDoHocVan.Location = new System.Drawing.Point(0, 130);
            this.dgvTrinhDoHocVan.Name = "dgvTrinhDoHocVan";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrinhDoHocVan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrinhDoHocVan.Size = new System.Drawing.Size(797, 227);
            this.dgvTrinhDoHocVan.TabIndex = 3;
            this.dgvTrinhDoHocVan.SelectionChanged += new System.EventHandler(this.DgvTrinhDoHocVan_SelectionChanged);
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
            this.txtGhiChu.Location = new System.Drawing.Point(527, 380);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGhiChu.MaxLength = 32767;
            this.txtGhiChu.MouseOnHover = System.Drawing.Color.Empty;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.OnFocusColor = System.Drawing.Color.Empty;
            this.txtGhiChu.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtGhiChu.ReadOnly = false;
            this.txtGhiChu.Size = new System.Drawing.Size(195, 28);
            this.txtGhiChu.TabIndex = 4;
            this.txtGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGhiChu.TextName = "";
            // 
            // txtTenTrinhDoHocVan
            // 
            this.txtTenTrinhDoHocVan.BackColor = System.Drawing.Color.Transparent;
            this.txtTenTrinhDoHocVan.BorderColor = System.Drawing.Color.Empty;
            this.txtTenTrinhDoHocVan.BorderRadius = 1;
            this.txtTenTrinhDoHocVan.FillColor = System.Drawing.SystemColors.Window;
            this.txtTenTrinhDoHocVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTenTrinhDoHocVan.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTenTrinhDoHocVan.ForeColors = System.Drawing.Color.Gray;
            this.txtTenTrinhDoHocVan.IsPassword = false;
            this.txtTenTrinhDoHocVan.LineThickness = 2;
            this.txtTenTrinhDoHocVan.Location = new System.Drawing.Point(277, 380);
            this.txtTenTrinhDoHocVan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenTrinhDoHocVan.MaxLength = 32767;
            this.txtTenTrinhDoHocVan.MouseOnHover = System.Drawing.Color.Empty;
            this.txtTenTrinhDoHocVan.Name = "txtTenTrinhDoHocVan";
            this.txtTenTrinhDoHocVan.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTrinhDoHocVan.OnFocusColor = System.Drawing.Color.Empty;
            this.txtTenTrinhDoHocVan.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtTenTrinhDoHocVan.ReadOnly = false;
            this.txtTenTrinhDoHocVan.Size = new System.Drawing.Size(195, 28);
            this.txtTenTrinhDoHocVan.TabIndex = 5;
            this.txtTenTrinhDoHocVan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenTrinhDoHocVan.TextName = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(299, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Trình Độ Học Vấn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(596, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ghi Chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(211, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cập Nhật";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(514, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Xóa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 124);
            this.panel1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(194, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(435, 40);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quản Lý Trình Độ Học Vấn";
            // 
            // QuanLyTDHV_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenTrinhDoHocVan);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.dgvTrinhDoHocVan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaTrinhDoHocVan);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "QuanLyTDHV_GUI";
            this.Text = "QuanLyTDHV_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDoHocVan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JMetroTextBox.JMetroTextBox txtMaTrinhDoHocVan;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btxoa;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btcapnhat;
        private System.Windows.Forms.DataGridView dgvTrinhDoHocVan;
        private JMetroTextBox.JMetroTextBox txtGhiChu;
        private JMetroTextBox.JMetroTextBox txtTenTrinhDoHocVan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}