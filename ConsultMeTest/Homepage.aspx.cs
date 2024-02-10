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
        
        protected void Similar_lawyer_Click(object sender, EventArgs e)
        {
            

        }

        protected void SearchRequirement_Click(object sender, EventArgs e)
        {

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
    }

    
}