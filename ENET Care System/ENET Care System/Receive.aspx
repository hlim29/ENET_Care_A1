﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Receive.aspx.cs" masterpagefile="~/Agent.Master" %>

<asp:Content ID="Receive" ContentPlaceHolderID="AgentContent" runat="server">
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
       <asp:Button runat="server" text="Receive" />
    </div>
</asp:Content>