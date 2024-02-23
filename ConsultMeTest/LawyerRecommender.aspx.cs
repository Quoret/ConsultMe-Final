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
    public partial class LawyerRecommender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string areaOfExpertise = Request.QueryString["AreaOfExpertise"];
            string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string RecommendedLawyerQuery = "SELECT top 10 Similarityindex.LawyerID,Lawyer.LawyerFullname,LawyerAdditionalInfo.AreaOfExperties,LawyerAdditionalInfo.Contact,LawyerAdditionalInfo.District,LawyerAdditionalInfo.CaseCount,LawyerAdditionalInfo.AvailableDate FROM Similarityindex INNER JOIN Lawyer ON Similarityindex.LawyerID = Lawyer.LawyerID INNER JOIN LawyerAdditionalInfo ON LawyerAdditionalInfo.LawyerID = Similarityindex.LawyerID  WHERE LawyerAdditionalInfo.AreaofExperties='"+areaOfExpertise+"' ORDER BY Similarityindex.Similarity_index DESC";

            SqlCommand cmd = new SqlCommand(RecommendedLawyerQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            RecommendedLawyer.DataSource= dt;
            RecommendedLawyer.DataBind();

        }
        protected void RecommendedLawyer_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            HyperLink lawyerLink = new HyperLink();
            lawyerLink.Text = e.Row.Cells[1].Text;
            lawyerLink.NavigateUrl = "~/UserFeedback.aspx?LawyerID=" + e.Row.Cells[0].Text + "&ClientID=" + Session["ClientId"]; // Assuming the LawyerID is in the first cell
            e.Row.Cells[1].Controls.Add(lawyerLink);   
        }
        }
}