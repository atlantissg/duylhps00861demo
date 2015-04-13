using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace test1
{
    public partial class FromSanPham : Form
    {
        public FromSanPham()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();

            this.textBoxup.Text = op.FileName;
            FileInfo fi = new FileInfo(op.FileName);
            this.textBoxup.Text = fi.Name;
            Image myim = Image.FromFile(op.FileName);
            this.pictureBoxdow.Image = myim;
        }

        private void FromSanPham_Load(object sender, EventArgs e)
        {
            comboBoxLoaisp.DataSource = category.DanhSachCategory();
            this.comboBoxLoaisp.DisplayMember = "ten_dm";
            this.comboBoxLoaisp.ValueMember = "id";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //string tensp = textBoxTensp.Text;
            //string mota = richTextBoxMota.Text;
            //int giatien = Int32.Parse(textBoxGiatien.Text);
            //string nhasx = textBoxNhasx.Text;
            //bool trangthai = true;
            //if (checkBoxtt.Checked == true)
            //{
             //   trangthai = true;
            //}
            //else
            //    trangthai = false;


        }
    }
}
