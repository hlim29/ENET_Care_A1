<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Receive.aspx.cs" Inherits="ENET_Care_New.Pages.Receive" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Receive a package</h1>
    <br />
       <br />
       <br />
       <asp:label runat="server">
           Bar Code:
       </asp:label>
        <asp:TextBox runat="server">

        </asp:TextBox>
        <br />
       <asp:Button runat="server" text="Receive" />
</asp:Content>
