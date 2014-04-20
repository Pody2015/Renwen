using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class video : System.Web.UI.Page
{
    public string videourl = "";
    public string conts = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            GetContent();
        else
            return;
    }

    private void GetContent()
    {
        zs.BLL.Tbl_Video bll = new zs.BLL.Tbl_Video();
        string id = ApplicationMethod.decript(Request.QueryString["id"]);
        zs.Model.Tbl_Video model = bll.GetModelByCache(int.Parse(id));
        this.lb_title.Text = model.title;
        conts = model.conts;
        videourl = model.videourl;

        this.Repeater1.DataSource = bll.GetList(5, "", "newid()");
        this.Repeater1.DataBind();
    }
}