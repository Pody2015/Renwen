<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true" CodeFile="tbl_news.aspx.cs" Inherits="admincp_tbl_news" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="./js/artDialog.js?skin=idialog" type="text/javascript"></script>
    <script>
        function tan(num) {
            art.dialog({
                id: 'EF893L',
                padding: 0,
                width: 940,
                height: 500,
                title: '新闻新增/编辑',
                content: '123',
                close: function () {
                    window.location.reload(true);
                }
            });
            art.dialog.list['EF893L'].content('<iframe height=510 width=930 frameborder=no border=0 src=./tbl_newsadd.aspx?id=' + num + '></iframe>');
        }
function Button2_onclick() {

}

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="content">
        <div id="main">
            <table style="width: 100%;" class="table">
            <thead>
                <tr>
                    <td>
                        &nbsp;标题
                    </td>
                    <td>
                        &nbsp;作者
                    </td>
                    <td>
                        &nbsp;时间
                    </td>
                    <td>
                        &nbsp;页面地址
                    </td>
                    <td>
                        &nbsp;编辑
                    </td>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server" 
                    onitemcommand="Repeater1_ItemCommand">
                <ItemTemplate>
                <tr>
                    <td>
                        &nbsp;<%# Eval("title") %></td>
                    <td>
                        &nbsp;<%# Eval("author") %></td>
                    <td>
                        &nbsp;<%# Eval("addtime","{0:yyyy-MM-dd}") %></td>
                    <td>
                        &nbsp;./news.aspx?id=<%# ApplicationMethod.encript(Eval("id").ToString()) %></td>
                    <td>
                        &nbsp;<a href='javascript:tan(<%# Eval("id") %>)'>编辑</a>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("id") %>' CommandName="delete" OnClientClick="return confirm('真的删除吗？')">删除</asp:LinkButton>
                        </td>
                </tr>
                </ItemTemplate>
                </asp:Repeater>
                
            </tbody>
            </table>
            <div style=" float:right">
        <asp:Literal ID="RecordCount" runat="server"></asp:Literal>条咨询
        共有<asp:Literal ID="PageCount" runat="server"></asp:Literal>页
        当前第<asp:Literal ID="Pageindex" runat="server"></asp:Literal>页
            <asp:HyperLink ID="FirstPage" runat="server" Text="首页"></asp:HyperLink>
            <asp:HyperLink ID="PrevPage" runat="server" Text="上一页"></asp:HyperLink>
            <asp:HyperLink ID="NextPage" runat="server" Text="下一页"></asp:HyperLink>
            <asp:HyperLink ID="LastPaeg" runat="server" Text="尾页"></asp:HyperLink>
        跳转到<asp:Literal ID="Literal1" runat="server"></asp:Literal>页
        </div>
            <input id="Button2" type="button" value="添加新闻" class="btn btn-default" 
                onclick="tan(0)" onclick="return Button2_onclick()" />
            <hr />
        </div>
    </div>
    <!-- End of Main Content -->
    <!-- Sidebar -->
    
    <!-- End of Sidebar -->
</asp:Content>

