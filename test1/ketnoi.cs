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
    class ketnoi
    {
        public static SqlConnection getconnet()
        {
            SqlConnection con;
            string strcon = @"workstation id=duylhps00861.mssql.somee.com;packet size=4096;user id=duylhps00861;pwd=lehuuduy;data source=duylhps00861.mssql.somee.com;persist security info=False;initial catalog=duylhps00861;";
            try
            {
                con = new SqlConnection(strcon);
                con.Open();
            }
            catch
            {
                con = null;
            }
            return con;
        }

    }
}
