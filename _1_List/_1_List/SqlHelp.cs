using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace _1_List
{
    public class SqlHelp
    {
        public DataTable getDataTable()
        {

            DataTable dt = new DataTable();
            DataSet ds=new DataSet();
            using (SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ToString()))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from [testTable]", sqlcon);
                sqlda.Fill(ds);
                sqlcon.Close();
            }
            dt = ds.Tables[0];
            return dt;
        }
    }
}
