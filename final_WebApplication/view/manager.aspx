<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manager.aspx.cs" Inherits="final_WebApplication.view.manager" %>

<!DOCTYPE html>
<link href="../design/HomeStyle.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body class="backround">
    <form id="form1" runat="server">
        <asp:Button ID="Button2" runat="server" Text="Home" OnClick="Button2_Click" />

        <table style="width: 100%;">
            <tr>
                <td style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Text="Management Settings"></asp:Label></td>
                <td style="text-align: center">
                    <asp:Label ID="Label2" runat="server" Text="Reports"></asp:Label></td>
                <td style="text-align: center">
                    <asp:Label ID="Label3" runat="server" Text="Employees"></asp:Label></td>
            </tr>
            <tr>
                <td style="text-align: center">
                    <asp:Button CssClass="button_in_manager_menu" ID="Button1" runat="server" Text="Log file" OnClick="Button1_Click" /></td>
                <td style="text-align: center">
                    <asp:Button CssClass="button_in_manager_menu" ID="Button4" runat="server" Text="Monthly Summary" OnClick="Button4_Click" /></td>
                <td style="text-align: center">
                    <asp:Button CssClass="button_in_manager_menu" ID="Button3" runat="server" Text="New employee" OnClick="Button3_Click" /></td>
            </tr>
            <tr>
                <td style="text-align: center">&nbsp;</td>
                <td style="text-align: center">
                    <asp:Button CssClass="button_in_manager_menu" ID="Button6" runat="server" Text="Real time" OnClick="Button6_Click" /></td>
                <td style="text-align: center">
                    <asp:Button CssClass="button_in_manager_menu" ID="Button5" runat="server" Text="Attendance changing" OnClick="Button5_Click" /></td>
            </tr>
            <tr>
                <td style="text-align: center">&nbsp;</td>
                <td style="text-align: center">
                    <asp:Button CssClass="button_in_manager_menu" ID="Button8" runat="server" Text="List of employees" OnClick="Button8_Click" /></td>
                <td style="text-align: center">
                    <asp:Button CssClass="button_in_manager_menu" ID="Button7" runat="server" Text="Details change" OnClick="Button7_Click" /></td>
            </tr>
            <tr>
                <td style="text-align: center">&nbsp;</td>
                <td style="text-align: center">
                    <asp:Button CssClass="button_in_manager_menu" ID="Button10" runat="server" Text="Statistics" OnClick="Button10_Click" /></td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center">&nbsp;</td>
                <td style="text-align: center">&nbsp;</td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center">&nbsp;</td>
                <td style="text-align: center">&nbsp;</td>
                <td style="text-align: center">&nbsp;</td>
            </tr>
        </table>

    </form>
</body>
</html>
