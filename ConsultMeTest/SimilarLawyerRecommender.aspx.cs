using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsultMeTest
{
    public partial class SimilarLawyerRecommender : System.Web.UI.Page
    {
        string strcon1 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Request.QueryString["LawyerID"] != null)
                {
                    // Store LawyerID and ClientID in hidden fields
                    HiddenField1.Value = Request.QueryString["LawyerID"];

                }
            }



            string lawyer_id = HiddenField1.Value;
            string DeleteQuery = "DELETE  FROM ContentBased";
            string NumberQuery = "SELECT COUNT(*)  FROM Lawyer";
            string extractQuery = "SELECT Lawyer.LawyerID AS LawyerID1,University AS University1,State as State1, District as District1,AreaOfExperties as AreaOfExperties1,YearsOfExperience as YearsOfExperience1 from Lawyer INNER JOIN LawyerAdditionalInfo on Lawyer.LawyerID=LawyerAdditionalInfo.LawyerID";
            string extractQuery2 = "SELECT Lawyer.LawyerID AS LawyerID2,University AS University2,State as State2, District as District2,AreaOfExperties as AreaOfExperties2,YearsOfExperience as YearsOfExperience2 from Lawyer INNER JOIN LawyerAdditionalInfo on Lawyer.LawyerID=LawyerAdditionalInfo.LawyerID where Lawyer.LawyerID='" + lawyer_id + "'";
            string insertResult = "INSERT INTO ContentBased (LawyerID,RatingNumber) VALUES (@LawyerID,@RatingNumber)";
            using (SqlConnection con = new SqlConnection(strcon1))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(NumberQuery, con);
                SqlCommand cmd2 = new SqlCommand(extractQuery2, con);
                SqlCommand cmd3 = new SqlCommand(insertResult, con);
                SqlCommand cmd4 = new SqlCommand(DeleteQuery, con);
                cmd4.ExecuteNonQuery();
                SqlDataReader reader = cmd2.ExecuteReader();
                int lawyerID2 = 0;
                string university2 = null;
                string state2 = null;
                string district2 = null;
                string areaOfExperties2 = null;
                string yearsOfExperience2 = null;
                // Check if there are rows returned
                if (reader.Read())
                {
                    // Read values from the reader and store them in variables
                    lawyerID2 = Convert.ToInt32(reader["LawyerID2"]);

                    university2 = reader["University2"].ToString();
                    state2 = reader["State2"].ToString();
                    district2 = reader["District2"].ToString();
                    areaOfExperties2 = reader["AreaOfExperties2"].ToString();
                    yearsOfExperience2 = reader["YearsOfExperience2"].ToString();

                    // Now you can use these variables as needed

                }

                reader.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(extractQuery, con);

                // Create a DataTable to store the retrieved data
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                foreach (DataRow row in dataTable.Rows)
                {
                    cmd3.Parameters.Clear();
                    int lawyerID1 = Convert.ToInt32(row["LawyerID1"]);
                    string university1 = row["University1"].ToString();
                    string state1 = row["State1"].ToString();
                    string district1 = row["District1"].ToString();
                    string areaOfExperties1 = row["AreaOfExperties1"].ToString();
                    string yearsOfExperience1 = row["YearsOfExperience1"].ToString();
                    while (lawyerID1 != lawyerID2)
                    {
                        while (areaOfExperties1 == areaOfExperties2)
                        {
                            while ((district1 == district2) && state2 == state1)
                            {
                                cmd3.Parameters.Clear();
                                if (university1 == university2 && areaOfExperties1 == areaOfExperties2 && yearsOfExperience1 == yearsOfExperience2)
                                {
                                    cmd3.Parameters.AddWithValue("@LawyerID", lawyerID1);
                                    cmd3.Parameters.AddWithValue("@RatingNumber", 5);
                                    cmd3.ExecuteNonQuery();
                                }
                                else if ((university1 == university2 && areaOfExperties1 == areaOfExperties2) || (university1 == university2 && yearsOfExperience1 == yearsOfExperience2) || (areaOfExperties1 == areaOfExperties2 && yearsOfExperience1 == yearsOfExperience2))
                                {
                                    cmd3.Parameters.AddWithValue("@LawyerID", lawyerID1);
                                    cmd3.Parameters.AddWithValue("@RatingNumber", 4);
                                    cmd3.ExecuteNonQuery();
                                }

                                else if (university1 == university2 || areaOfExperties1 == areaOfExperties2 || yearsOfExperience1 == yearsOfExperience2)
                                {
                                    cmd3.Parameters.AddWithValue("@LawyerID", lawyerID1);
                                    cmd3.Parameters.AddWithValue("@RatingNumber", 3);
                                    cmd3.ExecuteNonQuery();
                                }
                                else
                                {
                                    cmd3.Parameters.AddWithValue("@LawyerID", lawyerID1);
                                    cmd3.Parameters.AddWithValue("@RatingNumber", 2);
                                    cmd3.ExecuteNonQuery();
                                }
                                break;
                            }
                            break;
                        }
                        break;
                    }



                }

                string similarQuery = "SELECT top 5 ContentBased.LawyerID,Lawyer.LawyerFullname,LawyerAdditionalInfo.AreaOfExperties,LawyerAdditionalInfo.Contact,LawyerAdditionalInfo.District,LawyerAdditionalInfo.CaseCount,LawyerAdditionalInfo.AvailableDate,LawyerAdditionalInfo.Availability FROM ContentBased INNER JOIN Lawyer ON ContentBased.LawyerID = Lawyer.LawyerID INNER JOIN LawyerAdditionalInfo ON LawyerAdditionalInfo.LawyerID = ContentBased.LawyerID ORDER BY ContentBased.RatingNumber DESC";
                SqlCommand cmmd = new SqlCommand(similarQuery, con);
                SqlDataAdapter da = new SqlDataAdapter(cmmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SimilarLawyerRecommend.DataSource=dt;
                SimilarLawyerRecommend.DataBind();

            }

        }
        protected void SimilarLawyerRecommend_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            HyperLink lawyerLink = new HyperLink();
            lawyerLink.Text = e.Row.Cells[1].Text;
            lawyerLink.NavigateUrl = "~/UserFeedback.aspx?LawyerID=" + e.Row.Cells[0].Text + "&ClientID=" + Session["ClientId"]; // Assuming the LawyerID is in the first cell
            e.Row.Cells[1].Controls.Add(lawyerLink);

        }
    }

}