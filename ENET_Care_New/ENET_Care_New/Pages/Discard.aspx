<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Discard.aspx.cs" Inherits="ENET_Care_New.Pages.Discard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="span8 offset2">
        <br />
       <asp:label runat="server">
           Bar Code:
       </asp:label>
        <asp:TextBox runat="server" ID="BarCode">

        </asp:TextBox>
        <br />
       <asp:Button runat="server" text="Discard" onclick="Submit_Click"/>
    </div>
</asp:Content>
