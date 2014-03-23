<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true"
    CodeFile="sysRole.aspx.cs" Inherits="admincp_sysRole" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="./js/artDialog.js?skin=idialog" type="text/javascript"></script>
    <script>
        function tan(num) {
            art.dialog({
                content: '<iframe id=ipage frameborder=no border=0 src=./sysRoleFunction.aspx?role=' + num + ' onLoad=iFrameHeight()></iframe>',
                id: 'EF893L',
                padding: 0,
                title: '角色功能'
            });
        }
        function tanadd() {
            art.dialog({
                content: '<iframe src=./sysRolesAdd.aspx></iframe>',
                id: 'aEF893a',
                padding: 0,
                title: '角色功能',
                height: 140,
                close: function () {
                    window.location.reload(true);
                }
            });
        }
        function iFrameHeight() {
            var ifm = document.getElementById("ipage");
            var subWeb = document.frames ? document.frames["ipage"].document : ifm.contentDocument;
            if (ifm != null && subWeb != null) {
                ifm.height = subWeb.body.scrollHeight;
            }
        } 
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="content">
        <div id="main">
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%"
                DataKeyNames="ID" AutoGenerateColumns="False" RowStyle-HorizontalAlign="Center"
                OnRowCancelingEdit="gridView_RowCancelingEdit" OnRowEditing="gridView_RowEditing"
                OnRowUpdating="gridView_RowUpdating" CssClass="table table-bordered">
                <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择">
                        <ItemTemplate>
                            <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                        </ItemTemplate>
                        <ControlStyle Width="30px"></ControlStyle>
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:TemplateField>
                    <asp:BoundField DataField="RoleName" HeaderText="角色名" SortExpression="RoleName" ItemStyle-HorizontalAlign="Center">
                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Description" HeaderText="描述" SortExpression="Description"
                        ItemStyle-HorizontalAlign="Center">
                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    </asp:BoundField>
                    <asp:CommandField ShowEditButton="True">
                        <ItemStyle Width="140px" />
                    </asp:CommandField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <a href='javascript:tan(<%# Eval("id")%>)'>编辑功能</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <RowStyle HorizontalAlign="Center"></RowStyle>
            </asp:GridView>
            <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-small btn-danger" Text="删除所选" OnClick="btnDelete_Click" />
        </div>
    </div>
    <div id="sidebar">
        <h2>
            <a href="#modal-table" data-toggle="modal">增加角色</a></h2>
        <div id="modal-table" class="modal hide fade in" tabindex="-1" aria-hidden="false">
            <div class="modal-header no-padding">
                <div class="table-header">
                    <button type="button" class="close" data-dismiss="modal">×</button>
                    增加角色
                </div>
            </div>

            <div class="modal-body no-padding">
                <div class="row-fluid">
                    <asp:TextBox ID="txtRoleName" runat="server" Width="200px" placeholder="角色名"></asp:TextBox>

                            <asp:TextBox ID="txtDescription" runat="server" Width="200px" placeholder="描述信息"></asp:TextBox>
                </div>
            </div>

            <div class="modal-footer">
                <button class="btn btn-small btn-danger " data-dismiss="modal">
                    <i class="icon-remove"></i>
                    Close
                </button>
                <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click" class="inputbutton"
                        CssClass="btn btn-small"></asp:Button>
                
            </div>
        </div>

        <!-- End of Statistics -->
    </div>
</asp:Content>
