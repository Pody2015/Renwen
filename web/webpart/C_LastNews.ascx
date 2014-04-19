<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_LastNews.ascx.cs" Inherits="webpart_C_LastNews" %>
<ul class="icons ul-list">
    <asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
    <li title=<%# Eval("title") %>>
    <a href='./news.aspx?id=<%# ApplicationMethod.encript(Eval("id").ToString()) %>' title='<%# Eval("addtime", "{0:yyyy.MM.dd}")%>'>
    <%# Eval("title") %></a></li>
    </ItemTemplate>
    </asp:Repeater>
    
</ul>
<div class="clearfix"></div>