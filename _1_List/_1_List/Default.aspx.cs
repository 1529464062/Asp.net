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

namespace _1_List
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            Response.Write("<script>console.log(\"开始加载时间:'" + dt + "\");</script>");
            SqlHelp sh = new SqlHelp();
            ListHelp lh = new ListHelp();
            lh.ListBindToData(listbox1, sh.getDataTable(), "testId", "testName");
            DateTime dt1 = DateTime.Now;
            Response.Write("<script>console.log(\"结束加载时间:'" + dt1 + "\");</script>");
            Response.Write("<script>console.log(\"加载所用时间:'" + (dt1 - dt) + "\");</script>");
        }



    }


}
