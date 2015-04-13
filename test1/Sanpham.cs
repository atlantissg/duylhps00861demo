using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Common;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
namespace test1
{
    class Sanpham
    {
        private int ma_sp;

        public int Ma_sp
        {
            get { return ma_sp; }
            set { ma_sp = value; }
        }
        private string ten_sp;

        public string Ten_sp
        {
            get { return ten_sp; }
            set { ten_sp = value; }
        }
        private DateTime ngaydang;

        public DateTime Ngaydang
        {
            get { return ngaydang; }
            set { ngaydang = value; }
        }
        private string mota;

        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }
        private bool trangthai;

        public bool Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
        private int giatien;

        public int Giatien
        {
            get { return giatien; }
            set { giatien = value; }
        }
        private string nhasx;

        public string Nhasx
        {
            get { return nhasx; }
            set { nhasx = value; }
        }
        private int category_id;

        public int Category_id
        {
            get { return category_id; }
            set { category_id = value; }
        }
        private byte[] image;

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }



        public bool ThemSanPham(string ten_sp, DateTime ngaydang, string mota, bool trangthai, int giatien, string nhasx, int category_id, byte[] image)
        {
            bool kq = true;
            try
            {
                string query = "insert into taikhoan (ten_sp,ngaydang,mota,trangthai,giatien,nhasx,category_id,image) values('{0}', '{1}', '{2}' , '{3}','{4}','{5}','{6}','{7}')";
                query = string.Format(query, ten_sp, ngaydang, trangthai.ToString(), giatien.ToString(), nhasx, category_id.ToString(), image);
                SqlCommand sc = new SqlCommand(query, ketnoi.getconnet());
                return sc.ExecuteNonQuery() > 0;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }
    }
}
