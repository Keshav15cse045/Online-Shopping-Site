<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication14.Admin.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
           
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
            width: 652px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1" style="background-color:burlywood">
            <tr>
                <td colspan="2" style="text-align:center">
                    
                    <asp:Label ID="Label1" runat="server" Text="Pacific Shopping [Admin]"></asp:Label>
                    <hr />
                </td>
                
            </tr>
            <tr>
                <td style="text-align:right" class="auto-style2">LoginId </td>
                <td style="text-align:center" class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td style="text-align:right" class="auto-style2">Password</td>
                <td style="text-align:center" class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>


                </td>
            </tr>
            <tr>
               
                <td></td>
                <td colspan="2"  style="align-content:center;text-align:left">
                     <br />
                <br />
                <br />
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />


                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Label ID="Label2"  runat="server"></asp:Label>


                </td>
               
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
