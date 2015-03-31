<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script runat="server">

  void Logon_Click(object sender, EventArgs e)
  {
    if ((UserEmail.Text == "admin@enetcare.com") && (UserPass.Text == "123456"))
    {
          FormsAuthentication.RedirectFromLoginPage (UserEmail.Text, Persist.Checked);
    }
    else
    {
          Msg.Text = "Invalid credentials. Please try again.";

    }
}

</script>
</asp:Content>
<asp:Content ID="Login" ContentPlaceHolderID="LoginContent" runat="server">
    <div class="offset2 span8">
        <br />
        <br />
        <br />
       <h3>
          Sign In</h3>
        <table>
          <tr>
            <td>
              E-mail address:
            </td>
            <td>
              <asp:TextBox ID="UserEmail" runat="server" /></td>
            <td>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="UserEmail" Display="Dynamic" ErrorMessage="Cannot be empty."  runat="server" />
            </td>
          </tr>
          <tr>
            <td>
              Password:
            </td>
            <td>
              <asp:TextBox ID="UserPass" TextMode="Password" runat="server" />
            </td>
            <td>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="UserPass" ErrorMessage="Cannot be empty." runat="server" />
            </td>
          </tr>
          <tr>
            <td>
              Remember me?
            </td>
            <td>
              <asp:CheckBox ID="Persist" runat="server" />
            </td>
          </tr>
        </table>
        
        <asp:Button ID="Submit1" OnClick="Logon_Click" Text="Log On" runat="server" />

        <p>
          <asp:Label ID="Msg" ForeColor="red" runat="server" />
        </p>
    </div>
</asp:Content>
