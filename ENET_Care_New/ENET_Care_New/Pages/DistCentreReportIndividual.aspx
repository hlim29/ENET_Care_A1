<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DistCentreReportIndividual.aspx.cs" Inherits="ENET_Care_New.Pages.DistCentreRepostIndividual" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Current distribution centre - <asp:Label ID="CentreNameLabel" runat="server" Text=""></asp:Label></h1>
    <p>
        Colours denote the expiry status of a package.</p>
    <p>
        Red: The package has expired<br />
        Orange: The package will expire within a week<br />
        White: The package is not due to expire for at least a week</p>
    <asp:GridView ID="StockGridView" runat="server" OnRowDataBound="DataBind">
    </asp:GridView>

</asp:Content>
