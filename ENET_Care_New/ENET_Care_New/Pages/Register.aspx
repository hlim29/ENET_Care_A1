<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ENET_Care_New.Pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div>
          <h1>Register a package</h1>
       <asp:label runat="server">
           Package Type:
       </asp:label>
          <asp:DropDownList ID="PackageTypeDropDown" runat="server" AutoPostBack="True" OnSelectedIndexChanged="PackageTypeDropDown_SelectedIndexChanged">
          </asp:DropDownList>
        <br />
        
       <asp:label runat="server">
           Expire Date:
       </asp:label>
        <asp:TextBox runat="server" ID="txtBoxExpiry" ReadOnly="True"></asp:TextBox>
        <asp:Calendar runat="server" ID="CalendarExpiry" OnSelectionChanged="CalendarExpiry_SelectionChanged">
        </asp:Calendar>
        <br />
       <asp:Button runat="server" text="Register" OnClick="Unnamed4_Click" />
    </div>
</asp:Content>
