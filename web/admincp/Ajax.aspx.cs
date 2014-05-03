using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admincp_Ajax : System.Web.UI.Page
{
    zs.BLL.Tbl_Guide bllGuide = new zs.BLL.Tbl_Guide();
    protected void Page_Load(object sender, EventArgs e)
    {
        string op = SiteAbout.gStr("op");
        if (!IsPostBack)
        {
            switch (op)
            {
                case "GetGuideForZtree":
                    {
                        GetGuideForZtree();
                        break;
                    }
                case "GetGuideDetail":
                    {
                        GetGuideDetail();
                        break;
                    }
                case "SetGuideDetail":
                    {
                        SetGuideDetail();
                        break;
                    }
                case "DeleteGuideDetail":
                    {
                        DeleteGuideDetail();
                        break;
                    }
            }
        }
    }

    private void DeleteGuideDetail()
    {
        int id = SiteAbout.gInt("id");
        Response.ContentType = "application/json";
        if (bllGuide.Delete(id))
        {
            Response.Write("{\"status\":\"true\"}");
        }
        else
            Response.Write("{\"status\":\"false\"}");
    }

    private void SetGuideDetail()
    {
        int id = SiteAbout.gInt("id");
        string name = SiteAbout.gStr("name");
        string url = SiteAbout.gStr("url");
        string type = SiteAbout.gStr("type");
        int sortid = SiteAbout.gInt("sortid");
        if (id > 0)
        {
            zs.Model.Tbl_Guide modelGuide = bllGuide.GetModel(id);
            modelGuide.sortid = sortid;
            modelGuide.type = type;
            modelGuide.url = url;
            modelGuide.name = name;
            Response.ContentType = "application/json";
            if (bllGuide.Update(modelGuide))
            {
                if (type == "news")
                {
                    modelGuide.url = "./newslist.aspx?id=" + ApplicationMethod.encript(id.ToString());
                    bllGuide.Update(modelGuide);
                }
                Response.Write("{\"status\":\"true\"}");
            }
            else
                Response.Write("{\"status\":\"false\"}");
        }
        else
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(url) || string.IsNullOrEmpty(type))
                return;
            zs.Model.Tbl_Guide modelGuide = new zs.Model.Tbl_Guide();
            modelGuide.pid = 0;
            modelGuide.sortid = sortid;
            modelGuide.type = type;
            modelGuide.url = url;
            modelGuide.name = name;
            Response.ContentType = "application/json";
            int ret =bllGuide.Add(modelGuide);
            if ( ret > 0)
            {
                if (type == "news")
                {
                    modelGuide.id = ret;
                    modelGuide.url = "./newslist.aspx?id=" + ApplicationMethod.encript(ret.ToString());
                    bllGuide.Update(modelGuide);
                }
                Response.Write("{\"status\":\"true\"}");
            }
            else
                Response.Write("{\"status\":\"false\"}");
        }
    }

    private void GetGuideDetail()
    {
        int id=SiteAbout.gInt("id");
        zs.Model.Tbl_Guide modelGuide = bllGuide.GetModel(id);
        string temp ="";
        if (modelGuide != null)
            temp = ("{\"id\":\"" + id +
                "\",\"name\":\"" + modelGuide.name +
                "\",\"url\":\"" + modelGuide.url +
                "\",\"type\":\"" + modelGuide.type +
                "\",\"sortid\":\"" + modelGuide.sortid.ToString() + "\"}");
        Response.ContentType = "application/json";
        Response.Write(temp);
    }

    private void GetGuideForZtree()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("{\"node\":[");
        DataTable dt = bllGuide.GetList(1000,"1=1","sortid asc").Tables[0];
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            sb.Append("{");
            sb.Append(string.Format("\"id\": \"{0}\", \"pId\": \"{1}\", \"name\": \"{2}\", \"open\": \"false\",\"title\":\"{3}\"", dt.Rows[i]["id"].ToString(), dt.Rows[i]["pid"].ToString(), dt.Rows[i]["name"].ToString(), "顺序："+dt.Rows[i]["sortid"].ToString() + "URL："+dt.Rows[i]["url"].ToString()));
            if (i == (dt.Rows.Count - 1))
                sb.Append("}");
            else
                sb.Append("},");
        }
        sb.Append("]}");
        Response.ContentType = "application/json";
        Response.Write(sb.ToString());
    }
}