<%@ Page Title="" Language="C#" MasterPageFile="~/Consult.Master" AutoEventWireup="true" CodeBehind="SearchLawyer.aspx.cs" Inherits="ConsultMeTest.SearchLawyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Datatable/CSS/jquery.dataTables.min.css" rel="stylesheet" />
    <script src="Datatable/Js/jquery.dataTables.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {

            //$(document).ready(function () {
            //$('.table').DataTable();
            // });

            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
            //$('.table1').DataTable();
        });
    </script>
    <style>
            .larger-text {
    font-family: sans-serif;
    font-size: 30px;
    font-weight: bold;
    display: block;
    color: #001431;
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
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server">
                        </asp:SqlDataSource>
                            <center>
                                <h1 class="larger-text" >Search Lawyer</h1>
                                <hr />
                                <asp:GridView class="table table-striped table-bordered" ID="Search_lawyer" runat="server" AutoGenerateColumns="True" OnRowDataBound="Search_lawyer_RowDataBound"></asp:GridView>
                        
                        </center>                       
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
</asp:Content>

