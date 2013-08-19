<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="monthlySumery.aspx.cs" Inherits="final_WebApplication.view.monthlySumery" %>

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
    <form style="text-align: center" id="form1" runat="server">
        <div style="background-color: burlywood">
            <div style="text-align: left">
                <asp:Button ID="Button1" runat="server" Text="Back to menu" OnClick="Button1_Click" />
            </div>
            <asp:Label ID="Label1" Text="Monthly Summary." Font-Bold="true" Font-Size="Larger" runat="server" />
            <br />
            <hr />
            <asp:Label ID="Label2" Text="Here you can view a monthly summary, simply choose to display the shifts and employee of the day." Font-Bold="true" Font-Size="Larger" runat="server" />
            <br />

            <hr style="width: 50%" />
            <br />
        </div>
        <div>
            <div>
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" OnSelectionChanged="celanderSel_change">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
                <div class="calendar1-r">
                    <hr>
                    <asp:Table Width="1200px" ID="Table1" runat="server" BackColor="#CA9560" BorderColor="#333300" BorderStyle="Double" BorderWidth="6px" CssClass="auto-style1">
                        <asp:TableHeaderRow>
                            <asp:TableCell Width="160px" Text="  name :  "></asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">00-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">01-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">02-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">03-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">04-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">05-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">06-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">07-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">08-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">09-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">10-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">11-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">12-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">13-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">14-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">15-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">16-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">17-00</asp:TableCell>

                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">18-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">19-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">20-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">21-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">22-00</asp:TableCell>
                            <asp:TableCell BorderColor="Black" BorderWidth="1px" Width="40px">23-00</asp:TableCell>

                        </asp:TableHeaderRow>
                    </asp:Table>

                </div>
                <hr />
            </div>
        </div>
    </form>
</body>
</html>
