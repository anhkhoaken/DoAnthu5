namespace QuanLyNhanVien
{
    partial class ThemNgach_GUI
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
            this.txbMaNgach = new System.Windows.Forms.TextBox();
            this.txbTenNgach = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(129, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Ngạch :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(122, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Ngạch :";
            // 
            // txbMaNgach
            // 
            this.txbMaNgach.Location = new System.Drawing.Point(43, 186);
            this.txbMaNgach.Name = "txbMaNgach";
            this.txbMaNgach.Size = new System.Drawing.Size(297, 20);
            this.txbMaNgach.TabIndex = 2;
            // 
            // txbTenNgach
            // 
            this.txbTenNgach.Location = new System.Drawing.Point(43, 256);
            this.txbTenNgach.Name = "txbTenNgach";
            this.txbTenNgach.Size = new System.Drawing.Size(297, 20);
            this.txbTenNgach.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 117);
            this.panel1.TabIndex = 5;
            // 
            // ThemNgach_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 334);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbTenNgach);
            this.Controls.Add(this.txbMaNgach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemNgach_GUI";
            this.Text = "ThemNgach_GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMaNgach;
        private System.Windows.Forms.TextBox txbTenNgach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}