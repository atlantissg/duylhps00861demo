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
    class KhachHang
    {
        private int ma_kh;

        public int Ma_kh
        {
            get { return ma_kh; }
            set { ma_kh = value; }
        }
        private string teh_kh;

        public string Teh_kh
        {
            get { return teh_kh; }
            set { teh_kh = value; }
        }
        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private string dienthoai;

        public string Dienthoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
        private string gioitinh;

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        private string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        //danh sách khách hàng
        public static DataTable DanhSachKhachHang()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "select * from khachhang";
                SqlDataAdapter sda = new SqlDataAdapter(query, ketnoi.getconnet());
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0];
            }
            catch
            {
                dt = null;
            }
            return dt;
        }
        //thêm khách hàng
        public static bool ThemKhachhang(string ten_kh, string diachi, string dienthoai, string gioitinh, string mail)
        {
            bool kq = true;
            try
            {
                string query = "insert into khachhang (ten_kh,diachi,dienthoai,gioitinh,mail) values('{0}', '{1}', '{2}' , '{3}','{4}')";
                query = string.Format(query, ten_kh, diachi, dienthoai, gioitinh, mail);
                SqlCommand sc = new SqlCommand(query, ketnoi.getconnet());
                return sc.ExecuteNonQuery() > 0;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }

        //update khách hàng
        public static bool updateKhachHang(string ma_kh, string ten_kh,string diachi, string dienthoai , string gioitinh  ,string email)
        {

            bool kq = true;
            try
            {
                string query = "update khachhang set ten_kh = '{0}', diachi =  '{1}' ,dienthoai =  '{2}', gioitinh = '{3}', mail = '{4}' where ma_kh = '{5}' ";
                query = string.Format(query, ten_kh, diachi, dienthoai,gioitinh,email,ma_kh);
                SqlCommand sc = new SqlCommand(query, ketnoi.getconnet());
                return sc.ExecuteNonQuery() > 0;
            }
            catch
            {
                kq = false;
            }
            return kq;

        }

        //xóa khách hàng
        public static bool xoakh(string ma_kh)
        {
            bool kq = true;
            try
            {
                string query = "delete from khachhang where ma_kh = '{0}'";
                query = string.Format(query, ma_kh);
                SqlCommand sc = new SqlCommand(query, ketnoi.getconnet());
                return sc.ExecuteNonQuery() > 0;
            }
            catch
            {

            }
            return kq;
        }


    }
}
