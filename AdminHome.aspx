<%@ Page Title="" Language="C#" MasterPageFile="~/mstr/Site2.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="MyProject.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
            width: 83px;
        }
    .auto-style2 {
            width: 83px;
            height: 27px;
        }
    .auto-style3 {
        height: 27px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="Black" PostBackUrl="~/add_edit_cat.aspx">add or edit category</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="Black" PostBackUrl="~/add_edit_product.aspx">add or edit product</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td class="auto-style2"></td>
        <td class="auto-style3">
            <asp:LinkButton ID="LinkButton3" runat="server" ForeColor="Black" PostBackUrl="~/User_view.aspx">view registered users  list</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2"></td>
        <td class="auto-style3">
            <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/MailSend.aspx">View user feedback</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td class="auto-style2"></td>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:LinkButton ID="LinkButton5" runat="server" PostBackUrl="~/viewPaidCustmr.aspx">View Paid Customers</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td class="auto-style2"></td>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
