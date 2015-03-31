<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LoginContent" runat="server">
    <br />
    <br />
    <br />
<div class="span4 offset4">
	<h4>Sign In</h4>
	
		
		<form action="/siabweb/users/login" id="UserLoginForm" method="post" accept-charset="utf-8">
            <div style="display:none;">
                <input type="hidden" name="_method" />

            </div>
            <div class="input text required">
                <label>Username</label>
                <input maxlength="40" type="text" id="Username" required="required"/>

            </div>
            <div class="input password required">
                <label>Password</label>
                <input type="password" id="Password" required="required"/>

            </div>
            <div class="submit">
                <input  class="btn btn-default" type="submit" value="Login"/>

            </div>

		</form>		
		
		
		<a href="#">Forgot Password</a>
    </div>

</asp:Content>
