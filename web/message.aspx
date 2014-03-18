<%@ Page Title="在线咨询 - 浙江树人大学招生网" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="message.aspx.cs" Inherits="message" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<meta name="keywords" content="浙江树人大学招生,在线咨询,树人招生,浙江树人大学" />
<meta name="description" content="浙江树人大学（学院）招生办在线网络咨询留言。您在报考我们院校时遇到的所有问题均可以留言咨询，我们将及时为您答疑解惑。" />
<meta name="author" content="Dsrj Studio Team" />
<meta name="copyright" content="2009-2011 Dsrj Studio." />
<style>
.nodisplay{display:none;}
.onepiece{border:1px solid #F0F0F0;margin-bottom: 10px;}
.onepiece .onetitle{background:#F0F9F9;}
.onepiece .onetitle strong{line-height: 32px;font-size: 18px;}
.onepiece .oneask{padding: 0 12px;}
.onepiece .oneask span{color:red;}
.onepiece .oneask .oneaskcont{border: 1px dashed #dddddd;padding: 5px 10px;border-bottom: none;}
.onepiece .oneans{padding: 0 12px;}
.onepiece .oneans .oneanscont{border: 1px dashed #dddddd;background-color: #f9f9f9;padding: 5px 10px;margin-bottom: 10px;}
.onepiece .oneans .oneanscont span{color:red;}
#tbnum{margin: 0;padding: 5px;height: 15px;width: 192px;font-size: 12px;color: #888;}
.btn{margin: 0;padding: 0 5px 0 5px;width: 55px;height: 27px;cursor: pointer;border: none;background-color: #D6D6D6;color: #555;}
.btn1{margin: 0;padding: 0 5px 0 5px;width: 55px;height: 27px;cursor: pointer;border: none;background-color: #E6E6E6;color: #555; display:block}
input:focus, input.sffocus {background-color: #dddddd;color:#666666;}
</style>
<script type="text/javascript">
    $(document).ready(function () {
        $("#Button1").hide();
    });


    $(function () {
        $("#btnOK").click(function () {
            var num = "";
            num = document.getElementById("tbnum").value;

            if (num != "") {
                $.ajax({
                    type: "Post",
                    url: "message.aspx/GetStr",
                    data: "{'str':'" + num + "'}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (data) {
                        document.getElementById("list").innerHTML = " ";
                        document.getElementById("listpage").innerHTML = " ";
                        document.getElementById("list").innerHTML = data.d;
                        HighLight(num);
                    },
                    error: function (err) {
                        document.getElementById("list").innerHTML = err;
                    }
                });
                $("#btnOK").attr("disabled", "disabled");
                $('#btnOK').css("color", "#eeeeee");
                $("#Button1").show();
                setTimeout("enable()", 3000);
            }
            //
            return false;
        });
    });

    function enable() {
        $('#btnOK').removeAttr('disabled');
        $('#btnOK').css("color", "#111111");
    }

    function HighLight(nWord) {
        if (nWord != '') {
            var keyword = document.body.createTextRange();
            while (keyword.findText(nWord)) {
                keyword.pasteHTML("<span style='color:blue;background-color:yellow'>" + keyword.text + "</span>");
                keyword.moveStart('character', 1);
            }
        }
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="page-header">
        <img src="./styles/images/1000x180.png" width="1000" height="180" alt="" />
    </div>
    <h1 class="text-center">
        浙江树人大学在线咨询</h1>
    <fieldset id="1">
        <legend>咨询须知</legend>
        <ul>
            <li>为了提高咨询效率，同时更快解决您的疑惑，请您先<a href="page.aspx?id=XPp0JNwpIFY=">点此浏览常见问题</a>的答复。或者搜索咨询列表。</li>
            <li>若您担心咨询内容过多不容易找到自己的问题，请您留下正确的E-mail地址，我们将在第一时间答复并发送邮件告知结果。</li>
            <li>咨询繁忙时，您也可以通过页面底部的微博与我们取得联系，或者也可以直接拨打热线电话等其他方式联系我们。</li>
            <li>搜索结果只显示最新的前50条记录，仅支持单关键字搜索。</li>
        </ul>
        <div class="bordered" style=" background-color:#eeeeee">
            <label>关键字搜索：</label>
                <input id="tbnum" type="text" class="text"/><input id="btnOK" class="btn" type="button" value="搜索" onclick="Light()"/>
                  热门关键字：分数线、录取、浙江理科、江苏、通知书...
                
        </div>
    </fieldset>
    <fieldset>
        <legend>咨询列表</legend>
        <input id="Button1" class="btn" style="width:auto;" type="button" value="返回所有结果" onclick="javascript:window.location.reload(true)" />
        <div id="list">
        <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
        <div class="onepiece">
            <div class="onetitle">
            <strong> &nbsp;<%# Eval("title") %></strong></div>
            <div class="oneask">
            <span><%# Eval("name") %></span>于[<%# Eval("askTime","{0:yyyy-MM-dd HH:mm:ss}") %>]询问：
                <div class="oneaskcont">
                <%# Eval("conts") %>
                </div>
            </div>
            <div class="oneans">
                <div class="oneanscont">
                <span>招生办</span>回复：<%# Eval("reply") %>[<%# Eval("replyTime","{0:yyyy-MM-dd HH:mm:ss}") %>]
                </div>
            </div>
        </div>
        </ItemTemplate>
        </asp:Repeater>
        </div>
        <div id="listpage" class="text-right">
        <asp:Literal ID="RecordCount" runat="server"></asp:Literal>条咨询
        共有<asp:Literal ID="PageCount" runat="server"></asp:Literal>页
        当前第<asp:Literal ID="Pageindex" runat="server"></asp:Literal>页
            <asp:HyperLink ID="FirstPage" runat="server" Text="首页"></asp:HyperLink>
            <asp:HyperLink ID="PrevPage" runat="server" Text="上一页"></asp:HyperLink>
            <asp:HyperLink ID="NextPage" runat="server" Text="下一页"></asp:HyperLink>
            <asp:HyperLink ID="LastPaeg" runat="server" Text="尾页"></asp:HyperLink>
        跳转到<asp:Literal ID="Literal1" runat="server"></asp:Literal>页
        </div>
    </fieldset>
    <fieldset>
    <legend>留言咨询</legend>
    <form id="subform" runat="server">
        <p class="col280 last">
            <label for="ContentPlaceHolder1_tb_name">昵称: <span class="required">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="*" ControlToValidate="tb_name"></asp:RequiredFieldValidator></span>
            </label>
            <br />
            <asp:TextBox ID="tb_name" CssClass="text" runat="server"></asp:TextBox>
        </p>
        <p class="col280 last">
            <label for="ContentPlaceHolder1_tb_mail">Email地址: <span class="required">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="*" ControlToValidate="tb_mail"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                runat="server" ErrorMessage="邮箱很重要，请认真填写！" ControlToValidate="tb_mail" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </span>
            </label>
            <br />
            <asp:TextBox ID="tb_mail" CssClass="text" runat="server"></asp:TextBox>
        </p>
        <p class="col205 last">
            <label for="ContentPlaceHolder1_tb_tel">联系电话: </label>
            <br />
            <asp:TextBox ID="tb_tel" CssClass="text" runat="server"></asp:TextBox>
        </p>
        <p class=" col205">
            <label for="ContentPlaceHolder1_tb_title">标题: <span class="required">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="tb_title" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator></span>
            </label>
            <br />
            <asp:TextBox ID="tb_title" CssClass="text" runat="server"></asp:TextBox>
        </p>
        <p class="col205">
            <label>&nbsp;</label>
            <br />&nbsp;
        </p>
        <p class="last col205">
            <label>&nbsp;</label>
            <br />&nbsp;
        </p>
        <p  class=" col655">
            <label for="ContentPlaceHolder1_tb_message">问题详细:<span class="required"><asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="tb_message"
                runat="server" ErrorMessage="*"></asp:RequiredFieldValidator></span>
            </label>
            <br />
            <asp:TextBox ID="tb_message" TextMode="MultiLine" runat="server"></asp:TextBox>
        </p>
        <p class="col655 last">
            <asp:Button ID="btn_Send" runat="server" Text="提交" onclick="btn_Send_Click" />
        </p>
        </form>
    </fieldset>
</asp:Content>
