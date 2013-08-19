<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAllShifts.aspx.cs" Inherits="final_WebApplication.ShowAllShifts" %>

<!DOCTYPE html>
<link href="../design/HomeStyle.css" rel="stylesheet" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body class="backround">
    <form id="form1" runat="server">
        <div style="text-align: center; width: auto; direction: ltr; height: 438px;">
            <div>
                <hr />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <hr />
            </div>
            <div style="text-align: center;">
                <div style="width: 50%; margin: 0 auto; text-align: left;">

                    <hr>
                    <asp:Table Width="650px" ID="Table1" runat="server" BackColor="#C18446" BorderColor="#333300" BorderStyle="Double" BorderWidth="6px">
                    </asp:Table>
                    <hr />
                </div>
            </div>


            <div style="text-align: center; height: 291px;">
                <hr>
                <asp:Button CssClass="button_backAfterAllShifts" ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
                <hr />
            </div>
        </div>
    </form>
</body>
</html>
