<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="ASPWebApp_Dec.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 297px;
        }
        .auto-style3 {
            width: 384px;
        }
        .auto-style5 {
            width: 270px;
        }
        .auto-style6 {
            width: 280px;
        }
        .auto-style7 {
            height: 29px;
        }
        .auto-style8 {
            width: 280px;
            height: 29px;
        }
        .auto-style9 {
            width: 297px;
            height: 29px;
        }
        .auto-style10 {
            width: 270px;
            height: 29px;
        }
        .auto-style11 {
            width: 384px;
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">
                    <asp:Label ID="num1" runat="server" Text="Number 1"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtnum1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:Label ID="num2" runat="server" Text="Number 2"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtnum2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="add" runat="server" Font-Bold="True" Font-Size="Medium" Height="30px" OnClick="add_Click" Text="+" Width="101px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="subtract" runat="server" Font-Bold="True" Font-Size="Medium" Height="30px" OnClick="subtract_Click" Text="-" Width="101px" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="multiply" runat="server" Font-Bold="True" Font-Size="Medium" Height="30px" OnClick="multiply_Click" Text="*" Width="101px" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="divide" runat="server" Font-Bold="True" Font-Size="Medium" Height="30px" OnClick="divide_Click" Text="/" Width="101px" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style6">
                    <asp:Label ID="outputAdd" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="outputSubtract" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="outputMultiply" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="outputDivide" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Page1.aspx">Page 1</asp:HyperLink>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
