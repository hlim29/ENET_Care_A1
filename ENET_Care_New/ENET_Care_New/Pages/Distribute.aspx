<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Distribute.aspx.cs" Inherits="ENET_Care_New.Pages.Distribute" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <h1>Distribute packages</h1>

       <asp:label runat="server">
           Bar Code:
       </asp:label>
        <asp:TextBox runat="server">

        </asp:TextBox>
        <br />
       <asp:Button runat="server" text="Distribute" />
    
</asp:Content>
