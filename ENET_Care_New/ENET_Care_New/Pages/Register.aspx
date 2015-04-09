<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ENET_Care_New.Pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div>
          <h1>Register a package</h1>
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
