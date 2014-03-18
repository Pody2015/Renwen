using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Text;

public partial class check : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod]
    public static string GetStr(string str)
    {
        zs.BLL.Tbl_Chaxun bll = new zs.BLL.Tbl_Chaxun();
        if (bll.Exists(str))
        {
            zs.Model.Tbl_Chaxun model = bll.GetModel(str);
            StringBuilder sb = new StringBuilder();
            sb.Append("<strong>恭喜您被录取了，以下是您的录取信息，请核对：</strong>");
            sb.Append("<ul>");
            sb.Append("<li>姓名：" + model.name + "</li>");
            sb.Append("<li>学号：" + model.stuno + "</li>");
            sb.Append("<li>分数：" + model.score + "</li>");
            sb.Append("<li>学院：" + model.luquxueyuan + "</li>");
            sb.Append("<li>专业：" + model.luquzhuanye + "</li>");
            sb.Append("</ul>");
            
            return sb.ToString();
        }
        else
            return "<strong>非常抱歉，没有" + str + "相应的录取信息，请您核对输入是否正确，或联系我们核实。</strong>";
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