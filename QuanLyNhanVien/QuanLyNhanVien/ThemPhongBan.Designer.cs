namespace QuanLyNhanVien
{
    partial class ThemPhongBan
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
            this.label4 = new System.Windows.Forms.Label();
            this.MaPB = new JMetroTextBox.JMetroTextBox();
            this.SLNV = new JMetroTextBox.JMetroTextBox();
            this.TenPB = new JMetroTextBox.JMetroTextBox();
            this.GC = new JMetroTextBox.JMetroTextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btadd = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label5 = new System.Windows.Forms.Label();
            this.jGradientPanel1 = new JGradient_Panel.JGradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.jGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(106, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Phòng Ban";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(106, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Phòng Ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(814, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số Lượng Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(882, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ghi Chú";
            // 
            // MaPB
            // 
            this.MaPB.BackColor = System.Drawing.Color.Transparent;
            this.MaPB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MaPB.BorderRadius = 20;
            this.MaPB.FillColor = System.Drawing.SystemColors.Window;
            this.MaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MaPB.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MaPB.ForeColors = System.Drawing.Color.Black;
            this.MaPB.IsPassword = false;
            this.MaPB.LineThickness = 2;
            this.MaPB.Location = new System.Drawing.Point(9, 189);
            this.MaPB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaPB.MaxLength = 32767;
            this.MaPB.MouseOnHover = System.Drawing.Color.Empty;
            this.MaPB.Name = "MaPB";
            this.MaPB.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.MaPB.OnFocusColor = System.Drawing.Color.Empty;
            this.MaPB.OnFocusFontColor = System.Drawing.Color.Empty;
            this.MaPB.ReadOnly = false;
            this.MaPB.Size = new System.Drawing.Size(375, 57);
            this.MaPB.TabIndex = 9;
            this.MaPB.Tag = "";
            this.MaPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaPB.TextName = "PKD";
            // 
            // SLNV
            // 
            this.SLNV.BackColor = System.Drawing.Color.Transparent;
            this.SLNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SLNV.BorderRadius = 20;
            this.SLNV.FillColor = System.Drawing.SystemColors.Window;
            this.SLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SLNV.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SLNV.ForeColors = System.Drawing.Color.Black;
            this.SLNV.IsPassword = false;
            this.SLNV.LineThickness = 2;
            this.SLNV.Location = new System.Drawing.Point(732, 189);
            this.SLNV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SLNV.MaxLength = 32767;
            this.SLNV.MouseOnHover = System.Drawing.Color.Empty;
            this.SLNV.Name = "SLNV";
            this.SLNV.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.SLNV.OnFocusColor = System.Drawing.Color.Empty;
            this.SLNV.OnFocusFontColor = System.Drawing.Color.Empty;
            this.SLNV.ReadOnly = false;
            this.SLNV.Size = new System.Drawing.Size(375, 57);
            this.SLNV.TabIndex = 10;
            this.SLNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SLNV.TextName = "50";
            // 
            // TenPB
            // 
            this.TenPB.BackColor = System.Drawing.Color.Transparent;
            this.TenPB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TenPB.BorderRadius = 20;
            this.TenPB.FillColor = System.Drawing.SystemColors.Window;
            this.TenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TenPB.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TenPB.ForeColors = System.Drawing.Color.Black;
            this.TenPB.IsPassword = false;
            this.TenPB.LineThickness = 2;
            this.TenPB.Location = new System.Drawing.Point(9, 314);
            this.TenPB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TenPB.MaxLength = 32767;
            this.TenPB.MouseOnHover = System.Drawing.Color.Empty;
            this.TenPB.Name = "TenPB";
            this.TenPB.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.TenPB.OnFocusColor = System.Drawing.Color.Empty;
            this.TenPB.OnFocusFontColor = System.Drawing.Color.Empty;
            this.TenPB.ReadOnly = false;
            this.TenPB.Size = new System.Drawing.Size(375, 57);
            this.TenPB.TabIndex = 11;
            this.TenPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TenPB.TextName = "Phòng Kinh Doanh";
            // 
            // GC
            // 
            this.GC.BackColor = System.Drawing.Color.Transparent;
            this.GC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GC.BorderRadius = 20;
            this.GC.FillColor = System.Drawing.SystemColors.Window;
            this.GC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.GC.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.GC.ForeColors = System.Drawing.Color.Black;
            this.GC.IsPassword = false;
            this.GC.LineThickness = 2;
            this.GC.Location = new System.Drawing.Point(732, 314);
            this.GC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GC.MaxLength = 32767;
            this.GC.MouseOnHover = System.Drawing.Color.Empty;
            this.GC.Name = "GC";
            this.GC.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.GC.OnFocusColor = System.Drawing.Color.Empty;
            this.GC.OnFocusFontColor = System.Drawing.Color.Empty;
            this.GC.ReadOnly = false;
            this.GC.Size = new System.Drawing.Size(375, 57);
            this.GC.TabIndex = 12;
            this.GC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GC.TextName = "Ghi Chú";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btadd});
            this.shapeContainer1.Size = new System.Drawing.Size(1128, 484);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // btadd
            // 
            this.btadd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btadd.BorderWidth = 3;
            this.btadd.CornerRadius = 19;
            this.btadd.Location = new System.Drawing.Point(489, 387);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(147, 51);
            this.btadd.Click += new System.EventHandler(this.Btadd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(534, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Thêm";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // jGradientPanel1
            // 
            this.jGradientPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.jGradientPanel1.ColorBottom = System.Drawing.Color.Empty;
            this.jGradientPanel1.ColorTop = System.Drawing.Color.Empty;
            this.jGradientPanel1.Controls.Add(this.label6);
            this.jGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.jGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.jGradientPanel1.Name = "jGradientPanel1";
            this.jGradientPanel1.Size = new System.Drawing.Size(1291, 116);
            this.jGradientPanel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(424, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thêm Phòng Ban";
            // 
            // ThemPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 484);
            this.Controls.Add(this.jGradientPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GC);
            this.Controls.Add(this.TenPB);
            this.Controls.Add(this.SLNV);
            this.Controls.Add(this.MaPB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThemPhongBan";
            this.Text = "Form3";
            this.jGradientPanel1.ResumeLayout(false);
            this.jGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private JMetroTextBox.JMetroTextBox MaPB;
        private JMetroTextBox.JMetroTextBox SLNV;
        private JMetroTextBox.JMetroTextBox TenPB;
        private JMetroTextBox.JMetroTextBox GC;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btadd;
        private System.Windows.Forms.Label label5;
        private JGradient_Panel.JGradientPanel jGradientPanel1;
        private System.Windows.Forms.Label label6;
    }
}