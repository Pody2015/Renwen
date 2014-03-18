<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="zhuanye.aspx.cs" Inherits="zhuanye" ViewStateMode="Disabled" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<meta name="keywords" content="浙江树人大学,专业,招生" />
<meta name="description" content="由浙江省政协主办的浙江树人大学（学院）坐落于杭州市城区，是改革开放以来我国最早成立并经国家教育部首批批准承认学历的全日制民办本科高校之一。" />
<meta name="author" content="小D" />
<meta name="copyright" content="2009-2012 Dsrj Studio Team." />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="page-header">
        <img src="./styles/images/1000x180.png" width="1000" height="180" alt="树人全景">
    </div>
    <div class="fixed">
            <div class="col280">
                <h1 class="last"><%=name %>专业介绍</h1>
                <h5>点击专业名称查看专业详细</h5>
            </div>
            <div class="col580 last">
                <ul id="portfolio-filter" class="fixed">
                    <li class=""><a href="./zhuanye.aspx">所有学院</a>
                        <ul class="filter-options" style="display: block; visibility: hidden;">
                            <%=GetXueyuanList() %>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
        <hr />
    <ul id="accordion-1" class="accordion fixed">
        <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
        <li><a href='#accordion-1-slide-<%# (Container.ItemIndex+1) %>'><%# Eval("name") %></a>
            <div style="display: none;">
                <p><%# Eval("cont") %></p>
            </div>
        </li>
        </ItemTemplate>
        </asp:Repeater>
    </ul>
    <hr />
</asp:Content>
