﻿namespace QuanLyNhanVien
{
    partial class ThemBAC_GUI
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
            this.txbMaBac = new System.Windows.Forms.TextBox();
            this.TxbTenBac = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Bậc :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Bậc :";
            // 
            // txbMaBac
            // 
            this.txbMaBac.Location = new System.Drawing.Point(288, 94);
            this.txbMaBac.Name = "txbMaBac";
            this.txbMaBac.Size = new System.Drawing.Size(233, 20);
            this.txbMaBac.TabIndex = 2;
            // 
            // TxbTenBac
            // 
            this.TxbTenBac.Location = new System.Drawing.Point(288, 138);
            this.TxbTenBac.Name = "TxbTenBac";
            this.TxbTenBac.Size = new System.Drawing.Size(233, 20);
            this.TxbTenBac.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(288, 207);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 51);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ThemBAC_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 355);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.TxbTenBac);
            this.Controls.Add(this.txbMaBac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemBAC_GUI";
            this.Text = "ThemBAC_GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMaBac;
        private System.Windows.Forms.TextBox TxbTenBac;
        private System.Windows.Forms.Button btnThem;
    }
}