using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsultMeTest
{
    public partial class Consult : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Session.Add("role", "All");

                //if (Session["role"].Equals(""))
                //{
                //    client_Login.Visible = true;
                //    lawyer_login.Visible = true;
                //    Logout.Visible = false;
                //    UpdateProfile.Visible = false;
                //    Hello.Visible = false;


                //}
                if (Session["role"] != null && Session["role"].ToString()=="client")
                {
                    client_Login.Visible = false;
                    lawyer_login.Visible = false;
                    Logout.Visible = true;
                    UpdateProfile.Visible = false;
                    Hello.Visible = true;
                    Hello.Text = "Hello " + Session["username"].ToString();
                }
                else if (Session["role"] != null && Session["role"].ToString() == "lawyer")
                {
                    client_Login.Visible = false;
                    lawyer_login.Visible = false;
                    Logout.Visible = true;
                    UpdateProfile.Visible = true;
                    Hello.Visible = true;
                    Hello.Text = "Hello " + Session["username"].ToString();

                }
                else
                {
                    client_Login.Visible = true;
                    lawyer_login.Visible = true;
                    Logout.Visible = false;
                    UpdateProfile.Visible = false;
                    Hello.Visible = false;
                }

            }
            catch (Exception ex)
            {

            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            client_Login.Visible = true;
            lawyer_login.Visible = true;
            Logout.Visible = false;
            Hello.Visible = false;
            Response.Redirect("Homepage.aspx");
            
        }

        protected void client_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }



        protected void lawyer_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Lawyerlogin.aspx");
        }

        protected void UpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("LawyerProfile.aspx");
        }
    }
}