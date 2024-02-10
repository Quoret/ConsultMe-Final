<%@ Page Title="" Language="C#" MasterPageFile="~/Consult.Master" AutoEventWireup="true" CodeBehind="LawyerRegistration.aspx.cs" Inherits="ConsultMeTest.LawyerRegistration" %>

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
                                    <h2>Lawyer Registration</h2>
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
                                <label>Fullname</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="L_Fullname" runat="server" placeholder="Fullname" BackColor="White" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
                                </div>
                                <label>Email</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="L_Email" runat="server" placeholder="Email" BorderStyle="Solid" BorderColor="Black" BackColor="White" TextMode="Email"></asp:TextBox>
                                </div>
                                <label>Username</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="L_Username" runat="server" placeholder="Username" BackColor="White" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
                                </div>
                                <label>Password</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="L_Password" runat="server" placeholder="Password" TextMode="Password" BorderStyle="Ridge" BorderColor="Black" BackColor="White"></asp:TextBox>
                                </div>
                                <label>Confirm Password</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="L_conPassword" runat="server" placeholder="Confirm Password" TextMode="Password" BackColor="White" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Register" runat="server" Text="Register Now" OnClick="Register_Click" />
                                </div>

                            </div>
                        </div>
                        <p class="font-weight-bold">Already have an account?<a href="Login.aspx">Login now</a></p>
                    </div>


                </div>

                <br>
            </div>
        </div>
    </div>
</asp:Content>
