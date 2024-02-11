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
    public partial class UserFeedback : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            fillTheDropdownLists();
        }

        protected void Submit_feedback_Click(object sender, EventArgs e)
        {

        }
        void fillTheDropdownLists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if(con.State==ConnectionState.Closed)
                {
                    con.Open(); 
                }
                SqlCommand cmd =new SqlCommand("SELECT FeedbackStatus FROM FeedbackInfo", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);   
                DataTable dt = new DataTable(); 
                da.Fill(dt);
                CommunicationSkills.DataSource= dt;
                CommunicationSkills.DataValueField = "FeedbackStatus";
                CommunicationSkills.DataBind();

                Experties.DataSource = dt;
                Experties.DataValueField = "FeedbackStatus";
                Experties.DataBind();

                Professionalism.DataSource = dt;
                Professionalism.DataValueField = "FeedbackStatus";
                Professionalism.DataBind();

                Morality.DataSource = dt;
                Morality.DataValueField = "FeedbackStatus";
                Morality.DataBind();

                CaseManagement.DataSource = dt;
                CaseManagement.DataValueField = "FeedbackStatus";
                CaseManagement.DataBind();

                ClientSatisfaction.DataSource = dt;
                ClientSatisfaction.DataValueField = "FeedbackStatus";
                ClientSatisfaction.DataBind();

                

            }
            catch(Exception ex) 
            {
                Response.Write("<script>alert('Error 404');</script>");
            }
        }
       
    }
}