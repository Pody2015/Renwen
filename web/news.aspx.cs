using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class news : System.Web.UI.Page
{
    public string tags = "";
    public string desc = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            GetContent();
        else
            return;
    }

    private void GetContent()
    {
        zs.BLL.Tbl_News bll = new zs.BLL.Tbl_News();
        string id = ApplicationMethod.decript(Request.QueryString["id"]);
        zs.Model.Tbl_News model = bll.GetModelByCache(int.Parse(id));
        this.lb_title.Text = model.title;
        this.lb_Cont.Text = model.conts;
        tags = "浙江树人大学,招生网,树大招生,"+model.title;
        desc = ApplicationMethod.NoHtmlCode(model.conts, 80);
        Page.Title = model.title + " - 浙江树人大学招生网";
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
}