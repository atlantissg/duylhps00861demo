namespace test1
{
    partial class frommain
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
            this.taiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucSanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachDanhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachKhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taiKhoanToolStripMenuItem,
            this.danhMucSanPhamToolStripMenuItem,
            this.khachHangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // taiKhoanToolStripMenuItem
            // 
            this.taiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dSToolStripMenuItem});
            this.taiKhoanToolStripMenuItem.Name = "taiKhoanToolStripMenuItem";
            this.taiKhoanToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.taiKhoanToolStripMenuItem.Text = "tài khoản";
            this.taiKhoanToolStripMenuItem.Click += new System.EventHandler(this.taiKhoanToolStripMenuItem_Click);
            // 
            // dSToolStripMenuItem
            // 
            this.dSToolStripMenuItem.Name = "dSToolStripMenuItem";
            this.dSToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.dSToolStripMenuItem.Text = "Danh sach tai khoan";
            this.dSToolStripMenuItem.Click += new System.EventHandler(this.dSToolStripMenuItem_Click);
            // 
            // danhMucSanPhamToolStripMenuItem
            // 
            this.danhMucSanPhamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSachDanhMucToolStripMenuItem});
            this.danhMucSanPhamToolStripMenuItem.Name = "danhMucSanPhamToolStripMenuItem";
            this.danhMucSanPhamToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.danhMucSanPhamToolStripMenuItem.Text = "danh muc san pham";
            // 
            // danhSachDanhMucToolStripMenuItem
            // 
            this.danhSachDanhMucToolStripMenuItem.Name = "danhSachDanhMucToolStripMenuItem";
            this.danhSachDanhMucToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.danhSachDanhMucToolStripMenuItem.Text = "danh sach danh muc";
            this.danhSachDanhMucToolStripMenuItem.Click += new System.EventHandler(this.danhSachDanhMucToolStripMenuItem_Click);
            // 
            // khachHangToolStripMenuItem
            // 
            this.khachHangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSachKhachHangToolStripMenuItem});
            this.khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            this.khachHangToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.khachHangToolStripMenuItem.Text = "Khach hang";
            // 
            // danhSachKhachHangToolStripMenuItem
            // 
            this.danhSachKhachHangToolStripMenuItem.Name = "danhSachKhachHangToolStripMenuItem";
            this.danhSachKhachHangToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.danhSachKhachHangToolStripMenuItem.Text = "Danh sach khach hang";
            this.danhSachKhachHangToolStripMenuItem.Click += new System.EventHandler(this.danhSachKhachHangToolStripMenuItem_Click);
            // 
            // frommain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frommain";
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.frommain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucSanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSachDanhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSachKhachHangToolStripMenuItem;


    }
}