<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Basketball._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="panel1" runat="server"><ContentTemplate>
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlSpelers" runat="server" Height="28px" Width="282px">
    </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ListBox ID="ListBox1" runat="server" Height="76px" Width="177px"></asp:ListBox>
        </ContentTemplate></asp:UpdatePanel>
&nbsp;<asp:Button ID="bnAdd" runat="server" OnClick="bnAdd_Click" Text="Add" />
    <asp:Label ID="lbName" runat="server" Text="Name:"></asp:Label>
    <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
</asp:Content>

