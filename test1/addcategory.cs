﻿using System;
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
    public partial class addcategory : Form
    {
        public addcategory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdddm_Click(object sender, EventArgs e)
        {
            string ten_dm = textBoxtenDM.Text;
            bool trangthai = true;
            if (checkBox1.Checked == true)
            {
                trangthai = true;
            }
            else
                trangthai = false;

            if (category.Themcategory(ten_dm, trangthai))
            {
                MessageBox.Show("them thanh cong");
            }
            else
            {
                MessageBox.Show("them that bai");
            }
        }



        private void addcategory_Load(object sender, EventArgs e)
        {
            
        }
    }
}
