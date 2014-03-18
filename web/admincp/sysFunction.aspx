<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true"
    CodeFile="sysFunction.aspx.cs" Inherits="admincp_sysFunction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="content">
        <div id="main">
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"
                OnPageIndexChanging="gridView_PageIndexChanging" DataKeyNames="ID" AutoGenerateColumns="False"
                RowStyle-HorizontalAlign="Center" OnRowCancelingEdit="gridView_RowCancelingEdit"
                OnRowEditing="gridView_RowEditing" OnRowUpdating="gridView_RowUpdating"
                CssClass="fullwidth" BackColor="White" BorderColor="#999999" 
                BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择">
                        <ItemTemplate>
                            <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                        </ItemTemplate>
                        <ControlStyle Width="30px"></ControlStyle>
                        <HeaderStyle BackColor="Black" Height="28px" />
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:TemplateField>
                    <asp:BoundField DataField="FunctionName" HeaderText="功能名称" SortExpression="FunctionName"
                        ItemStyle-HorizontalAlign="Center">
                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="FunctionDescription" HeaderText="显示文字" SortExpression="FunctionDescription"
                        ItemStyle-HorizontalAlign="Center">
                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Assembly" HeaderText="相对路径" SortExpression="Assembly"
                        ItemStyle-HorizontalAlign="Center">
                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    </asp:BoundField>
                    <asp:CommandField ShowEditButton="True" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle HorizontalAlign="Center" BackColor="Black" Font-Bold="True" 
                    ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle HorizontalAlign="Center"></RowStyle>
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click" 
                CssClass="button" />
        </div>
    </div>
    <div id="sidebar">
        <h2>
            增加功能</h2>
        <div class="sort ui-sortable">
            <div class="box ui-widget ui-widget-content ui-corner-all portlet ui-helper-clearfix">
                <div class="portlet-header ui-widget-header ui-corner-all">
                    <span class="ui-icon ui-icon-circle-arrow-s"></span>增加功能</div>
                <div class="portlet-content">
                    <dl>
                        <dt>
                            <asp:TextBox ID="txtFunctionName" runat="server" Width="200px" placeholder="功能名称"></asp:TextBox></dt>
                        <dt>
                            <asp:TextBox ID="txtFunctionDescription" runat="server" Width="200px" placeholder="显示文字"></asp:TextBox></dt>
                        <dt>
                            <asp:TextBox ID="txtAssembly" runat="server" Width="200px" placeholder="相对路径"></asp:TextBox></dt>
                    </dl>
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
