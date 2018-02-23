<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="details_order.aspx.cs" Inherits="WebApplication14.Admin.details_order" %>

<%@ Register src="../uccustomerdetails.ascx" tagname="uccustomerdetails" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
    <div style="align-self:center">

        <asp:ImageButton ID="ImageButton1" src="IMAGE/back1.jpg" Width="70px"  runat="server" OnClick="ImageButton1_Click" />
        
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="clear & search other transaction" OnClick="clear_search" BackColor="#FFCC00" ForeColor="Blue" />
        <br />
        <br />
    </div>
        <uc1:uccustomerdetails ID="uccustomerdetails1" runat="server" />
        <hr />
        <br />
    </form>
</body>
</html>
