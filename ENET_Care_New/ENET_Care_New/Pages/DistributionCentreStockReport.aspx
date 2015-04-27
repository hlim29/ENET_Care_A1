<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DistributionCentreStockReport.aspx.cs" Inherits="ENET_Care_New.Pages.DistributionCentreStockReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Distribution stock report generator</h1>
    <asp:Label runat="server">
           Dist. Centre

    </asp:Label>
       <asp:DropDownList runat="server" ID="CentreDropDownList">
    </asp:DropDownList>
    <br />

    <asp:Button runat="server" Text="Generate" OnClick="Unnamed2_Click" />
   
</asp:Content>
