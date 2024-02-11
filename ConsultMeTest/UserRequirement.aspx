<%@ Page Title="" Language="C#" MasterPageFile="~/Consult.Master" AutoEventWireup="true" CodeBehind="UserRequirement.aspx.cs" Inherits="ConsultMeTest.UserRequirement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .search-button {
            padding: 10px 20px;
            background-color: aquamarine;
            color: #fff;
            font-size: 18px;
            border: thin;
            border-radius: 5px;
            box-shadow: 4px 8px 10px rgba(0, 0, 0, 0.3);
            cursor: pointer;
            transition: background-color 0.3s ease;
            text-align: center;
            display: inline-block;
            text-decoration: none;
            width: 150px;
            height: 50px;
        }

            .search-button:hover {
                background-color: #dc3545;
            }

                .search-button:hover .larger-text {
                    color: white;
                }



        .larger-text {
            font-family: sans-serif;
            font-size: 24px;
            font-weight: bold;
            display: block;
            color: #001431;
        }
        /* Custom CSS for ASP.NET dropdown options */
        .custom-dropdown {
            font-family: sans-serif;
            background-color: #f4f4f4;
            color: #333;
            border-bottom: 1px solid #ddd;
            width: 200px;
            height: 40px;
        }

            .custom-dropdown:last-child {
                border-bottom: none; /* Remove bottom border for the last option */
            }

            /* Hover effect */
            .custom-dropdown:hover {
                background-color: #e0e0e0;
                color: #000;
            }

        .custom-dropdown-achieve {
            font-family: sans-serif;
            background-color: #f4f4f4;
            color: #333;
            border-bottom: 1px solid #ddd;
            width: 426px;
            height: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <br />
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4 class="larger-text">User Feedback Form</h4>
                                </center>
                            </div>
                        </div>
                        <hr />

                        <!-- university,state,district-->
                        <div class="row mx-auto">
                            <div class="col-md-4">
                                <label style="font-weight: bold">Are of Experties of Lawyer?</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="AreaOfExperties" runat="server">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">Availability</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="Availability" runat="server">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">Available Date</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="AvailableDate" runat="server">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>

                        <br />
                        <!-- catagoty,experience,education -->
                        <div class="row mx-auto">
                            <div class="col-md-4">
                                <label style="font-weight: bold">Trial Lawyer?</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="TrialLawyer" runat="server">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">Case Count</label>
                                <asp:TextBox CssClass="form-control" ID="Case_count" runat="server" placeholder="Case Count" BackColor="White" BorderColor="Black" BorderStyle="Solid" TextMode="Number"></asp:TextBox>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">Consulting Fee(per hour)</label>
                                <asp:TextBox CssClass="form-control" ID="ConsultingFee" runat="server" placeholder="Amount" BackColor="White" BorderColor="Black" BorderStyle="Solid" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>
                        <br />

                        <br />

                        <!-- button-->
                        <div class="row mx-auto">
                            <div class="col">
                                <br />
                                <center>
                                    <div class="form-group">
                                        <asp:LinkButton class="btn btn-info btn-block btn-lg" ID="Submit_feedback" runat="server">Submit</asp:LinkButton>
                                    </div>
                                </center>
                            </div>
                        </div>
                    </div>
                    <a href="Homepage.aspx"><< Back to Home</a><br>
                    <br>
                </div>
            </div>
        </div>
    </div>
    <br />
</asp:Content>
