                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              <%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true"
    CodeFile="sysFunction.aspx.cs" Inherits="admincp_sysFunction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="content">
        <div id="main">
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" 
                OnPageIndexChanging="gridView_PageIndexChanging" DataKeyNames="ID" AutoGenerateColumns="False"
                RowStyle-HorizontalAlign="Center" OnRowCancelingEdit="gridView_RowCancelingEdit"
                OnRowEditing="gridView_RowEditing" OnRowUpdating="gridView_RowUpdating"
                CssClass="table table-bordered">
                <AlternatingRowStyle  />
                <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择">
                        <ItemTemplate>
                            <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                        </ItemTemplate>
                        <ControlStyle Width="30px"></ControlStyle>
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
                
            </asp:GridView>
            <asp:Button ID="btnDelete" runat="server" Text="删除所选" OnClick="btnDelete_Click" 
                CssClass="btn btn-small btn-danger" />
        </div>
    </div>
    <div id="sidebar">
        <h2>
            <a href="#modal-table" data-toggle="modal">增加功能</a></h2>
        <div id="modal-table" class="modal hide fade in" tabindex="-1" aria-hidden="false">
            <div class="modal-header no-padding">
                <div class="table-header">
                    <button type="button" class="close" data-dismiss="modal">×</button>
                    增加功能
                </div>
            </div>

            <div class="modal-body no-padding">
                <div class="row-fluid">
                    <dl>
                        <dt>
                             功能名称:<asp:TextBox ID="txtFunctionName" runat="server" Width="200px" placeholder="功能名称"></asp:TextBox></dt>
                        <dt>
                             显示文字:<asp:TextBox ID="txtFunctionDescription" runat="server" Width="200px" placeholder="显示文字"></asp:TextBox></dt>
                        <dt>
                             相对路径:<asp:TextBox ID="txtAssembly" runat="server" Width="200px" placeholder="相对路径"></asp:TextBox></dt>
                    </dl>
                </div>
            </div>

            <div class="modal-footer">
                <button class="btn btn-small btn-danger " data-dismiss="modal">
                    <i class="icon-remove"></i>
                    Close
                </button>
                <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click"
                        CssClass="btn btn-small"></asp:Button>
                
            </div>
        </div>
        
        
        <!-- End of Statistics -->
    </div>
</asp:Content>
