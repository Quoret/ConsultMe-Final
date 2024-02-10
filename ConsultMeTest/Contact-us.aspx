<%@ Page Title="" Language="C#" MasterPageFile="~/Consult.Master" AutoEventWireup="true" CodeBehind="Contact-us.aspx.cs" Inherits="ConsultMeTest.Contact_us" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- contact section start -->
      <div class="contact_section layout_padding">
         <div class="container">
            <div class="row">
               <div class="col-sm-12">
                  <h1 class="contact_taital">Contact us</h1>
               </div>
            </div>
            <div class="contact_section_2">
               <div class="row">
                  <div class="col-md-12">
                     <div class="mail_section map_form_container">
                        <form action="">
                        <input type="text" class="mail_text" placeholder="Name" name="Name">
                        <input type="text" class="mail_text" placeholder="Phone Number" name="Phone Number"> 
                        <input type="text" class="mail_text" placeholder="Your Email" name="Your Email">
                        <textarea class="massage-bt" placeholder="Massage" rows="5" id="comment" name="Massage"></textarea>
                        <div class="send_bt active"><a href="#">Send Now</a></div>
                        </form>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
</asp:Content>
