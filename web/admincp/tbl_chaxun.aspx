<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true"
    CodeFile="tbl_chaxun.aspx.cs" Inherits="admincp_tbl_chaxun" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="content">
        <div id="main">
            <table style="width: 100%;" class="fullwidth">
                <thead>
                    <tr>
                        <td>
                            &nbsp;姓名
                        </td>
                        <td>
                            &nbsp;学号
                        </td>
                        <td>
                            &nbsp;考试号
                        </td>
                        <td>
                            &nbsp;身份证
                        </td>
                        <td>
                            &nbsp;分数
                        </td>
                        <td>
                            &nbsp;操作
                        </td>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                        <ItemTemplate>
                            <tr>
                                <td>
                                    &nbsp;<%# Eval("name") %></td>
                                <td>
                                    &nbsp;<%# Eval("stuno") %></td>
                                <td>
                                    &nbsp;<%# Eval("ksno") %></td>
                                <td>
                                    &nbsp;<%# Eval("cardid") %></td>
                                <td>
                                    &nbsp;<%# Eval("score") %></td>
                                <td>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("id") %>'
                                        CommandName="delete" OnClientClick="return confirm('真的删除吗？')">删除</asp:LinkButton>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <div style="float: right">
                <asp:Literal ID="RecordCount" runat="server"></asp:Literal>条咨询 共有<asp:Literal ID="PageCount"
                    runat="server"></asp:Literal>页 当前第<asp:Literal ID="Pageindex" runat="server"></asp:Literal>页
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
            导入</h2>
        <!-- Datepicker -->
        <div id="accordion" class="ui-accordion ui-widget ui-helper-reset" role="tablist">
            <div>
                <h3 class="ui-accordion-header ui-helper-reset ui-state-active ui-corner-top" role="tab"
                    aria-expanded="true" tabindex="0">
                    <span class="ui-icon ui-icon-triangle-1-s"></span><a href="#" title="First slide"
                        class="tooltip">注意事项</a></h3>
                <div class="ui-accordion-content ui-helper-reset ui-widget-content ui-corner-bottom ui-accordion-content-active"
                    style="display: block; height: 180px; padding-top: 10px; padding-bottom: 10px;
                    overflow: auto;" role="tabpanel">
                    不提供修改功能，如果信息有错请重新将错误信息修正后导入。若身份证有错则请将信息删除后导入正确信息。</div>
            </div>
            <div>
                <h3 class="ui-accordion-header ui-helper-reset ui-state-default ui-corner-all" role="tab"
                    aria-expanded="false" tabindex="-1">
                    <span class="ui-icon ui-icon-triangle-1-e"></span><a href="#" title="Second slide"
                        class="tooltip">模板下载</a></h3>
                <div class="ui-accordion-content ui-helper-reset ui-widget-content ui-corner-bottom ui-accordion-content-active"
                    style="overflow: auto; display: none; height: 180px; padding-top: 10px; padding-bottom: 10px;"
                    role="tabpanel">
                    此处下载的模版为标准模版，请按照格式编辑好相关信息后上传。那么有个需要注意的地方是所有单元格必须为文本类型，不得有'符号，不得有空格，sheet表名称必须是student。
                    模板下载：<a href="../import/sample.xls">sample.xls</a>
                    </div>
            </div>
            <div>
                <h3 class="ui-accordion-header ui-helper-reset ui-state-default ui-corner-all" role="tab"
                    aria-expanded="false" tabindex="-1">
                    <span class="ui-icon ui-icon-triangle-1-e"></span><a href="#" title="Third slide"
                        class="tooltip">导入信息</a></h3>
                <div class="ui-accordion-content ui-helper-reset ui-widget-content ui-corner-bottom"
                    style="height: 181px; display: none;" role="tabpanel">
                    <asp:FileUpload ID="FileUPexcel" runat="server" Width="190px" />
    <asp:Button ID="Button1" runat="server" CssClass="button" Text="导入" OnClick="Button1_Click" />
    <asp:Label ID="lb_Result" runat="server" Text="此处将显示导入结果"></asp:Label>
                    
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
