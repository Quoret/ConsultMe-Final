﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace ConsultMeTest
{
    public partial class LawyerProfile : System.Web.UI.Page
    {
        string strcon= ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_profile_Click(object sender, EventArgs e)
        {
            if (checkIfLawyerIdExists())
            {
                updateLawyerProfile();
            }
            else
            {
                submitLawyerProfile();
            }

        }
        void submitLawyerProfile()
        {
            try
            {
                //if (Session["lawyerId"]!=null)
                //{
                //    string lawyer_ID = (String)Session["lawyerId"];
                //}
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "INSERT INTO LawyerAdditionalInfo (LawyerID,University,State,District,IsBarMember,Achievements,AreaOfExperties,YearsOfExperience,Education,IsTrialLawyer,Language,Contact,FirmName,Availability,Address,CaseCount,CaseWon,AvailableDate) VALUES (@LawyerID,@University,@State,@District,@IsBarMember,@Achievements,@AreaOfExperties,@YearsOfExperience,@Education,@IsTrialLawyer,@Language,@Contact,@FirmName,@Availability,@Address,@CaseCount,@CaseWon,@AvailableDate)";
                SqlCommand cmd = new SqlCommand(query, con);
                if (!string.IsNullOrEmpty(Session["LawyerId"] as string))
                {
                    int lawyerId;
                    if (int.TryParse(Session["LawyerId"].ToString(), out lawyerId))
                    {
                        cmd.Parameters.AddWithValue("@LawyerID", lawyerId);
                    }
                }

                // cmd.Parameters.AddWithValue("@LawyerID",(int)Session["lawyerId"]);

                cmd.Parameters.AddWithValue("@University", University.SelectedItem.Value);//1
                cmd.Parameters.AddWithValue("@State", StateDropdown.SelectedItem.Value);//2 
                cmd.Parameters.AddWithValue("@District", DistrictDropdown.SelectedItem.Value);//3
                cmd.Parameters.AddWithValue("@IsBarMember", Membership.SelectedItem.Value);//4   
                cmd.Parameters.AddWithValue("@Achievements", Achievements.SelectedItem.Value);//5
                cmd.Parameters.AddWithValue("@AreaOfExperties", Catagory.SelectedItem.Value);//6
                cmd.Parameters.AddWithValue("@YearsOfExperience", Experience.SelectedItem.Value);//7
                cmd.Parameters.AddWithValue("@Education", Education.SelectedItem.Value);//8
                cmd.Parameters.AddWithValue("@IsTrialLawyer", TrialLawyer.SelectedItem.Value);//9
                cmd.Parameters.AddWithValue("@Language", language.SelectedItem.Value);//10
                cmd.Parameters.AddWithValue("@Availability", Available.SelectedItem.Value);//13
                cmd.Parameters.AddWithValue("@Contact", Contact_Num.Text.Trim());//11
                cmd.Parameters.AddWithValue("@FirmName", Firm_name.Text.Trim());//12               
                cmd.Parameters.AddWithValue("@Address", Office_Address.Text.Trim());//14
                cmd.Parameters.AddWithValue("@CaseCount", Case_count.Text.Trim());//15
                cmd.Parameters.AddWithValue("@CaseWon", Case_won.Text.Trim());//16
                cmd.Parameters.AddWithValue("@AvailableDate", Available_date.Text.Trim());//17
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Profile submitted Successfully');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        bool checkIfLawyerIdExists()
        {
            //try
            //{
            //    using (SqlConnection con = new SqlConnection(strcon))
            //    {
            //        con.Open();
            //        if (!string.IsNullOrEmpty(Session["LawyerId"] as string) && int.TryParse(Session["LawyerId"].ToString(), out int lawyerId))
            //        {
            //            string check_query = "SELECT * FROM LawyerAdditionalInfo WHERE LawyerID= "+lawyerId+"";
            //            SqlCommand cmd = new SqlCommand(check_query, con);
            //            // cmd.Parameters.AddWithValue("@LawyerID", lawyerId);
            //            SqlDataAdapter da = new SqlDataAdapter(cmd);                           
            //            DataTable dt = new DataTable();
            //            da.Fill(dt);
            //            if(dt.Rows.Count > 0)
            //            {
            //                return true;
            //            }
            //            else
            //            {
            //                return false;
            //            }             
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Response.Write("<script>alert('" + ex.Message + "');</script>");
            //    return false;
            //}
            int lawyerId;
            if (Session["LawyerId"] != null && int.TryParse(Session["LawyerId"].ToString(), out lawyerId))
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    else { return false; }

                    string query = "SELECT COUNT(*) AS TotalCount FROM [ConsultMeDB].[dbo].[LawyerAdditionalInfo] WHERE LawyerID = @LawyerID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LawyerID", lawyerId);

                    int totalCount = (int)cmd.ExecuteScalar(); // ExecuteScalar returns a single value (in this case, the count)
                    con.Close();

                    // Now you can use totalCount as needed
                    if (totalCount > 0)
                    {
                        // There are records for the specified LawyerID
                        //Response.Write("<script>alert('There are records for the specified LawyerID');</script>");
                        return true;
                    }
                    else
                    {
                        // There are no records for the specified LawyerID
                       // Response.Write("<script>alert('There are no records for the specified LawyerID');</script>");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                    return false;
                }
            }
            else
            {
                // Handle the case where the session does not contain a valid LawyerID
                Response.Write("<script>alert('Invalid LawyerID in session');</script>");
                return false;
            }
        }
        void updateLawyerProfile()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (!string.IsNullOrEmpty(Session["LawyerId"] as string))
                {
                    int lawyerId;
                    if (int.TryParse(Session["LawyerId"].ToString(), out lawyerId))
                    {
                        string query = "UPDATE LawyerAdditionalInfo SET University = @University,State = @State, District = @District,   IsBarMember = @IsBarMember  ,  Achievements = @Achievements,    AreaOfExperties = @AreaOfExperties,     YearsOfExperience = @YearsOfExperience,    Education = @Education,    IsTrialLawyer = @IsTrialLawyer,    Language = @Language,    Contact = @Contact,    FirmName = @FirmName,   Availability = @Availability,    Address = @Address,    CaseCount = @CaseCount,    CaseWon = @CaseWon,    AvailableDate = @AvailableDate WHERE LawyerID = " + lawyerId + "";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@University", University.SelectedItem.Value);//1
                        cmd.Parameters.AddWithValue("@State", StateDropdown.SelectedItem.Value);//2 
                        cmd.Parameters.AddWithValue("@District", DistrictDropdown.SelectedItem.Value);//3
                        cmd.Parameters.AddWithValue("@IsBarMember", Membership.SelectedItem.Value);//4   
                        cmd.Parameters.AddWithValue("@Achievements", Achievements.SelectedItem.Value);//5
                        cmd.Parameters.AddWithValue("@AreaOfExperties", Catagory.SelectedItem.Value);//6
                        cmd.Parameters.AddWithValue("@YearsOfExperience", Experience.SelectedItem.Value);//7
                        cmd.Parameters.AddWithValue("@Education", Education.SelectedItem.Value);//8
                        cmd.Parameters.AddWithValue("@IsTrialLawyer", TrialLawyer.SelectedItem.Value);//9
                        cmd.Parameters.AddWithValue("@Language", language.SelectedItem.Value);//10
                        cmd.Parameters.AddWithValue("@Availability", Available.SelectedItem.Value);//13
                        cmd.Parameters.AddWithValue("@Contact", Contact_Num.Text.Trim());//11
                        cmd.Parameters.AddWithValue("@FirmName", Firm_name.Text.Trim());//12               
                        cmd.Parameters.AddWithValue("@Address", Office_Address.Text.Trim());//14
                        cmd.Parameters.AddWithValue("@CaseCount", Case_count.Text.Trim());//15
                        cmd.Parameters.AddWithValue("@CaseWon", Case_won.Text.Trim());//16
                        cmd.Parameters.AddWithValue("@AvailableDate", Available_date.Text.Trim());//17
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Response.Write("<script>alert('Profile Updated Successfully');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
            
        }
    }
}
           
