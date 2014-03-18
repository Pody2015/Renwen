<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true" CodeFile="sysCache.aspx.cs" Inherits="admincp_sysCache" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <!-- Main Content -->
    <div id="content">
        <div id="main">
            <h1>网站数据缓存控制</h1>
            <div class="pad20">
                <asp:Button ID="Button1" runat="server" CssClass="button" Text="清空所有数据缓存" onclick="Button1_Click" />
                <!-- Big buttons -->
              <p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></p>  
                <!-- End of Big buttons ServerSessions-->
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

