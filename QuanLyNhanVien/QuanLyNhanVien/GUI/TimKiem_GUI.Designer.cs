namespace QuanLyNhanVien.GUI
{
    partial class TimKiem_GUI
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
            this.txttimkiem = new JMetroTextBox.JMetroTextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bttimkiem = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.cbchon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // txttimkiem
            // 
            this.txttimkiem.BackColor = System.Drawing.Color.Transparent;
            this.txttimkiem.BorderColor = System.Drawing.Color.Empty;
            this.txttimkiem.BorderRadius = 1;
            this.txttimkiem.FillColor = System.Drawing.SystemColors.Window;
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txttimkiem.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txttimkiem.ForeColors = System.Drawing.Color.Gray;
            this.txttimkiem.IsPassword = false;
            this.txttimkiem.LineThickness = 2;
            this.txttimkiem.Location = new System.Drawing.Point(297, 11);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttimkiem.MaxLength = 32767;
            this.txttimkiem.MouseOnHover = System.Drawing.Color.Empty;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txttimkiem.OnFocusColor = System.Drawing.Color.Empty;
            this.txttimkiem.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txttimkiem.ReadOnly = false;
            this.txttimkiem.Size = new System.Drawing.Size(273, 43);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txttimkiem.TextName = "";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.bttimkiem});
            this.shapeContainer1.Size = new System.Drawing.Size(895, 508);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // bttimkiem
            // 
            this.bttimkiem.BorderWidth = 3;
            this.bttimkiem.CornerRadius = 20;
            this.bttimkiem.Location = new System.Drawing.Point(642, 11);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(102, 40);
            this.bttimkiem.Click += new System.EventHandler(this.Bttimkiem_Click);
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvnhanvien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvnhanvien.Location = new System.Drawing.Point(0, 61);
            this.dgvnhanvien.Name = "dgvnhanvien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnhanvien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvnhanvien.Size = new System.Drawing.Size(895, 238);
            this.dgvnhanvien.TabIndex = 3;
            // 
            // cbchon
            // 
            this.cbchon.FormattingEnabled = true;
            this.cbchon.Location = new System.Drawing.Point(12, 23);
            this.cbchon.Name = "cbchon";
            this.cbchon.Size = new System.Drawing.Size(252, 21);
            this.cbchon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(660, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm Kiếm";
            // 
            // TimKiem_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbchon);
            this.Controls.Add(this.dgvnhanvien);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "TimKiem_GUI";
            this.Text = "TimKiem_GUI";
            this.Load += new System.EventHandler(this.TimKiem_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JMetroTextBox.JMetroTextBox txttimkiem;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape bttimkiem;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.ComboBox cbchon;
        private System.Windows.Forms.Label label1;
    }
}