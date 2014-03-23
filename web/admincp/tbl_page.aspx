<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true" CodeFile="tbl_page.aspx.cs" Inherits="admincp_tbl_page" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="./js/artDialog.js?skin=idialog" type="text/javascript"></script>
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
            <table style="width: 100%;" class="table">
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
        </div>
    </div>
    <!-- End of Main Content -->
    <!-- Sidebar -->
    
    <!-- End of Sidebar -->
</asp:Content>

