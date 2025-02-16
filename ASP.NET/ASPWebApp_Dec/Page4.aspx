<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page4.aspx.cs" Inherits="ASPWebApp_Dec.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-top: 151px;
        }
        .auto-style2 {
            height: 33px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            width: 235px;
        }
        .auto-style5 {
            height: 33px;
            width: 235px;
        }
        .auto-style6 {
            height: 26px;
            width: 235px;
        }
        .auto-style7 {
            height: 58px;
        }
        .auto-style8 {
            width: 235px;
            height: 58px;
        }
        .auto-style9 {
            height: 58px;
            width: 123px;
        }
        .auto-style10 {
            width: 123px;
        }
        .auto-style11 {
            height: 33px;
            width: 123px;
        }
        .auto-style12 {
            height: 26px;
            width: 123px;
        }
        .auto-style13 {
            height: 58px;
            width: 307px;
        }
        .auto-style14 {
            width: 307px;
        }
        .auto-style15 {
            height: 33px;
            width: 307px;
        }
        .auto-style16 {
            height: 26px;
            width: 307px;
        }
        .auto-style17 {
            height: 58px;
            width: 436px;
        }
        .auto-style18 {
            width: 436px;
        }
        .auto-style19 {
            height: 33px;
            width: 436px;
        }
        .auto-style20 {
            height: 26px;
            width: 436px;
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
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem Value="1">Red</asp:ListItem>
                        <asp:ListItem Value="2">white</asp:ListItem>
                        <asp:ListItem Value="3">Black</asp:ListItem>
                        <asp:ListItem Value="4">Yellow</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style9"></td>
                <td class="auto-style17">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                        <asp:ListItem Value="1">Male</asp:ListItem>
                        <asp:ListItem Value="11">Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style7"></td>
                <td class="auto-style13">
                    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                        <asp:ListItem Value="1">SSLC</asp:ListItem>
                        <asp:ListItem Value="2">PLUS TWO</asp:ListItem>
                        <asp:ListItem Value="3">BTECH</asp:ListItem>
                        <asp:ListItem Value="4">MTECH</asp:ListItem>
                    </asp:ListBox>
                </td>
                <td class="auto-style7"></td>
                <td class="auto-style7">
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        <asp:ListItem>A</asp:ListItem>
                        <asp:ListItem>B</asp:ListItem>
                        <asp:ListItem>C</asp:ListItem>
                        <asp:ListItem>D</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td class="auto-style7"></td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Select" />
                </td>
                <td class="auto-style11"></td>
                <td class="auto-style19">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Select" />
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style15">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="height: 29px" Text="Select" />
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Select" />
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style6">
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style12"></td>
                <td class="auto-style20">
                    <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3"></td>
                <td class="auto-style16">
                    <asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3"></td>
                <td class="auto-style3">
                    <asp:Label ID="Label7" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style12"></td>
                <td class="auto-style20">
                    <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3"></td>
                <td class="auto-style16">
                    <asp:Label ID="Label6" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style3"></td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style6"></td>
                <td class="auto-style12"></td>
                <td class="auto-style20"></td>
                <td class="auto-style3"></td>
                <td class="auto-style16"></td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Label ID="Label8" runat="server" Text="Photo"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style6"></td>
                <td class="auto-style12"></td>
                <td class="auto-style20">
                    <asp:Button ID="Button5" runat="server" Text="Save" OnClick="Button5_Click" />
                </td>
                <td class="auto-style3"></td>
                <td class="auto-style16"></td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style18">
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style18">
                    <asp:Image ID="Image1" runat="server" Height="237px" Width="354px" />
                </td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
