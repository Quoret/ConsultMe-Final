<%@ Page Title="" Language="C#" MasterPageFile="~/Consult.Master" AutoEventWireup="true" CodeBehind="SimilarLawyerRecommender.aspx.cs" Inherits="ConsultMeTest.SimilarLawyerRecommender" %>

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

        .agaadi-lyauni {
            text-align: left;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <div class="container">
        <div class="card">
            <div class="card-body">
                <div class="row">
                    <div class="col">
                        <center>
                            <h4 class="larger-text">Following Lawyers are Similar to your Previous Lawyer</h4>
                            <span>(Hover over the lawyer name to provide feedback)</span>
                        </center>
                    </div>
                </div>
                <hr />
                <div class="row mx-auto">

                    <div class="col">
                        <asp:GridView ID="SimilarLawyerRecommend" class="table table-striped table-bordered" runat="server" OnRowDataBound="SimilarLawyerRecommend_RowDataBound"></asp:GridView>
                    </div>
                </div>
                <center>
                    <a href="Homepage.aspx"><< Back </a>
                    <br>
                </center>
            </div>
        </div>
    </div>

    <hr />
</asp:Content>
