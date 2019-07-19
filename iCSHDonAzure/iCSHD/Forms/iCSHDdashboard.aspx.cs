using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iCSHD;
using iCSHD.Models;
using iCSHD.Helpers;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace iCSHD.Forms
{


    public partial class iCSHDdashboard : System.Web.UI.Page
    {
        public static string EngAlias;
        SQLHelpers sqlhelpers = new SQLHelpers();
        private List<CxProfile> cxprofileset = new List<CxProfile>();
        private List<string> casenumbers = new List<string>();


        protected void Page_Load(object sender, EventArgs e)
        {
            EngAlias = iCSHDhome.EngAlias;
            cxprofileset = sqlhelpers.GetCxInfoByEngAlias(EngAlias);
            string CS = ConfigurationManager.ConnectionStrings["SDCasesTEST"].ConnectionString;

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("[dbo].[GetCxInfoByEngAliasnCxID]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EngAlias", EngAlias);
                cmd.Parameters.AddWithValue("@cxID", cxprofileset.FirstOrDefault().CxID);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                con.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                CxInfoView.DataSource = dt;

                con.Close();
            }

            CxInfoView.DataBind();


            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("[dbo].[GetCasesByCxIDnEngAlisListBox]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cxID", cxprofileset.FirstOrDefault().CxID);
                cmd.Parameters.AddWithValue("@engAlias", EngAlias);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                con.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);

                ListItem[] ListItemList = new ListItem[dt.Rows.Count];



                foreach (DataRow dr in dt.Rows)
                {
                    casenumbers.Add(dr["CASENUMBER"].ToString());

                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListItem ListItemObject = new ListItem(casenumbers[i]);
                    ListItemList[i] = ListItemObject;
                }


                 CaseListBox.Items.AddRange(ListItemList);

                 cmd.Dispose();
                
                }

                CaseListBox.DataBind();
            }

      //  }

        protected void CxInfoButton_Click(object sender, EventArgs e)
        {

        }

        protected void CxInfoView_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {

            CxInfoView.PageIndex = e.NewPageIndex;
            CxInfoView.DataBind();

        }

        protected void CaseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CaseListBox.DataBind();

        }
    }
}