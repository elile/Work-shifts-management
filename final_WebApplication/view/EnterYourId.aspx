<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnterYourId.aspx.cs" Inherits="final_WebApplication.view.EnterYourId" %>

<!DOCTYPE html>
<link href="../design/HomeStyle.css" rel="stylesheet" />

<head>
  
    <html xmlns="http://www.w3.org/1999/xhtml">
    <style type="text/css">
        .auto-style1 {
            top: 697px;
            left: 492px;
        }
    </style>
</head>

<body class="backround">
    <div class="bodyClass">
        <form id="form1" runat="server" aria-haspopup="True" aria-orientation="horizontal">
            <div class="clockMain">

                <script type="text/javascript" src="http://www.worldtimeserver.com/clocks/embed.js"></script>
                <script type="text/javascript" language="JavaScript">objIL = new Object; objIL.wtsclock = "wtsclock001.swf"; objIL.color = "7E3817"; objIL.wtsid = "IL"; objIL.width = 200; objIL.height = 200; objIL.wmode = "transparent"; showClock(objIL);</script>
            </div>
            <asp:Label CssClass="date" ID="date" runat="server" Text="date" Font-Bold="False" Font-Italic="True" Font-Names="Vladimir Script" Font-Size="50pt" ForeColor="#663300"></asp:Label>
            <asp:Label ID="Label1" runat="server" CssClass="enterIdLabel" Font-Italic="True" ForeColor="#663300">** System requires to insert ID number, so in order to identify the signature card, or the manager.
If you do not have such a number, or you&#39;re not set on the system, called the Human Resources department in order to be put into a database.</asp:Label>
            <div>
                <hr class="imageLogPass" />
                <asp:Button ID="Button1" runat="server" CssClass="ButtonLogin" Font-Names="Agency FB" Font-Size="X-Large" OnClick="Button1_Click" Style="top: 641px; left: 665px; width: 91px" Text="Login" />

                <asp:TextBox ID="TextBox1" runat="server" CssClass="textBoxEnterId"></asp:TextBox>

                <asp:TextBox ID="TextBox2" TextMode="Password" runat="server" CssClass="textBoxEnterPass"></asp:TextBox>

                <asp:Label ID="Label2" runat="server" CssClass="LabelId" Font-Names="Agency FB" Font-Size="X-Large" Text="Enter Id :"></asp:Label>

                <asp:Label ID="Label3" runat="server" CssClass="LabelPass" Font-Names="Agency FB" Font-Size="X-Large" Text="Password :"></asp:Label>
                <asp:Label ID="Label4" runat="server" CssClass="labalIncorect auto-style1" Font-Size="Large" ForeColor="Red" Text="Username and \ or password are incorrect" Visible="False"></asp:Label>
            </div>
        </form>
    </div>

</body>
</html>
