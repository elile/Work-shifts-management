<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employee.aspx.cs" Inherits="final_WebApplication.view.employee" %>

<!DOCTYPE html>
<link href="../design/HomeStyle.css" rel="stylesheet" />


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body class="backround">
    <form id="form1" runat="server">
        <asp:Button ID="Button4" Text="Home" runat="server" OnClick="Button4_Click" />
        <br />
        <div style="text-align: center">
            <script type="text/javascript" src="http://www.worldtimeserver.com/clocks/embed.js"></script>
            <script type="text/javascript" language="JavaScript">objIL = new Object; objIL.wtsclock = "wtsclock001.swf"; objIL.color = "0000FF"; objIL.wtsid = "IL"; objIL.width = 200; objIL.height = 200; objIL.wmode = "transparent"; showClock(objIL);</script>
            <br />
            <hr />
        </div>
        <div style="text-align: center">
            <asp:Button ID="Button1" runat="server" CssClass="buttonEnter" Text="Start a shift" OnClick="Button1_Click" />
            <br />
            <hr />
        </div>
        <div style="text-align: center">
            <asp:Button ID="Button2" runat="server" CssClass="buttonExit" Text="End shift" OnClick="Button2_Click" />
            <br />
            <hr />
        </div>
        <div style="text-align: center">
            <asp:Button ID="Button3" Text="Show all my shifts" CssClass="button_ShowAllShifts" runat="server" OnClick="Button3_Click" />
            <br />
            <hr />

        </div>

    </form>
</body>
</html>
