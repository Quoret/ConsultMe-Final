using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsultMeTest
{
    public partial class Homepage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                bool isClientLoggedIn = IsClientLoggedIn();
                SearchLawyer.Visible = isClientLoggedIn;
                SimilarLawyer.Visible = isClientLoggedIn;
                SearchRequirement.Visible = isClientLoggedIn;
            }



        }
        protected void SearchLawyer_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchLawyer.aspx");
        }
        bool IsClientLoggedIn()
        {
            // Check if the session variable "role" is set to "client"
            return Session["role"] != null && (string)Session["role"] == "client";
        }

        protected void SearchRequirement_Click1(object sender, EventArgs e)
        {
            Response.Redirect("UserRequirement.aspx");
        }

        protected void SimilarLawyer_Click(object sender, EventArgs e)
        {
            Response.Redirect("SimilarLawyer.aspx");

        }
    }

    
}