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
using System.Data.SqlClient;

namespace EncryptedTransmission
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
            {
                sqlcon.Open();
                string strSQL = "[testTable_select]"; //要执行的SQL语句 
                SqlDataAdapter da = new SqlDataAdapter(strSQL, sqlcon); //创建DataAdapter数据适配器实例                
                da.Fill(ds, "qwe");//使用DataAdapter的Fill方法(填充)，调用SELECT命令                
                sqlcon.Close();
            }
            Response.Write(ds.Tables["qwe"].Rows.Count);
            GridView1.DataSource = ds.Tables["qwe"];
            GridView1.DataBind();
            //Response.Write("<script type=\"text/javascript\">function GetJson(JsonString) {var JsonObject = JSON.parse(JsonString);for (var i = 0; i<JsonObject.length; i++) {for (key in JsonObject[i]) {console.log(key + JsonObject[i][key]);}}}</script>");
            Response.Write("<script type=\"text/javascript\">function GetJson(JsonString){var JsonObject = JSON.parse(JsonString);var table=\"<table>\";for(var i=0;i<JsonObject.length;i++){table=table+\"<tr>\"if(i==0){for(key in JsonObject[0]){table=table+\"<td>\"+key+\"</td>\";table=table+\"</tr><tr>\";}}for(key in JsonObject[i]){table=table+\"<td>\"+JsonObject[i][key]+\"</td>\";table=table+\"</tr>\";}}table=table+\"</table>\";document.body.innerHTML=document.body.innerHTML+table;}");
            string json = DataTableToJson(ds.Tables["qwe"]);
            Response.Write("<script type=\"text/javascript\">GetJson('"+json.ToString()+"')</script>");
        }
        private string DataTableToJson(DataTable dt) 
        {
            string Json = "";
            Json = Json + "[";
            foreach (DataRow dr in dt.Rows) 
            {
                Json = Json + "{";
                foreach (DataColumn dc in dt.Columns)                 
                {
                    Json = Json + "\"" + dc.ColumnName + "\":\"" + dr[dc].ToString() + "\""+",";
                }
                Json = Json.Substring(0, Json.Length - 1);
                Json = Json + "},";
            }
            Json = Json.Substring(0, Json.Length - 1);
            Json = Json + "]";
            return Json;
        }
    }
}
