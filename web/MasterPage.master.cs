using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class MasterPage : System.Web.UI.MasterPage
{
    zs.BLL.Tbl_Guide bll = new zs.BLL.Tbl_Guide();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.lb_copy.Text = "&copy; " + DateTime.Now.Year + " 浙江树人大学. All right are reserved. Powered by 小D.";
    }

    public string GetGuides()
    {
        StringBuilder sb = new StringBuilder();
        List<zs.Model.Tbl_Guide> models = bll.GetModelList(" pid=0 order by sortid asc");
        zs.Model.Tbl_Guide ri = new zs.Model.Tbl_Guide();
        for (int i = 0; i < models.Count; i++)
        {
            ri = models[i];
            if (i == (models.Count - 1))
            {
                sb.Append("<li class='last'>");
                sb.Append("<a href='" + ri.url + "'>");
                sb.Append(ri.name);
                sb.Append("</a>");
                List<zs.Model.Tbl_Guide> modelss = bll.GetModelList(" pid=" + ri.id + " order by sortid asc");
                if (modelss.Count > 0)
                    sb.Append(erjizuhe(modelss));
                sb.Append("</li>");
            }
            else
            {
                sb.Append("<li>");
                sb.Append("<a href='" + ri.url + "'>");
                sb.Append(ri.name);
                sb.Append("</a>");
                List<zs.Model.Tbl_Guide> modelss = bll.GetModelList(" pid=" + ri.id + " order by sortid asc");
                if (modelss.Count > 0)
                    sb.Append(erjizuhe(modelss));
                sb.Append("</li>");
            }
        }
        return sb.ToString();
    }

    private string erjizuhe(List<zs.Model.Tbl_Guide> models)
    {
        StringBuilder sb1 = new StringBuilder();
        sb1.Append("<ul class='sub-menu'>");
        foreach (zs.Model.Tbl_Guide ri in models)
        {
            List<zs.Model.Tbl_Guide> modelss = bll.GetModelList(" pid=" + ri.id + " order by sortid asc");
            if (modelss.Count == 0)
            {
                string temp = "";
                if (ri.type.Equals("out"))
                {
                    temp = " target='_blank'";
                }
                sb1.Append("<li>");
                sb1.Append("<a href='" + ri.url + "'" + temp + ">");
                sb1.Append(ri.name);
                sb1.Append("</a>");
                sb1.Append("</li>");
            }
            else
            {
                string temp = "";
                if (ri.type.Equals("out"))
                {
                    temp = " target='_blank'";
                }
                sb1.Append("<li class='arrow'>");
                sb1.Append("<a href='" + ri.url + "'" + temp + ">");
                sb1.Append(ri.name);
                sb1.Append("</a>");
                sb1.Append(sanjizuhe(modelss));
                sb1.Append("</li>");
            }
        }
        sb1.Append("</ul>");
        return sb1.ToString();
    }

    private string sanjizuhe(List<zs.Model.Tbl_Guide> models)
    {
        StringBuilder sb2 = new StringBuilder();
        sb2.Append("<ul>");
        foreach (zs.Model.Tbl_Guide ri in models)
        {
            string temp = "";
            if (ri.type.Equals("out"))
            {
                temp = " target='_blank'";
            }
            int pid = ri.id;
            sb2.Append("<li>");
            sb2.Append("<a href='" + ri.url + "'" + temp + ">");
            sb2.Append(ri.name);
            sb2.Append("</a>");
            sb2.Append("</li>");
        }
        sb2.Append("</ul>");
        return sb2.ToString();
    }
}
