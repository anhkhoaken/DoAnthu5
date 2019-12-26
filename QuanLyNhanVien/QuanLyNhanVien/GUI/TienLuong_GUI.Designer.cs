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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvtienluong = new System.Windows.Forms.DataGridView();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btxem = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btxuatbc = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label6 = new System.Windows.Forms.Label();
            this.lbXem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtienluong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvtienluong
            // 
            this.dgvtienluong.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtienluong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtienluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtienluong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtienluong.Location = new System.Drawing.Point(0, 242);
            this.dgvtienluong.Name = "dgvtienluong";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtienluong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtienluong.Size = new System.Drawing.Size(1009, 272);
            this.dgvtienluong.TabIndex = 0;
            this.dgvtienluong.SelectionChanged += new System.EventHandler(this.Dgvtienluong_SelectionChanged);
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Location = new System.Drawing.Point(384, 214);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(200, 20);
            this.dtpThoiGian.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(292, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
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
            this.shapeContainer1.Size = new System.Drawing.Size(1012, 590);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // btxem
            // 
            this.btxem.BorderWidth = 2;
            this.btxem.CornerRadius = 10;
            this.btxem.Location = new System.Drawing.Point(602, 210);
            this.btxem.Name = "btxem";
            this.btxem.Size = new System.Drawing.Size(75, 23);
            this.btxem.Click += new System.EventHandler(this.Btxem_Click);
            // 
            // btxuatbc
            // 
            this.btxuatbc.BorderWidth = 2;
            this.btxuatbc.CornerRadius = 17;
            this.btxuatbc.Location = new System.Drawing.Point(430, 534);
            this.btxuatbc.Name = "btxuatbc";
            this.btxuatbc.Size = new System.Drawing.Size(141, 42);
            this.btxuatbc.Click += new System.EventHandler(this.Btxuatbc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(454, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Xuất Báo Cáo";
            // 
            // lbXem
            // 
            this.lbXem.AutoSize = true;
            this.lbXem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbXem.Location = new System.Drawing.Point(624, 213);
            this.lbXem.Name = "lbXem";
            this.lbXem.Size = new System.Drawing.Size(37, 16);
            this.lbXem.TabIndex = 13;
            this.lbXem.Text = "Xem";
            this.lbXem.Click += new System.EventHandler(this.LbXem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 189);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(329, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiền Lương Nhân Viên";
            // 
            // TienLuong_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbXem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.dgvtienluong);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "TienLuong_GUI";
            this.Text = "TienLuong_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtienluong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label lbXem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}