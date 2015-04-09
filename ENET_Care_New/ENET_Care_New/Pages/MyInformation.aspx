<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyInformation.aspx.cs" Inherits="ENET_Care_New.Pages.MyInformation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server">
            Name:
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
            Password:
    </asp:Label>
    <asp:TextBox runat="server">

    </asp:TextBox>
    <asp:Button runat="server" Text="Change" />
    <br />
    <asp:Label runat="server">
            Dist. Centre:
    </asp:Label>
    <asp:DropDownList AppendDataBoundItems="true" runat="server">
        <asp:ListItem Text="Centre 1">
                Centre 1
        </asp:ListItem>
        <asp:ListItem Text="Centre 2">
                Centre 2
        </asp:ListItem>
        <asp:ListItem Text="Centre 3">
                Centre 3
        </asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Button runat="server" Text="Cancel" />
    <asp:Button runat="server" Text="Save" />
</asp:Content>
