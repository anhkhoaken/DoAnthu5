namespace QuanLyNhanVien
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bậcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmBậcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBậcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bộPhậmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmBộPhậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBộPhậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmChứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quốcTịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmQuốcTịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýQuốcTịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýLoạiToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.côngToolStripMenuItem,
            this.phòngBanToolStripMenuItem,
            this.bậcToolStripMenuItem,
            this.bộPhậmToolStripMenuItem,
            this.chứcVụToolStripMenuItem,
            this.quốcTịchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýLoạiToolStripMenuItem
            // 
            this.quảnLýLoạiToolStripMenuItem.Name = "quảnLýLoạiToolStripMenuItem";
            this.quảnLýLoạiToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.quảnLýLoạiToolStripMenuItem.Text = "Tiền Lương";
            this.quảnLýLoạiToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýLoạiToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmNhânViênToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            // 
            // thêmNhânViênToolStripMenuItem
            // 
            this.thêmNhânViênToolStripMenuItem.Name = "thêmNhânViênToolStripMenuItem";
            this.thêmNhânViênToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.thêmNhânViênToolStripMenuItem.Text = "Thêm Nhân Viên";
            this.thêmNhânViênToolStripMenuItem.Click += new System.EventHandler(this.ThêmNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýNhânViênToolStripMenuItem_Click);
            // 
            // côngToolStripMenuItem
            // 
            this.côngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmCôngToolStripMenuItem,
            this.quảnLýCôngToolStripMenuItem});
            this.côngToolStripMenuItem.Name = "côngToolStripMenuItem";
            this.côngToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.côngToolStripMenuItem.Text = "Công";
            // 
            // thêmCôngToolStripMenuItem
            // 
            this.thêmCôngToolStripMenuItem.Name = "thêmCôngToolStripMenuItem";
            this.thêmCôngToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.thêmCôngToolStripMenuItem.Text = "Thêm Công";
            this.thêmCôngToolStripMenuItem.Click += new System.EventHandler(this.ThêmCôngToolStripMenuItem_Click);
            // 
            // quảnLýCôngToolStripMenuItem
            // 
            this.quảnLýCôngToolStripMenuItem.Name = "quảnLýCôngToolStripMenuItem";
            this.quảnLýCôngToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.quảnLýCôngToolStripMenuItem.Text = "Quản Lý Công";
            this.quảnLýCôngToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýCôngToolStripMenuItem_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhòngBanToolStripMenuItem,
            this.thêmPhòngBanToolStripMenuItem});
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.phòngBanToolStripMenuItem.Text = "Phòng Ban";
            // 
            // quảnLýPhòngBanToolStripMenuItem
            // 
            this.quảnLýPhòngBanToolStripMenuItem.Name = "quảnLýPhòngBanToolStripMenuItem";
            this.quảnLýPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.quảnLýPhòngBanToolStripMenuItem.Text = "Quản Lý Phòng Ban";
            this.quảnLýPhòngBanToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýPhòngBanToolStripMenuItem_Click);
            // 
            // thêmPhòngBanToolStripMenuItem
            // 
            this.thêmPhòngBanToolStripMenuItem.Name = "thêmPhòngBanToolStripMenuItem";
            this.thêmPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.thêmPhòngBanToolStripMenuItem.Text = "Thêm Phòng Ban";
            this.thêmPhòngBanToolStripMenuItem.Click += new System.EventHandler(this.ThêmPhòngBanToolStripMenuItem_Click);
            // 
            // bậcToolStripMenuItem
            // 
            this.bậcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmBậcToolStripMenuItem,
            this.quảnLýBậcToolStripMenuItem});
            this.bậcToolStripMenuItem.Name = "bậcToolStripMenuItem";
            this.bậcToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.bậcToolStripMenuItem.Text = "Bậc";
            // 
            // thêmBậcToolStripMenuItem
            // 
            this.thêmBậcToolStripMenuItem.Name = "thêmBậcToolStripMenuItem";
            this.thêmBậcToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.thêmBậcToolStripMenuItem.Text = "Thêm Bậc";
            this.thêmBậcToolStripMenuItem.Click += new System.EventHandler(this.ThêmBậcToolStripMenuItem_Click);
            // 
            // quảnLýBậcToolStripMenuItem
            // 
            this.quảnLýBậcToolStripMenuItem.Name = "quảnLýBậcToolStripMenuItem";
            this.quảnLýBậcToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.quảnLýBậcToolStripMenuItem.Text = "Quản Lý Bậc";
            this.quảnLýBậcToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýBậcToolStripMenuItem_Click);
            // 
            // bộPhậmToolStripMenuItem
            // 
            this.bộPhậmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmBộPhậnToolStripMenuItem,
            this.quảnLýBộPhậnToolStripMenuItem});
            this.bộPhậmToolStripMenuItem.Name = "bộPhậmToolStripMenuItem";
            this.bộPhậmToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bộPhậmToolStripMenuItem.Text = "Bộ phận";
            this.bộPhậmToolStripMenuItem.Click += new System.EventHandler(this.BộPhậmToolStripMenuItem_Click);
            // 
            // thêmBộPhậnToolStripMenuItem
            // 
            this.thêmBộPhậnToolStripMenuItem.Name = "thêmBộPhậnToolStripMenuItem";
            this.thêmBộPhậnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thêmBộPhậnToolStripMenuItem.Text = "Thêm Bộ Phận";
            this.thêmBộPhậnToolStripMenuItem.Click += new System.EventHandler(this.ThêmBộPhậnToolStripMenuItem_Click);
            // 
            // quảnLýBộPhậnToolStripMenuItem
            // 
            this.quảnLýBộPhậnToolStripMenuItem.Name = "quảnLýBộPhậnToolStripMenuItem";
            this.quảnLýBộPhậnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýBộPhậnToolStripMenuItem.Text = "Quản Lý Bộ Phận";
            this.quảnLýBộPhậnToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýBộPhậnToolStripMenuItem_Click);
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmChứcVụToolStripMenuItem,
            this.quảnLýChứcVụToolStripMenuItem});
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.chứcVụToolStripMenuItem.Text = "Chức Vụ";
            // 
            // thêmChứcVụToolStripMenuItem
            // 
            this.thêmChứcVụToolStripMenuItem.Name = "thêmChứcVụToolStripMenuItem";
            this.thêmChứcVụToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.thêmChứcVụToolStripMenuItem.Text = "Thêm Chức Vụ";
            this.thêmChứcVụToolStripMenuItem.Click += new System.EventHandler(this.ThêmChứcVụToolStripMenuItem_Click);
            // 
            // quảnLýChứcVụToolStripMenuItem
            // 
            this.quảnLýChứcVụToolStripMenuItem.Name = "quảnLýChứcVụToolStripMenuItem";
            this.quảnLýChứcVụToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.quảnLýChứcVụToolStripMenuItem.Text = "Quản Lý Chức Vụ";
            this.quảnLýChứcVụToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýChứcVụToolStripMenuItem_Click);
            // 
            // quốcTịchToolStripMenuItem
            // 
            this.quốcTịchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmQuốcTịchToolStripMenuItem,
            this.quảnLýQuốcTịchToolStripMenuItem});
            this.quốcTịchToolStripMenuItem.Name = "quốcTịchToolStripMenuItem";
            this.quốcTịchToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.quốcTịchToolStripMenuItem.Text = "Quốc Tịch";
            // 
            // thêmQuốcTịchToolStripMenuItem
            // 
            this.thêmQuốcTịchToolStripMenuItem.Name = "thêmQuốcTịchToolStripMenuItem";
            this.thêmQuốcTịchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thêmQuốcTịchToolStripMenuItem.Text = "Thêm Quốc Tịch";
            this.thêmQuốcTịchToolStripMenuItem.Click += new System.EventHandler(this.ThêmQuốcTịchToolStripMenuItem_Click);
            // 
            // quảnLýQuốcTịchToolStripMenuItem
            // 
            this.quảnLýQuốcTịchToolStripMenuItem.Name = "quảnLýQuốcTịchToolStripMenuItem";
            this.quảnLýQuốcTịchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýQuốcTịchToolStripMenuItem.Text = "Quản Lý Quốc Tịch";
            this.quảnLýQuốcTịchToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýQuốcTịchToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bậcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmBậcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBậcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bộPhậmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmBộPhậnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBộPhậnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmChứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quốcTịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmQuốcTịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýQuốcTịchToolStripMenuItem;
    }
}