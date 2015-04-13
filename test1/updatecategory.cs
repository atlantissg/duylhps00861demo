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
    public partial class updatecategory : Form
    {
        public updatecategory()
        {
            InitializeComponent();
        }

        public string id { set; get; }
        public string ten_dm { set; get; }

        private void buttonAdddm_Click(object sender, EventArgs e)
        {
            string id1 = labelMadm.Text;
            string tendm1 = textBoxtenDM.Text;
            bool trangthai = true;
            if (checkBox1.Checked == true)
            {
                trangthai = true;
            }
            else
                trangthai = false;

            if (category.updatecategory(id1,tendm1,trangthai))
            {
                MessageBox.Show("update thanh cong");
            }
            else
            {
                MessageBox.Show("them that bai");
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelMadm_Click(object sender, EventArgs e)
        {

        }

        private void textBoxtenDM_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updatecategory_Load(object sender, EventArgs e)
        {
            labelMadm.Text = id;
            textBoxtenDM.Text = ten_dm;
        }
    }
}
