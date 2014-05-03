<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="xueyuan.aspx.cs" Inherits="xueyuan" Title="学院简介 - 浙江树人大学招生网" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<meta name="keywords" content="浙江树人大学招生,树大招生,树人招生,浙江树人大学" />
<meta name="description" content="由浙江省政协主办的浙江树人大学（学院）坐落于杭州市城区，是改革开放以来我国最早成立并经国家教育部首批批准承认学历的全日制民办本科高校之一。" />
<meta name="author" content="小D" />
<meta name="copyright" content="2009-2011 Dsrj Studio Team." />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
        <div id="page-header">
            <img src="./styles/images/1000x180.png" width="1000" height="180" alt="">
        </div>
        <div class="fixed">
            <div class="col580">
                <h1 class="last">
                    浙江树人大学 人文学院
                    专业简介</h1>
            </div>
            <div class="col280 last">
                <ul id="portfolio-filter" class="fixed">
                    <li class=""><a href="#">排名不分先后</a>
                        <ul class="filter-options" style="display: block; visibility: hidden;">
                            <%= GetXueyuanList() %>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
        <div class="hr">
        </div>
        <div class="portfolio-overview">
            <ul class="fixed">
                <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                <li <%# ((Container.ItemIndex+1)%3!=0)?"":"class='last'" %>>
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
        <div class="hr">
        </div>
</asp:Content>
