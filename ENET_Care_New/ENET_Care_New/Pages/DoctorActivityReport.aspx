<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DoctorActivityReport.aspx.cs" Inherits="ENET_Care_New.Pages.DoctorActivityReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label runat="server">
                        <b>Dr. James Bond</b>
                </asp:Label>
            </td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <u>Qty </u>
            </td>
            <td>
                <u>Type</u>
            </td>
            <td>
                <u>Price</u>
            </td>
            <td>
                <u>Subtotal</u>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label runat="server">3</asp:Label>
            </td>
            <td>
                <asp:Label runat="server">Paracetamol</asp:Label>
            </td>
            <td>
                <asp:Label runat="server">$15</asp:Label>
            </td>
            <td>
                <asp:Label runat="server">$45</asp:Label>
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <hr />
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td>Total:
                <asp:Label runat="server">$45</asp:Label>
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <h3>
                    <b>Grand Total</b>
                    <asp:Label runat="server">$45</asp:Label>
                </h3>
            </td>
        </tr>
    </table>
</asp:Content>
