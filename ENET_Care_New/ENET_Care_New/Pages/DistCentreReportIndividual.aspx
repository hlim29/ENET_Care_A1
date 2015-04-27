<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DistCentreReportIndividual.aspx.cs" Inherits="ENET_Care_New.Pages.DistCentreRepostIndividual" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        <asp:Label ID="CentreNameLabel" runat="server" Text="Centre Name"></asp:Label></h1>
    <asp:GridView ID="StockGridView" runat="server">
    </asp:GridView>

</asp:Content>
