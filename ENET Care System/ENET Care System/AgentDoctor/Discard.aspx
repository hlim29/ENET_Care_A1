<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Discard.aspx.cs" masterpagefile="~/MasterPage.Master" %>

<asp:Content id="Discard" runat="server" ContentPlaceHolderID="Content">
    <div class="span8 offset2">
        <br />
        <br />
        <br />
       <asp:label runat="server">
           Bar Code:
       </asp:label>
        <asp:TextBox runat="server">

        </asp:TextBox>
        <br />
       <asp:Button runat="server" text="Discard" />
    </div>
</asp:Content>
