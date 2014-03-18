<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_LastNews.ascx.cs" Inherits="webpart_C_LastNews" %>
<ul class="side-nav">
    <asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
    <li style="float: left;width: 100%;" title=<%# Eval("title") %>>
    <a href='./news.aspx?id=<%# ApplicationMethod.encript(Eval("id").ToString()) %>' style="width: 65%;float: left;white-space: nowrap;overflow: hidden;">
    <%# Eval("title") %></a>
    <div style="float: right;padding: 10px 0 10px 10px;">[<%# Eval("addtime", "{0:yyyy.MM.dd}")%>]</div></li>
    </ItemTemplate>
    </asp:Repeater>
    
</ul>
