<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DistributionCentreLossesReport.aspx.cs" Inherits="ENET_Care_New.Pages.DistributionCentreLossesReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br />
       <br />
       <br />
       <asp:label runat="server">
           <b>Distribution Centre 1</b>
       </asp:label>
        <br />
        <asp:Label runat="server">
            Lost:
        </asp:Label>
        <asp:Label runat="server">
            1
        </asp:Label>
        <br />
        <asp:Label runat="server">
            Discarded:
        </asp:Label>
        <asp:Label runat="server">
            1
        </asp:Label>
        <br />
        <asp:Label runat="server">
            Distributed:
        </asp:Label>
        <asp:Label runat="server">
            100
        </asp:Label>
        <br />
        <asp:label runat="server">
            <b>Ratio</b>
        </asp:label>
        <asp:Label runat="server">
            <b>1.9%</b>
        </asp:Label>
       <br />
       <br />
       <asp:label runat="server">
           <b>Distribution Centre 2</b>
       </asp:label>
        <br />
        <asp:Label runat="server">
            Lost:
        </asp:Label>
        <asp:Label runat="server">
            1
        </asp:Label>
        <br />
        <asp:Label runat="server">
            Discarded:
        </asp:Label>
        <asp:Label runat="server">
            1
        </asp:Label>
        <br />
        <asp:Label runat="server">
            Distributed:
        </asp:Label>
        <asp:Label runat="server">
            100
        </asp:Label>
        <br />
        <asp:label runat="server">
            <b>Ratio</b>
        </asp:label>
        <asp:Label runat="server">
            <b>1.9%</b>
        </asp:Label>
        <br />
        <asp:Button runat="server" Text="Print" />
</asp:Content>
