<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="page.aspx.cs" Inherits="page" ViewStateMode="Disabled" %>

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
            <section style="display:none">
                <h3 class="widget-title">Blog Archives</h3>
                <div class="accordion" id="accordion2">
                    <div class="accordion-group">
                        <div class="accordion-heading">
                            <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapse1">
                                <i class="icon-minus icon-white"></i>
                                December 2012
                            </a>
                        </div>
                        <div id="collapse1" class="accordion-body collapse in">
                            <div class="accordion-inner">
                                <ul class="icons ul-list-2">
                                    <li><a href="#">Wed Design</a></li>
                                    <li><a href="#">Responsive</a></li>
                                    <li><a href="#">HTML5 / CSS3</a></li>
                                    <li><a href="#">Coding Essentials</a></li>
                                    <li><a href="#">SEO Optimization</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="accordion-group">
                        <div class="accordion-heading">
                            <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapse2">
                                <i class="icon-plus icon-white"></i>
                                November 2012
                            </a>
                        </div>
                        <div id="collapse2" class="accordion-body collapse">
                            <div class="accordion-inner">
                                <ul class="icons ul-list-2">
                                    <li><a href="#">Wed Design</a></li>
                                    <li><a href="#">Responsive</a></li>
                                    <li><a href="#">HTML5 / CSS3</a></li>
                                    <li><a href="#">Coding Essentials</a></li>
                                    <li><a href="#">SEO Optimization</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="accordion-group">
                        <div class="accordion-heading">
                            <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapse3">
                                <i class="icon-plus icon-white"></i>
                                October 2012
                            </a>
                        </div>
                        <div id="collapse3" class="accordion-body collapse">
                            <div class="accordion-inner">
                                <ul class="icons ul-list-2">
                                    <li><a href="#">Wed Design</a></li>
                                    <li><a href="#">Responsive</a></li>
                                    <li><a href="#">HTML5 / CSS3</a></li>
                                    <li><a href="#">Coding Essentials</a></li>
                                    <li><a href="#">SEO Optimization</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="accordion-group">
                        <div class="accordion-heading">
                            <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapse4">
                                <i class="icon-plus icon-white"></i>
                                September 2012
                            </a>
                        </div>
                        <div id="collapse4" class="accordion-body collapse">
                            <div class="accordion-inner">
                                <ul class="icons ul-list-2">
                                    <li><a href="#">Wed Design</a></li>
                                    <li><a href="#">Responsive</a></li>
                                    <li><a href="#">HTML5 / CSS3</a></li>
                                    <li><a href="#">Coding Essentials</a></li>
                                    <li><a href="#">SEO Optimization</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="accordion-group">
                        <div class="accordion-heading">
                            <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapse5">
                                <i class="icon-plus icon-white"></i>
                                August 2012
                            </a>
                        </div>
                        <div id="collapse5" class="accordion-body collapse">
                            <div class="accordion-inner">
                                <ul class="icons ul-list-2">
                                    <li><a href="#">Wed Design</a></li>
                                    <li><a href="#">Responsive</a></li>
                                    <li><a href="#">HTML5 / CSS3</a></li>
                                    <li><a href="#">Coding Essentials</a></li>
                                    <li><a href="#">SEO Optimization</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="accordion-group">
                        <div class="accordion-heading">
                            <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapse6">
                                <i class="icon-plus icon-white"></i>
                                July 2012
                            </a>
                        </div>
                        <div id="collapse6" class="accordion-body collapse">
                            <div class="accordion-inner">
                                <ul class="icons ul-list-2">
                                    <li><a href="#">Wed Design</a></li>
                                    <li><a href="#">Responsive</a></li>
                                    <li><a href="#">HTML5 / CSS3</a></li>
                                    <li><a href="#">Coding Essentials</a></li>
                                    <li><a href="#">SEO Optimization</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
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
            <section>
                <h3 class="widget-title">Latest Work</h3>
                <div id="latestwork-sidebar" class="carousel slide">
                    <div class="carousel-inner">
                        <div class="item active">
                            <img src="example/latest3.jpg" alt="photo"></div>
                        <div class="item">
                            <img src="example/latest4.jpg" alt="photo"></div>
                        <div class="item">
                            <img src="example/latest5.jpg" alt="photo"></div>
                    </div>
                    <a class="carousel-control left" href="#latestwork-sidebar" data-slide="prev"></a>
                    <a class="carousel-control right" href="#latestwork-sidebar" data-slide="next"></a>
                </div>
                <script type="text/javascript">
                    $(document).ready(function () {
                        $('.carousel').carousel({
                            interval: 5000
                        })
                    });
                </script>
            </section>
            <!--Flickr -->
            <section>
                <h3 class="widget-title">Flickr</h3>
                <ul class="sidebar-flickr clearfix">
                    <li class="thumbnail"><a rel="prettyPhoto[flickr]" href="http://farm3.staticflickr.com/2842/13493135915_3d1327bcf1.jpg" title="Azenha do Mar">
                        <img src="http://farm3.staticflickr.com/2842/13493135915_3d1327bcf1_s.jpg" alt="Azenha do Mar"><span class="frame-overlay"></span></a></li>
                    <li class="thumbnail"><a rel="prettyPhoto[flickr]" href="http://farm4.staticflickr.com/3732/13330417625_f56cb31037.jpg" title="Spring Waltz for you">
                        <img src="http://farm4.staticflickr.com/3732/13330417625_f56cb31037_s.jpg" alt="Spring Waltz for you"><span class="frame-overlay"></span></a></li>
                    <li class="thumbnail"><a rel="prettyPhoto[flickr]" href="http://farm4.staticflickr.com/3772/13090307495_47f5ec31f2.jpg" title="We are LIGHT - Somos LUZ">
                        <img src="http://farm4.staticflickr.com/3772/13090307495_47f5ec31f2_s.jpg" alt="We are LIGHT - Somos LUZ"><span class="frame-overlay"></span></a></li>
                    <li class="thumbnail"><a rel="prettyPhoto[flickr]" href="http://farm4.staticflickr.com/3424/13066331693_8c0781a32c.jpg" title="Lago di Resia">
                        <img src="http://farm4.staticflickr.com/3424/13066331693_8c0781a32c_s.jpg" alt="Lago di Resia"><span class="frame-overlay"></span></a></li>
                    <li class="thumbnail"><a rel="prettyPhoto[flickr]" href="http://farm8.staticflickr.com/7406/12972457425_139f04f155.jpg" title="Pamukkale">
                        <img src="http://farm8.staticflickr.com/7406/12972457425_139f04f155_s.jpg" alt="Pamukkale"><span class="frame-overlay"></span></a></li>
                    <li class="thumbnail"><a rel="prettyPhoto[flickr]" href="http://farm6.staticflickr.com/5504/11969960704_48ed6fc9fe.jpg" title="Illa da Toxa">
                        <img src="http://farm6.staticflickr.com/5504/11969960704_48ed6fc9fe_s.jpg" alt="Illa da Toxa"><span class="frame-overlay"></span></a></li>
                    <li class="thumbnail"><a rel="prettyPhoto[flickr]" href="http://farm8.staticflickr.com/7303/12642620875_7af70aa94d.jpg" title="Today I celebrate my birthday and over 9 million views to my gallery. Thanks to all! ;-))">
                        <img src="http://farm8.staticflickr.com/7303/12642620875_7af70aa94d_s.jpg" alt="Today I celebrate my birthday and over 9 million views to my gallery. Thanks to all! ;-))"><span class="frame-overlay"></span></a></li>
                    <li class="thumbnail"><a rel="prettyPhoto[flickr]" href="http://farm4.staticflickr.com/3798/12370245425_b525284c96.jpg" title="Magic moment">
                        <img src="http://farm4.staticflickr.com/3798/12370245425_b525284c96_s.jpg" alt="Magic moment"><span class="frame-overlay"></span></a></li>
                </ul>
            </section>

        </aside>

    </div>
</asp:Content>
