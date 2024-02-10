using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsultMeTest
{
    public partial class LawyerRegistration : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            if (checkLawyerExists())
            {
                Response.Write("<script>alert('Username already exists !!');</script>");
            }
            else
            {
                if (checkPasswordMatch())
                {
                    newLawyerSignUp();
                }
                else
                {
                    Response.Write("<script>alert('Password doesnot match!!');</script>");
                }

            }
        }
        void newLawyerSignUp()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("INSERT INTO Lawyer (LawyerFullname,LawyerEmail,LawyerUsername,LawyerPassword) values(@LawyerFullname,@LawyerEmail,@LawyerUsername,@LawyerPassword) ", con);
                
                cmd.Parameters.AddWithValue("@LawyerFullname", L_Fullname.Text.Trim());
                    cmd.Parameters.AddWithValue("@LawyerEmail", L_Email.Text.Trim());
                    cmd.Parameters.AddWithValue("@LawyerUsername", L_Username.Text.Trim());
                    cmd.Parameters.AddWithValue("@LawyerPassword", L_conPassword.Text.Trim());
                    cmd.ExecuteNonQuery();
                con.Close();
                    Response.Write("<script>alert('Sign up successful. Login now !!');</script>");
                
               

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        bool checkLawyerExists()
        {
            try
            {
                string check;
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                check = "SELECT * FROM Lawyer WHERE LawyerUsername='" + L_Username.Text.Trim() + "' ";
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
        bool checkPasswordMatch()
        {
            if (L_Password.Text.Trim() == L_conPassword.Text.Trim())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}