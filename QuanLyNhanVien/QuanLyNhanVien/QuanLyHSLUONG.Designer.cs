namespace QuanLyNhanVien
{
    partial class QuanLyHSLUONG
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
            this.txbHeSo = new System.Windows.Forms.TextBox();
            this.txbMaBac = new System.Windows.Forms.TextBox();
            this.txbMaHS = new System.Windows.Forms.TextBox();
            this.txbMaNgach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.btnUpdate.Location = new System.Drawing.Point(98, 452);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 76);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Cập nhập";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbHeSo
            // 
            this.txbHeSo.Location = new System.Drawing.Point(279, 142);
            this.txbHeSo.Name = "txbHeSo";
            this.txbHeSo.Size = new System.Drawing.Size(372, 20);
            this.txbHeSo.TabIndex = 16;
            // 
            // txbMaBac
            // 
            this.txbMaBac.Location = new System.Drawing.Point(279, 101);
            this.txbMaBac.Name = "txbMaBac";
            this.txbMaBac.Size = new System.Drawing.Size(372, 20);
            this.txbMaBac.TabIndex = 15;
            // 
            // txbMaHS
            // 
            this.txbMaHS.Location = new System.Drawing.Point(279, 23);
            this.txbMaHS.Name = "txbMaHS";
            this.txbMaHS.Size = new System.Drawing.Size(372, 20);
            this.txbMaHS.TabIndex = 14;
            // 
            // txbMaNgach
            // 
            this.txbMaNgach.Location = new System.Drawing.Point(279, 55);
            this.txbMaNgach.Name = "txbMaNgach";
            this.txbMaNgach.Size = new System.Drawing.Size(372, 20);
            this.txbMaNgach.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hệ Số lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã Bậc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Ngạch Lương";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã hệ số lương";
            // 
            // dtgdanhsach
            // 
            this.dtgdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdanhsach.Location = new System.Drawing.Point(98, 194);
            this.dtgdanhsach.Name = "dtgdanhsach";
            this.dtgdanhsach.Size = new System.Drawing.Size(553, 218);
            this.dtgdanhsach.TabIndex = 18;
            this.dtgdanhsach.SelectionChanged += new System.EventHandler(this.dtgdanhsach_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(472, 452);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 76);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // QuanLyHSLUONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtgdanhsach);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbHeSo);
            this.Controls.Add(this.txbMaBac);
            this.Controls.Add(this.txbMaHS);
            this.Controls.Add(this.txbMaNgach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyHSLUONG";
            this.Text = "QuanLyHSLUONG";
            ((System.ComponentModel.ISupportInitialize)(this.dtgdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbHeSo;
        private System.Windows.Forms.TextBox txbMaBac;
        private System.Windows.Forms.TextBox txbMaHS;
        private System.Windows.Forms.TextBox txbMaNgach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgdanhsach;
        private System.Windows.Forms.Button btnDelete;
    }
}