using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class newslist : System.Web.UI.Page
{
    public string tags = "";
    public string desc = "";
    public string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            GetNewsList();
        else
            GetAllNews();
    }

    private void GetAllNews()
    {
        zs.BLL.Tbl_News bll = new zs.BLL.Tbl_News();
        zs.BLL.Tbl_Guide bllg = new zs.BLL.Tbl_Guide();
        UsersBind1(bll.GetModelList("1=1 order by id desc"), 15);
        string title = "招考快讯";
        this.lb_title.Text = title;
        tags = "浙江树人大学,招生网,树大招生," + title;
        desc = "由浙江省政协主办的浙江树人大学（学院）坐落于杭州市城区，是改革开放以来我国最早成立并经国家教育部首批批准承认学历的全日制民办本科高校之一。";
        Page.Title = title + " - 浙江树人大学招生网";
    }

    private void GetNewsList()
    {
        zs.BLL.Tbl_News bll = new zs.BLL.Tbl_News();
        zs.BLL.Tbl_Guide bllg = new zs.BLL.Tbl_Guide();
        id = ApplicationMethod.decript(Request.QueryString["id"]);
        UsersBind(bll.GetModelList("leiid=" + id + " order by id desc"), 15);
        string title = bllg.GetModelByCache(int.Parse(id)).name;
        this.lb_title.Text = title;
        tags = "浙江树人大学,招生网,树大招生," +title;
        desc = "由浙江省政协主办的浙江树人大学（学院）坐落于杭州市城区，是改革开放以来我国最早成立并经国家教育部首批批准承认学历的全日制民办本科高校之一。";
        Page.Title = title + " - 浙江树人大学招生网";
    }

    public string GetMetaTags()
    {
        return "<meta name=\"keywords\" content=\"" + tags + "\" />";
    }

    public string GetMetaDescription()
    {
        return "<meta name=\"description\" content=\"" + desc + "\" />";
    }

    public string GetGeyan()
    {
        zs.BLL.Tbl_Flex bll = new zs.BLL.Tbl_Flex();
        return bll.GetList(1, "keyName='geyan'", "NEWID()").Tables[0].Rows[0]["keyValue"].ToString();
    }

    public string GetVideo()
    {
        zs.BLL.Tbl_Video bll = new zs.BLL.Tbl_Video();
        return bll.GetList(1, "", "newid()").Tables[0].Rows[0]["videourl"].ToString();
    }

    private void UsersBind(List<zs.Model.Tbl_News> userList, int pageSize)//repeater分页并绑定
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

            FirstPage.NavigateUrl = Request.CurrentExecutionFilePath + "?id=" + ApplicationMethod.encript(id) + "&page=1";
            PrevPage.NavigateUrl = Request.CurrentExecutionFilePath + "?id=" + ApplicationMethod.encript(id)+ "&page=" + (CurPage - 1);
            NextPage.NavigateUrl = Request.CurrentExecutionFilePath + "?id=" + ApplicationMethod.encript(id)+ "&page=" + (CurPage + 1);
            LastPaeg.NavigateUrl = Request.CurrentExecutionFilePath + "?id=" + ApplicationMethod.encript(id)+ "&page=" + objPage.PageCount.ToString();
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

    private void UsersBind1(List<zs.Model.Tbl_News> userList, int pageSize)//repeater分页并绑定
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
            Literal1.Text = PageList1(objPage.PageCount, CurPage);

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

        sb.Append("<select id=\"Page_Jump\" name=\"Page_Jump\" onchange=\"window.location='" + Request.CurrentExecutionFilePath + "?id=" + ApplicationMethod.encript(id) + "&page='+ this.options[this.selectedIndex].value + '';\">");

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

    private string PageList1(int Pagecount, int Pageindex)
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
}