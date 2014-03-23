<%@ Page Title="" Language="C#" MasterPageFile="~/admincp/MasterAdmin.master" AutoEventWireup="true"
    CodeFile="tbl_Guide.aspx.cs" Inherits="admincp_tbl_Guide" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="js/zTree/css/zTreeStyle/zTreeStyle.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Main Content -->
    <div class="row-fluid">
    <div id="content" class="span8">
        <div class="row-fluid">
            <fieldset id="Div1" class="span6 zTreeDemoBackground left">
                <legend>导航</legend>
                <ul id="treeDemo" class="ztree"></ul>

                <div class="alert alert-block alert-success" id="msg_success" style="display:none">
                    <button type="button" class="close" data-dismiss="alert">
                        <i class="icon-remove"></i>
                    </button>
                    <p>
                        <strong>
                            <i class="icon-ok"></i>
                            保存成功
                        </strong>
                       
                    </p>
                </div>
            </fieldset>
            <fieldset id="Div2" class="span6 form-horizontal">
                <legend>链接详细</legend>
                <div class="control-group">
                    <label class="control-label" for="form-field-1">链接名称</label>
                    <div class="controls">
                        <input type="text" id="txt_name" placeholder="链接名称" />
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label" for="Text1">链接地址</label>
                    <div class="controls">
                        <input type="text" id="txt_url" placeholder="链接地址" />
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label" for="Text2">链接顺序</label>
                    <div class="controls">
                        <input type="text" id="txt_sortid" placeholder="链接顺序" />
                    </div>
                </div>
                <div class="control-group">
                    <label class="control-label" for="Text2">链接类型</label>
                    <div class="controls">
                        <input type="text" id="txt_type" placeholder="链接类型" />
                    </div>
                    <input id="txt_id" type="hidden" />
                </div>
                <div class="form-actions">
                    <button class="btn btn-info" type="button" onclick="saveguide()">
                        <i class="icon-ok bigger-110"></i>
                        保存
                    </button>
                    <button class="btn btn-info" type="button" onclick="deleteguide()">
                        <i class=" icon-off bigger-110"></i>
                        删除
                    </button>

                </div>
            </fieldset>
        </div>
        
    </div>
    <!-- End of Main Content -->
    <!-- Sidebar -->
    <div id="sidebar" class="span4">
        <!-- Datepicker -->
        <div id="accordion2" class="accordion">
            <div class="accordion-group">
                <div class="accordion-heading">
                    <a href="#collapseOne" data-parent="#accordion2" data-toggle="collapse" class="accordion-toggle collapsed">注意事项
                    </a>
                </div>

                <div class="accordion-body collapse" id="collapseOne" style="height: 0px;">
                    <div class="accordion-inner">
                        此处导航直接影响前台导航显示，所有操作请慎重！
                    点击前面的+打开二级导航的信息，最多支持三级目录。
                    由于前台加密算法，例如在填写page.aspx?id=的后面请写加密后的字符串。
                    type有两个特殊类型：news和out。news则为新闻类型。out说明链接在新窗口打开。
                    </div>
                </div>
            </div>

            <div class="accordion-group">
                <div class="accordion-heading">
                    <a href="#collapseTwo" data-parent="#accordion2" data-toggle="collapse" class="accordion-toggle collapsed">添加page页面
                    </a>
                </div>

                <div class="accordion-body collapse" id="collapseTwo" style="height: 0px;">
                    <div class="accordion-inner">
                        本站导航可以添加page.aspx页面，这些页面主要是类似简介之类的页面，可直接将页面管理中的地址复制到需要添加的
                    导航下面，并设置好其顺序即可。请注意加密字符串。(./page.aspx?id=)
                    </div>
                </div>
            </div>

            <div class="accordion-group">
                <div class="accordion-heading">
                    <a href="#collapseThree" data-parent="#accordion2" data-toggle="collapse" class="accordion-toggle collapsed">添加news页面
                    </a>
                </div>

                <div class="accordion-body collapse" id="collapseThree" style="height:0px;">
                    <div class="accordion-inner">
                        本站导航还可以添加新闻页面，同理，与page页面一样，需要注意的同样是页面地址加密字符串。
                    同理本站还可以扩展其他页面的导航，您甚至可以导航到外站（这可能会影响SEO，请慎重）。(./newslist.aspx?id=)
                    </div>
                </div>
            </div>
        </div>
        
        <!-- End of Datepicker -->
        <!-- Statistics -->
        
        <!-- End of Statistics -->
    </div></div>
    <!-- End of Sidebar -->
</asp:Content>
<asp:Content ID="js" ContentPlaceHolderID="CPH_Foot" runat="server">
    <script src="js/zTree/js/jquery.ztree.all-3.5.js"></script>
    <script>
        var setting = {
            view: {
                selectedMulti: false
            },
            edit: {
                enable: true,
                showRemoveBtn: false,
                showRenameBtn: false
            },
            data: {
                keep: {
                    parent: true,
                    leaf: true
                },
                simpleData: {
                    enable: true,title: "title"
                }
            },
            key:{
                
            },
            callback: {
                onClick: zTreeOnClick
            }
        };

        function zTreeOnClick(event, treeId, treeNode) {
            //alert(treeNode.id + ", " + treeNode.name);
            $.ajax({
                url: "Ajax.aspx?op=GetGuideDetail",
                data: { "id": treeNode.id },
                cache: false,
                success: function (result) {
                    $("#txt_name").val(result.name);
                    $("#txt_url").val(result.url);
                    $("#txt_sortid").val(result.sortid);
                    $("#txt_type").val(result.type);
                    $("#txt_id").val(result.id);
                }
            });
        }
        function saveguide() {
            $.ajax({
                url: "Ajax.aspx?op=SetGuideDetail",
                data: { "id": $("#txt_id").val(),"name": $("#txt_name").val(),"url":$("#txt_url").val(),"sortid":$("#txt_sortid").val(),"type":$("#txt_type").val()},
                cache: false,
                success: function (result) {
                    if (result.status == "true") {
                        $("#msg_success").css("display", "block");
                        GetGuide();
                        $("#txt_id").val("");
                        $("#txt_name").val("");
                        $("#txt_url").val("");
                        $("#txt_sortid").val("");
                        $("#txt_type").val("");
                    }
                    else
                        alert("保存失败");
                }
            });
        }
        function deleteguide() {
            $.ajax({
                url: "Ajax.aspx?op=DeleteGuideDetail",
                data: { "id": $("#txt_id").val() },
                cache: false,
                success: function (result) {
                    if (result.status == "true") {
                        $("#msg_success").css("display", "block");
                        GetGuide();
                        $("#txt_id").val("");
                        $("#txt_name").val("");
                        $("#txt_url").val("");
                        $("#txt_sortid").val("");
                        $("#txt_type").val("");
                    }
                    else
                        alert("删除失败");
                }
            });
        }
        function GetGuide() {
            $.ajax({
                url: "Ajax.aspx?op=GetGuideForZtree",
                data: { "root": "0" },
                cache: false,
                success: function (result) {
                    $.fn.zTree.init($("#treeDemo"), setting, result.node);
                }
            });
        }
        $(document).ready(function () {
            GetGuide();
            
        });
    </script>
</asp:Content>