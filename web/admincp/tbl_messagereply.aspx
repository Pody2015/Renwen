<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tbl_messagereply.aspx.cs" Inherits="admincp_tbl_messagereply" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="border:1px solid #F0F0F0;margin-bottom: 10px;">
            <div style=" background:#F0F9F9">
            <strong style="line-height: 32px;font-size: 18px;"> &nbsp;
            <%=title %>
            </strong></div>
            <div style="padding: 0 12px;">
            <span style="color:red"><%=name %>：</span>于[<%=asktime %>]询问：
                <div style="border: 1px dashed #dddddd;padding: 5px 10px;border-bottom: none;">
                <%=conts %>
                </div>
            </div>
            <div style="padding: 0 12px;">
                <div style="border: 1px dashed #dddddd;background-color: #f9f9f9;padding: 5px 10px;margin-bottom: 10px;">
  
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" MaxLength="500" Height="100px" Width="430px"></asp:TextBox>
                </div>
                <asp:Button ID="Button1" runat="server" Text="回复" onclick="Button1_Click" />
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                请不要反问用户。若邮件发送失败请再点击一次回复，谢谢！</div>
        </div>
    </div>
    </form>
</body>
</html>
