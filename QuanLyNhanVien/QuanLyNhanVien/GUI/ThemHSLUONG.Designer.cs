namespace QuanLyNhanVien
{
    partial class ThemHSLUONG
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
            this.txbMaNgach = new System.Windows.Forms.TextBox();
            this.txbMaHS = new System.Windows.Forms.TextBox();
            this.txbMaBac = new System.Windows.Forms.TextBox();
            this.txbHeSo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hệ số lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Ngạch Lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Bậc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hệ Số lương";
            // 
            // txbMaNgach
            // 
            this.txbMaNgach.Location = new System.Drawing.Point(254, 108);
            this.txbMaNgach.Name = "txbMaNgach";
            this.txbMaNgach.Size = new System.Drawing.Size(372, 20);
            this.txbMaNgach.TabIndex = 4;
            // 
            // txbMaHS
            // 
            this.txbMaHS.Location = new System.Drawing.Point(254, 76);
            this.txbMaHS.Name = "txbMaHS";
            this.txbMaHS.Size = new System.Drawing.Size(372, 20);
            this.txbMaHS.TabIndex = 5;
            // 
            // txbMaBac
            // 
            this.txbMaBac.Location = new System.Drawing.Point(254, 154);
            this.txbMaBac.Name = "txbMaBac";
            this.txbMaBac.Size = new System.Drawing.Size(372, 20);
            this.txbMaBac.TabIndex = 6;
            // 
            // txbHeSo
            // 
            this.txbHeSo.Location = new System.Drawing.Point(254, 195);
            this.txbHeSo.Name = "txbHeSo";
            this.txbHeSo.Size = new System.Drawing.Size(372, 20);
            this.txbHeSo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 76);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThemHSLUONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbHeSo);
            this.Controls.Add(this.txbMaBac);
            this.Controls.Add(this.txbMaHS);
            this.Controls.Add(this.txbMaNgach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemHSLUONG";
            this.Text = "ThemHSLUONG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMaNgach;
        private System.Windows.Forms.TextBox txbMaHS;
        private System.Windows.Forms.TextBox txbMaBac;
        private System.Windows.Forms.TextBox txbHeSo;
        private System.Windows.Forms.Button button1;
    }
}