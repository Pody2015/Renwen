<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true" CodeFile="tbl_zhuanye.aspx.cs" Inherits="admincp_tbl_zhuanye" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="./js/artDialog.js?skin=black" type="text/javascript"></script>
    <script>
        function tan(num) {
            art.dialog({
                id: 'EF893L',
                padding: 0,
                width: 730,
                title: '专业信息修改',
                content: '123'
            });
            art.dialog.list['EF893L'].content('<iframe height=405 width=725 frameborder=no border=0 src=./tbl_zhuanyeadd.aspx?id=' + num + '></iframe>');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="content">
        <div id="main">
            <table style="width: 100%;" class="fullwidth">
            <thead>
                <tr>
                    <td>
                        &nbsp;专业名称
                    </td>
                    <td>
                        &nbsp;操作
                    </td>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server" 
                    onitemcommand="Repeater1_ItemCommand">
                <ItemTemplate>
                <tr title='<%# Eval("cont") %>' class="tooltip">
                    <td>
                        &nbsp;<%# Eval("name") %></td>
                    
                    <td>
                        &nbsp;<a href='javascript:tan(<%# Eval("id") %>)'>修改</a>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("id") %>' CommandName="delete" OnClientClick="return confirm('真的删除吗？')">删除</asp:LinkButton>
                        </td>
                </tr>
                </ItemTemplate>
                </asp:Repeater>
                
            </tbody>
            </table>
            <input id="Button1" type="button" value="新增专业" class="button" onclick="tan(0)" />

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
            <hr />
        </div>
    </div>
    <!-- End of Main Content -->
    <!-- Sidebar -->
    <div id="sidebar">
        <h2>
            日历</h2>
        <!-- Datepicker -->
        <div id="datepicker">
        </div>
        <div class="sort ui-sortable">
            <div class="box ui-widget ui-widget-content ui-corner-all portlet ui-helper-clearfix">
                <div class="portlet-header ui-widget-header ui-corner-all"><span class="ui-icon ui-icon-circle-arrow-s"></span>
                    <span class="ui-icon ui-icon-circle-arrow-s"></span>注意事项</div>
                <div class="portlet-content">
                为了加快修改/新增效率，在您回修改/新增后，系统不会及时刷新列表的显示，您可以刷新页面后查看。
                </div>
            </div>
        </div>
        <!-- End of Datepicker -->
        <!-- Statistics -->
        <h2>
            统计</h2>
        <p>
            <b>新闻:</b> 2201</p>
        <p>
            <b>留言:</b> 17092</p>
        <p>
            <b>用户:</b> 3788</p>
        <!-- End of Statistics -->
    </div>
    <!-- End of Sidebar -->
</asp:Content>

