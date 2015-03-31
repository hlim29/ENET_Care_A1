<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" MasterPageFile="~/Agent.Master" %>

<asp:Content id="RegisterPage" ContentPlaceHolderID="AgentContent" runat="server">
    <div class="span8 offset2">
       <br />
       <br />
       <br />
       <asp:label runat="server">
           Package Type:
       </asp:label>
        <asp:TextBox runat="server">
        </asp:TextBox>
        <br />
        
       <asp:label runat="server">
           Expire Date:
       </asp:label>
        <asp:TextBox runat="server">

        </asp:TextBox>
        <asp:Calendar runat="server">
        </asp:Calendar>
        <br />
       <asp:Button runat="server" text="Register" />
    </div>
</asp:Content>
