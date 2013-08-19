<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogFile.aspx.cs" Inherits="final_WebApplication.view.defultSetting" %>

<!DOCTYPE html>
<link href="../design/HomeStyle.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body class="backround">
    <form id="form1" runat="server">
        <div style="background-color: burlywood">
            <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
            <div style="text-align: center">
                <hr />
                <asp:Label ID="Label1" Text="Log File" Font-Bold="true" Font-Size="Larger" runat="server" />
                <br />
                <hr />
                <br />
            </div>
        </div>
        <br />
        <div>
            <asp:Table CssClass="dinamicTable" ID="Table1" runat="server"></asp:Table>
        </div>
    </form>
</body>
</html>
