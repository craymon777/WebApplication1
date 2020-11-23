<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CourseList.aspx.cs" Inherits="WebApplication1.CourseList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" DataKeyNames="id" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting" OnRowCommand="GridView1_RowCommand" >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="ID">
                <ItemTemplate>
                    <asp:Label ID="lbID" Text='<%# Bind("id") %>' runat="server"></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="lbID_edt" Text='<%# Bind("id") %>' runat="server"></asp:Label>
                </EditItemTemplate>
                <FooterTemplate></FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Course Name">
                <ItemTemplate>
                    <asp:Label ID="lbCourseName" Text='<%# Bind("name") %>' runat="server"></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tbCourseName" Text='<%# Bind("name") %>' runat="server"></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tbCourseName_foot" runat="server"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Course Code">
                <ItemTemplate>
                    <asp:Label ID="lbCourseCode" Text='<%# Bind("code") %>' runat="server"></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tbCourseCode" Text='<%# Bind("code") %>' runat="server"></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tbCourseCode_foot" runat="server"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Venue">
                <ItemTemplate>
                    <asp:Label ID="lbVenue" Text='<%# Bind("venue") %>' runat="server"></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tbVenue" Text='<%# Bind("venue") %>' runat="server"></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tbVenue_foot" runat="server"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Timeline">
                <ItemTemplate>
                    <asp:Label ID="lbTimeline" Text='<%# Bind("timeline") %>' runat="server"></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tbTimeline" Text='<%# Bind("timeline") %>' runat="server"></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tbTimeline_foot"  runat="server"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Lecturer">
                <ItemTemplate>
                    <asp:Label ID="lbLecturer" Text='<%# Bind("username") %>' runat="server"></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:DropDownList ID="ddlLecturer" DataSourceID="SqlDataSource1" DataTextField="username" DataValueField="id" runat="server"></asp:DropDownList>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:DropDownList ID="ddlLecturer_foot" DataSourceID="SqlDataSource1" DataTextField="username" DataValueField="id" runat="server"></asp:DropDownList>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowEditButton ="true" />
            <asp:CommandField ShowDeleteButton="true" />
                
            <asp:TemplateField HeaderText="Command">
                
                <FooterTemplate>
                    <asp:LinkButton ID="Insert" CommandName="Insert" Text="Insert" runat="server"></asp:LinkButton>
                </FooterTemplate>
            </asp:TemplateField>
        </Columns>
        
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
       
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:campusoneConnectionString %>" SelectCommand="SELECT [username], [id] FROM [Users]"></asp:SqlDataSource>

    <asp:Button ID="btn_insert" Text="Add Course" runat="server" OnClick="btn_insert_Click" />
</asp:Content>
