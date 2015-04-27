<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyInformation.aspx.cs" Inherits="ENET_Care_New.Pages.MyInformation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server">
            First Name:
    </asp:Label>
    <asp:TextBox runat="server" ID="FirstName">

    </asp:TextBox>
    <br />
    <asp:Label runat="server">
            Last Name:
    </asp:Label>
    <asp:TextBox runat="server" ID="LastName">

    </asp:TextBox>
    <br />
    <asp:Label runat="server">
            Email:
    </asp:Label>
    <asp:TextBox runat="server" ID="Email">

    </asp:TextBox>
    <br />
    <br />
    <asp:Panel ID="Panel1" runat="server" BorderStyle="Groove">
        <asp:Label ID="PasswordResultLabel" runat="server" Text="Error label" Visible="False"></asp:Label>
        <br />
        <asp:Label runat="server">
            Old Password:
    </asp:Label>
    <asp:TextBox runat="server" ID="OldPassword" TextMode="Password">

    </asp:TextBox>
    <br />
    <asp:Label runat="server">
            New Password:
    </asp:Label>
    <asp:TextBox runat="server" TextMode="Password" ID="NewPassword">

    </asp:TextBox>
    <br />
    <asp:Label runat="server">
            New Password:
    </asp:Label>
    <asp:TextBox runat="server" TextMode="Password" ID="NewPasswordConfirm">

    </asp:TextBox>
    <asp:Button runat="server" Text="Change" ID="ChangePassword" />
    </asp:Panel>
    
    <br />
    <asp:Label runat="server">
            Dist. Centre:
    </asp:Label>
    <asp:DropDownList AppendDataBoundItems="true" runat="server" ID="CentreDropDownList" AutoPostBack = "true">
    </asp:DropDownList>
    <br />
    <asp:Button runat="server" Text="Cancel" />
    <asp:Button runat="server" Text="Save" onclick="Submit_Click" />
</asp:Content>
