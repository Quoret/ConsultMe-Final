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
            //string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            //SqlConnection con = new SqlConnection(strcon);
            //string GridQuery = "SELECT Lawyer.LawyerFullname,LawyerAdditionalInfo.AreaOfExperties,LawyerAdditionalInfo.Contact,LawyerAdditionalInfo.District,LawyerAdditionalInfo.CaseCount,LawyerAdditionalInfo.AvailableDate FROM Lawyer \r\n  INNER JOIN LawyerAdditionalInfo ON Lawyer.LawyerID=LawyerAdditionalInfo.LawyerID";
            
            //if(con.State==ConnectionState.Closed )
            //{
            //    con.Open();
            //}
            //SqlCommand cmd = new SqlCommand(GridQuery, con);
            //SqlDataAdapter da= new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //Search_lawyer.DataSource = dt;//DefaultView.ToTable(false, "LawyerFullname", "AreaOfExperties", "Contact", "District", "CaseCount", "AvailableDate");
            //Search_lawyer.DataKeyNames = new string[] { "LawyerID" }; // Set the LawyerID as the data key
            //Search_lawyer.DataBind();




            //con.Close();

            

        }
        //protected void Search_lawyer_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {
                
               
        //    }
           
        //}
        //protected void Search_lawyer_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    if (e.CommandName == "SelectLawyer")
        //    {
        //        int index=Convert.ToInt32(e.CommandArgument);

        //        if (index >= 0 && index < Search_lawyer.Rows.Count)
        //        {
        //            GridViewRow selectedRow = Search_lawyer.Rows[index];
        //            int lawyerID = Convert.ToInt32(Search_lawyer.DataKeys[index].Value/*["LawyerID"]*/);

        //            int clientID = Convert.ToInt32(Session["ClientId"]);

        //            // Redirect to feedback page with LawyerID and ClientID
        //            Response.Redirect($"UserFeedback.aspx?LawyerID={lawyerID}&ClientID={clientID}");
        //        }

        //        // Redirect to feedback page with lawyer ID
        //        // Response.Redirect($"UserFeedback.aspx?LawyerID={lawyerID}");
        //        //Response.Redirect($"UserFeedback.aspx?LawyerID={lawyerID}&ClientID={clientID}");
        //    }
        //}



    }
}