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
    class roles
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string role;

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public static DataTable GetAllRole()
        {
            string query = "select * from role";
            SqlDataAdapter sda = new SqlDataAdapter(query, ketnoi.getconnet());
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        }
    }
}
