using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace test1
{
    public partial class FromKhachHang : Form
    {
        public FromKhachHang()
        {
            InitializeComponent();
            //set kich thuoc cua from
        }

        private void FromKhachHang_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = KhachHang.DanhSachKhachHang();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            MinimizeBox = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten_kh = this.textBoxten_kh.Text;
            string diachi = this.textBoxDienthoai.Text;
            string dienthoai = this.textBoxdiachi.Text;
            string gioitinh = this.comboBox1.SelectedItem.ToString();
            string mail = this.textBoxEmail.Text;

            if (KhachHang.ThemKhachhang(ten_kh, diachi, dienthoai, gioitinh, mail))
            {
                MessageBox.Show("them tai khoan thanh cong");
                this.dataGridView1.DataSource = KhachHang.DanhSachKhachHang();
            }
            else
            {
                MessageBox.Show("them that bai");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string ma_kh = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Ban co chac xoa ko??", "Xac nhan", MessageBoxButtons.YesNo);
            if (dr.Equals(DialogResult.Yes))
            {
                if (KhachHang.xoakh(ma_kh))
                {
                    this.dataGridView1.DataSource = KhachHang.DanhSachKhachHang();
                    MessageBox.Show("Xoa thanh cong");

                }
                else
                    MessageBox.Show("That bai");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ma_kh = labelma_KH.Text;
            string ten_kh = this.textBoxten_kh.Text;
            string diachi = this.textBoxDienthoai.Text;
            string dienthoai = this.textBoxdiachi.Text;
            string gioitinh = this.comboBox1.SelectedItem.ToString();
            string mail = this.textBoxEmail.Text;
            DialogResult dr = MessageBox.Show("Ban co chac update ko??", "Xac nhan", MessageBoxButtons.YesNo);
            if (dr.Equals(DialogResult.Yes))
            {
                if (KhachHang.updateKhachHang(ma_kh, ten_kh,diachi ,dienthoai ,gioitinh ,mail))
                {
                    MessageBox.Show("update thanh cong");
                    this.dataGridView1.DataSource = KhachHang.DanhSachKhachHang();
                }
                else
                {
                    MessageBox.Show("update that bai");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.labelma_KH.Text = dataGridView1.CurrentRow.Cells["ma_kh"].Value.ToString();
            this.textBoxten_kh.Text = (dataGridView1.CurrentRow.Cells["ten_kh"].Value.ToString());
            this.textBoxdiachi.Text = dataGridView1.CurrentRow.Cells["diachi"].Value.ToString();
            this.textBoxEmail.Text = dataGridView1.CurrentRow.Cells["mail"].Value.ToString();
            this.textBoxDienthoai.Text = dataGridView1.CurrentRow.Cells["dienthoai"].Value.ToString();
            this.comboBox1.Text = dataGridView1.CurrentRow.Cells["gioitinh"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxdiachi.Clear();
            textBoxDienthoai.Clear();
            textBoxEmail.Clear();
            textBoxten_kh.Clear();
            labelma_KH.Text = "";
        }
    }
}
