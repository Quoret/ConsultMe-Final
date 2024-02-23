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

            if (!IsPostBack)
            {
                if (Request.QueryString["LawyerID"] != null && Request.QueryString["ClientID"] != null)
                {
                    // Store LawyerID and ClientID in hidden fields
                    hidLawyerID.Value = Request.QueryString["LawyerID"];
                    hidClientID.Value = Request.QueryString["ClientID"];
                }
            }


            //fillTheDropdownLists();
        }


        protected void Submit_feedback_Click(object sender, EventArgs e)
        {
            if (checkLawyerExists())
            {
                submitUpdatedFeedback();
            }
            else
            {
                submitFeedback();
            }

        }
        void submitFeedback()
        {
            string lawyer_id = hidLawyerID.Value;
            string client_id = hidClientID.Value;
            string communication_availability = CommunicationAvailability.SelectedItem.Value;
            string communication_skills = CommunicationSkillsz.SelectedItem.Value;
            string experties = Experties.SelectedItem.Value;
            string time_flexibility = TimeFlexibility.SelectedItem.Value;
            string morality = Morality.SelectedItem.Value;
            string time_investment = TimeInvestment.SelectedItem.Value;
            string case_management = CaseManagement.SelectedItem.Value;
            string strategy = Strategy1.SelectedItem.Value;
            string price_charged = PriceCharged.SelectedItem.Value;
            string experience = Experience1.SelectedItem.Value;

            if (communication_availability == "Select" || communication_skills == "Select" || experties == "Select" || time_flexibility == "Select" || morality == "Select" || time_investment == "Select" || case_management == "Select" || strategy == "Select" || price_charged == "Select" || experience == "Select")
            {
                Response.Write("<script>alert('Please Select the appropriate Field');</script>");
            }
            else
            {
                int communicationAvailabilityRating = MapToNumericRating(communication_availability);
                int communicationSkillRating = MapToNumericRating(communication_skills);
                int expertiesRating = MapToNumericRating(experties);
                int flexibilityRating = MapToNumericRating(time_flexibility);
                int moralityRating = MapToNumericRating(morality);
                int timeInvestmentRating = MapToNumericRating(time_investment);
                int caseManagementRating = MapToNumericRating(case_management);
                int strategyRating = MapToNumericRating(strategy);
                int priceChargedRating = MapToNumericRating(price_charged);
                int experienceRating = MapToNumericRating(experience);
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("INSERT INTO ClientFeedback (ClientID,LawyerID,CommunicationAvailability,CommunicationSkills,Experties,TimeFlexibility,Morality,TimeInvestment,CaseManagement,Strategy,PriceCharged,Experience) VALUES (@ClientID,@LawyerID,@CommunicationAvailability,@CommunicationSkills,@Experties,@TimeFlexibility,@Morality,@TimeInvestment,@CaseManagement,@Strategy,@PriceCharged,@Experience) ", con);
                    cmd.Parameters.AddWithValue("@ClientID", client_id);
                    cmd.Parameters.AddWithValue("@LawyerID", lawyer_id);
                    cmd.Parameters.AddWithValue("@CommunicationAvailability", communicationAvailabilityRating);
                    cmd.Parameters.AddWithValue("@CommunicationSkills", communicationSkillRating);
                    cmd.Parameters.AddWithValue("@Experties", expertiesRating);
                    cmd.Parameters.AddWithValue("@TimeFlexibility", flexibilityRating);
                    cmd.Parameters.AddWithValue("@Morality", moralityRating);
                    cmd.Parameters.AddWithValue("@TimeInvestment", timeInvestmentRating);
                    cmd.Parameters.AddWithValue("@CaseManagement", caseManagementRating);
                    cmd.Parameters.AddWithValue("@Strategy", strategyRating);
                    cmd.Parameters.AddWithValue("@PriceCharged", priceChargedRating);
                    cmd.Parameters.AddWithValue("@Experience", experienceRating);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Feedback Submitted Sucessfully');</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }


            
        }
        void submitUpdatedFeedback()
        {
            string lawyer_id = hidLawyerID.Value;
            string client_id = hidClientID.Value;

            string communication_availability = CommunicationAvailability.SelectedItem.Value;
            string communication_skills = CommunicationSkillsz.SelectedItem.Value;
            string experties = Experties.SelectedItem.Value;
            string time_flexibility = TimeFlexibility.SelectedItem.Value;
            string morality = Morality.SelectedItem.Value;
            string time_investment = TimeInvestment.SelectedItem.Value;
            string case_management = CaseManagement.SelectedItem.Value;
            string strategy = Strategy1.SelectedItem.Value;
            string price_charged = PriceCharged.SelectedItem.Value;
            string experience = Experience1.SelectedItem.Value;

            if (communication_availability == "Select" || communication_skills == "Select" || experties == "Select" || time_flexibility == "Select" || morality == "Select" || time_investment == "Select" || case_management == "Select" || strategy == "Select" || price_charged == "Select" || experience == "Select")
            {
                Response.Write("<script>alert('Please Select the appropriate Field');</script>");
            }
            else
            {
                int communicationAvailabilityRating = MapToNumericRating(communication_availability);
                int communicationSkillRating = MapToNumericRating(communication_skills);
                int expertiesRating = MapToNumericRating(experties);
                int flexibilityRating = MapToNumericRating(time_flexibility);
                int moralityRating = MapToNumericRating(morality);
                int timeInvestmentRating = MapToNumericRating(time_investment);
                int caseManagementRating = MapToNumericRating(case_management);
                int strategyRating = MapToNumericRating(strategy);
                int priceChargedRating = MapToNumericRating(price_charged);
                int experienceRating = MapToNumericRating(experience);
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE ClientFeedback SET CommunicationAvailability=@CommunicationAvailability,CommunicationSkills=@CommunicationSkills,Experties=@Experties,TimeFlexibility=@TimeFlexibility,Morality=@Morality,TimeInvestment=@TimeInvestment,CaseManagement=@CaseManagement,Strategy=@Strategy,PriceCharged=@PriceCharged,Experience=@Experience WHERE LawyerID='" + lawyer_id + "'", con);
                    cmd.Parameters.AddWithValue("@CommunicationAvailability", communicationAvailabilityRating);
                    cmd.Parameters.AddWithValue("@CommunicationSkills", communicationSkillRating);
                    cmd.Parameters.AddWithValue("@Experties", expertiesRating);
                    cmd.Parameters.AddWithValue("@TimeFlexibility", flexibilityRating);
                    cmd.Parameters.AddWithValue("@Morality", moralityRating);
                    cmd.Parameters.AddWithValue("@TimeInvestment", timeInvestmentRating);
                    cmd.Parameters.AddWithValue("@CaseManagement", caseManagementRating);
                    cmd.Parameters.AddWithValue("@Strategy", strategyRating);
                    cmd.Parameters.AddWithValue("@PriceCharged", priceChargedRating);
                    cmd.Parameters.AddWithValue("@Experience", experienceRating);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Feedback Submitted Successfully');</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
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
        bool checkLawyerExists()
        {
            string lawyer_id = hidLawyerID.Value;
            string cliend_id = hidClientID.Value;
            try
            {
                string check;
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                check = "SELECT * FROM ClientFeedback WHERE LawyerID='" + lawyer_id + "' AND ClientID='" + cliend_id + "'";
                SqlCommand cmd = new SqlCommand(check, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }

        }
    }
}