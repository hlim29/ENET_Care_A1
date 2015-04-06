<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ENET_Care.Presentation.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    
    <asp:Login ID="Login1" runat="server" Height="173px"></asp:Login>
    <asp:ValidationSummary ID="ValidationSummary2" runat="server" ValidationGroup="Login1" />
</asp:Content>
