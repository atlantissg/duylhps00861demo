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


    class category
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string ten_dm;

        public string Ten_dm
        {
            get { return ten_dm; }
            set { ten_dm = value; }
        }
        private bool trangthai;

        public bool Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
        //danh sach danh muc
        public static DataTable DanhSachCategory()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "select * from category";
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
        //them danh muc
        public static bool Themcategory(string ten_dm, bool trangthai)
        {
            bool kq = true;
            try
            {
                string query = "insert into category (ten_dm,trangthai) values('{0}', '{1}')";
                query = string.Format(query, ten_dm, trangthai.ToString());
                SqlCommand sc = new SqlCommand(query, ketnoi.getconnet());
                return sc.ExecuteNonQuery() > 0;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }
        //update danh muc
        public static bool updatecategory (string id, string ten_dm, bool trangthai)
        {
            bool kq = true;
            try
            {
                string query = "update category set ten_dm = '{0}' ,trangthai =  '{1}' where id = '{2}'";
                query = string.Format(query, ten_dm, trangthai.ToString(), id);
                SqlCommand sc = new SqlCommand(query, ketnoi.getconnet());
                return sc.ExecuteNonQuery() > 0;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }
        //Xoa danh muc
        public static bool xoacategory(string id)
        {
            bool kq = true;
            try
            {
                string query = "delete from category where id = '{0}'";
                query = string.Format(query, id);
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
