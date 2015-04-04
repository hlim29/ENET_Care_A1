<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Distribute.aspx.cs" masterpagefile="~/MasterPage.Master" %>

<asp:Content ID="Distribute" ContentPlaceHolderID="Content" runat="server">
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
       <asp:Button runat="server" text="Distribute" />
    </div>
</asp:Content>
