<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Send.aspx.cs" Inherits="ENET_Care_New.Pages.Send" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <asp:Label ID="labelInvalidBarcode" runat="server" Text="Invalid barcode" Visible="False"></asp:Label>
    <br />
    <asp:Label runat="server">
            Destination:
    </asp:Label>
    <asp:DropDownList AppendDataBoundItems="true" runat="server" ID="CentreDropDownList">
    </asp:DropDownList>
    <br />
    <asp:Label runat="server">
            Bar Code:
    </asp:Label>
    <asp:TextBox runat="server" ID="txtBarcode"></asp:TextBox>
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
    <asp:Button runat="server" Text="Send" ID="buttonSend" OnClick="buttonSend_Click" />
    <br />
    <asp:Label ID="LabelSuccess" runat="server" Text="Your package has been successfully sent" Visible="False"></asp:Label>
    <br />
    <asp:Label ID="LabelSource" runat="server" Text="Source" Visible="False"></asp:Label>
    <br />
    <asp:Label ID="LabelDestination" runat="server" Text="Dest" Visible="False"></asp:Label>
    <br />
    <asp:Label ID="LabelPackageId" runat="server" Text="Id" Visible="False"></asp:Label>
    <br />
    <asp:HyperLink ID="HyperLinkAnother" runat="server" NavigateUrl="Send.aspx">Click here to send another package</asp:HyperLink>
</asp:Content>
