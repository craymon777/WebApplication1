<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Show" runat="server"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;+
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;=
            <asp:Label ID="Result" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Calculate" Width="439px" OnClick="Button1_Click" />
        </p>
    <table>
        <tr>
            <td>Username: </td>
            <td>
                <asp:TextBox ID="Username" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Password: 
            </td>
            <td>
                <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Check" runat="server" Text=""></asp:Label>
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Login" Width="167px" Height="36px" OnClick="Button2_Click" />
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>
