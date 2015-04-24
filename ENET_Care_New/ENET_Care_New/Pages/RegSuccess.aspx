<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegSuccess.aspx.cs" Inherits="ENET_Care_New.Pages.RegSuccess" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Package registration success</h1>
    <asp:Label ID="PrefixLabel" runat="server" Text="The package has been successfully registered. The barcode is: "></asp:Label>
    <asp:Label ID="BarcodeLabel" runat="server" Text=""></asp:Label>
    <br />
    <div id="barcode">
        <asp:PlaceHolder ID="BarcodePlaceholder" runat="server"></asp:PlaceHolder>
    </div>
    <br />
    <input type="button" id="btnPrint" value="Print barcode" onclick="PrintImage()" />
    <br />

    <script language="javascript" type="text/javascript">
        function PrintImage() {
            printWindow = window.open("", "mywindow", "location=1,status=1,scrollbars=1,width=600,height=600");
            printWindow.document.write("<div style='width:100%;'>");
            printWindow.document.write(document.getElementById('barcode').innerHTML);
            printWindow.document.write("</div>");
            printWindow.document.close();
            printWindow.print();
        }
    </script>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pages/Register.aspx">Register another</asp:HyperLink>
</asp:Content>
