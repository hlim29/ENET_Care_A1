﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoctorActivityReport.aspx.cs" masterpagefile="~/Manager.Master" %>

<asp:Content ID="DoctorActivity" ContentPlaceHolderID="Manager" runat="server">
    <div class="span8 offset2">
        <br />
        <br />
        <br />
        <table>
            <tr>
                <td>
                    <asp:label runat="server">
                        <b>Dr. James Bond</b>
                    </asp:label>
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
                        <asp:Label runat="server">$45</asp:Label>
                    </h3>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
