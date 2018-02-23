<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="orderdetails.aspx.cs" Inherits="WebApplication14.Admin.orderdetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table style="width: 100%">
        <tr>
            <td>
                <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                    <Columns>
                        <asp:BoundField DataField="customerid" HeaderText="id" ItemStyle-Width="100" >
<ItemStyle Width="100px"></ItemStyle>
                        </asp:BoundField>
                          <asp:BoundField DataField="customername" HeaderText="Name" ItemStyle-Width="100" >
<ItemStyle Width="100px"></ItemStyle>
                        </asp:BoundField>
                          <asp:BoundField DataField="customerphoneno" HeaderText="Phone" ItemStyle-Width="100" >
<ItemStyle Width="100px"></ItemStyle>
                        </asp:BoundField>
                          <asp:BoundField DataField="totalproducts" HeaderText="Total Products" ItemStyle-Width="100" >
<ItemStyle Width="100px"></ItemStyle>
                        </asp:BoundField>
                          <asp:BoundField DataField="totalprice" HeaderText="Total price" ItemStyle-Width="100" >
<ItemStyle Width="100px"></ItemStyle>
                        </asp:BoundField>
                    <asp:TemplateField>
                        <ItemTemplate>
                        <asp:HyperLink  id="hyper1" runat="server" NavigateUrl='<%# Eval("customerid","~/Admin/details_order.aspx?customerid={0}") %>' Text="view details" Target="_blank" />
                   </ItemTemplate>
                             </asp:TemplateField>
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
