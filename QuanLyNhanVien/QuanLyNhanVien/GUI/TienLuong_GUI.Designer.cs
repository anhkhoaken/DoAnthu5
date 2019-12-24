namespace QuanLyNhanVien.GUI
{
    partial class TienLuong_GUI
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
            this.dgvtienluong = new System.Windows.Forms.DataGridView();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btxem = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btxuatbc = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtienluong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtienluong
            // 
            this.dgvtienluong.BackgroundColor = System.Drawing.Color.White;
            this.dgvtienluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtienluong.Location = new System.Drawing.Point(1, 56);
            this.dgvtienluong.Name = "dgvtienluong";
            this.dgvtienluong.Size = new System.Drawing.Size(1009, 272);
            this.dgvtienluong.TabIndex = 0;
            this.dgvtienluong.SelectionChanged += new System.EventHandler(this.Dgvtienluong_SelectionChanged);
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Location = new System.Drawing.Point(444, 23);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(200, 20);
            this.dtpThoiGian.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thời Gian";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btxem,
            this.btxuatbc});
            this.shapeContainer1.Size = new System.Drawing.Size(1012, 422);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // btxem
            // 
            this.btxem.CornerRadius = 10;
            this.btxem.Location = new System.Drawing.Point(694, 18);
            this.btxem.Name = "btxem";
            this.btxem.Size = new System.Drawing.Size(75, 23);
            this.btxem.Click += new System.EventHandler(this.Btxem_Click);
            // 
            // btxuatbc
            // 
            this.btxuatbc.CornerRadius = 10;
            this.btxuatbc.Location = new System.Drawing.Point(485, 356);
            this.btxuatbc.Name = "btxuatbc";
            this.btxuatbc.Size = new System.Drawing.Size(107, 42);
            this.btxuatbc.Click += new System.EventHandler(this.Btxuatbc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Xuất Báo Cáo";
            // 
            // TienLuong_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 422);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.dgvtienluong);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "TienLuong_GUI";
            this.Text = "TienLuong_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtienluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtienluong;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.Label label5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btxuatbc;
        private System.Windows.Forms.Label label6;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btxem;
    }
}