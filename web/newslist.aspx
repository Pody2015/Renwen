<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="newslist.aspx.cs" Inherits="newslist" %>

<%@ Register Src="webpart/C_LastNews.ascx" TagName="C_LastNews" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <%= GetMetaTags() %>
    <%= GetMetaDescription() %>
    <meta name="author" content="小D" />
    <meta name="copyright" content="2009-2012 Dsrj Studio Team." />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="page-header">
        <img src="./styles/images/1000x180.png" width="1000" height="180" alt="树人全景">
    </div>
    <div class="row">
        <section id="page-sidebar" class="pull-left span8">
            <h1>
                <asp:Label ID="lb_title" runat="server" Text="您查看的页面不存在！"></asp:Label></h1>
         
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <article class="blog-post">
                            <div class="row">
                                <div class="span8">
                                    <h3 class="post-title">
                                        <a href='./news.aspx?id=<%# ApplicationMethod.encript(Eval("id").ToString()) %>' >
                                <%# Eval("title") %></a></h3>
                                    <ul class="post-meta">
                                        <li><i class="icon-calendar"></i><a href="#"><%# Eval("addtime", "{0:yyyy.MM.dd}")%></a></li>
                                        <li><i class="icon-user"></i><a href="#"><%# Eval("author")%></a></li>
                                        <li><i class="icon-list-alt"></i><a href="#">News</a>, <a href="#">Web Design</a></li>
                                        <li><i class="icon-tag"></i><a href="#">CSS3</a> <a href="#">HTML5</a> <a href="#">Responsive</a></li>
                                        <li><i class="icon-comment"></i><a href="#">12 Comments</a></li>
                                    </ul>
                                    <div class="post-media">
                                        <img src="temple/example/blog2.jpg" alt="" >
                                    </div>
                                    <div class="post-content">
                                        <p>
                                            <%# ApplicationMethod.NoHtmlCode(Eval("conts").ToString(),250) %>
                                        </p>
                                        <p><a href='./news.aspx?id=<%# ApplicationMethod.encript(Eval("id").ToString()) %>' class="btn btn-large btn-welcome"><i class="icon-chevron-right"></i> 继续阅读</a></p>
                                    </div>
                                </div>
                            </div>
                        </article>
                        <hr />
                    </ItemTemplate>
                </asp:Repeater>
        
            <div class="pagination pull-right">
                <asp:Literal ID="RecordCount" runat="server"></asp:Literal>条资讯
        共有<asp:Literal ID="PageCount" runat="server"></asp:Literal>页
        当前第<asp:Literal ID="Pageindex" runat="server"></asp:Literal>页
            <asp:HyperLink ID="FirstPage" runat="server" Text="首页"></asp:HyperLink>
                <asp:HyperLink ID="PrevPage" runat="server" Text="上一页"></asp:HyperLink>
                <asp:HyperLink ID="NextPage" runat="server" Text="下一页"></asp:HyperLink>
                <asp:HyperLink ID="LastPaeg" runat="server" Text="尾页"></asp:HyperLink>
                跳转到<asp:Literal ID="Literal1" runat="server"></asp:Literal>页
            </div>
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
</asp:Content>

