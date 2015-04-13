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
    class taikhoan
    {
        //tao cac doi tuong
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string passwork;

        public string Passwork
        {
            get { return passwork; }
            set { passwork = value; }
        }

        private string ma_tk;

        public string Ma_tk
        {
            get { return ma_tk; }
            set { ma_tk = value; }
        }
        private bool trangthai;

        public bool Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
        private DateTime ngaydangky;

        public DateTime Ngaydangky
        {
            get { return ngaydangky; }
            set { ngaydangky = value; }
        }
        private int role_id;

        public int Role_id
        {
            get { return role_id; }
            set { role_id = value; }
        }

        //đăng nhập
        public static bool dangnhap(string usrename, string passwork)
        {
            bool kq = true;
            try
            {
                string query = "select * from taikhoan where username = '{0}' and password = '{1}' ";
                query = string.Format(query, usrename, passwork);
                SqlDataAdapter sda = new SqlDataAdapter(query, ketnoi.getconnet());
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0].Rows.Count > 0;
            }
            catch
            {
                kq = false;
            }
            return kq;

        }
        //danh sach tai khoan
        public static DataTable DanhSachtaikhoan()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "select * from taikhoan";
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
        //thêm tài khoản
        public static bool Themtaikhoan(string username, string password, bool trangthai, DateTime ngaydangky, int role_id)
        {
            bool kq = true;
            try
            {
                string query = "insert into taikhoan (username,password,trangthai,ngaydangky,role_id) values('{0}', '{1}', '{2}' , '{3}','{4}')";
                query = string.Format(query, username, password, trangthai.ToString(), ngaydangky, role_id);
                SqlCommand sc = new SqlCommand(query, ketnoi.getconnet());
                return sc.ExecuteNonQuery() > 0;
            }
            catch
            {
                kq = false;  
            }
            return kq;
        }

        //update tai khoan
        public static bool updateTaikhoan(string ma_tk, string username, string password, bool trangthai, int role_id)
        {

            bool kq = true;
            try
            {
                string query = "update taikhoan set username = '{0}', password =  '{1}' ,trangthai =  '{2}', role_id = '{3}' where ma_tk = '{4}' ";
                query = string.Format(query, username, password, trangthai, role_id,ma_tk);
                SqlCommand sc = new SqlCommand(query, ketnoi.getconnet());
                return sc.ExecuteNonQuery() > 0;
            }
            catch
            {
                kq = false;
            }
            return kq;

        }

        //xoa tai khoan
        public static bool xoataikhoan(string ma_tk)
        {
            bool kq = true;
            try
            {
                string query = "delete from taikhoan where ma_tk = '{0}'";
                query = string.Format(query, ma_tk);
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
