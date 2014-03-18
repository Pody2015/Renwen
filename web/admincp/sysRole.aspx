<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true"
    CodeFile="sysRole.aspx.cs" Inherits="admincp_sysRole" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="./js/artDialog.js?skin=black" type="text/javascript"></script>
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
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"
                DataKeyNames="ID" AutoGenerateColumns="False" RowStyle-HorizontalAlign="Center"
                OnRowCancelingEdit="gridView_RowCancelingEdit" OnRowEditing="gridView_RowEditing"
                OnRowUpdating="gridView_RowUpdating" CssClass="fullwidth" BackColor="White" BorderColor="#999999"
                BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择">
                        <ItemTemplate>
                            <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                        </ItemTemplate>
                        <ControlStyle Width="30px"></ControlStyle>
                        <HeaderStyle Height="28px" />
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
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle HorizontalAlign="Center"></RowStyle>
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <asp:Button ID="btnDelete" runat="server" CssClass="button" Text="删除所选" OnClick="btnDelete_Click" />
        </div>
    </div>
    <div id="sidebar">
        <h2>
            增加角色</h2>
        <div class="sort ui-sortable">
            <div class="box ui-widget ui-widget-content ui-corner-all portlet ui-helper-clearfix">
                <div class="portlet-header ui-widget-header ui-corner-all">
                    <span class="ui-icon ui-icon-circle-arrow-s"></span>增加角色</div>
                <div class="portlet-content">


                            <asp:TextBox ID="txtRoleName" runat="server" Width="200px" placeholder="角色名"></asp:TextBox>

                            <asp:TextBox ID="txtDescription" runat="server" Width="200px" placeholder="描述信息"></asp:TextBox>

                    <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click" class="inputbutton"
                        CssClass="button"></asp:Button>
                </div>
            </div>
        </div>
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
</asp:Content>
