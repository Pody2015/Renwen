<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tbl_zhuanyeadd.aspx.cs" Inherits="admincp_tbl_zhuanyeadd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <div>
    <p><label>专业名称：</label>
    <asp:TextBox ID="tb_name" runat="server" Width="323px"></asp:TextBox></p>
    <p><label style="vertical-align: top">详细描述：</label>
        
        </p>
    <p><label>所属学院：</label>
        <asp:DropDownList ID="ddl_xueyuanid" runat="server">
        </asp:DropDownList>
    </p>
        <asp:Button ID="btn_add" runat="server" Text="保 存" onclick="btn_add_Click" />
    </div>
    </form>
</body>
</html>
