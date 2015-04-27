<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Distribute.aspx.cs" Inherits="ENET_Care_New.Pages.Distribute" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <h1>Distribute packages</h1>

    <asp:Label ID="labelInvalidBarcode" runat="server" Text="Please enter a valid package barcode" Visible="False"></asp:Label>
       <br />

       <asp:label runat="server">
           Bar Code:
       </asp:label>
        <asp:TextBox runat="server" ID="txtBarcode"></asp:TextBox>
        <br />
       <asp:Button runat="server" text="Distribute" ID="DistributeButton" OnClick="DistributeButton_Click" />
    
</asp:Content>
