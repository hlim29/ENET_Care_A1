<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RemoveLoss.aspx.cs" masterpagefile="~/MasterPage.Master" %>

<asp:Content ID="RemoveLoss" ContentPlaceHolderID="Content" runat="server">
    <div class="span8 offset2">
        <br />
        <br />
        <br />
       <asp:label runat="server">
           Package:
       </asp:label>
        <asp:dropdownlist AppendDataBoundItems="true" runat="server">
            <asp:ListItem Value="Ibuprofen">
                Ibuprofeno
            </asp:ListItem>
        </asp:dropdownlist>
        <br />
       <asp:Button runat="server" text="Remove Loss" />
    </div>
</asp:Content>
