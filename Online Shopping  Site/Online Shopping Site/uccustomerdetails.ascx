<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uccustomerdetails.ascx.cs" Inherits="WebApplication14.uccustomerdetails" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        height: 20px;
    }
</style>
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:Label ID="Label1" runat="server" Text="CustomerId" ForeColor="#000066"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="search" OnClick="search_userdetail" BackColor="#FFCC00" />

        <table class="auto-style1">
    <tr>
       
        <td>
             <hr />
            <asp:RadioButtonList ID="RadioButtonList1" RepeatDirection="Horizontal" AutoPostBack="true" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Selected="True" Value="1">customer details</asp:ListItem>
                <asp:ListItem Value="2">product details</asp:ListItem>
                <asp:ListItem Value="3">delievery status</asp:ListItem>
             </asp:RadioButtonList>
                  
             <hr />

        </td>
       
       
    </tr>
    <tr>
        <td>
            <asp:Panel ID="Panel1" runat="server">



                <table class="auto-style1">
                    <tr >
                        <td style="text-align:center;align-content:center;align-items:center;align-self:center">
                            <asp:Image ID="Image1"  runat="server" img src="IMAGE/users.JPG"  ImageAlign="Middle" height="100" Width="150"/>


                        </td>
                    
                    <td>
                        <table>
                            <tr>
                        <td style="text-align:center">Name</td>
                        <td style="text-align:left">
                             <asp:Label ID="Label2" runat="server" Text="Label" ForeColor="#003366"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:center">PhoneNo</td>
                        <td style="text-align:left">
                          <asp:Label ID="Label3" runat="server" Text="Label" ForeColor="#003366"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:center">EmailId</td>
                        <td style="text-align:left">
                              <asp:Label ID="Label4" runat="server" Text="Label" ForeColor="#003366"></asp:Label>

                        </td>


                    </tr>
                    <tr>
                        <td style="text-align:center">TotalPrice</td>
                        <td style="text-align:left">
                            <asp:Label ID="Label5" runat="server" Text="Label" ForeColor="#003366"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:center">TotalProducts</td>
                        <td style="text-align:left">
                            <asp:Label ID="Label6" runat="server" Text="Label" ForeColor="#003366"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:center">Address</td>
                        <td style="text-align:left">
                           <asp:Label ID="Label7" runat="server" Text="Label" ForeColor="#003366"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:center">Payment Mode</td>
                        <td style="text-align:left">
                          <asp:Label ID="Label8" runat="server" Text="Label" ForeColor="#003366"></asp:Label>
                        </td>
                        </table>
                        </td>
                        </tr>
                </table>



            </asp:Panel>

            <asp:Panel ID="Panel2" runat="server">



                <table class="auto-style1">
                    <tr>
                        <td><asp:Image ID="Image2" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DataList ID="DataList1" runat="server">
                                <ItemTemplate>
                                    <table class="auto-style1">
                                        <tr>
                                            <td colspan="2">
                                                <asp:Label ID="Label9" runat="server" Text='<%# Eval("name") %>'></asp:Label>

                                            </td>
                                            
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <img ID="Image3" runat="server" alt="" src='<%# Eval("productimage") %>' width="200" />


                                            </td>
                                           
                                        </tr>
                                        <tr>
                                            <td>
                                              Price:   <asp:Label ID="Label10" runat="server" Text='<%# Eval("price") %>'></asp:Label>
                                                

                                            </td>
                                            <td>
                                              Quantity:  <asp:Label ID="Label11" runat="server" Text='<%# Eval("productquantity") %>'></asp:Label>

                                            </td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:DataList>


                        </td>
                    </tr>
                </table>

            </asp:Panel>
            <asp:Panel ID="Panel3" runat="server">


                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">
                            <asp:Image ID="Image4" runat="server" />


                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>

                        </td>
                    </tr>
                    <tr>
                        <td>
                           <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> &nbsp;&nbsp;  <asp:Button ID="Button2" runat="server" Text="Update Status" OnClick="update_status" BackColor="#FFCC00" />
                           

                        </td>
                    </tr>
                </table>


            </asp:Panel>

            <asp:Panel ID="Panel4" runat="server">
                <asp:Image ID="Image5" runat="server" />

            </asp:Panel>




            

            





        </td>
       
    </tr>
</table>
    </ContentTemplate>

</asp:UpdatePanel>


 