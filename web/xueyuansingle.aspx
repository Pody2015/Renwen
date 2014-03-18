<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="xueyuansingle.aspx.cs" Inherits="xueyuansingle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<meta name="keywords" content='<%=tags %>' />
<meta name="description" content='<%=desc %>' />
<meta name="author" content="小D" />
<meta name="copyright" content="2009-2012 Dsrj Studio Team." />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
        <div id="page-header">
            <img src="./styles/images/1000x180.png" width="1000" height="180" alt="">
        </div>
        <div class="fixed">
            <div class="col280">
                <h1 class="last"><%=name %></h1>
                <h5 class="last"><%=nameen %></h5>
            </div>
            <div class="col580 last">
                <ul id="portfolio-filter" class="fixed">
                    <li class=""><a href="./xueyuan.aspx">所有学院</a>
                        <ul class="filter-options" style="display: block; visibility: hidden;">
                            <%=GetXueyuanList() %>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
        <div class="hr">
        </div>
        <div id="slideshow-portfolio">
            <ul class="fixed">
                <li style="position: absolute; top: 0px; left: 0px; width: 880px; height: 350px;
                    z-index: 3; opacity: 0; display: none;">
                    <img src='<%=image1 %>' width="880" height="350" alt="">
                </li>
                <li style="position: absolute; z-index: 4; top: 0px; left: 0px; display: block; width: 880px;
                    height: 350px; opacity: 1;">
                    <img src='<%=image2 %>' width="880" height="350" alt="">
                </li>
                <li style="position: absolute; top: 0px; left: 0px; width: 880px; height: 350px;
                    z-index: 3; opacity: 0; display: none;">
                    <img src='<%=image3 %>' width="880" height="350" alt="">
                </li>
            </ul>
            <div id="slideshow-portfolio-pager">
                &nbsp;<a href="#" class="">1</a><a href="#" class="activeSlide">2</a><a href="#"
                    class="">3</a></div>
        </div>
        <div class="fixed">
            <div class="col280">
                <h5>院长简介</h5>
                <br>
                <p><%=yuanzhang %></p>
            </div>
            
            <div class="col580 last">
                <h5>学院简介</h5>
                <br>
                <%=conts %>
            </div>
        </div>
        <div class="hr">
        </div>
        <div class="fixed">
            <div class="col280">
                <h1 class="last">浙江树人大学</h1>
                <h5>专业简介</h5>
                <br>
                <p>这里是关于浙江树人大学学院的简介，您可以查看我们的学院简介和本学院的专业简介。</p>
                <p>
                    <a href='./zhuanye.aspx?xid=<%=xid %>'>查看本学院相关专业</a></p>
            </div>
            <div class="col580 last">
                <div class="portfolio-overview">
                    <ul class="fixed">
                    <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                    <li <%# ((Container.ItemIndex+1)%2!=0)?"":"class='last'" %>>
                        <img src='<%# Eval("logo") %>' width="280" height="170" alt="" style="opacity: 1;">
                        <h5>
                            <a href='xueyuansingle.aspx?id=<%# ApplicationMethod.encript(Eval("id").ToString()) %>'><%# Eval("name") %></a></h5>
                        <p>
                        <%# Eval("nameen") %></p>
                    </li>
                    </ItemTemplate>
                    </asp:Repeater>
                    </ul>
                </div>
            </div>
        </div>
</asp:Content>
