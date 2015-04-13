using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class FormTaikhoan : Form
    {
        public FormTaikhoan()
        {
            InitializeComponent();

            //set kich thuoc cua from ko cho phong to
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            //lay danh sach cua role truyen vao combobox
            this.comboBox1.DataSource = roles.GetAllRole();
            this.comboBox1.DisplayMember = "role";
            this.comboBox1.ValueMember = "id";
            try
            {
                //danh sach tai khaon
                this.dataGridViewt.DataSource = taikhoan.DanhSachtaikhoan();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            try
            {
                //lay du lieu len checkbox va combobox
                checkBox1.DataBindings.Add("Checked", dataGridViewt.DataSource, "trangthai");
                comboBox1.DataBindings.Add("SelectedValue", dataGridViewt.DataSource, "role_id");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBoxuser.Text;
            string password = this.textBoxpass.Text;
            
            //Lấy t/g hiện tại
            DateTime ngaydangky = DateTime.Now;
            int id_role = Int32.Parse(comboBox1.SelectedValue.ToString());
            bool trangthai = true;
            if (checkBox1.Checked)
            {
                trangthai = true;
            }
            else
            {
                trangthai = false;
            }

            if (username == null && password ==null)
            {
                MessageBox.Show("Them that bai");
                
            }
            else
            {
                taikhoan.Themtaikhoan(username, password, trangthai, ngaydangky, id_role);
                MessageBox.Show("Them thanh cong");
                this.dataGridViewt.DataSource = taikhoan.DanhSachtaikhoan();
            }
   
        }

        private void dataGridViewt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lay du lieu vao textbox
            textBoxuser.DataBindings.Clear();
            textBoxuser.DataBindings.Add("text", dataGridViewt.DataSource, "username");
            textBoxpass.DataBindings.Clear();
            textBoxpass.DataBindings.Add("text", dataGridViewt.DataSource, "password");
            
            labelID.DataBindings.Clear();
            labelID.DataBindings.Add("text", dataGridViewt.DataSource, "ma_tk");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = this.textBoxuser.Text;
            string password = this.textBoxpass.Text;
            string ma_tk = this.labelID.Text;

            
            int id_role = Int32.Parse(comboBox1.SelectedValue.ToString());
            bool trangthai = true;
            if (checkBox1.Checked)
            {
                trangthai = true;
            }
            else
            {
                trangthai = false;
            }
            //update du lieu
            DialogResult dr = MessageBox.Show("Ban co chac update ko??", "Xac nhan", MessageBoxButtons.YesNo);
            if (dr.Equals(DialogResult.Yes))
            {
                if(taikhoan.updateTaikhoan(ma_tk,username,password,trangthai,id_role))
                {   
                MessageBox.Show("update thanh cong");
                this.dataGridViewt.DataSource = taikhoan.DanhSachtaikhoan();
                }
                else
                {
                    MessageBox.Show("update that bai");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Xoa du lieu trong database
            string username = this.dataGridViewt.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Ban co chac xoa ko??", "Xac nhan", MessageBoxButtons.YesNo);
            if (dr.Equals(DialogResult.Yes))
            {
                if (taikhoan.xoataikhoan(username))
                {
                    this.dataGridViewt.DataSource =  taikhoan.DanhSachtaikhoan();
                    MessageBox.Show("Xoa thanh cong");
                    
                }
                else
                    MessageBox.Show("That bai");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Xoa du lieu
            textBoxuser.Clear();
            textBoxpass.Clear();
            labelID.Text ="";
            checkBox1.Checked = false;
        }
        
    }
}

