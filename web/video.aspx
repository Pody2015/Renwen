<%@ Page Title="在线视频 - 浙江树人大学招生网" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="video.aspx.cs" Inherits="video" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="page-header">
        <img src="./styles/images/1000x180.png" width="1000" height="180" alt="">
    </div>
    <h1 class="text-center">
        <asp:Label ID="lb_title" runat="server" Text="浙江树人大学校园在线"></asp:Label>
    </h1>
    <div class="portfolio-overview text-center row-fluid" style="background-color: #333333">
        <embed type="application/x-shockwave-flash" src='<%= videourl %>'
            id="movie_player" name="movie_player" bgcolor="#FFFFFF" quality="high" allowfullscreen="true"
            flashvars="isShowRelatedVideo=false&showAd=0&show_pre=1&show_next=1&isAutoPlay=false&isDebug=false&UserID=&winType=interior&playMovie=true&MMControl=false&MMout=false&RecordCode=1001,1002,1003,1004,1005,1006,2001,3001,3002,3003,3004,3005,3007,3008,9999"
            pluginspage="http://www.macromedia.com/go/getflashplayer" class="span8" height="450"></embed>
        <div class="span4" style="padding-top:10px">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
            <div class="media">
                <a class="pull-left" href='video.aspx?id=<%# ApplicationMethod.encript(Eval("id").ToString()) %>'>
                    <img src='<%# Eval("thumb") %>' class="media-object" alt="" style="opacity: 1; height:74px; width:94px">
                </a>
                <div class="media-body">
                    <h4 class="media-heading"><a style="color:#fff" href='video.aspx?id=<%# ApplicationMethod.encript(Eval("id").ToString()) %>'><%# Eval("title") %></a>
                        <small class=""><%# Eval("addtime","{0:yyyy-MM-dd HH:mm:ss}") %></small>
                    </h4>
                    
                </div>
            </div>
                    </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <hr />
    <div class="portfolio-overview">
        <%= conts %>
    </div>


</asp:Content>

