<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyInformation.aspx.cs" MasterPageFile="~/Agent.Master ~/Manager.Master" %>

<asp:Content id="MyInformation" ContentPlaceHolderID="AgentContent ManagerContent" runat="server">
    <div class="span8 offset2">
       <br />
       <br />
       <br />
        <asp:Label runat="server">
            Name:
        </asp:Label>
        <asp:textbox runat="server">

        </asp:textbox>
        <br />
        <asp:Label runat="server">
            Email:
        </asp:Label>
        <asp:TextBox runat="server">

        </asp:TextBox>
        <br />
        <asp:Label runat="server">
            Password:
        </asp:Label>
        <asp:TextBox runat="server">

        </asp:TextBox>
        <asp:Button runat="server" text="Change" />
        <br />
        <asp:Label runat="server">
            Dist. Centre:
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
        <asp:button runat="server" Text="Cancel" />
        <asp:Button runat="server" Text="Save" />
    </div>
</asp:Content>
