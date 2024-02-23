<%@ Page Title="" Language="C#" MasterPageFile="~/Consult.Master" AutoEventWireup="true" CodeBehind="UserFeedback.aspx.cs" Inherits="ConsultMeTest.UserFeedback" %>

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
        <asp:HiddenField ID="hidLawyerID" runat="server" />
        <asp:HiddenField ID="hidClientID" runat="server" />
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
                                <label style="font-weight: bold">Communication Availability</label>
                                <div class="form-group">
                                       <asp:DropDownList class="custom-dropdown" ID="CommunicationAvailability" runat="server">
                                           <asp:ListItem Text="Select" Value="Select" />
                                       <asp:ListItem Text="Excellent availability" Value="Excellent" />
                                           <asp:ListItem Text="Good availability" Value="Very Good" />
                                       <asp:ListItem Text="Moderate availability" Value="Good" />
                                       <asp:ListItem Text="Poor availability" Value="Fair" />
                                       <asp:ListItem Text="Very poor availability" Value="Poor" />
                                    </asp:DropDownList>
                                    </div>
                                </div>                
                                <div class="col-md-4">
                                    <label style="font-weight: bold">Communication Skills</label>
                                    <div class="form-group">
                                        <asp:DropDownList class="custom-dropdown" ID="CommunicationSkillsz" runat="server">
                                            <asp:ListItem Text="Select" Value="Select" />
                                            <asp:ListItem Text="Excellent" Value="Excellent" />
                                            <asp:ListItem Text="Very Good" Value="Very Good" />
                                            <asp:ListItem Text="Good" Value="Good" />
                                            <asp:ListItem Text="Fair" Value="Fair" />
                                            <asp:ListItem Text="Poor" Value="Poor" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <label style="font-weight: bold">Experties</label>
                                    <div class="form-group">
                                        <asp:DropDownList class="custom-dropdown" ID="Experties" runat="server">
                                            <asp:ListItem Text="Select" Value="Select" />
                                            <asp:ListItem Text="Very High" Value="Excellent" />
                                            <asp:ListItem Text="High" Value="Very Good" />
                                            <asp:ListItem Text="Moderate" Value="Good" />
                                            <asp:ListItem Text="Low" Value="Fair" />
                                            <asp:ListItem Text="Very Low" Value="Poor" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                
                                

                          
                            <!-- catagoty,experience,education -->
                            <div class="row mx-auto">
                                <div class="col-md-4">
                                    <label style="font-weight: bold">Time Flexibility</label>
                                    <div class="form-group">
                                        <asp:DropDownList class="custom-dropdown" ID="TimeFlexibility" runat="server">
                                            <asp:ListItem Text="Select" Value="Select" />
                                            <asp:ListItem Text="Highly flexible" Value="Excellent" />
                                            <asp:ListItem Text="Flexible schedule" Value="High" />
                                            <asp:ListItem Text="Moderate flexibility" Value="Average" />
                                            <asp:ListItem Text="Limited flexibility" Value="Fair " />
                                            <asp:ListItem Text="Very rigid schedule" Value="Poor " />
                                        </asp:DropDownList>
                                    </div>
                                   </div>
                                <div class="col-md-4">
                                    <label style="font-weight: bold">Morality</label>
                                    <div class="form-group">
                                        <asp:DropDownList class="custom-dropdown" ID="Morality" runat="server">
                                            <asp:ListItem Text="Select" Value="Select" />
                                            <asp:ListItem Text="Excellent" Value="Excellent" />
                                            <asp:ListItem Text="Very Good" Value="Very Good" />
                                            <asp:ListItem Text="Good" Value="Good" />
                                            <asp:ListItem Text="Fair" Value="Fair" />
                                            <asp:ListItem Text="Poor" Value="Poor" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                             
                                <div class="col-md-4">
                                    <label style="font-weight: bold">Time investment</label>
                                    <div class="form-group">
                                        <asp:DropDownList class="custom-dropdown" ID="TimeInvestment" runat="server">
                                            <asp:ListItem Text="Select" Value="Select" />
                                            <asp:ListItem Text="Very High" Value="Excellent" />
                                            <asp:ListItem Text="High" Value="Very Good" />
                                            <asp:ListItem Text="Moderate" Value="Average" />
                                            <asp:ListItem Text="low" Value="Fair" />
                                            <asp:ListItem Text="Very low" Value="Poor" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                                <div class="col-md-4">
                                    <label style="font-weight: bold">Case Management</label>
                                    <div class="form-group">
                                        <asp:DropDownList class="custom-dropdown" ID="CaseManagement" runat="server">
                                            <asp:ListItem Text="Select" Value="Select" />
                                            <asp:ListItem Text="Excellent" Value="Excellent" />
                                            <asp:ListItem Text="Very Good" Value="Very Good" />
                                            <asp:ListItem Text="Good" Value="Good" />
                                            <asp:ListItem Text="Fair" Value="Fair" />
                                            <asp:ListItem Text="Poor" Value="Poor" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <label style="font-weight: bold">Strategy</label>
                                    <div class="form-group">
                                        <asp:DropDownList class="custom-dropdown" ID="Strategy1" runat="server">
                                            <asp:ListItem Text="Select" Value="Select" />
                                            <asp:ListItem Text="Extremely strategic" Value="Excellent" />
                                            <asp:ListItem Text="Highly strategic" Value="Very Good" />
                                            <asp:ListItem Text="Moderately strategic" Value="Good" />
                                            <asp:ListItem Text="Somewhat strategic" Value="Fair" />
                                            <asp:ListItem Text="Not strategic" Value="Poor" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="row mx-auto">
                            <div class="col-md-4">
                                <label style="font-weight: bold">Price charged</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="PriceCharged" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Very expensive" Value="Excellent" />
                                        <asp:ListItem Text="Expensive" Value="Very Good" />
                                        <asp:ListItem Text="Moderately priced" Value="Good" />
                                        <asp:ListItem Text="Inexpensive" Value="Fair" />
                                        <asp:ListItem Text="Very inexpensive" Value="Poor" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">Experience</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="Experience1" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Very High" Value="Excellent" />
                                        <asp:ListItem Text="High" Value="Very Good" />
                                        <asp:ListItem Text="Moderate" Value="Average" />
                                        <asp:ListItem Text="low" Value="Fair" />
                                        <asp:ListItem Text="Very low" Value="Poor" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            
</div>          
                            <
                            <br />

                            <br />

                            <!-- button-->
                            <div class="row mx-auto">
                                <div class="col">
                                    <br />
                                    <center>
                                        <div class="form-group">
                                            <asp:LinkButton class="btn btn-info btn-block btn-lg" ID="Submit_feedback" runat="server" OnClick="Submit_feedback_Click">Submit</asp:LinkButton>
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
       
        <br />
    </asp:Content>