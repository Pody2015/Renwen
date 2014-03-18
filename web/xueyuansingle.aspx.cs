using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class xueyuansingle : System.Web.UI.Page
{
    zs.BLL.Tbl_Xueyuan bll = new zs.BLL.Tbl_Xueyuan();
    public string name = "";
    public string nameen = "";
    public string conts = "";
    public string yuanzhang = "";
    public string image1 = "";
    public string image2 = "";
    public string image3 = "";
    public string tags = "";
    public string desc = "";
    public string xid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["id"]))
        {
            InitData();
        }
    }

    private void InitData()
    {
        string id = ApplicationMethod.decript(Request.QueryString["id"].ToString());
        zs.Model.Tbl_Xueyuan model = bll.GetModelByCache(int.Parse(id));
        name = model.name;
        nameen = model.nameen;
        conts = model.conts;
        yuanzhang = model.yuanzhang;
        image1 = model.image1;
        image2 = model.image2;
        image3 = model.image3;
        tags = "浙江树人大学招生网," + model.name;
        desc = ApplicationMethod.NoHtmlCode(model.conts, 80);
        xid = ApplicationMethod.encript(model.id.ToString());
        this.Page.Title = model.name + " - 浙江树人大学招生网";
        this.Repeater1.DataSource = bll.GetList(2, "", "newid()");
        this.Repeater1.DataBind();
    }

    public string GetXueyuanList()
    {
        List<zs.Model.Tbl_Xueyuan> models = bll.GetModelList("");
        StringBuilder sb = new StringBuilder();
        foreach (zs.Model.Tbl_Xueyuan model in models)
        {
            sb.Append("<li class=''>");
            sb.Append("<a href='xueyuansingle.aspx?id=" + ApplicationMethod.encript(model.id.ToString()) + "'>");
            sb.Append(model.name + "</a></li>");
        }
        return sb.ToString();
    }
}