<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Button ID="Button1" runat="server" Text="Button" 
    onclick="Button1_Click" />

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="Button" onclick="Button2_Click" />

    <br />
    <asp:Button ID="Button3" runat="server" Text="Button" onclick="Button3_Click" />
</asp:Content>

