using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsultMeTest
{
    public partial class SearchLawyer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            string GridQuery = "SELECT Lawyer.LawyerFullname,LawyerAdditionalInfo.AreaOfExperties,LawyerAdditionalInfo.Contact,LawyerAdditionalInfo.District,LawyerAdditionalInfo.CaseCount,LawyerAdditionalInfo.AvailableDate FROM Lawyer \r\n  INNER JOIN LawyerAdditionalInfo ON Lawyer.LawyerID=LawyerAdditionalInfo.LawyerID";
           
            if(con.State==ConnectionState.Closed )
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(GridQuery, con);
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Search_lawyer.DataSource= dt;
            Search_lawyer.DataBind();
            con.Close();
            

        }
        protected void Search_lawyer_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                // Modify the header text of each column
                e.Row.Cells[0].Text = "Full Name";
                e.Row.Cells[1].Text = "Area of Expertise";
                e.Row.Cells[2].Text = "Contact";
                e.Row.Cells[3].Text = "District";
                e.Row.Cells[4].Text = "Case Count";
                e.Row.Cells[5].Text = "Available Date";
            }
        }



    }
}