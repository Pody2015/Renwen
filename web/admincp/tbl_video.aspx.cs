using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class admincp_tbl_video : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        zs.BLL.Tbl_Video bll = new zs.BLL.Tbl_Video();
        UsersBind(bll.GetModelList(""), 15);
    }

    private void UsersBind(List<zs.Model.Tbl_Video> userList, int pageSize)//repeater分页并绑定
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
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "delete")
        {
            zs.BLL.Tbl_Video bll = new zs.BLL.Tbl_Video();
            bll.Delete(int.Parse(e.CommandArgument.ToString()));
            BindData();
        }
    }
}