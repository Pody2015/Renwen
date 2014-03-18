<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sysRoleFunction.aspx.cs" Inherits="admincp_sysRoleFunction" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:Repeater ID="Repeater1" runat="server" 
            onitemcommand="Repeater1_ItemCommand">
            <ItemTemplate>
            <div style=" float:left; width:200px; background-color:#eeeeee">
                <asp:HiddenField ID="HiddenField1" runat="server" Value=<%# Eval("FunctionID") %> />
                <asp:Label ID="lb_FunctionName1" runat="server" Text="lb_FunctionName"></asp:Label>
                <asp:Button ID="btn_Delete1" runat="server" CommandName="delete" CommandArgument=<%# Eval("ID") %> Text="删除" />
            </div>
            </ItemTemplate>
        </asp:Repeater>
        <div style=" clear:both"></div>
        新增功能：
        <asp:DropDownList ID="ddl_Function" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btn_AddFunction" runat="server" Text="新增功能" 
            onclick="btn_AddFunction_Click" />
    </div>
    </form>
</body>
</html>
