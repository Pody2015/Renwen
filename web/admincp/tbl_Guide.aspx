<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true"
    CodeFile="tbl_Guide.aspx.cs" Inherits="admincp_tbl_Guide" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v10.1, Version=10.1.6.0, Culture=neutral, PublicKeyToken=c6bed6029ccaee5e"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v10.1, Version=10.1.6.0, Culture=neutral, PublicKeyToken=c6bed6029ccaee5e"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Main Content -->
    <div id="content">
        <div id="main">
            <dx:ASPxGridView ID="ASPxGridView1" runat="server" KeyFieldName="id" AutoGenerateColumns="False"
                ClientIDMode="AutoID" OnRowDeleting="ASPxGridView1_RowDeleting" OnRowInserting="ASPxGridView1_RowInserting"
                OnRowUpdating="ASPxGridView1_RowUpdating" CssClass="fullwidth">
                <SettingsDetail ShowDetailRow="True" />
                <Columns>
                    <dx:GridViewDataTextColumn Caption="编号" FieldName="id" ReadOnly="True" ShowInCustomizationForm="True"
                        VisibleIndex="0">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="父编号" FieldName="pid" ShowInCustomizationForm="True"
                        VisibleIndex="1">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="显示名称" FieldName="name" ShowInCustomizationForm="True"
                        VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="相对路径" FieldName="url" ShowInCustomizationForm="True"
                        VisibleIndex="3">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="排序" FieldName="sortid" ShowInCustomizationForm="True"
                        VisibleIndex="4">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="类型" FieldName="type" ShowInCustomizationForm="True"
                        VisibleIndex="5">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewCommandColumn VisibleIndex="6">
                        <EditButton Text="编辑" Visible="True">
                        </EditButton>
                        <NewButton Text="新增" Visible="True">
                        </NewButton>
                        <DeleteButton Text="删除" Visible="True">
                        </DeleteButton>
                        <CancelButton Text="取消">
                        </CancelButton>
                        <UpdateButton Text="修改">
                        </UpdateButton>
                    </dx:GridViewCommandColumn>
                </Columns>
                <SettingsBehavior ConfirmDelete="True" />
                <SettingsEditing Mode="Inline" />
                <SettingsDetail ShowDetailRow="True"></SettingsDetail>
                <Templates>
                    <DetailRow>
                        <dx:ASPxGridView ID="ASPxGridView2" runat="server" OnDataBinding="ASPxGridView2_DataBinding"
                            KeyFieldName="id" OnRowDeleting="ASPxGridView1_RowDeleting" OnRowInserting="ASPxGridView1_RowInserting"
                            OnRowUpdating="ASPxGridView1_RowUpdating">
                            <Columns>
                                <dx:GridViewDataTextColumn Caption="编号" FieldName="id" ReadOnly="True" ShowInCustomizationForm="True"
                                    VisibleIndex="0">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="父编号" FieldName="pid" ShowInCustomizationForm="True"
                                    VisibleIndex="1">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="显示名称" FieldName="name" ShowInCustomizationForm="True"
                                    VisibleIndex="2">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="相对路径" FieldName="url" ShowInCustomizationForm="True"
                                    VisibleIndex="3">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="排序" FieldName="sortid" ShowInCustomizationForm="True"
                                    VisibleIndex="4">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="类型" FieldName="type" ShowInCustomizationForm="True"
                                    VisibleIndex="5">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewCommandColumn VisibleIndex="6">
                                    <EditButton Text="编辑" Visible="True">
                                    </EditButton>
                                    <NewButton Text="新增" Visible="True">
                                    </NewButton>
                                    <DeleteButton Text="删除" Visible="True">
                                    </DeleteButton>
                                    <CancelButton Text="取消">
                                    </CancelButton>
                                    <UpdateButton Text="修改">
                                    </UpdateButton>
                                </dx:GridViewCommandColumn>
                            </Columns>
                            <SettingsBehavior ConfirmDelete="True" />
                            <SettingsEditing Mode="Inline" />
                            <SettingsDetail IsDetailGrid="True" ShowDetailRow="True" />
                            <Templates>
                                <DetailRow>
                                    <dx:ASPxGridView ID="ASPxGridView3" runat="server" OnDataBinding="ASPxGridView3_DataBinding"
                                        KeyFieldName="id" OnRowDeleting="ASPxGridView1_RowDeleting" OnRowInserting="ASPxGridView1_RowInserting"
                                        OnRowUpdating="ASPxGridView1_RowUpdating">
                                        <Columns>
                                            <dx:GridViewDataTextColumn Caption="编号" FieldName="id" ReadOnly="True" ShowInCustomizationForm="True"
                                                VisibleIndex="0">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="父编号" FieldName="pid" ShowInCustomizationForm="True"
                                                VisibleIndex="1">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="显示名称" FieldName="name" ShowInCustomizationForm="True"
                                                VisibleIndex="2">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="相对路径" FieldName="url" ShowInCustomizationForm="True"
                                                VisibleIndex="3">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="排序" FieldName="sortid" ShowInCustomizationForm="True"
                                                VisibleIndex="4">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="类型" FieldName="type" ShowInCustomizationForm="True"
                                                VisibleIndex="5">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewCommandColumn VisibleIndex="6">
                                                <EditButton Text="编辑" Visible="True">
                                                </EditButton>
                                                <NewButton Text="新增" Visible="True">
                                                </NewButton>
                                                <DeleteButton Text="删除" Visible="True">
                                                </DeleteButton>
                                                <CancelButton Text="取消">
                                                </CancelButton>
                                                <UpdateButton Text="修改">
                                                </UpdateButton>
                                            </dx:GridViewCommandColumn>
                                        </Columns>
                                        <SettingsBehavior ConfirmDelete="True" />
                                        <SettingsEditing Mode="Inline" />
                                    </dx:ASPxGridView>
                                </DetailRow>
                            </Templates>
                        </dx:ASPxGridView>
                    </DetailRow>
                </Templates>
            </dx:ASPxGridView>
        </div>
    </div>
    <!-- End of Main Content -->
    <!-- Sidebar -->
    <div id="sidebar">
        <h2>导航管理注意</h2>
        <!-- Datepicker -->
        <div id="accordion" class="ui-accordion ui-widget ui-helper-reset" role="tablist">
            <div>
                <h3 class="ui-accordion-header ui-helper-reset ui-state-active ui-corner-top" role="tab"
                    aria-expanded="true" tabindex="0">
                    <span class="ui-icon ui-icon-triangle-1-s"></span><a href="#" title="First slide"
                        class="tooltip">注意事项</a></h3>
                <div class="ui-accordion-content ui-helper-reset ui-widget-content ui-corner-bottom ui-accordion-content-active"
                    style="height: 181px;" role="tabpanel">
                    此处导航直接影响前台导航显示，所有操作请慎重！
                    点击前面的+打开二级导航的信息，最多支持三级目录。
                    由于前台加密算法，例如在填写page.aspx?id=的后面请写加密后的字符串。
                    type有两个特殊类型：news和out。news则为新闻类型。out说明链接在新窗口打开。
                    </div>
            </div>
            <div>
                <h3 class="ui-accordion-header ui-helper-reset ui-state-default ui-corner-all" role="tab"
                    aria-expanded="false" tabindex="-1">
                    <span class="ui-icon ui-icon-triangle-1-e"></span><a href="#" title="Second slide"
                        class="tooltip">添加page页面</a></h3>
                <div class="ui-accordion-content ui-helper-reset ui-widget-content ui-corner-bottom"
                    style="height: 181px; display: none;" role="tabpanel">
                    本站导航可以添加page.aspx页面，这些页面主要是类似学校简介之类的页面，可直接将页面管理中的地址复制到需要添加的
                    导航下面，并设置好其顺序即可。请注意加密字符串。</div>
            </div>
            <div>
                <h3 class="ui-accordion-header ui-helper-reset ui-state-default ui-corner-all" role="tab"
                    aria-expanded="false" tabindex="-1">
                    <span class="ui-icon ui-icon-triangle-1-e"></span><a href="#" title="Third slide"
                        class="tooltip">添加news页面</a></h3>
                <div class="ui-accordion-content ui-helper-reset ui-widget-content ui-corner-bottom"
                    style="height: 181px; display: none;" role="tabpanel">
                    本站导航还可以添加新闻页面，同理，与page页面一样，需要注意的同样是页面地址加密字符串。
                    同理本站还可以扩展其他页面的导航，您甚至可以导航到外站（这可能会影响SEO，请慎重）。</div>
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
