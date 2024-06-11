<%@ Page Title="" Language="C#" MasterPageFile="~/mstr/Site2.Master" AutoEventWireup="true" CodeBehind="one_product.aspx.cs" Inherits="MyProject.one_product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 501px;
        }
        .auto-style3 {
            width: 501px;
            height: 27px;
        }
        .auto-style4 {
            height: 27px;
        }
        .auto-style6 {
            width: 401px;
        }
        .auto-style7 {
            width: 401px;
            height: 27px;
        }
        .auto-style8 {
            width: 501px;
            height: 444px;
        }
        .auto-style9 {
            width: 401px;
            height: 444px;
        }
        .auto-style10 {
            height: 444px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                </td>
            <td class="auto-style9">
                <asp:Image ID="Image1" runat="server" Width="387px" />
            </td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
            </td>
            <td class="auto-style7">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                Rs</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style6">
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style6">
                   <div class="qty-input">
	                   Quantity</div>
               
            </td>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Button ID="Button3" runat="server" Text="-" Width="31px" Font-Bold="true" OnClick="Button3_Click" />
                        <asp:TextBox ID="TextBox1" runat="server" Width="50px"></asp:TextBox>
                        <asp:Button ID="Button4" runat="server" Font-Bold="true" OnClick="Button4_Click" Text="+" Width="31px" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="please order atleast one quantity"></asp:RequiredFieldValidator>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                   &nbsp;</td>
            <td class="auto-style7">
                   &nbsp;</td>
            <td class="auto-style2">
          
                &nbsp;</tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style6">
                <asp:Button ID="Button1" runat="server" Text="Add to cart" OnClick="Button1_Click" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Continue.." OnClick="Button2_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
