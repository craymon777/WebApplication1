<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="WebApplication1.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content-wrapper" style="margin: 20px 0;">
        <div style="background-color: lightblue; width: 25%;margin:auto;">
            <div style="text-align:center;padding:5px;font-size:1.2em;">
                Login
            </div>
            <div style="margin:auto;width:70%;">
                <table>
                    <tr>
                        <td>Username: </td>
                        <td>
                            <asp:TextBox ID="RegUsername" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Password: </td>
                        <td>
                            <asp:TextBox ID="RegPassword" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="RegResult" runat="server" Text=""></asp:Label>
                        </td>
                        <td>
                            <asp:Button Text="Register" runat="server" OnClick="Unnamed1_Click"  />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
