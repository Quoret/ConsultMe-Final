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
            width: 280px;
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
        .agaadi-lyauni{
            text-align:left;
            font-weight:bold;
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
                                    <h4 class="larger-text">Enter Your Requirement</h4>
           
                                </center>
                            </div>
                        </div>
                        <hr />
                        <div class="row mx-auto">
                            <div class="col-md-12">     
                                <label class="agaadi-lyauni">Area of Experties</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="LawyerCatagory" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Criminal Law" Value="Criminal Law" />
                                        <asp:ListItem Text="Civil Law" Value="Civil Law" />
                                        <asp:ListItem Text="Family Law" Value="Family Law" />
                                        <asp:ListItem Text="Corporate Law" Value="Corporate Law" />
                                        <asp:ListItem Text="Real Estate Law" Value="Real Estate Law" />
                                        <asp:ListItem Text="Immigration Law" Value="Immigration Law" />
                                        <asp:ListItem Text="Intellectual Property Law" Value="Intellectual Property Law" />
                                        <asp:ListItem Text="Environmental Law" Value="Environmental Law" />
                                        <asp:ListItem Text="Tax Law" Value="Tax Law" />
                                        <asp:ListItem Text="Employment Law" Value="Employment Law" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <br />
                        <!-- university,state,district-->
<!------------------------------------------------------------------------------------------------------------------------------------->

                        <div class="row mx-auto">
                            <div class="col-md-6">
                                <label style="font-weight: bold">How often would you need to communicate with your lawyer?</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="communicationBetween2" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Several times a day" Value="Excellent" />
                                        <asp:ListItem Text="Multiple times a week" Value="Very Good" />
                                        <asp:ListItem Text="Once or twice a week" Value="Good" />
                                        <asp:ListItem Text="Several times a month" Value="Fair" />
                                        <asp:ListItem Text="Once a month or less" Value="Poor" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label style="font-weight: bold">How much lawyer-judge communication does your case require?</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="CommunicationBetween" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Excellent" Value="Excellent" />
                                        <asp:ListItem Text="Very Good" Value="Very Good" />
                                        <asp:ListItem Text="Good" Value="Good" />
                                        <asp:ListItem Text="Fair" Value="Fair" />
                                        <asp:ListItem Text="Poor" Value="Poor" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            </div>
                           <br />
 <!------------------------------------------------------------------------------------------------------------------------------------->

                            
                       <div class="row mx-auto">
                                <div class="col-md-6">
                                    <label style="font-weight: bold">Legal problem complexity level</label>
                                    <div class="form-group">
                                        <asp:DropDownList class="custom-dropdown" ID="CaseDifficulty" runat="server">
                                            <asp:ListItem Text="Select" Value="Select" />
                                            <asp:ListItem Text="Excellent" Value="Excellent" />
                                            <asp:ListItem Text="Very Good" Value="Very Good" />
                                            <asp:ListItem Text="Good" Value="Good" />
                                            <asp:ListItem Text="Fair" Value="Fair" />
                                            <asp:ListItem Text="Poor" Value="Poor" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <label style="font-weight: bold">How much time flexibility do you need?</label>
                                    <div class="form-group">
                                        <asp:DropDownList class="custom-dropdown" ID="TimeFLexibility" runat="server">
                                            <asp:ListItem Text="Select" Value="Select" />
                                            <asp:ListItem Text="Excellent" Value="Excellent" />
                                            <asp:ListItem Text="Very Good" Value="Very Good" />
                                            <asp:ListItem Text="Good" Value="Good" />
                                            <asp:ListItem Text="Fair" Value="Fair" />
                                            <asp:ListItem Text="Poor" Value="Poor" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                        <br />
 <!------------------------------------------------------------------------------------------------------------------------------------->
                            <div class="row mx-auto">
                                <div class="col-md-6">
                                    <label style="font-weight: bold">What is the type of help you require?</label>
                                    <div class="form-group">
                                        <asp:DropDownList class="custom-dropdown" ID="TypeOfHelp" runat="server">
                                            <asp:ListItem Text="Select" Value="Select" />
                                            <asp:ListItem Text="Excellent" Value="Excellent" />
                                            <asp:ListItem Text="Very Good" Value="Very Good" />
                                            <asp:ListItem Text="Good" Value="Good" />
                                            <asp:ListItem Text="Fair" Value="Fair" />
                                            <asp:ListItem Text="Poor" Value="Poor" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <label style="font-weight: bold">How long do you want to hire the lawyer for?</label>
                                    <div class="form-group">
                                        <asp:DropDownList class="custom-dropdown" ID="TimeDuration" runat="server">
                                            <asp:ListItem Text="Select" Value="Select" />
                                            <asp:ListItem Text="Excellent" Value="Excellent" />
                                            <asp:ListItem Text="Very Good" Value="Very Good" />
                                            <asp:ListItem Text="Good" Value="Good" />
                                            <asp:ListItem Text="Fair" Value="Fair" />
                                            <asp:ListItem Text="Poor" Value="Poor" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                        <br />

<!------------------------------------------------------------------------------------------------------------------------------------->
                            <div class="row mx-auto">
                                <div class="col-md-6">
                                    <label style="font-weight: bold">How sensitive is your case to moral issues?</label>
                                    <div class="form-group">
                                        <asp:DropDownList class="custom-dropdown" ID="CaseSensitivity" runat="server">
                                            <asp:ListItem Text="Select" Value="Select" />
                                            <asp:ListItem Text="Excellent" Value="Excellent" />
                                            <asp:ListItem Text="Very Good" Value="Very Good" />
                                            <asp:ListItem Text="Good" Value="Good" />
                                            <asp:ListItem Text="Fair" Value="Fair" />
                                            <asp:ListItem Text="Poor" Value="Poor" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            <div class="col-md-6">
                                <label style="font-weight: bold">Strategy creativity level of lawyer?</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="LawyerCreativity" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Excellent" Value="Excellent" />
                                        <asp:ListItem Text="Very Good" Value="Very Good" />
                                        <asp:ListItem Text="Good" Value="Good" />
                                        <asp:ListItem Text="Fair" Value="Fair" />
                                        <asp:ListItem Text="Poor" Value="Poor" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <br />
<!------------------------------------------------------------------------------------------------------------------------------------->
                        <div class="row mx-auto">
                            <div class="col-md-6">
                                <label style="font-weight: bold"> What range of cost do you expect?</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="CostRange" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Excellent" Value="Excellent" />
                                        <asp:ListItem Text="Very Good" Value="Very Good" />
                                        <asp:ListItem Text="Good" Value="Good" />
                                        <asp:ListItem Text="Fair" Value="Fair" />
                                        <asp:ListItem Text="Poor" Value="Poor" />
                                    </asp:DropDownList>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <label style="font-weight: bold">How much experience is necessary for you?</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="Experience" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Very Highly necessary" Value="Excellent" />
                                        <asp:ListItem Text="Highly necessary" Value="Very Good" />
                                        <asp:ListItem Text="Averagely necessary" Value="Good" />
                                        <asp:ListItem Text="Not much necessary" Value="Fair" />
                                        <asp:ListItem Text="Not necessary at all" Value="Poor" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
<!------------------------------------------------------------------------------------------------------------------------------------->

                <br />
                <br />

                <!-- button-->
                        <div class="row mx-auto">
                            <div class="col">
                                <br />
                                <center>
                                    <div class="form-group">
                                        <asp:LinkButton class="btn btn-info btn-block btn-lg" ID="Submit_Requirement" runat="server" OnClick="Submit_requirement_Click">Submit</asp:LinkButton>
                                    </div>
                                </center>
                            </div>
                        </div>
                    </div>
                    <a href="Homepage.aspx"><< Back </a>
                    <br>
                    <br>
                </div>
            </div>
            </div>
        </div>
    <br />
</asp:Content>