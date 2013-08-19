<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm_example.aspx.cs" Inherits="final_WebApplication.view.WebForm_example" %>
<!DOCTYPE html>
<head>
<link href="../design/HomeStyle.css" rel="stylesheet" />

<html xmlns="http://www.w3.org/1999/xhtml">

<style type="text/css">
    #form1 {
        direction: ltr;
    }
</style>
    </head>

<body class="backround">
    <div class="bodyClass">
        <div class="clockMain">

            <script type="text/javascript" src="http://www.worldtimeserver.com/clocks/embed.js"></script>
            <script type="text/javascript" language="JavaScript">objIL = new Object; objIL.wtsclock = "wtsclock001.swf"; objIL.color = "7E3817"; objIL.wtsid = "IL"; objIL.width = 200; objIL.height = 200; objIL.wmode = "transparent"; showClock(objIL);</script>
        </div>
        <form id="form1" runat="server">
            <asp:Button CssClass="button_login" ID="Button_login" runat="server" Text="Stamping Card" BackColor="#996633" ForeColor="Black" OnClick="Button1_Click" />
            <asp:Label CssClass="date" ID="date" runat="server" Text="date" Font-Bold="False" Font-Italic="True" Font-Names="Vladimir Script" Font-Size="50pt" ForeColor="#663300"></asp:Label>
            <asp:Button CssClass="button_mang" ID="button_mang" runat="server" Text="Settings Manager" BackColor="#996633" ForeColor="Black" OnClick="button_mang_Click" />
        </form>
    </div>
</body>
</html>
