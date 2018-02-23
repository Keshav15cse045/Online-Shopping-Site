<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication14._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            text-align:center;
        }
        .auto-style2 {
            height: 102px;
        }
        .auto-style4 {
            width: 500px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            height: 102px;
            width: 887px;
        }
        .auto-style7 {
            width: 870px;
        }
        .auto-style8 {
            height: 31px;
        }
        .auto-style9 {
            height: 25px;
        }
        .auto-style10 {
            height: 24px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server" >
    
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">

            <ContentTemplate>
       
    

        <table class="auto-style1">
            <tr style=" background: linear-gradient(#CCFF33,white);" >
                <td class="auto-style6" style="background: linear-gradient(chartreuse,white);" ><h1 style="font-family:Viner Hand ITC;">Pacific Shopping</h1></td>
                <td class="auto-style2" style="text-align:right;">
                    
                              <asp:LinkButton ID="btncartcount"   runat="server" OnClick="btncartcount_Click" ForeColor="#D70000" style="position:absolute;" Font-Size="X-Large">0</asp:LinkButton>


                    
                    
                    
                   

                   

                              <asp:Image ID="Image67" img src="IMAGE/cart.JPG" runat="server" Height="50" Width="50" />


                    
                    
                    
                   

                   

                </td>
            </tr>
        </table>
        <hr style="color:green" class="auto-style4" />

    
        <br />
        <br />
    


    
        <table class="auto-style1">
            <tr>
                <td class="auto-style7" style="text-align:center;color:cadetblue;font-family:fantasy">                        <asp:ImageButton ImageAlign="left" ID="ImageButton4" runat="server"  ImageUrl="~/IMAGE/back1.JPG" Width="90px" OnClick="back_home"  />&nbsp;&nbsp;&nbsp;
  <br /><br /><br /><br /></td>
                <td><br /><br /><br /><br /></td>
            </tr>
                    
             <tr>
                <td class="auto-style7">
                    <asp:Panel ID="pnlproducts" runat="server" ScrollBars="Auto" BackColor="#FFCC00" >
                        <asp:DataList ID="DataList1" Width="551px" ItemStyle-Width="50px" runat="server" RepeatColumns="3" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" BackColor="#FF9900">
                            <ItemStyle Width="50px" />
                            <ItemTemplate>
                                <table class="auto-style1">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label1" runat="server"  Text='<%# Eval("name") %>' ForeColor="#990000" ></asp:Label>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            
                                            <!--
                                            <asp:Image ID="Image5" runat="server" alt="" src='<%# Eval("productimage") %>'/>
                                             -->
                                            <img alt="" src='<%# Eval("productimage") %>'  runat="server" id="image55"  width="200" border="5" style="border-color: #800000" height="250" />   
                                            
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("price") %>' ForeColor="#990000"></asp:Label>
                                        
                                            Stock:&nbsp;
                                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("availablestock") %>' ForeColor="#990000"></asp:Label>
                                            <asp:HiddenField ID="HiddenField2" runat="server"  Value='<%# Eval("productid") %>'/>


                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="Button1" runat="server" Text="Add to Cart" CommandArgument='<%# Eval("productid") %>' OnClick="addtocart_Click" />

                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:DataList>


                    </asp:Panel>

                    <asp:Panel ID="pnlmycart" runat="server" Visible="false" BackColor="Tomato" >
                        <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                        
                        <asp:DataList ID="dlcartproducts" ItemStyle-Width="50px" runat="server" RepeatColumns="3" BackColor="#FF9900"  >
                            <ItemStyle Width="50px" />
                            <ItemTemplate>
                                <table class="auto-style1">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("name") %>' ForeColor="#990000"></asp:Label>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <!--
                                            <asp:Image ID="Image3" runat="server"  alt="" src='<%# Eval("productimage") %>' />
                                            -->
                                             <img alt="" src='<%# Eval("productimage") %>' runat="server" id="image66" width="200" height="250" border="5" style="border-color: #800000" /> 
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Available Stock:&nbsp;
                                            <asp:Label ID="Label4" runat="server" Text="9"  ForeColor="#990000" ></asp:Label>
                                            <br />
                                          Price:<asp:Label ID="lblprice" runat="server" Text='<%# Eval( "price") %>' ForeColor="#990000"></asp:Label>
                                            &nbsp; <asp:TextBox ID="txtproductquantity" runat="server" MaxLength="1" AutoPostBack="true" Text='<%# Eval("productquantity") %>'   ></asp:TextBox>

                                            <asp:HiddenField ID="HiddenField1" runat="server" value='<%# Eval("productid") %>' />



                                        </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <asp:Button ID="Button2" runat="server" Text="Remove from cart" CommandArgument='<%# Eval("productid") %>' OnClick="remove_cart"   />


                                            <br />


                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:DataList>
                      



                    </asp:Panel>

                     <asp:Panel ID="pnlemptycart" runat="server" Visible="false" BackColor="#FFCC66">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                                            <h1 style="text-align:center;color:blue;font-family:Algerian">Empty Cart</h1>

                    <asp:Image ID="Image2" runat="server" ImageUrl="~/IMAGE/108202825.jpg" Width="400px" />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    
                         </asp:Panel>
                     <table style="width:100%">
                         <tr> 
                                                   <asp:Panel ID="pnlordersuccessfull" Visible="false" runat="server">
                        <h1 style="color:darkgreen;font-family:Algerian">Congratulations order placed successfully..</h1>
                        <br />
                        Check Shipping Status at:<asp:HyperLink ID="HyperLink1" NavigateUrl="~/trackurorder.aspx" runat="server">Here</asp:HyperLink>
                        
                        <tr>
                    <td colspan="3" style="text-align:right; background: linear-gradient(#CCFF33,white);">
                        <hr />
                        <hr />
                                     </td>

                    </asp:Panel>
                    </tr>
                    </table>

                                     


                </td>

                <td style="background-color:burlywood;text-align:center;background-image:url(~/IMAGE/back11.jpg);">
                    <asp:Panel ID="pnlcategories" runat="server" Width="150px" BackImageUrl="~/IMAGE/back11.jpg">
                        <asp:DataList ID="DataList2" runat="server"  BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="#006600" GridLines="Vertical" Width="500px">
                           

                            <AlternatingItemStyle BackColor="White" />
                            <FooterStyle BackColor="#CCCC99" />
                            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                            <ItemStyle BackColor="#F7F7DE" />
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server"  Text='<%# Eval("categoryname") %>' CommandArgument=' <%# Eval("categoryid") %>' OnClick="LinkButton1_Click" BackColor="#FFFF99"></asp:LinkButton>
                            </ItemTemplate>
                            <SelectedItemStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                           

                        </asp:DataList>

                    </asp:Panel>

                      <!--
                    <asp:Panel ID="pnlcheckoutform" runat="server" Visible="false">
                        

                        
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    Name:

                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox2" ForeColor="red"></asp:RequiredFieldValidator>


                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">
                                        Phone No:                                    

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server" MaxLength="10"></asp:TextBox>


                                </td>
                            </tr>
                            <tr>
                                <td>

                                    Email ID:
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">
                                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Address:

                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">
                                    <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Total products:
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">
                                    <asp:TextBox ID="txttotalproducts" runat="server" value="1"></asp:TextBox>


                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">
                                    Total Price:
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="txttotalprice" ReadOnly="true"  runat="server"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>Payment Mode</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                        <asp:ListItem Value="1" Selected="True">1.Cash on delivery</asp:ListItem>
                                        <asp:ListItem Value="2" >2.Payment Gateway</asp:ListItem>


                                    </asp:RadioButtonList>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="Button3" runat="server" Text="Place Order" OnClick="place_order"   />

                                </td>
                            </tr>
                            
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        
                   
                        
                        

                    </asp:Panel>

                -->
                     
                    
                    <asp:Panel ID="Panel1" runat="server" Visible="false" BackColor="#FFFF66">
                           <table class="auto-style1">
                            <tr>
                                <td>
                                    Name:

                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">
                                    <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
                     

                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style10">
                                        Phone No:                                    

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="TextBox33" runat="server" MaxLength="10"></asp:TextBox>


                                </td>
                            </tr>
                            <tr>
                                <td>

                                    Email ID:
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style9">
                                    <asp:TextBox ID="TextBox44" runat="server"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Address:

                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">
                                    <asp:TextBox ID="TextBox55" runat="server" TextMode="MultiLine"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Total products:
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style8">
                                    <asp:TextBox ID="txttotalproduct" runat="server" value="1"></asp:TextBox>


                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style5">
                                    Total Price:
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="txttotalpric" ReadOnly="true"  runat="server"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>Payment Mode</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonLis1" runat="server">
                                        <asp:ListItem Value="1" Selected="True">1.Cash on delivery</asp:ListItem>
                                        <asp:ListItem Value="2" >2.Payment Gateway</asp:ListItem>


                                    </asp:RadioButtonList>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="Button33" runat="server" Text="Place Order" OnClick="place_order"   />

                                </td>
                            </tr>
                            
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                       


                    </asp:Panel>
                   
                                     

                </td>
            </tr>

            <caption>
                <hr style="color:blue" />
                <marquee style="background-color:aquamarine;color:red;">Happy Shopping </marquee>
                <hr style="color:blue" />
                <tr>
                    <td colspan="2" style="text-align:right; background: linear-gradient(#CCFF33,white);">
                        <hr />
                        <hr />
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/IMAGE/trackorder.PNG" OnClick="track_order" Width="150px" />
                        <br />
                        <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Admin/login.aspx" runat="server">Go to Admin</asp:HyperLink>
                        <br />
                        <asp:Image ID="Image3" runat="server" ImageUrl="~/IMAGE/Contactus.JPG" Width="200px" />
                    </td>
                </tr>
               
            </caption>
        </table>



    </ContentTemplate>
     </asp:UpdatePanel>
        
    </form>
</body>
</html>
