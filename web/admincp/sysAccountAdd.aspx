<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sysAccountAdd.aspx.cs" Inherits="admincp_sysAccountAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>
    <label>用户名：</label>
        <asp:TextBox ID="tb_name" runat="server"></asp:TextBox>
    </p>
    <p>
    <label>密码：</label>
        <asp:TextBox ID="tb_Psw" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="保 存" />
    </p>
    <p>
    <label>角色：</label>
        <asp:DropDownList ID="ddl_role" runat="server" AutoPostBack="True" 
            onselectedindexchanged="ddl_role_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
        <p>必须先保存后指定用户角色。</p>
    </div>
    </form>
</body>
</html>
