using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsultMeTest
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //register button clicked
        protected void Register_Click(object sender, EventArgs e)
        {
            if(checkUserExists())
            {
                Response.Write("<script>alert('Username already exists !!');</script>");
            }
            else 
            {
                
                if(checkPasswordMatch())
                {
                    if (IsthePasswordValid(U_conPassword.Text.Trim()))
                    {
                        newUserSignUp();
                        Response.Redirect("login.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Password must include atleast on Capital letter and special character and minimum length 8');</script>");

                    }

                }
                else
                {
                    Response.Write("<script>alert('Password doesnot match!!');</script>");
                }
                
                
            }
            
        }

        void newUserSignUp()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO Client(ClientFullname,ClientEmail,ClientUsername,ClientPassword) values(@ClientFullname,@ClientEmail,@ClientUsername,@ClientPassword) ", con);
                cmd.Parameters.AddWithValue("@ClientFullname", U_Fullname.Text.Trim());
                cmd.Parameters.AddWithValue("@ClientEmail", U_Email.Text.Trim());
                cmd.Parameters.AddWithValue("@ClientUsername", U_Username.Text.Trim());
                cmd.Parameters.AddWithValue("@ClientPassword", U_conPassword.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Sign up successful. Login now !!');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        bool checkUserExists()
        {
            try
            {
                string check;
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                check = "SELECT * FROM Client WHERE ClientUsername='" + U_Username.Text.Trim() + "' ";
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
            if(U_Password.Text.Trim()==U_conPassword.Text.Trim())
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        bool IsthePasswordValid(string password)
        {
            string pattern = @"^(?=.*[!@#$%^&*()])(?=.*[A-Z])(?=.*\d).{8,}$";

            return Regex.IsMatch(password, pattern);
        }
    }
}