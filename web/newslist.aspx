<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="newslist.aspx.cs" Inherits="newslist" %>

<%@ Register src="webpart/C_LastNews.ascx" tagname="C_LastNews" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<%= GetMetaTags() %>
<%= GetMetaDescription() %>
<meta name="author" content="小D" />
<meta name="copyright" content="2009-2012 Dsrj Studio Team." />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-header">
        <img src="./styles/images/1000x180.png" width="1000" height="180" alt="树人全景">
    </div>
    <div class=" fixed">
        <div class=" col580">
            <h1><asp:Label ID="lb_title" runat="server" Text="您查看的页面不存在！"></asp:Label></h1>
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
    <div class="text-right">
        <asp:Literal ID="RecordCount" runat="server"></asp:Literal>条资讯
        共有<asp:Literal ID="PageCount" runat="server"></asp:Literal>页
        当前第<asp:Literal ID="Pageindex" runat="server"></asp:Literal>页
            <asp:HyperLink ID="FirstPage" runat="server" Text="首页"></asp:HyperLink>
            <asp:HyperLink ID="PrevPage" runat="server" Text="上一页"></asp:HyperLink>
            <asp:HyperLink ID="NextPage" runat="server" Text="下一页"></asp:HyperLink>
            <asp:HyperLink ID="LastPaeg" runat="server" Text="尾页"></asp:HyperLink>
        跳转到<asp:Literal ID="Literal1" runat="server"></asp:Literal>页
        </div>
        </div>
        <div class=" col280 last">
            <h1>&nbsp;</h1>
            <h5>树人语录</h5>
            <p style="margin-bottom: 20px; text-indent: 2em">
                <%= GetGeyan() %></p>
            <h5>最新消息</h5>
            <uc1:c_lastnews ID="C_LastNews1" runat="server" />
            <p style="margin-bottom: 20px">&nbsp;</p>
            <h5>学校视频</h5>
<embed type="application/x-shockwave-flash"src='<%= GetVideo() %>'
 id="movie_player" name="movie_player" bgcolor="#FFFFFF" quality="high" allowfullscreen="true"
 flashvars="isShowRelatedVideo=false&showAd=0&show_pre=1&show_next=1&isAutoPlay=false&isDebug=false&UserID=&winType=interior&playMovie=true&MMControl=false&MMout=false&RecordCode=1001,1002,1003,1004,1005,1006,2001,3001,3002,3003,3004,3005,3007,3008,9999"
 pluginspage="http://www.macromedia.com/go/getflashplayer" width="280" height="195"></embed>
        </div>
    </div>
</asp:Content>

