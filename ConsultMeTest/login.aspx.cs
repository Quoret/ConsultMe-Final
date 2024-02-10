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
    public partial class login : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            string query_user;
           // string query_lawyer;
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State ==ConnectionState.Closed)
                {
                    con.Open();
                }
                query_user = "SELECT *FROM Client where ClientUsername='" + Username.Text.Trim() + "' AND ClientPassword='" + Password.Text.Trim() + "'";
                //query_lawyer = "SELECT *FROM lawyerGeneralinfo where l_username='" + Username.Text.Trim() + "' AND password='" + Password + "'";
                SqlCommand cmd_U = new SqlCommand(query_user, con); // for user
               // SqlCommand cmd_L = new SqlCommand(query_lawyer, con);// for lawyer
                SqlDataReader dr_U = cmd_U.ExecuteReader();
               // SqlDataReader dr_L = cmd_L.ExecuteReader();
                if (dr_U.HasRows)
                {
                    while (dr_U.Read())
                    {
                        Response.Write("<script>alert('Login Sucessful');</script>");
                        Session["ClientId"] = dr_U.GetValue(0).ToString();
                        Session["username"] = dr_U.GetValue(3).ToString();
                        Session["fullname"]=dr_U.GetValue(1).ToString();
                        Session["role"] = "client";
                    }
                    Response.Redirect("Homepage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid Credentials');</script>");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}