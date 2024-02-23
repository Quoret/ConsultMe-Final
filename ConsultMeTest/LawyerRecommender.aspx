<%@ Page Title="" Language="C#" MasterPageFile="~/Consult.Master" AutoEventWireup="true" CodeBehind="LawyerRecommender.aspx.cs" Inherits="ConsultMeTest.LawyerRecommender" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="card">
            <div class="card-body">
                <div class="row">
                    <div class="col">
                        <center>
                            <h4 class="larger-text">Following Lawyers are Recommended for you</h4>
                            <span>(Hover over the lawyer name to provide feedback)</span>
                        </center>
                    </div>
                </div>
                <hr />
                <div class="row mx-auto">

                    <div class="col">

                        <%-- <asp:GridView class="table table-striped table-bordered"  ID="RecommendedLawyer" runat="server" OnRowDataBound="LawyerGridView_RowDataBound"></asp:GridView>--%>
                        <asp:GridView ID="RecommendedLawyer" runat="server" class="table table-striped table-bordered" OnRowDataBound="RecommendedLawyer_RowDataBound">
                           <%-- <Columns>
                                <asp:TemplateField HeaderText="Lawyer Name">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "UserFeedback.aspx?LawyerID=" + Eval("LawyerID") + "&ClientID=" + Session["ClientId"] %>' Text='<%# Eval("LawyerFullname") %>'></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>--%>
                        </asp:GridView>

                    </div>
                </div>
                <center><a href="Homepage.aspx"><< Back </a>
                    <br>
                </center>
            </div>
        </div>
    </div>

    <br />



</asp:Content>
