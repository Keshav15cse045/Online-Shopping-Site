<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="allproducts.aspx.cs" Inherits="WebApplication14.Admin.allproducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table  style="width: 100% " >
        <tr>
            <td>
                <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="697px">
                    <Columns>
                        <asp:BoundField DataField="categoryid" HeaderText="categoryid" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
                        </asp:BoundField>
                         <asp:BoundField DataField="productid" HeaderText="Productid" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
                        </asp:BoundField>
                         <asp:BoundField DataField="name" HeaderText="name" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="price" HeaderText="price" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
                        </asp:BoundField>
                     
                        <asp:ImageField DataImageUrlField="productimage" ControlStyle-Width="150" />
                          <asp:BoundField DataField="productquantity" HeaderText="ProductQuantity" ItemStyle-Width="150" >
                <ItemStyle Width="150px"></ItemStyle>
                        </asp:BoundField>

                         <asp:BoundField DataField="categoryname" HeaderText="CategoryName" ItemStyle-Width="150" >
                <ItemStyle Width="150px"></ItemStyle>
                        </asp:BoundField>

                         <asp:BoundField DataField="productsold" HeaderText="productsold" ItemStyle-Width="150" >
                <ItemStyle Width="150px"></ItemStyle>
                        </asp:BoundField>

                         <asp:BoundField DataField="availablestock" HeaderText="availablestock" ItemStyle-Width="150" >
                <ItemStyle Width="150px"></ItemStyle>
                        </asp:BoundField>
                    </Columns>

                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />

                </asp:GridView>


            </td>
        </tr>
    </table>


</asp:Content>
