namespace QuanLyNhanVien
{
    partial class QuanLyNGACH_GUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.txbTenNgach = new System.Windows.Forms.TextBox();
            this.txbMaNgach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgdanhsach = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cập Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txbTenNgach
            // 
            this.txbTenNgach.Location = new System.Drawing.Point(279, 90);
            this.txbTenNgach.Name = "txbTenNgach";
            this.txbTenNgach.Size = new System.Drawing.Size(297, 20);
            this.txbTenNgach.TabIndex = 8;
            // 
            // txbMaNgach
            // 
            this.txbMaNgach.Location = new System.Drawing.Point(279, 36);
            this.txbMaNgach.Name = "txbMaNgach";
            this.txbMaNgach.Size = new System.Drawing.Size(297, 20);
            this.txbMaNgach.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(123, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Ngạch :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(123, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Ngạch :";
            // 
            // dtgdanhsach
            // 
            this.dtgdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdanhsach.Location = new System.Drawing.Point(128, 191);
            this.dtgdanhsach.Name = "dtgdanhsach";
            this.dtgdanhsach.ReadOnly = true;
            this.dtgdanhsach.Size = new System.Drawing.Size(448, 201);
            this.dtgdanhsach.TabIndex = 10;
            this.dtgdanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgdanhsach_CellContentClick);
            this.dtgdanhsach.SelectionChanged += new System.EventHandler(this.Dtgdanhsach_SelectionChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 64);
            this.button2.TabIndex = 11;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // QuanLyNGACH_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtgdanhsach);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbTenNgach);
            this.Controls.Add(this.txbMaNgach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyNGACH_GUI";
            this.Text = "QuanLyNGACH_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dtgdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbTenNgach;
        private System.Windows.Forms.TextBox txbMaNgach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgdanhsach;
        private System.Windows.Forms.Button button2;
    }
}