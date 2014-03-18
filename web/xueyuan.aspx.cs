using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class xueyuan : System.Web.UI.Page
{
    zs.BLL.Tbl_Xueyuan bll = new zs.BLL.Tbl_Xueyuan();
    protected void Page_Load(object sender, EventArgs e)
    {
        InitData();
    }

    private void InitData()
    {
        this.Repeater1.DataSource = bll.GetModelList("");
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
            sb.Append(model.name+"</a></li>");
        }
        return sb.ToString();
    }
}