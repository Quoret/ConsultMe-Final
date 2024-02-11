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


            //fillTheDropdownLists();
        }


        protected void Submit_feedback_Click(object sender, EventArgs e)
        {
            string communication_skills = CommunicationSkills.SelectedItem.Value;
            string experties = Experties.SelectedItem.Value;
            string professionalism = Professionalism.SelectedItem.Value;
            string morality = Morality.SelectedItem.Value;
            string case_management = CaseManagement.SelectedItem.Value;
            string client_satisfaction = ClientSatisfaction.SelectedItem.Value;

            int communicationSkillRating= MapToNumericRating(communication_skills);
            int expertiesRating=MapToNumericRating(experties);
            int professionalismRating = MapToNumericRating(professionalism);
            int moralityRating= MapToNumericRating(morality);
            int caseManagementRating= MapToNumericRating(case_management);
            int clientSatisfactionRating = MapToNumericRating(client_satisfaction);



            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO ClientFeedback (CommunicationSkill,Experties,Professionalism,Morality,CaseManagement,ClientSatisfaction) VALUES (@CommunicationSkill,@Experties,@Professionalism,@Morality,@CaseManagement,@ClientSatisfaction) ", con);
                cmd.Parameters.AddWithValue("@CommunicationSkill",communicationSkillRating);
                cmd.Parameters.AddWithValue("@Experties",expertiesRating);
                cmd.Parameters.AddWithValue("@Professionalism",professionalismRating);
                cmd.Parameters.AddWithValue("@Morality",moralityRating);
                cmd.Parameters.AddWithValue("@CaseManagement",caseManagementRating);
                cmd.Parameters.AddWithValue("@ClientSatisfaction",clientSatisfactionRating);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Feedback Submitted Sucessfully');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('"+ex.Message+"');</script>");
            }

        }
        void fillTheDropdownLists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT FeedbackStatus FROM FeedbackInfo", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CommunicationSkills.DataSource = dt;
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
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error 404');</script>");
            }
        }
        private int MapToNumericRating(string feedbackStatus)
        {

            switch (feedbackStatus)
            {
                case "Excellent":
                    return 5;
                    
                case "Very Good":
                    return 4;
                    
                case "Good":
                    return 3;
                    
                case "Fair":
                    return 2;
                    
                case "Poor":
                    return 1;
                default:
                    Console.WriteLine($"Unexpected feedback status: {feedbackStatus}");
                    return 0; // Example of returning a default value

            }

        }
       
    }
}