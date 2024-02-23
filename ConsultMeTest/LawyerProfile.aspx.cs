using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Text.RegularExpressions;
using System.Web.Security;

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
            if (IstheContactNumberValid(Contact_Num.Text.Trim()))
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
            else
            {
                Response.Write("<script>alert('Please enter a valid phone number');</script>");
            }
            

        }
        void submitLawyerProfile()
        {
            string university = University.SelectedItem.Value;
            string state = StateDropdown.SelectedItem.Value;
            string district = DistrictDropdown.SelectedItem.Value;
            string membership = Membership.SelectedItem.Value;
            string achievements = Achievements.SelectedItem.Value;
            string experience = Experience.SelectedItem.Value;
            string education = Education.SelectedItem.Value;
            string triallawyer = TrialLawyer.SelectedItem.Value;
            string llanguage = language.SelectedItem.Value;
            string availabe = Available.SelectedItem.Value;
            string casecount=Case_count.Text.Trim();
            string consultationfee = ConsultingFee.Text.ToString().Trim();
            string availabledate = Available_date.Text.Trim();

            if (university == "Select" || state == "Select" || district == "Select" || membership == "Select" || achievements == "Select" || experience == "Select" || education == "Select" || triallawyer == "Select" || llanguage == "Select" || availabe == "Select" || string.IsNullOrWhiteSpace(casecount) || string.IsNullOrWhiteSpace(consultationfee) || string.IsNullOrWhiteSpace(availabledate))
            {
                Response.Write("<script>alert('Please Select the appropriate Field');</script>");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }


                    string query_SearchLawyer = "INSERT INTO SearchLawyerGridView(LawyerID,LawyerFullname,AreaOfExperties,Contact,District,CaseCount,AvailableDate)VALUES(@LawyerID,@LawyerFullname,@AreaOfExperties,@Contact,@District,@CaseCount,@AvailableDate)";
                    string query = "INSERT INTO LawyerAdditionalInfo (LawyerID,University,State,District,IsBarMember,Achievements,AreaOfExperties,YearsOfExperience,Education,IsTrialLawyer,Language,Contact,FirmName,Availability,Address,CaseCount,ConsultingFee,AvailableDate) VALUES (@LawyerID,@University,@State,@District,@IsBarMember,@Achievements,@AreaOfExperties,@YearsOfExperience,@Education,@IsTrialLawyer,@Language,@Contact,@FirmName,@Availability,@Address,@CaseCount,@ConsultingFee,@AvailableDate)";
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
                    cmd.Parameters.AddWithValue("@ConsultingFee", ConsultingFee.Text.Trim());//16
                    cmd.Parameters.AddWithValue("@AvailableDate", Available_date.Text.Trim());//17
                    cmd.ExecuteNonQuery();
                    con.Close();


                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmmd = new SqlCommand(query_SearchLawyer, con);
                    if (!string.IsNullOrEmpty(Session["LawyerId"] as string))
                    {
                        string lawyer_Fullname = Session["firstname"].ToString();
                        cmmd.Parameters.AddWithValue("@LawyerFullname", lawyer_Fullname);
                        int lawyerId;
                        if (int.TryParse(Session["LawyerId"].ToString(), out lawyerId))
                        {
                            cmmd.Parameters.AddWithValue("@LawyerID", lawyerId);
                        }
                    }
                    cmmd.Parameters.AddWithValue("@AreaOfExperties", Catagory.SelectedItem.Value);
                    cmmd.Parameters.AddWithValue("@District", DistrictDropdown.SelectedItem.Value);
                    cmmd.Parameters.AddWithValue("@Contact", Contact_Num.Text.Trim());
                    cmmd.Parameters.AddWithValue("@CaseCount", Case_count.Text.Trim());
                    cmmd.Parameters.AddWithValue("@AvailableDate", Available_date.Text.Trim());
                    cmmd.ExecuteNonQuery();
                    con.Close();



                    Response.Write("<script>alert('Profile submitted Successfully');</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
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
            string university = University.SelectedItem.Value;
            string state = StateDropdown.SelectedItem.Value;
            string district = DistrictDropdown.SelectedItem.Value;
            string membership = Membership.SelectedItem.Value;
            string achievements = Achievements.SelectedItem.Value;
            string experience = Experience.SelectedItem.Value;
            string education = Education.SelectedItem.Value;
            string triallawyer = TrialLawyer.SelectedItem.Value;
            string llanguage = language.SelectedItem.Value;
            string availabe = Available.SelectedItem.Value;
            string casecount = Case_count.Text.Trim();
            string consultationfee = ConsultingFee.Text.Trim();
            string availabledate= Available_date.Text.Trim();

            if (university == "Select" || state == "Select" || district == "Select" || membership == "Select" || achievements == "Select" || experience == "Select" || education == "Select" || triallawyer == "Select" || llanguage == "Select" || availabe == "Select" || string.IsNullOrWhiteSpace(casecount) || string.IsNullOrWhiteSpace(consultationfee) || string.IsNullOrWhiteSpace(availabledate))
            {
                Response.Write("<script>alert('Please Select the appropriate Field');</script>");
            }
            
            else
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
                            string query = "UPDATE LawyerAdditionalInfo SET University = @University,State = @State, District = @District,   IsBarMember = @IsBarMember  ,  Achievements = @Achievements,    AreaOfExperties = @AreaOfExperties,     YearsOfExperience = @YearsOfExperience,    Education = @Education,    IsTrialLawyer = @IsTrialLawyer,    Language = @Language,    Contact = @Contact,    FirmName = @FirmName,   Availability = @Availability,    Address = @Address,    CaseCount = @CaseCount,    ConsultingFee = @ConsultingFee,    AvailableDate = @AvailableDate WHERE LawyerID = " + lawyerId + "";
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
                            cmd.Parameters.AddWithValue("@ConsultingFee", ConsultingFee.Text.Trim());//16
                            cmd.Parameters.AddWithValue("@AvailableDate", Available_date.Text.Trim());//17
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    if (!string.IsNullOrEmpty(Session["LawyerId"] as string))
                    {
                        int lawyerId;
                        if (int.TryParse(Session["LawyerId"].ToString(), out lawyerId))
                        {
                            string Query_update_searchLawyer = "UPDATE SearchLawyerGridView SET AreaOfExperties=@AreaOfExperties,Contact=@Contact ,District=@District,CaseCount=@CaseCount,AvailableDate=@AvailableDate WHERE LawyerID='" + lawyerId + "' ";
                            SqlCommand cmmd = new SqlCommand(Query_update_searchLawyer, con);
                            cmmd.Parameters.AddWithValue("@District", DistrictDropdown.SelectedItem.Value);
                            cmmd.Parameters.AddWithValue("@AreaOfExperties", Catagory.SelectedItem.Value);//6
                            cmmd.Parameters.AddWithValue("@CaseCount", Case_count.Text.Trim());//15
                            cmmd.Parameters.AddWithValue("@Contact", Contact_Num.Text.Trim());//11
                            cmmd.Parameters.AddWithValue("@AvailableDate", Available_date.Text.Trim());//17

                            cmmd.ExecuteNonQuery();
                            con.Close();

                        }
                        Response.Write("<script>alert('Profile Updated Successfully');</script>");
                    }

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }

            
            
        }
        bool IstheContactNumberValid(string ContactNumber)
        {
            string pattern = @"^(984|985|986|974|975|976|980|981|982)\d{7}$";
            return Regex.IsMatch(ContactNumber, pattern);
        }
        
    }
}

           

