<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="changeDetailsForEmployee.aspx.cs" Inherits="final_WebApplication.view.changeDetailsForEmployee" %>

<!DOCTYPE html>
<link href="../design/HomeStyle.css" rel="stylesheet" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            direction: ltr;
        }
    </style>
</head>
<body class="backround">
    <form id="form1" runat="server">
        <div style="text-align: center; height: 234px;">
            <div style="background-color: burlywood">
                <div style="text-align: left">
                    <asp:Button ID="Button4" runat="server" Text="Back" CssClass="auto-style2" OnClick="Button4_Click" />
                </div>
                <hr />
                <asp:Label ID="Label1" runat="server" Text="Select an employee to edit its shifts." Font-Size="X-Large"></asp:Label>
                <hr />
                <br />
            </div>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style1" Height="27px" Width="250px"></asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Select" Height="27px" Width="250px" OnClick="Button1_Click" />
            <br />
            <br />
            Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2" Width="140px"></asp:TextBox>
            <br />
            <br />
            Id :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:TextBox Enabled="false" ID="TextBox2" runat="server" Width="140px"></asp:TextBox>
            <br />
            <br />
            Hourly wage : &nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="140px"></asp:TextBox>
            <br />
            <br />
            Password :&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Width="140px"></asp:TextBox>
            <br />
            <br />
            Type :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" Width="142px" runat="server">
                <asp:ListItem Value="employee">employee</asp:ListItem>
                <asp:ListItem>manager</asp:ListItem>
            </asp:DropDownList>

            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Ok" OnClick="Button2_Click" CssClass="auto-style1" Width="108px" />
            <br />
            <hr />
        </div>
    </form>
</body>
</html>
