<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListOfEmployee.aspx.cs" Inherits="final_WebApplication.view.ListOfEmployee" %>

<!DOCTYPE html>
<link href="../design/HomeStyle.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                    <asp:Label ID="Label1" runat="server" Text="List of employees" Font-Size="Larger"></asp:Label>
                </div>
                <br />
                <div style="text-align: center">
                    <asp:Label ID="Label2" runat="server" Text="Here you can watch all the employee details."></asp:Label>
                    <hr style="width: 50%" />
                </div>
                <br />
            </div>
            <br />
            <div style="text-align: center">
                
            </div>
        </div>
    </form>
</body>
</html>
