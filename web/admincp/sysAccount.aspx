<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true"
    CodeFile="sysAccount.aspx.cs" Inherits="admincp_sysAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="./js/artDialog.js?skin=idialog" type="text/javascript"></script>
    <script>
        function tan(num) {
            art.dialog({
                id: 'EF893L',
                padding: 0,
                width:530,
                title: '用户信息修改',
                content: '123'
            });
            art.dialog.list['EF893L'].content('<iframe height=405 width=525 frameborder=no border=0 src=./sysAccountAdd.aspx?id=' + num + '></iframe>');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="content">
        <div id="main">
            <table style="width: 100%;" class="table">
                <thead>
                    <tr>
                        <td>
                            &nbsp; 用户名
                        </td>
                        <td>
                            &nbsp; 密码
                        </td>
                        <td>
                            &nbsp; 角色
                        </td>
                        <td>
                            &nbsp; 删除
                        </td>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server" 
                        onitemdatabound="Repeater1_ItemDataBound" 
                        onitemcommand="Repeater1_ItemCommand">
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <asp:HiddenField ID="HiddenField1" runat="server" Value=<%# Eval("id") %> />
                                    &nbsp;<%# Eval("userName") %></td>
                                <td>
                                    &nbsp;<%# Eval("userPsw") %></td>
                                <td>
                                    &nbsp;
                                    <asp:DropDownList ID="ddl_role" runat="server" Enabled="False">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <input id="Button2" class="btn btn-primary btn-small" type="button" value="修改" onclick=tan(<%# Eval("id") %>) />
                                    &nbsp; 
                                    <asp:Button ID="Button1" CssClass="btn btn-danger btn-small" runat="server" Text="删除" CommandName="delete" CommandArgument=<%# Eval("id") %> OnClientClick="return confirm('真的删除？')" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <input id="Button1" type="button" class="btn btn-primary" value="新增用户" onclick="tan(0)" />
        </div>
    </div>
    
    
</asp:Content>
