<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true"
    CodeFile="tbl_xueyuan.aspx.cs" Inherits="admincp_tbl_xueyuan" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v10.1, Version=10.1.6.0, Culture=neutral, PublicKeyToken=c6bed6029ccaee5e"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.ASPxEditors.v10.1, Version=10.1.6.0, Culture=neutral, PublicKeyToken=c6bed6029ccaee5e" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v10.1, Version=10.1.6.0, Culture=neutral, PublicKeyToken=c6bed6029ccaee5e" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="content">
        <div id="main">
            <fieldset>
                <legend>学院信息</legend>
                <p>
                    <label for="sf">
                        学院名称：
                    </label>
                    <asp:TextBox ID="tb_name" CssClass="sf" runat="server"></asp:TextBox>
                    <span class="field_desc">*</span>
                </p>
                <p>
                    <label for="mf">
                        英文名称:
                    </label>
                    <asp:TextBox ID="tb_nameen" CssClass="mf" runat="server"></asp:TextBox>
                    <span class="validate_success">*</span>
                </p>
                <p>
                    <label for="lf">
                        学院LOGO:
                    </label>
                    <asp:FileUpload ID="fu_logo" runat="server" />
                    <span class="validate_error">*</span>
                </p>
                <p>
                    <label>
                        学院风采:
                    </label>
                    <asp:FileUpload ID="fu_image1" runat="server" />
                    <asp:FileUpload ID="fu_image2" runat="server" />
                    <asp:FileUpload ID="fu_image3" runat="server" />
                </p>
                <p>
                <label>
                        院长简介:
                    </label>
                <dx:ASPxHtmlEditor ID="ASPxHtmlEditor_yuanzhang" runat="server" Height="180px">
                </dx:ASPxHtmlEditor>
                </p><p>
                    <label>
                        学院简介:
                    </label>
                    <dx:ASPxHtmlEditor ID="ASPxHtmlEditor_conts" runat="server" Height="250px">
                    </dx:ASPxHtmlEditor>
                </p>
                <p>
                    <!-- WYSIWYG editor -->

                    <!-- End of WYSIWYG editor -->
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </p>
                <p>
                    <asp:Button ID="btn_add" CssClass="button" runat="server" Text="保存信息" 
                        onclick="btn_add_Click" />
                    <input class="button" type="reset" value="重置">
                </p>
            </fieldset>
            <hr />
        </div>
    </div>
    <!-- End of Main Content -->
    <!-- Sidebar -->
    <div id="sidebar">
        <h2>
            学院列表</h2>
        <!-- Datepicker -->
        <ul>
            <%=GetXueyuanList()%>
            <li><a href="./tbl_xueyuan.aspx">新增学院</a></li>
        </ul>
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
