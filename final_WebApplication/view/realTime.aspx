<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="realTime.aspx.cs" Inherits="final_WebApplication.view.realTime" %>

<!DOCTYPE html>
<link href="../design/HomeStyle.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
    </style>
</head>
<body class="backround">
    <form id="form1" runat="server">
        <div>
            <div style="background-color: burlywood">

                <div>
                    <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
                </div>
                <hr />
                <div style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Text="Real Time" Font-Size="Larger"></asp:Label>
                </div>
                <br />
                <div style="text-align: center">
                    <asp:Label ID="Label2" runat="server" Text="Here you can watch who from your worker is in."></asp:Label>
                    <hr style="width: 50%" />
                </div>
                <br />
            </div>
            <br />
            <div style="text-align: center">
                <div>
                    <asp:Label ID="Label3" runat="server" Text="Work up to 8 hours  " Font-Size="20px" BackColor="Lime" Width="280px"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="Label4" runat="server" Text="Works over 8 hours and under 10  " Font-Size="20px" BackColor="Yellow" Width="280px"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="Label5" runat="server" Text="Working over 10 hours  " Font-Size="20px" BackColor="Red" Width="280px"></asp:Label>
                </div>
                <br />
            </div>
            <div>
            </div>
        </div>


    </form>
</body>
</html>
