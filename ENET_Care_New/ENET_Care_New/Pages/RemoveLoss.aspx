<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RemoveLoss.aspx.cs" Inherits="ENET_Care_New.Pages.RemoveLoss" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="span8 offset2">
       <br />
       <asp:label runat="server">
           Package:
       </asp:label>
        <asp:dropdownlist AppendDataBoundItems="true" runat="server">
            <asp:ListItem Value="Ibuprofen">
                Ibuprofen
            </asp:ListItem>
        </asp:dropdownlist>
        <br />
       <asp:Button runat="server" text="Remove Loss" />
    </div>
</asp:Content>
    
