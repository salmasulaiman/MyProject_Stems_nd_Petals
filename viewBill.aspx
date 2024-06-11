<%@ Page Title="" Language="C#" MasterPageFile="~/mstr/Site2.Master" AutoEventWireup="true" CodeBehind="viewBill.aspx.cs" Inherits="MyProject.viewBill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style6 {
            height: 27px;
        }
        .auto-style7 {
            width: 209px;
        }
        .auto-style8 {
            width: 209px;
            height: 27px;
        }
        .auto-style9 {
            width: 208px;
        }
        .auto-style10 {
            width: 208px;
            height: 27px;
        }
        .auto-style11 {
            height: 52px;
        }
        .auto-style12 {
            width: 566px;
        }
        .auto-style13 {
            height: 27px;
            width: 566px;
        }
        .auto-style14 {
            height: 52px;
            width: 87px;
        }
        .auto-style17 {
            height: 52px;
            width: 119px;
        }
        .auto-style19 {
            height: 52px;
            width: 116px;
        }
        .auto-style20 {
            height: 52px;
            width: 89px;
        }
        .auto-style21 {
            height: 52px;
            width: 66px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style12">Bill Number</td>
            <td class="auto-style7">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">Name</td>
            <td class="auto-style7">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">Address</td>
            <td class="auto-style7">
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">Date</td>
            <td class="auto-style7">
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13">
                <asp:DataList ID="DataList1" runat="server" Height="58px" RepeatColumns="1" Width="625px">
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style17">Product name</td>
                                <td class="auto-style19">
                                    <asp:Label ID="Label6" runat="server" Text='<%# Eval("Product_Name") %>'></asp:Label>
                                </td>
                                <td class="auto-style14">Quantity</td>
                                <td class="auto-style20">
                                    <asp:Label ID="Label7" runat="server" Text='<%# Eval("quantity") %>'></asp:Label>
                                </td>
                                <td class="auto-style21">Price<br /> </td>
                                <td class="auto-style11">
                                    <asp:Label ID="Label8" runat="server" Text='<%# Eval("price") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </td>
            <td class="auto-style8"></td>
            <td class="auto-style6"></td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style6"></td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">Total Amount</td>
            <td class="auto-style7">
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td class="auto-style8"></td>
            <td class="auto-style6"></td>
            <td class="auto-style10"></td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style7">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click here to payment" />
            </td>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
