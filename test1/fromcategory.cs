using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class fromcategory : Form
    {
        

        public fromcategory()
        {
            InitializeComponent();
        }

        private void fromcategory_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = category.DanhSachCategory();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updatecategory upd = new updatecategory();
            
            upd.id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            upd.ten_dm = dataGridView1.CurrentRow.Cells["ten_dm"].Value.ToString();
            
            upd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = category.DanhSachCategory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Ban co chac xoa ko??", "Xac nhan", MessageBoxButtons.YesNo);
            if (dr.Equals(DialogResult.Yes))
            {
                if (category.xoacategory(id))
                {
                    this.dataGridView1.DataSource = category.DanhSachCategory();
                    MessageBox.Show("Xoa thanh cong");

                }
                else
                    MessageBox.Show("That bai");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addcategory ath = new addcategory();
            ath.ShowDialog();
        }
    }
}
