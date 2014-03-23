using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class admincp_MasterAdmin : System.Web.UI.MasterPage
{
    zs.BLL.Sys_UserRole bllur = new zs.BLL.Sys_UserRole();
    zs.BLL.Sys_RoleFunction bllrf = new zs.BLL.Sys_RoleFunction();
    zs.BLL.Sys_Function bllf = new zs.BLL.Sys_Function();
    public string username="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["userId"] == null || Request.Cookies["userId"].Value == "")
            Response.Redirect("./Login.aspx");
        else
            username = Request.Cookies["userName"].Value;
    }

    public string GetUserFunction()
    {
        string uid = Request.Cookies["userId"].Value.ToString();
        StringBuilder sb = new StringBuilder();
        int rid = bllur.GetModelList("UserID=" + uid)[0].RoleID.Value;
        List<zs.Model.Sys_RoleFunction> modelrf = bllrf.GetModelList("RoleID=" + rid.ToString());
        foreach (zs.Model.Sys_RoleFunction ri in modelrf)
        {
            int fid = ri.FunctionID.Value;
            zs.Model.Sys_Function fun = bllf.GetModel(fid);
            sb.Append("<li>");
            sb.Append("<a href='" + fun.Assembly + "'><i class=\"icon-double-angle-right\"></i><span class=\"menu-text\">");
            sb.Append(fun.FunctionDescription);
            sb.Append("</span></a>");
            sb.Append("</li>\n\r");
        }
        return sb.ToString();
    }
}
