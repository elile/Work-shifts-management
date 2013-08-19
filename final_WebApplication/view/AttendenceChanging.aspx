<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AttendenceChanging.aspx.cs" Inherits="final_WebApplication.view.AttendenceChanging" %>

<!DOCTYPE html>
<link href="../design/HomeStyle.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
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
        <asp:Button ID="Button3" runat="server" Text="Update changes" Height="27px" Width="250px" OnClick="Button3_Click" />
        <br />
        <asp:Button ID="Button2" Height="27px" Width="250px" runat="server" Text="Back" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="* This screen displays only the shifts of the last month"></asp:Label>
        <br />
        <br />
        <asp:Table ID="Table1" runat="server" Style="text-align: center; margin-left: auto; width: 30%; margin-right: auto">
            <asp:TableRow Style="text-align: center">
                <asp:TableCell>
                    <asp:Label ID="Label5" runat="server" Text="Start"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label3" runat="server" Text="End"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label4" runat="server" Text="Start date"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label6" runat="server" Text="End date"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox1" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox2" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox3" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox4" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox5" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox6" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox7" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox8" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox9" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox10" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox11" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox12" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox13" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox14" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox15" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox16" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox17" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox18" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox19" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox20" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox21" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox22" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox23" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox24" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox25" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox26" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox27" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox28" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox29" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox30" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox31" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox32" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox33" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox34" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox35" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox36" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox37" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox38" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox39" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox40" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox41" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox42" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox43" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox44" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox45" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox46" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox47" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox48" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox49" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox50" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox51" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox52" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox53" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox54" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox55" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox56" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox57" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox58" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox59" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox60" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox61" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox62" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox63" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox64" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox65" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox66" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox67" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox68" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox69" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox70" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox71" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox72" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox73" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox74" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox75" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox76" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox77" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox78" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox79" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox80" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox81" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox82" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox83" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox84" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox85" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox86" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox87" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox88" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox89" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox90" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox91" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox92" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox93" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox94" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox95" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox96" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox97" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox98" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox99" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox100" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox101" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox102" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox103" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox104" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox105" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox106" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox107" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox108" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox109" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox110" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox111" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox112" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox113" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox114" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox115" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox116" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox117" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox118" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox119" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox120" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox121" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox122" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox123" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox124" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox125" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox126" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox127" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox Visible="false" ID="TextBox128" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>

        </asp:Table>
        </div>
    </form>
</body>
</html>
