using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class frommain : Form
    {
        public frommain()
        {
            InitializeComponent();
            //set kich thuoc cua from
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            //hien thi from Login
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void taiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }
        fromcategory ctl = new fromcategory();
        FormTaikhoan ftk = new FormTaikhoan();
        addcategory actl = new addcategory();
        FromKhachHang fkh = new FromKhachHang();
        private void dSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hien thi from tai khoan va an cac from dang mo
            ftk.MdiParent = this;
            ftk.Show();
            
        }

        private void danhSachDanhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hien thi from danh muc va an cac from dang mo
            ctl.MdiParent = this;
            ctl.Show();
            
        }

        private void themDanhMucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void danhSachKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hien thi cac from khach hang va an cac from dang mo
            fkh.MdiParent = this;
            fkh.Show();
            
        }

        private void frommain_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
