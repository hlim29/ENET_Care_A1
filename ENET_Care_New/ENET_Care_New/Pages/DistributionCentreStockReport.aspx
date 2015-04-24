<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DistributionCentreStockReport.aspx.cs" Inherits="ENET_Care_New.Pages.DistributionCentreStockReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server">
           Dist. Centre
    </asp:Label><a href="../Content/">../Content/</a>
    <asp:DropDownList runat="server" ID="DistributionCentreDropDown">
    </asp:DropDownList>
    <br />
    <asp:RadioButton ID="allProducts" runat="server" />
    <asp:Label runat="server">
           All Products
    </asp:Label>
    <br />
    <asp:RadioButton ID="oneProduct" runat="server" />
    <asp:Label runat="server">
            Product Type:
    </asp:Label>
    <asp:DropDownList runat="server" ID="PackageTypeDropDown">
    </asp:DropDownList>
    <br />
    <asp:Button runat="server" Text="Generate" />
    <asp:Button runat="server" Text="Generate and Print" />
</asp:Content>
