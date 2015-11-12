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

namespace _1_List
{
    public class ListHelp
    {
        public void ListBindToData(ListBox lb, DataTable dt, string dataTextField, string dataValueField)
        {
            lb.Items.Clear();
            lb.DataSource = dt;
            lb.DataTextField = dataTextField;
            lb.DataValueField = dataValueField;
            lb.DataBind();
        }
    }
}
