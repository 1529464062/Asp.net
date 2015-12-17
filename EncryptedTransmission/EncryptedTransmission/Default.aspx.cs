using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;
using System.Data.SqlClient;

namespace EncryptedTransmission
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            Session.Add("123", "start");
            Response.Write(Session["123"]);
           
            FileInfo fi = new FileInfo(Server.MapPath("/123.txt"));
            StreamWriter sw = fi.AppendText();
            sw.Write("123"+DateTime.Now+"\r\n");
            sw.Close();
             * 
            StreamReader sr = new StreamReader(Server.MapPath("/123.txt"));
            Response.Write(sr.ReadToEnd());
            sr.Close();
            */
            /**************************************/
            /******** 存储过程查询 ****************/
            
            string sqlText="tran_testTable";
            SqlParameter[] sqlparams = new SqlParameter[] {
                new SqlParameter("@testName_1", "234"),
                new SqlParameter("@testName_2", "234123"),
                new SqlParameter("@message",DbType.String)
            };
            using (SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
            {
                using(SqlCommand sqlcom=new SqlCommand(sqlText,sqlcon))
                {
                    try
                    {
                        sqlcon.Open();
                        sqlcom.CommandType = CommandType.StoredProcedure;
                        sqlcom.Parameters.Add(new SqlParameter("@testName_1", "123"));
                        sqlcom.Parameters.Add(new SqlParameter("@testName_2", "123456"));
                        sqlcom.Parameters.Add(new SqlParameter("@message", SqlDbType.NVarChar,50));
                        sqlcom.Parameters["@message"].Direction = ParameterDirection.Output;
                        sqlcom.ExecuteNonQuery();
                        Response.Write(sqlcom.Parameters["@message"].Value.ToString());
                        sqlcon.Close();
                        sqlcom.Dispose();
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message+ex.Source);
                    }
                }
                sqlcon.Dispose();
            }             
            
            /************ 存储过程查询结束 **********************      
            DataSet ds = new DataSet();
            using (SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
            {
                sqlcon.Open();                                                
                string strSQL = "SELECT * FROM [testTable]"; //要执行的SQL语句 
                SqlDataAdapter da = new SqlDataAdapter(strSQL, sqlcon); //创建DataAdapter数据适配器实例                
                da.Fill(ds,"qwe");//使用DataAdapter的Fill方法(填充)，调用SELECT命令                
                sqlcon.Close();
            }
            GridView1.DataSource = ds.Tables["qwe"];
            GridView1.DataBind();
            */ 
        }
    }
}
