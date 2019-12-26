namespace QuanLyNhanVien
{
    partial class QuanLyTDTH_GUI
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
            this.dgvTrinhDoTinHoc = new System.Windows.Forms.DataGridView();
            this.txtTenTrinhDoTinHoc = new JMetroTextBox.JMetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btxoa = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btcapnhat = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtMaTrinhDoTinHoc = new JMetroTextBox.JMetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jGradientPanel1 = new JGradient_Panel.JGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDoTinHoc)).BeginInit();
            this.jGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTrinhDoTinHoc
            // 
            this.dgvTrinhDoTinHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrinhDoTinHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrinhDoTinHoc.Location = new System.Drawing.Point(0, 114);
            this.dgvTrinhDoTinHoc.Name = "dgvTrinhDoTinHoc";
            this.dgvTrinhDoTinHoc.Size = new System.Drawing.Size(519, 251);
            this.dgvTrinhDoTinHoc.TabIndex = 0;
            this.dgvTrinhDoTinHoc.SelectionChanged += new System.EventHandler(this.DgvTrinhDoTinHoc_SelectionChanged);
            // 
            // txtTenTrinhDoTinHoc
            // 
            this.txtTenTrinhDoTinHoc.BackColor = System.Drawing.Color.Transparent;
            this.txtTenTrinhDoTinHoc.BorderColor = System.Drawing.Color.Empty;
            this.txtTenTrinhDoTinHoc.BorderRadius = 0;
            this.txtTenTrinhDoTinHoc.FillColor = System.Drawing.SystemColors.Window;
            this.txtTenTrinhDoTinHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTenTrinhDoTinHoc.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTenTrinhDoTinHoc.ForeColors = System.Drawing.Color.Gray;
            this.txtTenTrinhDoTinHoc.IsPassword = false;
            this.txtTenTrinhDoTinHoc.LineThickness = 2;
            this.txtTenTrinhDoTinHoc.Location = new System.Drawing.Point(279, 407);
            this.txtTenTrinhDoTinHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenTrinhDoTinHoc.MaxLength = 32767;
            this.txtTenTrinhDoTinHoc.MouseOnHover = System.Drawing.Color.Empty;
            this.txtTenTrinhDoTinHoc.Name = "txtTenTrinhDoTinHoc";
            this.txtTenTrinhDoTinHoc.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTrinhDoTinHoc.OnFocusColor = System.Drawing.Color.Empty;
            this.txtTenTrinhDoTinHoc.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtTenTrinhDoTinHoc.ReadOnly = false;
            this.txtTenTrinhDoTinHoc.Size = new System.Drawing.Size(218, 32);
            this.txtTenTrinhDoTinHoc.TabIndex = 1;
            this.txtTenTrinhDoTinHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenTrinhDoTinHoc.TextName = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(54, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Trình Độ Tin Học";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btxoa,
            this.btcapnhat});
            this.shapeContainer1.Size = new System.Drawing.Size(525, 531);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // btxoa
            // 
            this.btxoa.BorderWidth = 2;
            this.btxoa.CornerRadius = 20;
            this.btxoa.Location = new System.Drawing.Point(341, 463);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(94, 41);
            this.btxoa.Click += new System.EventHandler(this.Btxoa_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.BorderWidth = 2;
            this.btcapnhat.CornerRadius = 20;
            this.btcapnhat.Location = new System.Drawing.Point(75, 464);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(94, 41);
            this.btcapnhat.Click += new System.EventHandler(this.Btcapnhat_Click);
            // 
            // txtMaTrinhDoTinHoc
            // 
            this.txtMaTrinhDoTinHoc.BackColor = System.Drawing.Color.Transparent;
            this.txtMaTrinhDoTinHoc.BorderColor = System.Drawing.Color.Empty;
            this.txtMaTrinhDoTinHoc.BorderRadius = 0;
            this.txtMaTrinhDoTinHoc.FillColor = System.Drawing.SystemColors.Window;
            this.txtMaTrinhDoTinHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMaTrinhDoTinHoc.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMaTrinhDoTinHoc.ForeColors = System.Drawing.Color.Gray;
            this.txtMaTrinhDoTinHoc.IsPassword = false;
            this.txtMaTrinhDoTinHoc.LineThickness = 2;
            this.txtMaTrinhDoTinHoc.Location = new System.Drawing.Point(13, 407);
            this.txtMaTrinhDoTinHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTrinhDoTinHoc.MaxLength = 32767;
            this.txtMaTrinhDoTinHoc.MouseOnHover = System.Drawing.Color.Empty;
            this.txtMaTrinhDoTinHoc.Name = "txtMaTrinhDoTinHoc";
            this.txtMaTrinhDoTinHoc.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTrinhDoTinHoc.OnFocusColor = System.Drawing.Color.Empty;
            this.txtMaTrinhDoTinHoc.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtMaTrinhDoTinHoc.ReadOnly = false;
            this.txtMaTrinhDoTinHoc.Size = new System.Drawing.Size(218, 32);
            this.txtMaTrinhDoTinHoc.TabIndex = 4;
            this.txtMaTrinhDoTinHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaTrinhDoTinHoc.TextName = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(316, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Trình Độ Tin Học";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // jGradientPanel1
            // 
            this.jGradientPanel1.BackColor = System.Drawing.Color.Black;
            this.jGradientPanel1.ColorBottom = System.Drawing.Color.Empty;
            this.jGradientPanel1.ColorTop = System.Drawing.Color.Empty;
            this.jGradientPanel1.Controls.Add(this.label3);
            this.jGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.jGradientPanel1.Name = "jGradientPanel1";
            this.jGradientPanel1.Size = new System.Drawing.Size(800, 108);
            this.jGradientPanel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quản Lý Trình Độ Tin Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(373, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Xóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(90, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cập Nhật";
            // 
            // QuanLyTDTH_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 531);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jGradientPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaTrinhDoTinHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenTrinhDoTinHoc);
            this.Controls.Add(this.dgvTrinhDoTinHoc);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "QuanLyTDTH_GUI";
            this.Text = "QuanLyTDTH_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDoTinHoc)).EndInit();
            this.jGradientPanel1.ResumeLayout(false);
            this.jGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrinhDoTinHoc;
        private JMetroTextBox.JMetroTextBox txtTenTrinhDoTinHoc;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btxoa;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btcapnhat;
        private JMetroTextBox.JMetroTextBox txtMaTrinhDoTinHoc;
        private System.Windows.Forms.Label label2;
        private JGradient_Panel.JGradientPanel jGradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}