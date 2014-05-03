<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Button ID="Button1" runat="server" Text="Button" 
    onclick="Button1_Click" />

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="Button" onclick="Button2_Click" />

    <br />
    <asp:Button ID="Button3" runat="server" Text="Button" onclick="Button3_Click" />
    </div>
    </form>
</body>
</html>
