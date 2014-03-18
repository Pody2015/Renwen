<%@ Page Title="在线视频 - 浙江树人大学招生网" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="video.aspx.cs" Inherits="video" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="page-header">
        <img src="./styles/images/1000x180.png" width="1000" height="180" alt="">
    </div>
    <h1 class="text-center">
        <asp:Label ID="lb_title" runat="server" Text="浙江树人大学校园在线"></asp:Label>
    </h1>
<div class="portfolio-overview text-center" style=" background-color:#666666">
<embed type="application/x-shockwave-flash"src='<%= videourl %>'
 id="movie_player" name="movie_player" bgcolor="#FFFFFF" quality="high" allowfullscreen="true"
 flashvars="isShowRelatedVideo=false&showAd=0&show_pre=1&show_next=1&isAutoPlay=false&isDebug=false&UserID=&winType=interior&playMovie=true&MMControl=false&MMout=false&RecordCode=1001,1002,1003,1004,1005,1006,2001,3001,3002,3003,3004,3005,3007,3008,9999"
 pluginspage="http://www.macromedia.com/go/getflashplayer" width="780" height="455"></embed>


</div>
<hr />
<div class="portfolio-overview">
<%= conts %>
</div>
<hr />

<div class="portfolio-overview">
<ul class="fixed">
                <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                <li <%# ((Container.ItemIndex+1)%3!=0)?"":"class='last'" %>>
                    <img src='<%# Eval("thumb") %>' width="280" height="170" alt="" style="opacity: 1;">
                    <h5>
                        <a href='video.aspx?id=<%# ApplicationMethod.encript(Eval("id").ToString()) %>'><%# Eval("title") %></a></h5>
                    <p>
                        <%# Eval("addtime","{0:yyyy-MM-dd HH:mm:ss}") %></p>
                </li>
                </ItemTemplate>
                </asp:Repeater>
                
            </ul>
</div>
  
</asp:Content>

