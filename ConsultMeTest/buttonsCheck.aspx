<%@ Page Title="" Language="C#" MasterPageFile="~/Consult.Master" AutoEventWireup="true" CodeBehind="buttonsCheck.aspx.cs" Inherits="ConsultMeTest.buttonsCheck" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .search-button {
            padding: 10px 20px;
            background-color: aliceblue;
            color: #fff;
            
            font-size: 18px;
            border: none;
            border-radius: 5px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
            cursor: pointer;
            transition: background-color 0.3s ease;
            text-align: center;
            display: inline-block;
            text-decoration: none;
            width: 300px;
            height:85px;
        }

            .search-button:hover {
                background-color: #dc3545;
                
            }
            .search-button:hover .larger-text{
                color: white;
            }
            .search-button:hover .upper-text{
                color: white;
            }

        .larger-text {
            font-family:sans-serif;
            font-size: 24px;
            font-weight: bold;
            display: block;
            color:#001431;
        }
        .upper-text{
            color:#dc3545;
            font-family:sans-serif;
        }
    </style>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <div class="row">
            <div class="col">
                <br>
                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <center>
                                    <asp:LinkButton ID="SearchButton" runat="server" CssClass="search-button">
                                       
                                                <span class="upper-text">Search a</span><br />
                                   <span class="larger-text">Lawyer</span>
                                          

                                        
             
                                    </asp:LinkButton>

                                </center>
                            </div>
                        </div>

                    </div>


                </div>
                <a href="Homepage.aspx"><< Back to Home</a><br>
                <br>
            </div>
        </div>
    </div>
</asp:Content>
