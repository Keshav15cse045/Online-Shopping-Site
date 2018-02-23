<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="addnew_category.aspx.cs" Inherits="WebApplication14.Admin.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <hr />
     <table style="width: 212%">
        <tr>
            <td colspan="2" style="text-align:center;box-shadow:inherit;width:100%; height: 26px; border-bottom-style: double; border-bottom-color: brown; border-bottom-width: medium;">ADD CATEGORY</td>
        </tr>
        <tr>
            <td>
                <br />
                <br />
                 <asp:Label ID="Label1" runat="server" Text="Category" ForeColor="#003366"></asp:Label>

            </td>
            <td>
                
                <br />
                <br />
                <asp:TextBox ID="TextBox1" runat="server" BackColor="#FFCC00"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td colspan="2">
                <br />
                <asp:Button ID="Button1" runat="server" Text="Add" OnClick="addnew_category" BackColor="#FF9900" />

            </td>
            
        </tr>
    </table>


</asp:Content>
