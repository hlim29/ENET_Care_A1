<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegSuccess.aspx.cs" Inherits="ENET_Care_New.Pages.RegSuccess" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Package registration success</h1>
    <asp:Label ID="PrefixLabel" runat="server" Text="The package has been successfully registered. The barcode is: "></asp:Label>
    <asp:Label ID="BarcodeLabel" runat="server" Text=""></asp:Label>
    <br />
    <asp:PlaceHolder ID="BarcodePlaceholder" runat="server"></asp:PlaceHolder>
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pages/Register.aspx">Register another</asp:HyperLink>
</asp:Content>
