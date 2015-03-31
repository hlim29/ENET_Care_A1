<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Stocktaking.aspx.cs" masterpagefile="~/Agent.Master" %>

<asp:Content ID="Stocktaking" ContentPlaceHolderID="AgentContent" runat="server">
    <div class="span8 offset2">
       <br />
       <br />
       <br />
        <asp:CheckBox runat="server" />
        <asp:label runat="server">
            234567845 Ibuprofen
        </asp:label>
       <br />
        <asp:button runat="server" text="Update" />
    </div>
</asp:Content>
