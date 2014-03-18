<%@ Page Language="C#" validateRequest="false" AutoEventWireup="true" CodeFile="tbl_newsadd.aspx.cs" Inherits="admincp_tbl_newsadd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/core.css" rel="stylesheet" type="text/css" />
<link href="css/css3.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../ueditor/editor_all.js"></script>
<script type="text/javascript" src="../ueditor/editor_config.js"></script>
<link rel="stylesheet" href="../ueditor/themes/default/ueditor.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p><label>标题：</label>
    <asp:TextBox ID="tb_title" runat="server" Width="323px"></asp:TextBox></p>
    <p><label>作者：</label>
    <asp:TextBox ID="tb_author" runat="server"></asp:TextBox></p>
    <p><label>分类：</label>
        <asp:DropDownList ID="ddl_leiid" runat="server">
        </asp:DropDownList>
    </p>
    <div>
    <script type="text/plain" id="myEditor"><%=cont %></script>
    <script type="text/javascript">
        var editor = new baidu.editor.ui.Editor({
            textarea: 'myValue'
        });
        editor.render("myEditor");
    </script>
</div>
        <asp:Button ID="btn_add" runat="server" Text="增加" CssClass="button" 
            onclick="btn_add_Click" />
    </div>
    </form>
</body>
</html>
