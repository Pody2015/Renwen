using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class zhuanye : System.Web.UI.Page
{
    zs.BLL.Tbl_Xueyuan bllx = new zs.BLL.Tbl_Xueyuan();
    zs.BLL.Tbl_Zhuanye bll = new zs.BLL.Tbl_Zhuanye();
    public string name = "所有";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Request.QueryString["xid"]))
        {
            InitAllData();
        }
        else
        {
            InitData();
        }
    }

    private void InitData()
    {
        string xid = ApplicationMethod.decript(Request.QueryString["xid"]);
        this.Repeater1.DataSource = bll.GetModelList("xueyuanid=" + xid);
        this.Repeater1.DataBind();
        zs.Model.Tbl_Xueyuan xueyuan = bllx.GetModelByCache(int.Parse(xid));
        this.Page.Title = xueyuan.name + " - 专业介绍 - 浙江树人大学招生网";
        name = xueyuan.name;
    }

    private void InitAllData()
    {
        this.Repeater1.DataSource = bll.GetModelList("");
        this.Repeater1.DataBind();
        this.Page.Title = "专业介绍 - 浙江树人大学招生网";
    }

    public string GetXueyuanList()
    {
        List<zs.Model.Tbl_Xueyuan> models = bllx.GetModelList("");
        StringBuilder sb = new StringBuilder();
        foreach (zs.Model.Tbl_Xueyuan model in models)
        {
            sb.Append("<li class=''>");
            sb.Append("<a href='zhuanye.aspx?xid=" + ApplicationMethod.encript(model.id.ToString()) + "'>");
            sb.Append(model.name + "</a></li>");
        }
        return sb.ToString();
    }
}