<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="trackurorder.aspx.cs" Inherits="WebApplication14.trackurorder" %>

<%@ Register src="uccustomerdetails.ascx" tagname="uccustomerdetails" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton ImageAlign="left" ID="ImageButton4" runat="server"  ImageUrl="IMAGE/back1.JPG" Width="90px" OnClick="ImageButton4_Click" />
            <br />
            <br />

    </div>
        
         <uc1:uccustomerdetails ID="uccustomerdetails1" runat="server" />
   
    </form>
</body>
</html>
