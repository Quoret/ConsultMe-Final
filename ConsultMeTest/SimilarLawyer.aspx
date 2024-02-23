<%@ Page Title="" Language="C#" MasterPageFile="~/Consult.Master" AutoEventWireup="true" CodeBehind="SimilarLawyer.aspx.cs" Inherits="ConsultMeTest.SimilarLawyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link href="Datatable/CSS/jquery.dataTables.min.css" rel="stylesheet" />
    <script src="Datatable/Js/jquery.dataTables.min.js"></script>
        <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
            //$('.table1').DataTable();
        });
        </script>
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
 </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
    <div class="card">
        <div class="card-body">
            <br />
            <div class="row mx-auto">

                <div class="col">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:ConsultMeDBConnectionString %>' ProviderName='<%$ ConnectionStrings:ConsultMeDBConnectionString.ProviderName %>' SelectCommand="SELECT [LawyerID], [LawyerFullname], [AreaOfExperties], [Contact], [District], [CaseCount], [AvailableDate] FROM [SearchLawyerGridView]"></asp:SqlDataSource>
                    <center>
                        <h1 class="larger-text">Select your Present Lawyer </h1>
                        <span>(Here you can find new but similar lawyer you previously consulted to)</span>
                        <hr />
                        <%--<asp:GridView class="table table-striped table-bordered" ID="Search_lawyer" runat="server" OnRowDataBound="Search_lawyer_RowDataBound" DataKeyNames="LawyerID">
                            <Columns>
                                <asp:BoundField DataField="LawyerID" HeaderText="Lawyer ID" Visible="false" />
                                <asp:TemplateField HeaderText="Lawyer Name">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "UserFeedback.aspx?LawyerFullname=" + Server.UrlEncode(Eval("LawyerFullname").ToString()) %>' Text='<%# Eval("LawyerFullname") %>'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>

                            </Columns>
                        </asp:GridView>--%>

                        <asp:GridView class="table table-striped table-bordered" ID="Search_lawyer" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="LawyerID" HeaderText="LawyerID" SortExpression="LawyerID" Visible="False"></asp:BoundField>
                                 <asp:TemplateField HeaderText="Lawyer Name">
                                     <ItemTemplate>
                                         <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "SimilarLawyerRecommender.aspx?LawyerID=" + Eval("LawyerID") + "&ClientID=" + Session["ClientId"] %>' Text='<%# Eval("LawyerFullname") %>'></asp:HyperLink>                                         </ItemTemplate>
                                 </asp:TemplateField> 
                                <asp:BoundField DataField="AreaOfExperties" HeaderText="Catagory" SortExpression="AreaOfExperties"></asp:BoundField>
                                <asp:BoundField DataField="Contact" HeaderText="Contact" SortExpression="Contact"></asp:BoundField>
                                <asp:BoundField DataField="District" HeaderText="District" SortExpression="District"></asp:BoundField>
                                <asp:BoundField DataField="CaseCount" HeaderText="Case Count" SortExpression="CaseCount"></asp:BoundField>
                                <asp:BoundField DataField="AvailableDate" HeaderText="Available Date" SortExpression="AvailableDate"></asp:BoundField>
                            </Columns>
                        </asp:GridView>

                       

                    </center>
                </div>
            </div>
            <center><a href="Homepage.aspx"><< Back </a><br></center>
        </div>
    </div>
</div>
 
<br />

</asp:Content>

