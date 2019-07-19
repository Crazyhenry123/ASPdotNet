using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iCSHD
{
    public partial class iCSHDhome : System.Web.UI.Page
    {
        public static string EngAlias;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StartButton_OnClick(object sender, EventArgs e)
        {
            Session["EngAlias"] = StartAliasBox.Text;
            EngAlias = StartAliasBox.Text;
            Response.Redirect("iCSHDdashboard.aspx");

        }

        protected void StartAliasBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}