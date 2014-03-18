<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true" CodeFile="tbl_page.aspx.cs" Inherits="admincp_tbl_page" %>

<%@ Register src="C_tbl_Guide.ascx" tagname="C_tbl_Guide" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="./js/artDialog.js?skin=black" type="text/javascript"></script>
    <script>
        function tan(num) {
            art.dialog({
                id: 'EF893L',
                padding: 0,
                width: 940,
                height:500,
                title: '页面新增/编辑',
                content: '123',
                close: function () {
                    window.location.reload(true);
                }
            });
            art.dialog.list['EF893L'].content('<iframe height=510 width=930 frameborder=no border=0 src=./tbl_pageadd.aspx?id=' + num + '></iframe>');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- Main Content -->
    <div id="content">
        <div id="main">
            <table style="width: 100%;" class="fullwidth">
            <thead>
                <tr>
                    <td>
                        &nbsp;页面名称
                    </td>
                    <td>
                        &nbsp;关键字
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
                <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                <tr>
                    <td>
                        &nbsp;<%# Eval("name") %></td>
                    <td>
                        &nbsp;<%# Eval("metatags") %></td>
                    <td>
                        &nbsp;./page.aspx?id=<%# ApplicationMethod.encript(Eval("id").ToString()) %></td>
                    <td>
                        &nbsp;<a href='javascript:tan(<%# Eval("id") %>)'>编辑</a></td>
                </tr>
                </ItemTemplate>
                </asp:Repeater>
                
            </tbody>
            </table>
            <input id="Button2" type="button" value="新增页面" class="button" onclick="tan(0)" />
            <hr />
            <uc1:C_tbl_Guide ID="C_tbl_Guide1" runat="server" />
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

