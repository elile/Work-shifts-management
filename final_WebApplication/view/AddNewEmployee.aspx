<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewEmployee.aspx.cs" Inherits="final_WebApplication.view.AddNewEmployee" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>
<link href="../design/HomeStyle.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        .auto-style1 {
            direction: ltr;
        }

        .auto-style2 {
            direction: ltr;
        }
    </style>
</head>
<body class="backround">
    <form style="text-align: center" id="form1" runat="server">
        <div style="background-color: burlywood">
            <div style="text-align: left">
                <asp:Button ID="Button3" runat="server" Text="Back" CssClass="auto-style2" OnClick="Button3_Click" />
            </div>

            <hr />
            <asp:Label Text="Insert a new employee" Font-Bold="true" Font-Size="Larger" runat="server" />
            <br />
            <hr />
            <br />
        </div>
        <br />
        Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2" Width="140px"></asp:TextBox>
        *<br />
        <br />
        Id :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="140px"></asp:TextBox>
        *<br />
        <br />
        Hourly wage : &nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="140px"></asp:TextBox>
        *<br />
        <br />
        Password :&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Width="140px"></asp:TextBox>
        *<br />
        <br />
        Type :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" Width="142px" runat="server">
            <asp:ListItem Value="employee">employee</asp:ListItem>
            <asp:ListItem>manager</asp:ListItem>
        </asp:DropDownList>

        *<br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Ok" OnClick="Button1_Click" CssClass="auto-style1" Width="108px" />
        <br />
        <asp:Label Text="* One or more fields are missing." ForeColor="Red" runat="server" ID="ErrLabel" />
        <br />
        <asp:Label Text="* User already exists." ForeColor="Red" runat="server" ID="ErrLabel2" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Back" Width="108px" OnClick="Button2_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="User insert Ok." ForeColor="Green"></asp:Label>
        <hr />

    </form>
</body>
</html>
