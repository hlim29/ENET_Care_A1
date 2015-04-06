<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" masterpagefile="~/MasterPage.Master" Inherits="ENET_Care.Presentation.Default" %>

<asp:Content id="Default" runat="server" ContentPlaceHolderID="Content">
    <h1>Welcome to the ENET Care System</h1>

    <asp:LoginView ID="LoginView1" runat="server">
        <AnonymousTemplate>
            You are not logged in. Click <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">here </asp:HyperLink>  to login.
        </AnonymousTemplate>
        <LoggedInTemplate>
            You are logged in. Welcome <asp:LoginName ID="LoginName1" runat="server" />
            !
        </LoggedInTemplate>
    </asp:LoginView>
</asp:Content>