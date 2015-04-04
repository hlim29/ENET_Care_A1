<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="span4 offset4">
	<br />
	<br />
	<br />
	<h4>Sign In</h4>
	
		<div class="input text required">
			<asp:Label runat="server">Username</asp:Label>
			<asp:TextBox runat="server"></asp:TextBox>
		</div>
		<div class="input password required">
			<asp:Label runat="server">Password</asp:Label>
			<asp:TextBox runat="server" textmode="Password"></asp:TextBox>
		</div>
		<div class="submit ">
			<asp:Button runat="server"  text="Login" />
		</div>
		
    </div>
</asp:Content>
