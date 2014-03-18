<%@ Page Title="浙江树人大学录取查询系统 - 浙江树人大学招生网" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="check.aspx.cs" Inherits="check" %>
<%@ Register src="webpart/C_LastNews.ascx" tagname="C_LastNews" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<meta name="keywords" content="浙江树人大学招生,高考录取查询,专升本录取查询,浙江树人大学" />
<meta name="description" content="浙江树人大学（学院）招生办在线录取查询系统。您可以在线查询您最新的高考录取信息。同时我们也提供专升本录取查询功能。" />
<meta name="author" content="Dsrj Studio Team" />
<meta name="copyright" content="2009-2011 Dsrj Studio." />
<script type="text/javascript">
    $(function () {
        $("#btnOK").click(function () {
            var num = document.getElementById("tbnum").value;
            if (num != "") {
                $.ajax({
                    type: "Post",
                    url: "check.aspx/GetStr",
                    data: "{'str':'" + num + "'}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (data) {
                        document.getElementById("div1").innerHTML = data.d;
                    },
                    error: function (err) {
                        alert(err);
                    }
                });
                $("#btnOK").attr("disabled", "disabled");
                $('#btnOK').css("color", "#eeeeee");
                setTimeout("enable()", 3000);
            }
            return false;
        });
    });
    function enable() {
        $('#btnOK').removeAttr('disabled');
        $('#btnOK').css("color","#111111");
    }  
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-header">
        <img src="./styles/images/1000x180.png" width="1000" height="180" alt="树人全景" />
    </div>
    <div class=" fixed">
        <div class=" col580">
            <h1>浙江树人大学<asp:Label ID="lb_title" runat="server" Text=""></asp:Label></h1>
            <fieldset>
            <legend>查询说明</legend>
            <ol>
            <li>本站仅提供被本校录取的学生信息查询。</li>
            <li>若您在考试院或其他官方网站查询到被本校录取而在本站查询不到，这可能是由于我们还未及时将您的信息录入导致的，您可以联系我们帮您核实信息。</li>
            <li>请输入您的身份证号进行查询，暂不支持根据考试号查询。身份证末尾为X的若查不到请更换大小写再试试。</li>
            </ol>
            </fieldset>
            <div class="bordered">
            <label>您的身份证号码：</label>
                <input id="tbnum" type="text" class="text" style="margin: 0;padding: 5px;height: 15px;width: 192px;font-size: 12px;color: #888;" /><input id="btnOK" type="button" value="查询" style="padding: 0 5px 0 5px;width: 55px;height: 27px;cursor: pointer;border: none;background-color: #E6E6E6;color: #555;" />
                <hr />
                <div id="div1"></div>
            </div>
        </div>
        <div class=" col280 last">
            <h1>&nbsp;</h1>
            <h5>树人语录</h5>
            <p style="margin-bottom: 20px; text-indent: 2em">
                <%= GetGeyan() %></p>
            <h5>最新消息</h5>
            <uc1:c_lastnews ID="C_LastNews1" runat="server" />
            <p style="margin-bottom: 20px">&nbsp;</p>
            <h5>学校视频</h5>
<embed type="application/x-shockwave-flash"src='<%= GetVideo() %>' id="movie_player" name="movie_player" bgcolor="#FFFFFF" quality="high" allowfullscreen="true" flashvars="isShowRelatedVideo=false&showAd=0&show_pre=1&show_next=1&isAutoPlay=false&isDebug=false&UserID=&winType=interior&playMovie=true&MMControl=false&MMout=false&RecordCode=1001,1002,1003,1004,1005,1006,2001,3001,3002,3003,3004,3005,3007,3008,9999" pluginspage="http://www.macromedia.com/go/getflashplayer" width="280" height="195"></embed>
        </div>
    </div>
</asp:Content>

