<%@ Page Title="在线视频 - 浙江树人大学招生网" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="videolist.aspx.cs" Inherits="videolist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta name="keywords" content="浙江树人大学招生,学校视频,树人招生,浙江树人大学" />
    <meta name="description" content="浙江树人大学（学院）在线视频。欢迎在线欣赏我们的作品，了解影像中的树人大学！" />
    <meta name="author" content="Dsrj Studio Team" />
    <meta name="copyright" content="2009-2011 Dsrj Studio." />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="page-header">
        <img src="./styles/images/1000x180.png" width="1000" height="180" alt="">
    </div>
    <h1 class="text-center">
        <asp:Label ID="lb_title" runat="server" Text="浙江树人大学校园在线"></asp:Label>
    </h1>


        <div class="clear"></div>

    <section class="row portfolio filtrable clearfix">




        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <article data-id='id-<%# ((Container.ItemIndex+1)) %>' data-type="" class="span3">
                    <div class="inner-image">
                        <a href='video.aspx?id=<%# ApplicationMethod.encript(Eval("id").ToString()) %>' data-rel="" rel="">
                            <img src='<%# Eval("thumb") %>'  alt="" style="opacity: 1; height:200px;width:100%">
                            <span class="frame-overlay"></span>
                        </a>
                    </div>
                    <div class="sliding">
                        <div class="inner-text">
                            <h4 class="title" style="overflow:hidden"><a href='video.aspx?id=<%# ApplicationMethod.encript(Eval("id").ToString()) %>'><%# Eval("title") %></a></h4>
                           
                                <%# Eval("addtime","{0:yyyy-MM-dd HH:mm:ss}") %>
                            
                        </div>
                    </div>
                </article>

                
            </ItemTemplate>
        </asp:Repeater>







    </section>
    <div class="text-right">
        <asp:Literal ID="RecordCount" runat="server"></asp:Literal>个视频
        共有<asp:Literal ID="PageCount" runat="server"></asp:Literal>页
        当前第<asp:Literal ID="Pageindex" runat="server"></asp:Literal>页
            <asp:HyperLink ID="FirstPage" runat="server" Text="首页"></asp:HyperLink>
        <asp:HyperLink ID="PrevPage" runat="server" Text="上一页"></asp:HyperLink>
        <asp:HyperLink ID="NextPage" runat="server" Text="下一页"></asp:HyperLink>
        <asp:HyperLink ID="LastPaeg" runat="server" Text="尾页"></asp:HyperLink>
        跳转到<asp:Literal ID="Literal1" runat="server"></asp:Literal>页
    </div>
</asp:Content>

