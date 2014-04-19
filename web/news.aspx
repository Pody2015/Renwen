<%@ Page Title="" Language="C#" ViewStateMode="Disabled" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="news" %>

<%@ Register Src="webpart/C_LastNews.ascx" TagName="C_LastNews" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <%= GetMetaTags() %>
    <%= GetMetaDescription() %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="page-header">
        <img src="./styles/images/1000x180.png" width="1000" height="180" alt="树人全景">
    </div>
    <div class="row">
        <section id="page-sidebar" class="pull-left span8">
            <article class="blog-post">
                <div class="row">
                    <div class="span8">
                        <h3 class="post-title"><a href="#"><asp:Label ID="lb_title" runat="server" Text="您查看的页面不存在！" ViewStateMode="Disabled"></asp:Label></a></h3>
                        <div class="post-media">
                            <asp:Literal ID="lt_Media" runat="server"></asp:Literal></div>
                        <ul class="post-meta">
                            <li><i class="icon-calendar"></i><a href="#">October 30, 2012</a></li>
                            <li><i class="icon-user"></i><a href="#">DXThemes</a></li>
                            <li><i class="icon-list-alt"></i><a href="#">News</a>, <a href="#">Web Design</a></li>
                            <li><i class="icon-tag"></i><a href="#">CSS3</a> <a href="#">HTML5</a> <a href="#">Responsive</a></li>
                            <li><i class="icon-comment"></i><a href="#">12 Comments</a></li>
                        </ul>
                        <div class="post-content">
                            <asp:Label ID="lb_Cont" runat="server" Text="" ViewStateMode="Disabled"></asp:Label>
                        </div>
                        
                    </div>

                </div>
            </article>
        </section>
        <aside id="sidebar" class="pull-right span4">
            <section>
                <h3 class="widget-title">人文语录</h3>
                <p><%= GetGeyan() %></p>
            </section>
            <section>
                <h3 class="widget-title">最新消息</h3>
                <uc1:C_LastNews ID="C_LastNews1" runat="server" />
            </section>
            <section class="popular-posts">
                <h3 class="widget-title">最新视频</h3>
                <div class="media">
                    <embed type="application/x-shockwave-flash" src='<%= GetVideo() %>' id="movie_player"
                    name="movie_player" bgcolor="#FFFFFF" quality="high" allowfullscreen="true" flashvars="isShowRelatedVideo=false&showAd=0&show_pre=1&show_next=1&isAutoPlay=false&isDebug=false&UserID=&winType=interior&playMovie=true&MMControl=false&MMout=false&RecordCode=1001,1002,1003,1004,1005,1006,2001,3001,3002,3003,3004,3005,3007,3008,9999"
                    pluginspage="http://www.macromedia.com/go/getflashplayer" width="100%" height="295"></embed>
                </div>
            </section>
            
            
            <!--twitter -->
            <section>
                <h3 class="widget-title">微博</h3>
                <div class="">
                    <p class="">
                        
                    </p>
                </div>
                
            </section>
            
            

        </aside>

    </div>
    <%--<div class=" fixed">
        <div class=" col580 last" style="width: 880px">
            <div class=" col280 last" style="background-color: white; padding: 0 0 10px 10px;
                float: right;">
                <h1>
                    &nbsp;</h1>
                <h5>
                    树人语录</h5>
                <p style="margin-bottom: 20px; text-indent: 2em">
                    <%= GetGeyan() %></p>
                <h5>
                    最新消息</h5>
                <uc1:C_LastNews ID="C_LastNews1" runat="server" />
                <p style="margin-bottom: 20px">
                    &nbsp;</p>
                <h5>
                    学校视频</h5>
                <embed type="application/x-shockwave-flash" src='<%= GetVideo() %>' id="movie_player"
                    name="movie_player" bgcolor="#FFFFFF" quality="high" allowfullscreen="true" flashvars="isShowRelatedVideo=false&showAd=0&show_pre=1&show_next=1&isAutoPlay=false&isDebug=false&UserID=&winType=interior&playMovie=true&MMControl=false&MMout=false&RecordCode=1001,1002,1003,1004,1005,1006,2001,3001,3002,3003,3004,3005,3007,3008,9999"
                    pluginspage="http://www.macromedia.com/go/getflashplayer" width="280" height="195"></embed>
            </div>
            <h1>
                <asp:Label ID="lb_title" runat="server" Text="您查看的页面不存在！"></asp:Label></h1>
            <asp:Label ID="lb_Cont" runat="server" Text=""></asp:Label>
        </div>
    </div>--%>
</asp:Content>
