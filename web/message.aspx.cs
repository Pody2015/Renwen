using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Web.Services;
using System.Data;

public partial class message : System.Web.UI.Page
{
    public zs.BLL.Tbl_Message bll = new zs.BLL.Tbl_Message();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["asked"] != null)
        {
            this.btn_Send.Text = "您的问题已提交，请等待回复。稍后刷新页面可继续提问。";
            this.btn_Send.Enabled = false;
        }
        if (!IsPostBack)
        {
            InitData();
        }
    }

    private void InitData()
    {
        UsersBind(bll.GetModelList("isShow=1 order by id desc"),10);
    }

    private void UsersBind(List<zs.Model.Tbl_Message> userList, int pageSize)//repeater分页并绑定
    {
        try
        {
            PagedDataSource objPage = new PagedDataSource();
            objPage.DataSource = userList;
            objPage.AllowPaging = true;
            objPage.PageSize = pageSize;
            int CurPage;
            if (Request.QueryString["page"] != null)
            {
                CurPage = Convert.ToInt32(Request.QueryString["page"]);
            }
            else
            {
                CurPage = 1;
            }
            objPage.CurrentPageIndex = CurPage - 1;
            Repeater1.DataSource = objPage;
            Repeater1.DataBind();
            RecordCount.Text = objPage.DataSourceCount.ToString();
            PageCount.Text = objPage.PageCount.ToString();
            Pageindex.Text = CurPage.ToString();
            Literal1.Text = PageList(objPage.PageCount, CurPage);

            FirstPage.NavigateUrl = Request.CurrentExecutionFilePath + "?page=1";
            PrevPage.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" + (CurPage - 1);
            NextPage.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" + (CurPage + 1);
            LastPaeg.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" + objPage.PageCount.ToString();
            if (CurPage <= 1 && objPage.PageCount <= 1)
            {
                FirstPage.NavigateUrl = "";
                PrevPage.NavigateUrl = "";
                NextPage.NavigateUrl = "";
                LastPaeg.NavigateUrl = "";
            }
            if (CurPage <= 1 && objPage.PageCount > 1)
            {
                FirstPage.NavigateUrl = "";
                PrevPage.NavigateUrl = "";
            }
            if (CurPage >= objPage.PageCount)
            {
                NextPage.NavigateUrl = "";
                LastPaeg.NavigateUrl = "";
            }
        }
        catch (Exception error)
        {
            Response.Write(error.ToString());
        }
        finally
        {

        }
    }

    private string PageList(int Pagecount, int Pageindex)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<select id=\"Page_Jump\" name=\"Page_Jump\" onchange=\"window.location='" + Request.CurrentExecutionFilePath + "?page='+ this.options[this.selectedIndex].value + '';\">");

        for (int i = 1; i <= Pagecount; i++)
        {
            if (Pageindex == i)
                sb.Append("<option value='" + i + "' selected>" + i + "</option>");
            else
                sb.Append("<option value='" + i + "'>" + i + "</option>");
        }
        sb.Append("</select>");
        return sb.ToString();
    }

    protected void btn_Send_Click(object sender, EventArgs e)
    {
        zs.Model.Tbl_Message model = new zs.Model.Tbl_Message();
        model.askTime = DateTime.Now;
        model.conts = this.tb_message.Text.Trim();
        model.isShow = 0;
        model.mail = this.tb_mail.Text.Trim();
        model.name = this.tb_name.Text.Trim();
        model.tel = this.tb_tel.Text.Trim();
        model.title = this.tb_title.Text.Trim();
        bll.Add(model);
        Response.Cookies["asked"].Value = "yes";
        Response.Cookies["asked"].Expires = DateTime.Now.AddMinutes(2);
        this.btn_Send.Text = "您的问题已提交，请等待回复。稍后刷新页面可继续提问。";
        this.btn_Send.Enabled = false;
    }

    [WebMethod]
    public static string GetStr(string str)
    {
        zs.BLL.Tbl_Message bll = new zs.BLL.Tbl_Message();
        if (str != "")
        {
            string sqlwhere = "title like '%" + str + "%' or conts like '%" + str + "%' or reply like '%" + str + "%'";
            DataTable dt = bll.GetList(50, sqlwhere, "id desc").Tables[0];
            List<zs.Model.Tbl_Message> models = bll.DataTableToList(dt);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < models.Count; i++)
            {
                sb.Append("<div class='onepiece'><div class='onetitle'>");
                sb.Append("<strong> &nbsp;" + models[i].title + "</strong></div>");
                sb.Append("<div class='oneask'>");
                sb.Append("<span>" + models[i].name + "</span>于[" + models[i].askTime + "]询问：");
                sb.Append("<div class='oneaskcont'>" + models[i].conts + "</div></div>");
                sb.Append("<div class='oneans'><div class='oneanscont'>");
                sb.Append("<span>招生办</span>回复：" + models[i].reply + "[" + models[i].replyTime + "]");
                sb.Append("</div></div></div>");
            }
            if (sb.ToString() != "")
                return sb.ToString();
            else
                return "非常抱歉，没有找到相关结果。";
        }
        else
            return "非常抱歉，没有找到相关结果。";
    }
}