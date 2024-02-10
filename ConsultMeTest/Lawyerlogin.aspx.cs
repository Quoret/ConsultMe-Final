using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.EnterpriseServices.CompensatingResourceManager;

namespace ConsultMeTest
{
    public partial class Lawyerlogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void law_Login_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if(con.State==ConnectionState.Closed)
                {
                    con.Open(); 
                }
                SqlCommand cmd = new SqlCommand("SELECT *FROM Lawyer WHERE LawyerUsername='" + l_Username.Text.Trim() + "'AND LawyerPassword='" + l_Password.Text.Trim() + "'", con);
                SqlDataReader dr= cmd.ExecuteReader();  
                if(dr.HasRows) 
                {
                    while(dr.Read())
                    {
                        Response.Write("<Script>alert('Login successful !!');</script>");
                        Session["LawyerId"] = dr.GetValue(0).ToString();
                        Session["firstname"] = dr.GetValue(1).ToString();
                        Session["username"] = dr.GetValue(3).ToString();                      
                        Session["role"] = "lawyer";
                    }
                    Response.Write("< script > alert('" + Session["lawyerId"] +"');</ script > ");
                    Response.Redirect("Homepage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid Credentials !!');</script>");
                }


            }
            catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{ex.Message}');");
            }
        }
       
    }

}
