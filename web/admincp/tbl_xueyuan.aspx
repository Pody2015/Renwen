<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true"
    CodeFile="tbl_xueyuan.aspx.cs" Inherits="admincp_tbl_xueyuan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row-fluid">
    <div id="content" class="span9">
        <div id="main">
            <fieldset>
                <legend>专业信息</legend>
                <p>
                    <label for="sf">
                        专业名称：
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
                        列表图标:
                    </label>
                    <asp:FileUpload ID="fu_logo" runat="server" />
                    <span class="validate_error">*</span>
                </p>
                <p>
                    <label>
                        专业风采:
                    </label>
                    <asp:FileUpload ID="fu_image1" runat="server" />
                    <asp:FileUpload ID="fu_image2" runat="server" />
                    <asp:FileUpload ID="fu_image3" runat="server" />
                </p>
                <p>
                <label>
                        专业简介:
                    </label>
                    <textarea id="txt_jianjie">
                        <%=jianjie%>
                    </textarea>
                    <asp:HiddenField ID="hd_jianjie" runat="server" />
                </p><p>
                    <label>
                        专业简介:
                    </label>
 
                </p>
                <p>
                    <!-- WYSIWYG editor -->

                    <!-- End of WYSIWYG editor -->
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </p>
                <p>
                    <asp:Button ID="btn_add" CssClass="btn btn-primary" runat="server" Text="保存信息" 
                        onclick="btn_add_Click" OnClientClick="return checkInfo()" />
                    <asp:Button ID="btn_delete" CssClass="btn btn-danger" runat="server" Text="删除信息" OnClientClick="return confirm('确定删除吗？')" OnClick="btn_delete_Click"/>
                    <input class="btn btn-default" type="reset" value="重置">
                </p>
            </fieldset>
            <hr />
        </div>
    </div>
    <!-- End of Main Content -->
    <!-- Sidebar -->
    <div id="sidebar" class="span3">
        <h2>
            专业列表</h2>
        <!-- Datepicker -->
        <ul>
            <%=GetXueyuanList()%>
            <li><a href="./tbl_xueyuan.aspx">新增</a></li>
        </ul>
        <!-- End of Datepicker -->
        <!-- Statistics -->
        
        <!-- End of Statistics -->
    </div>
    <!-- End of Sidebar -->
        </div>
</asp:Content>
<asp:Content ID="js" ContentPlaceHolderID="CPH_Foot" runat="server">
    <link rel="stylesheet" href="../ueditor/themes/default/ueditor.css"/>
    <script src="../ueditor/ueditor.config.js"></script>
    <script src="../ueditor/ueditor.all.js"></script>
    <script>
        var editor = UE.getEditor('txt_jianjie');
        
        $(document).ready(function () {
           
            
        });
        function checkInfo() {
            var temp = (editor.getContent());
            temp = htmlEncode(temp);
            //alert(temp);
            $("#<%=hd_jianjie.ClientID%>").val(temp);
            return true;
        }
    </script>

</asp:Content>