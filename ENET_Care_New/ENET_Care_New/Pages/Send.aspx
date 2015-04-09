<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Send.aspx.cs" Inherits="ENET_Care_New.Pages.Send" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <asp:Label runat="server">
            Destination:
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
    <asp:Label runat="server">
            Bar Code:
    </asp:Label>
    <asp:TextBox runat="server">

    </asp:TextBox>
    <br />
    <asp:Label runat="server">
            Type:
    </asp:Label>
    <asp:TextBox runat="server" Enabled="false">

    </asp:TextBox>
    <br />
    <asp:Label runat="server">
            Expire Date:
    </asp:Label>
    <asp:TextBox runat="server" Enabled="false">

    </asp:TextBox>
    <br />
    <asp:Button runat="server" Text="Send" />
</asp:Content>
