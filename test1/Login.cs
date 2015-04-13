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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
             
        }

        public string roleid;

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = this.textBoxusername.Text;
            string pass = this.textBoxpassword.Text;
            if (taikhoan.dangnhap(username, pass))
            {
                MessageBox.Show("dang nhap thanh cong");
                this.Close();
            }
            else
            {
                MessageBox.Show("dang nhap that bai");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
             
        }
    }
}
