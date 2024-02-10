<%@ Page Title="" Language="C#" MasterPageFile="~/Consult.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ConsultMeTest.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <div class="container">
         
      <div class="row">
         <div class="col-md-6 mx-auto">
             <br>
            <div class="card">
               <div class="card-body">
                 
                  <div class="row">
                     <div class="col">
                        <center>
                           <h2 class="font-weight-bold">Client Login</h2>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <label>Username</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Username" runat="server" placeholder="Username"></asp:TextBox>
                        </div>
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="Password" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button class="btn btn-success btn-block btn-lg" ID="Login" runat="server" Text="Login" OnClick="Login_Click" />
                        </div>
                        <div class="form-group">
                            <p class="font-weight-bold">Not a member?
                           <a href="UserRegistration.aspx"><input class="btn btn-info btn-block btn-lg" id="Button2" type="button" value="Sign Up" /></a></p>
                        </div>
                     </div>
                  </div>
               </div>
            </div>
            <a href="Homepage.aspx"><< Back to Home</a><br><br>
         </div>
      </div>
   </div>



</asp:Content>
