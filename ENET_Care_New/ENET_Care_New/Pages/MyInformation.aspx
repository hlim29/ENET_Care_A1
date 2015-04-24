<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyInformation.aspx.cs" Inherits="ENET_Care_New.Pages.MyInformation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server">
            First Name:
    </asp:Label>
    <asp:TextBox runat="server">

    </asp:TextBox>
    <br />
    <asp:Label runat="server">
            Last Name:
    </asp:Label>
    <asp:TextBox runat="server">

    </asp:TextBox>
    <br />
    <asp:Label runat="server">
            Email:
    </asp:Label>
    <asp:TextBox runat="server">

    </asp:TextBox>
    <br />
    <asp:Label runat="server">
            Old Password:
    </asp:Label>
    <asp:TextBox runat="server">

    </asp:TextBox>
    <br />
    <asp:Label runat="server">
            New Password:
    </asp:Label>
    <asp:TextBox runat="server">

    </asp:TextBox>
    <asp:Button runat="server" Text="Change" />
    <br />
    <asp:Label runat="server">
            Dist. Centre:
    </asp:Label>
    <asp:DropDownList AppendDataBoundItems="true" runat="server" ID="CentreDropDownList">
    </asp:DropDownList>
    <br />
    <asp:Button runat="server" Text="Cancel" />
    <asp:Button runat="server" Text="Save" />
</asp:Content>
