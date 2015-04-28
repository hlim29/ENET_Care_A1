<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DistributionCentreLossesReport.aspx.cs" Inherits="ENET_Care_New.Pages.DistributionCentreLossesReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:GridView ID="StockGridView" runat="server">
    </asp:GridView>

    
        <asp:Button runat="server" Text="Print" />
</asp:Content>
