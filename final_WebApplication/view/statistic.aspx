<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="statistic.aspx.cs" Inherits="final_WebApplication.statistic" %>

<!DOCTYPE html>
<link href="../design/HomeStyle.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 1306px;
        }
    </style>
</head>
<body class="backround">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <div style="background-color: burlywood">
                <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
                <hr />
                <div style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Text="Statistics" Font-Size="Larger"></asp:Label>
                </div>
                <br />
                <div style="text-align: center">
                    <asp:Label ID="Label2" runat="server" Text="here you can watch Statistics on your business" Font-Size="Larger"></asp:Label>
                    <hr style="width: 70%" />
                </div>
                <br />
                <hr />
                <br />
            </div>
            <div style="text-align:center">
                <br />
                <asp:Label ID="Label3" runat="server" Text="The following graph shows the total payment to employees in each month."></asp:Label>

            </div>
            <br />
            <div style="width: 85%; position: absolute; background-color: azure; height: 90%; left: 10%">
                <br />
                <div style="width: 90%; position: absolute; left: 5%">
                    <asp:Chart ID="Chart2" Width="1000px" runat="server" OnLoad="Chart2_Load">
                        <Series>
                            <asp:Series Name="Series1"></asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </div>
                <br />


            </div>
        </div>
    </form>
</body>
</html>
