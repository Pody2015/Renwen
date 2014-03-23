<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="admincp_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Main Content -->
    <div id="content">
        <div id="main">
            <h1>
                欢迎来到 <span>浙江树人大学招生网管理中心</span>！</h1>
            <p>
                What would you like to do today?</p>
            <div class="pad20">
                <!-- Big buttons -->
                <table class="table" cellpadding="0" cellspacing="0" border="0">
                    <thead>
                        <tr>
                            <td>
                                项目名称
                            </td>
                            <td>
                                检查结果
                            </td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr class="odd">
                            <td>
                                操作系统
                            </td>
                            <td>
                                <%=ServerOS %>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                CPU个数/类型
                            </td>
                            <td>
                                <%=CpuSum %>/<%=CpuType %>
                            </td>
                        </tr>
                        <tr class="odd">
                            <td>
                                信息服务软件
                            </td>
                            <td>
                                <%=ServerSoft %>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                服务器名
                            </td>
                            <td>
                                <%=MachineName %>
                            </td>
                        </tr>
                        <tr class="odd">
                            <td>
                                服务器域名
                            </td>
                            <td>
                                <%=ServerName %>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                .NET 版本
                            </td>
                            <td>
                                <%=ServerNet %>
                            </td>
                        </tr>
                        <tr class="odd">
                            <td>
                                运行时长
                            </td>
                            <td>
                                <%=ServerStart %>小时
                            </td>
                        </tr>
                        <tr>
                            <td>
                                占用内存
                            </td>
                            <td>
                                <%=AspNetN%>MB
                            </td>
                        </tr>
                        <tr class="odd">
                            <td>
                                CPU使用率
                            </td>
                            <td>
                                <%=AspNetCpu%>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <!-- End of Big buttons ServerSessions-->
            </div>
            <hr />
        </div>
    </div>
    <!-- End of Main Content -->
    <!-- Sidebar -->
    
    <!-- End of Sidebar -->
</asp:Content>
