<%@ Control Language="C#" AutoEventWireup="true" CodeFile="C_tbl_Guide.ascx.cs" Inherits="admincp_C_tbl_Guide" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v10.1, Version=10.1.6.0, Culture=neutral, PublicKeyToken=c6bed6029ccaee5e"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v10.1, Version=10.1.6.0, Culture=neutral, PublicKeyToken=c6bed6029ccaee5e"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
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
                            <dx:ASPxGridView ID="ASPxGridView3" runat="server" OnDataBinding="ASPxGridView3_DataBinding" KeyFieldName="id" OnRowDeleting="ASPxGridView1_RowDeleting" OnRowInserting="ASPxGridView1_RowInserting"
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
