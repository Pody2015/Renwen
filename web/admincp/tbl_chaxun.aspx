<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true"
    CodeFile="tbl_chaxun.aspx.cs" Inherits="admincp_tbl_chaxun" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row-fluid">
    <div id="content" class="span9">
        <div id="main">
            <table style="width: 100%;" class="table">
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
            <asp:Button ID="Button2" runat="server" CssClass="btn btn-danger" Text="删除所有查询数据" OnClick="Button2_Click" />
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
    <div id="sidebar" class="span3">
        
        <!-- Datepicker -->
        <div id="accordion">
            <div class="well">
                <h3><a href="#" title="First slide"
                        class="">注意事项</a></h3>
                <div>
                    不提供修改功能，如果信息有错请重新将错误信息修正后导入。若身份证有错则请将信息删除后导入正确信息。</div>
            </div>
            <div class="well">
                <h3><a href="#" title="Second slide"
                        class="">模板下载</a></h3>
                <div>
                    此处下载的模版为标准模版，请按照格式编辑好相关信息后上传。那么有个需要注意的地方是所有单元格必须为文本类型，不得有'符号，不得有空格，sheet表名称必须是student。
                    模板下载：<a href="../import/sample.xls">sample.xls</a>
                    </div>
            </div>
            <div class="well">
                <h3>
                    <a href="#" title="Third slide"
                        class="">导入信息</a></h3>
                <div >
                    <asp:FileUpload ID="FileUPexcel" runat="server" Width="190px" />
    <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary btn-small" Text="导入" OnClick="Button1_Click" /><br />
    <asp:Label ID="lb_Result" runat="server" Text="此处将显示导入结果"></asp:Label>
                    
                    </div>
            </div>
        </div>
        <!-- End of Datepicker -->
        <!-- Statistics -->
       
        <!-- End of Statistics -->
    </div>
    <!-- End of Sidebar -->
    </div>
</asp:Content>
