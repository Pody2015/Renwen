<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true" CodeFile="tbl_message.aspx.cs" Inherits="admincp_tbl_message" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style>
.no{background-color:#ffeeee;}
tbody tr:hover{background-color:#eeeeee;}
tbody a:visited{color:#eeeeee;}
</style>
    <script src="./js/artDialog.js?skin=idialog" type="text/javascript"></script>
    <script>
        function tan(num) {
            art.dialog({
                id: 'EF893L',
                padding: 0,
                width: 500,
                title: '回复留言',
                content: '123'
            });
            art.dialog.list['EF893L'].content('<iframe height=405 width=495 frameborder=no border=0 src=./tbl_messagereply.aspx?id=' + num + '></iframe>');
        }
        function changecolor(obj) {
            var trs = obj.parentNode.parentNode;
            trs.style.backgroundColor = "#ffffff";
            trs.childNodes[9].innerHTML = "&nbsp;是";
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="content">
        <div id="main">
            <table style="width: 100%;" class="table">
            <thead>
                <tr>
                    <td>&nbsp;标题</td>
                    <td>&nbsp;作者</td>
                    <td>&nbsp;邮箱</td>
                    <td>&nbsp;时间</td>
                    <td>&nbsp;是否已回复</td>
                    <td>&nbsp;操作</td>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server" 
                    onitemcommand="Repeater1_ItemCommand">
                <ItemTemplate>
                <tr title='<%# Eval("conts") %>' class='tooltip <%# (Eval("isShow").ToString())=="0"?"no":"yes" %>'>
                    <td>&nbsp;<%# Eval("title") %></td>
                    <td>&nbsp;<%# Eval("name") %></td>
                    <td>&nbsp;<%# Eval("mail") %></td>
                    <td>&nbsp;<%# Eval("asktime","{0:yyyy-MM-dd HH:mm:ss}") %></td>
                    <td>&nbsp;<%# (Eval("isShow").ToString())=="0"?"否":"是" %></td>
                    <td>&nbsp;<a href='javascript:tan(<%# Eval("id") %>)' onclick="changecolor(this)">回复</a>
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
            <hr />
        </div>
    </div>
    <!-- End of Main Content -->
    <!-- Sidebar -->
    <div id="sidebar">
        <!-- Datepicker -->

        <div class="sort ui-sortable">
            <div class="box ui-widget ui-widget-content ui-corner-all portlet ui-helper-clearfix">
                
                <div class="portlet-content">
                    <input id="Button3" type="button" value="所有留言" onclick="javascript:window.location='./tbl_message.aspx'" class="btn btn-default" />
                    <input id="Button4" type="button" value="未回复留言" onclick="javascript:window.location='./tbl_message.aspx?isShow=0'" class="btn btn-default" />
                </div>
            </div>
            
        </div>
        <!-- End of Datepicker -->
        <!-- Statistics -->
        
        <!-- End of Statistics -->
    </div>
    <!-- End of Sidebar -->
</asp:Content>

