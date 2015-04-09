<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ValueInTransit.aspx.cs" Inherits="ENET_Care_New.Pages.ValueInTransit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <table>
            <tr>
                <td>
                    <b><asp:label runat="server">Centre 1 to Centre 2</asp:label></b>
                </td>
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
                    <asp:label runat="server">Paracetamol</asp:label>
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
                <td>
                    Total: <asp:Label runat="server">$45</asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <b><asp:label runat="server">Centre 2 to Centre 1</asp:label></b>
                </td>
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
                    <asp:label runat="server">Paracetamol</asp:label>
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
                <td>
                    Total: <asp:Label runat="server">$45</asp:Label>
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
                        <asp:Label runat="server">$90</asp:Label>
                    </h3>
                </td>
            </tr>
        </table>
</asp:Content>


