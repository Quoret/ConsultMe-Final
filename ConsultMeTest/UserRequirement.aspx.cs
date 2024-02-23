using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsultMeTest
{
    public partial class UserRequirement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_requirement_Click(object sender, EventArgs e)
        {
            SubmitNewRequirement();

        }
        void SubmitNewRequirement()
        {
                string lawyer_catagory = LawyerCatagory.SelectedItem.Value;
                
                string communication_between2 = communicationBetween2.SelectedItem.Value;
                string communication_between = CommunicationBetween.SelectedItem.Value;
                string case_difficulty = CaseDifficulty.SelectedItem.Value;
                string time_flexibility = TimeFLexibility.SelectedItem.Value;
                string type_of_help = TypeOfHelp.SelectedItem.Value;
                string time_duration = TimeDuration.SelectedItem.Value;
                string case_sensitivity = CaseSensitivity.SelectedItem.Value;
                string lawyer_creativity = LawyerCreativity.SelectedItem.Value;
                string cost_range = CostRange.SelectedItem.Value;
                string experience = Experience.SelectedItem.Value;
            if (lawyer_catagory == "Select" || communication_between2 == "Select" || communication_between == "Select" || case_difficulty == "Select" || time_flexibility == "Select" || type_of_help == "Select" || time_duration == "Select" || case_sensitivity == "Select" || lawyer_creativity == "Select" || cost_range == "Select" || experience == "Select")
            {
                Response.Write("<script>alert('Please Select the appropriate Field');</script>");
            }
            else
            {
                int communication_between2Rating = MapToNumericRating(communication_between2);
                int communication_betweenRating = MapToNumericRating(communication_between);
                int case_difficultyRating = MapToNumericRating(case_difficulty);
                int time_flexibilityRating = MapToNumericRating(time_flexibility);
                int type_of_helpRating = MapToNumericRating(type_of_help);
                int time_durationRating = MapToNumericRating(time_duration);
                int case_sensitivityRating = MapToNumericRating(case_sensitivity);
                int lawyer_creativityRating = MapToNumericRating(lawyer_creativity);
                int cost_rangeRating = MapToNumericRating(cost_range);
                int experienceRating = MapToNumericRating(experience);

                try
                {
                    
                    string filterByCatagoryQuery = "SELECT LawyerAdditionalInfo.AreaOfExperties FROM LawyerAdditionalInfo INNER JOIN Similarityindex ON LawyerAdditionalInfo.LawyerID=Similarityindex.LawyerID WHERE LawyerAdditionalInfo.AreaOfExperties='" + lawyer_catagory + "'";
                    string delete_table = "DELETE FROM SimilarityIndex";
                    string extract_lawyer_id = "Select top 5 FROM similarityindex order by similarity_index desc";
                    // string extract_lawyer_info = "SELECT * FROM Lawyer JOIN similarityindex ON similarityindex.LawyerID = Lawyer.LawyerID where lawyerID ='"++ "' ";
                    string insert_result = "INSERT INTO SimilarityIndex (Similarity_index,LawyerID) VALUES(@Similarity_index,@LawyerID)";
                    string NumberQuery = "SELECT COUNT(*)  FROM ClientFeedback";
                    string extractQuery = "SELECT LawyerID,AVG(CommunicationAvailability) AS AvgCommunicationAvailability,AVG(CommunicationSkills) AS AvgCommunicationSkills,AVG(Experties) AS AvgExperties, AVG(TimeFlexibility) AS AvgTimeFlexibility, AVG(Morality) AS AvgMorality, AVG(TimeInvestment) AS AvgTimeInvestment, AVG(CaseManagement) AS AvgCaseManagement, AVG(Strategy) AS AvgStrategy, AVG(PriceCharged) AS AvgPriceCharged, AVG(Experience) AS AvgExperience FROM ClientFeedback GROUP BY LawyerID;";
                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(delete_table, con);
                        cmd.ExecuteNonQuery();
                        SqlCommand cmd2 = new SqlCommand(NumberQuery, con);
                        //int rowCount = (int)cmd2.ExecuteScalar();
                        SqlCommand sqlCommand = new SqlCommand(extractQuery, con);
                        SqlDataAdapter adapter= new SqlDataAdapter(sqlCommand);
                       // SqlDataAdapter adapter = new SqlDataAdapter(extractQuery, con);

                        // Create a DataTable to store the retrieved data
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Do something with the retrieved data
                        SqlCommand cmd3 = new SqlCommand(insert_result, con);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            cmd3.Parameters.Clear();

                            int LawyerID2 = Convert.ToInt32(row["LawyerID"]);
                            double val1 = Convert.ToDouble(row["AvgCommunicationAvailability"]);
                            double val2 = Convert.ToDouble(row["AvgCommunicationSkills"]);
                            double val3 = Convert.ToDouble(row["AvgExperties"]);
                            double val4 = Convert.ToDouble(row["AvgTimeFlexibility"]);
                            double val5 = Convert.ToDouble(row["AvgMorality"]);
                            double val6 = Convert.ToDouble(row["AvgTimeInvestment"]);
                            double val7 = Convert.ToDouble(row["AvgCaseManagement"]);
                            double val8 = Convert.ToDouble(row["AvgStrategy"]);
                            double val9 = Convert.ToDouble(row["AvgPriceCharged"]);
                            double val10 = Convert.ToDouble(row["AvgExperience"]);


                            double average1 = mean(val1, val2, val3, val4, val5, val6, val7, val8, val9, val10);
                            double average2 = mean(communication_between2Rating, communication_betweenRating, case_difficultyRating, time_flexibilityRating, type_of_helpRating, time_durationRating, case_sensitivityRating, lawyer_creativityRating, cost_rangeRating, experienceRating);
                            val1 = Normalized(val1, average1);
                            val2 = Normalized(val2, average1); val3 = Normalized(val3, average1); val4 = Normalized(val4, average1); val5 = Normalized(val5, average1);
                            val6 = Normalized(val6, average1); val7 = Normalized(val7, average1); val8 = Normalized(val8, average1); val9 = Normalized(val9, average1); val10 = Normalized(val10, average1);
                            double value1 = Normalized(communication_between2Rating, average2);
                            double value2 = Normalized(communication_betweenRating, average2);
                            double value3 = Normalized(case_difficultyRating, average2);
                            double value4 = Normalized(time_flexibilityRating, average2);
                            double value5 = Normalized(type_of_helpRating, average2);
                            double value6 = Normalized(time_durationRating, average2);
                            double value7 = Normalized(case_sensitivityRating, average2);
                            double value8 = Normalized(lawyer_creativityRating, average2);
                            double value9 = Normalized(cost_rangeRating, average2);
                            double value10 = Normalized(experienceRating, average2);
                            double mag_aft_norm1 = magnitude(val1, val2, val3, val4, val5, val6, val7, val8, val9, val10);
                            double mag_aft_norm2 = magnitude(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
                            double uppervalue = (val1 * value1) + (val2 * value2) + (val3 * value3) + (val4 * value4) + (val5 * value5) + (val6 * value6) + (val7 * value7) + (val8 * value8) + (val9 * value9) + (val10 * value10);
                            double similarity_score = (uppervalue / (mag_aft_norm1 * mag_aft_norm2));
                            cmd3.Parameters.AddWithValue("@Similarity_index", similarity_score);
                            cmd3.Parameters.AddWithValue("@LawyerId", LawyerID2);
                            cmd3.ExecuteNonQuery();
                            SqlCommand cmd4 = new SqlCommand(extract_lawyer_id, con);

                        }
                        double Normalized(double value, double avg)
                        {
                            double answer;
                            answer = (value - avg);
                            return answer;

                        }
                        double magnitude(double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8, double val9, double val10)
                        {
                            double answer;
                            answer = Math.Sqrt((val1 * val1) + (val2 * val2) + (val3 * val3) + (val4 * val4) + (val5 * val5) + (val6 * val6) + (val7 * val7) + (val8 * val8) + (val9 * val9) + (val10 * val10));
                            return answer;
                        }
                        double mean(double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8, double val9, double val10)
                        {
                            double answer = ((val1 + val2 + val3 + val4 + val5 + val6 + val7 + val8 + val9 + val10) / 10);
                            return answer;
                        }


                        con.Close();
                        Response.Write("<script>alert('Requirement Submitted');</script>");
                        Response.Redirect($"LawyerRecommender.aspx?AreaOfExpertise={lawyer_catagory}",false);
                        Context.ApplicationInstance.CompleteRequest();
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception
                    Response.Write($"An error occurred: {ex.Message}");
                }
            }

            
        }
        //void NewTableForRecommendation()
        //{
        //    string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        //    try
        //    {
        //        string retrieveQuery = "SELECT\r\n    Similarityindex.Similarity_index,\r\n    Similarityindex.LawyerID,\r\n    Lawyer.LawyerFullname,\r\n    LawyerAdditionalInfo.AreaOfExperties,\r\n    LawyerAdditionalInfo.Contact,\r\n    LawyerAdditionalInfo.District,\r\n    LawyerAdditionalInfo.CaseCount,\r\n    LawyerAdditionalInfo.AvailableDate\r\nFROM\r\n    Similarityindex\r\n    INNER JOIN Lawyer ON Similarityindex.LawyerID = Lawyer.LawyerID\r\n    INNER JOIN LawyerAdditionalInfo ON LawyerAdditionalInfo.LawyerID = Similarityindex.LawyerID\r\nORDER BY\r\n    Similarityindex.Similarity_index DESC;\r\n";

        //    }
        //    catch( Exception ex ) { }
        //}
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
                    return 0;

            }


        }


    }
}