<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Receive.aspx.cs" Inherits="ENET_Care_New.Pages.Receive" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Receive a package</h1>
    <br />
       <br />
       <asp:Label ID="labelInvalidBarcode" runat="server" Text="Please enter a valid package barcode" Visible="False"></asp:Label>
       <br />
       <asp:label runat="server">
           Bar Code:
       </asp:label>
        <asp:TextBox runat="server" ID="txtBarcode"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtBarcode" runat="server" ErrorMessage="Only Numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator>
        <br />
       <asp:Button runat="server" text="Receive" ID="ReceiveButton" OnClick="ReceiveButton_Click" />
</asp:Content>
