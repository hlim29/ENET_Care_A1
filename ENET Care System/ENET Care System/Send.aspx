<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Send.aspx.cs" masterpagefile="~/Agent.Master" %>

<asp:Content ID="Send" ContentPlaceHolderID="AgentContent" runat="server">
    <div class="span8 offset2">
       <br />
       <br />
       <br />
        <asp:Label runat="server">
            Destination:
        </asp:Label>
        <asp:DropDownList AppendDataBoundItems="true" runat="server">
            <asp:ListItem Text="Centre 1">
                Centre 1
            </asp:ListItem>
            <asp:ListItem Text="Centre 2">
                Centre 2
            </asp:ListItem>
            <asp:ListItem Text="Centre 3">
                Centre 3
            </asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label runat="server">
            Bar Code:
        </asp:Label>
        <asp:textbox runat="server">

        </asp:textbox>
        <br />
        <asp:Label runat="server">
            Type:
        </asp:Label>
        <asp:TextBox runat="server" Enabled="false">

        </asp:TextBox>
        <br />
        <asp:Label runat="server">
            Expire Date:
        </asp:Label>
        <asp:TextBox runat="server" Enabled="false">

        </asp:TextBox>
        <br />
        <asp:Button runat="server" Text="Send" />
    </div>
</asp:Content>