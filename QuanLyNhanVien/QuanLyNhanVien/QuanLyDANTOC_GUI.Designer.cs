namespace QuanLyNhanVien
{
    partial class QuanLyDANTOC_GUI
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbGhiChu = new System.Windows.Forms.TextBox();
            this.TxbTenDanToc = new System.Windows.Forms.TextBox();
            this.txbMaDanToc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgdanhsach = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(203, 406);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 43);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Cập Nhập";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbGhiChu
            // 
            this.txbGhiChu.Location = new System.Drawing.Point(309, 110);
            this.txbGhiChu.Name = "txbGhiChu";
            this.txbGhiChu.Size = new System.Drawing.Size(284, 20);
            this.txbGhiChu.TabIndex = 12;
            // 
            // TxbTenDanToc
            // 
            this.TxbTenDanToc.Location = new System.Drawing.Point(309, 67);
            this.TxbTenDanToc.Name = "TxbTenDanToc";
            this.TxbTenDanToc.Size = new System.Drawing.Size(284, 20);
            this.TxbTenDanToc.TabIndex = 11;
            // 
            // txbMaDanToc
            // 
            this.txbMaDanToc.Location = new System.Drawing.Point(309, 27);
            this.txbMaDanToc.Name = "txbMaDanToc";
            this.txbMaDanToc.Size = new System.Drawing.Size(284, 20);
            this.txbMaDanToc.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ghi Chú :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Dân Tộc :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Dân Tộc :";
            // 
            // dtgdanhsach
            // 
            this.dtgdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdanhsach.Location = new System.Drawing.Point(152, 176);
            this.dtgdanhsach.Name = "dtgdanhsach";
            this.dtgdanhsach.Size = new System.Drawing.Size(441, 170);
            this.dtgdanhsach.TabIndex = 14;
            this.dtgdanhsach.SelectionChanged += new System.EventHandler(this.dtgdanhsach_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(464, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 43);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // QuanLyDANTOC_DAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtgdanhsach);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbGhiChu);
            this.Controls.Add(this.TxbTenDanToc);
            this.Controls.Add(this.txbMaDanToc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyDANTOC_DAL";
            this.Text = "QuanLyDANTOC_DAL";
            ((System.ComponentModel.ISupportInitialize)(this.dtgdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbGhiChu;
        private System.Windows.Forms.TextBox TxbTenDanToc;
        private System.Windows.Forms.TextBox txbMaDanToc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgdanhsach;
        private System.Windows.Forms.Button btnDelete;
    }
}